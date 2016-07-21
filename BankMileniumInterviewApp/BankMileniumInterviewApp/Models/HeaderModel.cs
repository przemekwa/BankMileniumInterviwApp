using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankMileniumInterviewApp.Models
{
    public class HeaderModel
    {
        public string CurrentCuture { get; set; } = "PL";

        private IEnumerable<CultureOption> cultureOptionList;

        public IEnumerable<CultureOption> CultureOptionList
        {
            get
            {
                this.cultureOptionList.Single(s => s.Id == this.CurrentCuture).IsActive = true;

                return cultureOptionList;
            }
            set { cultureOptionList = value; }
        }


    
        public HeaderModel()
        {
            this.cultureOptionList = new List<CultureOption>
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
                },
            };


          


        }
    }
}