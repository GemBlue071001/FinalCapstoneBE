using Application.Interface;
using Application.Request.Candidate;
using Application.Response;
using Application.Response.Candidate;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CandidateService : ICandidateService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public CandidateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddCadidate(CandidateRequest request)
        {
            var response = new ApiResponse();
            var trainingProgram = await _unitOfWork.Jobs.GetAsync(p => p.Id == request.JobId);

            if (trainingProgram == null)
                return response.SetBadRequest("Training Program Not Found !!");

            await _unitOfWork.Candidates.AddAsync(_mapper.Map<Candidate>(request));
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetProgramCadidate(int programId)
        {
            var response = new ApiResponse();
            var candidates = await _unitOfWork.Candidates.GetAllAsync(p => p.JobId == programId);

            var responseList = _mapper.Map<List<CandidateResponse>>(candidates);

            return response.SetOk(responseList);
        }
    }
}
