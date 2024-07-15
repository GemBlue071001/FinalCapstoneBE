using Application.Interface;
using Application.Request.AssessmentSubmition;
using Application.Request.Campaign;
using Application.Response;
using Application.Response.AssessmentSubmition;
using AutoMapper;
using Domain.Entities;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AssessmentSubmitionService : IAssessmentSubmitionService
    {
        public IUnitOfWork _unitOfWork;

        public IMapper _mapper;
        public AssessmentSubmitionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponse> AddSubmitionAsync(SubmitionRequest request)
        {
            var response = new ApiResponse();

            var submition = _mapper.Map<AssessmentSubmition>(request);

            await _unitOfWork.AssessmentSubmitions.AddAsync(submition);
            await _unitOfWork.SaveChangeAsync();
            return response.SetOk("Create Success !!");
        }

        public async Task<ApiResponse> GetAllSubmitionByAsseessmentAsync(int asseessmentId)
        {
            var response = new ApiResponse();
            var submitions = await _unitOfWork.AssessmentSubmitions.GetAllAsync(x => x.AssessmentId == asseessmentId);
            var submition = _mapper.Map<List<AssessmentSubmitionResponse>>(submitions);

            return response.SetOk(submition);
        }

        public async Task<ApiResponse> RemoveSubmitionAsync(int submitionId)
        {
            var response = new ApiResponse();
            var submition = await _unitOfWork.AssessmentSubmitions.GetAsync(x => x.Id == submitionId);
            if (submition == null)
            {
                return response.SetBadRequest($"submition {submitionId} not Found");

            }
            await _unitOfWork.AssessmentSubmitions.RemoveByIdAsync(submition.Id);
            await _unitOfWork.SaveChangeAsync();

            return response.SetOk("Delete Success !");
        }

    }
}
