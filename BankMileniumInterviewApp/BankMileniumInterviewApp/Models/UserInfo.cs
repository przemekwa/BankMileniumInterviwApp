﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BankMileniumInterviewApp.Models
{
    public class UserInfo : HeaderModel
    {
        public string Name { get; set; }

        public string Email { get; set; }
}
}