using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_El_gago.Controllers
{
    public class Traduccion
    {

        public string Palabra {  get; set; }
       
        public List<string> Sinonimos { get; set; }
        public int Codigo { get; set; }
       
    }
}