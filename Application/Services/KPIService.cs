using Application.Interface;
using Application.Request.Job;
using Application.Request.KPI;
using Application.Response;
using Application.Response.Job;
using Application.Response.KPI;
using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class KPIService : IKPIService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;
        public KPIService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResponse> AddKPI(KPIRequest request)
        {
            var response = new ApiResponse();
            await _unitOfWork.KPIs.AddAsync(_mapper.Map<KPI>(request));
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }
        public async Task<ApiResponse> AddKPIToTranningProgram(ProgramKPIRequest request)
        {
            var response = new ApiResponse();
            var programKPI = await _unitOfWork.ProgramKPIs.GetAsync(x => x.KPIId == request.KPIId &&
                                                                     x.TrainingProgramId == request.TrainingProgramId);
            if (programKPI != null)
                return response.SetBadRequest("KPI already exist in this Tranning Program !!");

            await _unitOfWork.ProgramKPIs.AddAsync(new ProgramKPI
            {
                TrainingProgramId = request.TrainingProgramId,
                KPIId = request.KPIId,
            });
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Add KPI To Training Program Success !!");
        }
        public async Task<ApiResponse> GetAllKPI()
        {
            var response = new ApiResponse();
            var kpis = await _unitOfWork.KPIs.GetAllAsync(null, x => x.Include(x => x.ProgramKPI)
                                                                        .ThenInclude(x => x.TrainingProgram));
            var responseList = _mapper.Map<List<KPIResponse>>(kpis);

            return response.SetOk(responseList);
        }
        public async Task<ApiResponse> DeleteKPI(int id)
        {
            var response = new ApiResponse();
            var kpis = await _unitOfWork.KPIs.GetAsync(x => x.Id == id);
            if (kpis == null)
                return response.SetBadRequest("kpi Not Found!");
            await _unitOfWork.KPIs.RemoveByIdAsync(id);
            await _unitOfWork.SaveChangeAsync();


            return response.SetOk(kpis);

        }
        public async Task<ApiResponse> UpdateKPIAsync(UpdateKPIRequest request)
        {
            var response = new ApiResponse();
            var kpi = await _unitOfWork.KPIs.GetAsync(x => x.Id == request.Id);
            if (kpi == null)
            {
                return response.SetBadRequest("kpi cannot found");
            }

            _mapper.Map(request, kpi);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk(kpi);
        }

    }
}
