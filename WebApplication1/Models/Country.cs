using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Country
    {
        public string name { get; set; }
        public string capital { get; set; }
        public string[] callingCodes {set;get;}
        public List<Currency> currencies { get; set; }
    }
}