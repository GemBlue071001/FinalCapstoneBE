﻿using Application.Response;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IVnPayService
    {
        Task<ApiResponse> CreatePaymentUrl(PaymentInformation model, HttpContext context);
        Task<ApiResponse> PaymentExecute(IQueryCollection collections);
    }
}