using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankMileniumInterviewApp
{
    public class TranslatorsFactory
    {
        public Dictionary<string, string> GetDictionary(string cutureSumbol)
        {
            switch (cutureSumbol)
            {
                default:
                case "PL":
                    return new Dictionary<string, string>
                    {
                        ["Name"] = "Podaj nazwę użytkownika",
                        ["NameError"] = "Pole nazwa użytkonikwa musi mieć tylko 2 litery",
                        ["Email"] = "Podaj e-mail",
                        ["EmailError"] = "Pole email nie zawiera poprawnego adresu email"

                    };
                case "EN":
                    return new Dictionary<string, string>
                    {
                        ["Name"] = "What is Your name?",
                        ["NameError"] = "Name error is ...",
                        ["Email"] = "What is Your email?",
                        ["EmailError"] = "Email error"
                    };
                case "HP":
                    return new Dictionary<string, string>
                    {
                        ["Name"] = "What is Your name?",
                        ["NameError"] = "Name error is ...",
                        ["Email"] = "What is Your email?",
                        ["EmailError"] = "Email error"
                    };
            }

        }
    }
}