﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST_api.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public String Role { get; set; }    
    }
}