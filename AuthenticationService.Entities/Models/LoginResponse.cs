﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Entities.Models
{
    public class LoginResponse
    {
        public string Username { get; set; }
        public string Token { get; set; }
    }
}
