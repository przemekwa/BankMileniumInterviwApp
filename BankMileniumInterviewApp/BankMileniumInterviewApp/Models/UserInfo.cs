using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BankMileniumInterviewApp.Models
{
    public class UserInfo : HeaderModel
    {
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Dictionary<string,string> Translator { get; set; }
    }
}