﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.Auth
{
    public class VerificationEmailRequest
    {
        public int UserId { get; set; }
        public string VerificationCode { get; set; }
    }
}
