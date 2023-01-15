using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace problem_4
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string BrowsingWeb(string x)
        {
            return x.Any(z => char.IsDigit(z)) ? "Invalid URL!" : $"Browsing: {x}!";
        }
        public string CallOtherPhones(string x)
        {
            return x.Any(z => char.IsDigit(z)) ? $"Calling... {x}" : "Invalid number!";
        }
    }
}
