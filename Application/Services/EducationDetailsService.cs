using Application.Interface;
using Application.Request.EducationDetail;
using Application.Response;
using AutoMapper;
using DocumentFormat.OpenXml.Bibliography;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EducationDetailsService : IEducationDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EducationDetailsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddNewEducationDetailAsync(EducationDetailRequest request)
        {
            try
            {
                var educationDetail = _mapper.Map<EducationDetail>(request);
                await _unitOfWork.EducationDetails.AddAsync(educationDetail);
                await _unitOfWork.SaveChangeAsync();
                return new ApiResponse().SetOk("Success !");
            }
            catch (Exception ex)
            {
                return new ApiResponse().SetBadRequest(ex.Message);
            }
        }

        public async Task<ApiResponse> GetEducationDetailListAsync()
        {
            var educations = await _unitOfWork.EducationDetails.GetAllAsync(null);
            var responseList = _mapper.Map<List<EducationDetailResponse>>(educations);

            return new ApiResponse().SetOk(responseList);
        }
    }
}
