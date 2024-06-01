using Application.Interface;
using Application.Request.Candidate;
using Application.Response;
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
        public CandidateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> AddCadidate(CandidateRequest request)
        {
            var response = new ApiResponse();
            await _unitOfWork.Candidates.AddAsync(_mapper.Map<Candidate>(request));
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Create Success !!");
        }
    }
}
