﻿using Application.Request.Message;
using Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IMessageService
    {
       Task<ApiResponse> AddMessages(MessageRequest request);
    }
}
