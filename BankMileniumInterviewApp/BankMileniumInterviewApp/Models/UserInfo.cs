using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace BankMileniumInterviewApp.Models
{
    public class UserInfo : HeaderModel, IValidatableObject
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return new List<ValidationResult>
           {
               new ValidationResult("źłe")
               
           };
        }
    }
}