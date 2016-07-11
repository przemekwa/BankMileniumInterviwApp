using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankMileniumInterviewApp.Models
{
    public class HeaderModel
    {
        public string CurrentCuture { get; set; } = "PL";

        public IEnumerable<CultureOption> CultureOptionList { get; set; }

        public HeaderModel(string CurrentCuture)
        {
            this.CurrentCuture = CurrentCuture;

            this.CultureOptionList = new List<CultureOption>
            {
                new CultureOption
                {
                    Id = "PL",
                    TextDisplay = "Polska wersja"
                },
                new CultureOption
                {
                    Id = "EN",
                    TextDisplay = "Angielska wersja"
                }
            };


            this.CultureOptionList.Single(s => s.Id == this.CurrentCuture).IsActive = true;


        }
    }
}