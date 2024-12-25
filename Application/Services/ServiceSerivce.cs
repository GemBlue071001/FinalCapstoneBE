using Application.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServiceSerivce
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;
        private IClaimService _claimService;
    }
}
