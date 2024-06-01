﻿using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IEmailService
    {
        Task<ApiResponse> SendMail(string recievedUser, string content);
    }
}
