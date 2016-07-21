using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMileniumInterviewApp
{
    interface ILanguage
    {
        string Id { get; set; }
        Dictionary<string, string> GetDictionary();
    }
}
