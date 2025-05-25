using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_El_gago.Controllers
{
    public class Traducciones
    {
        public string PalabraEs { get; set; }

        public List<string> Sinonimos { get; set; }

        public string PalabraIng { get; set; }

        public string PalabraFr { get; set; }

        public string PalabraAl { get; set; }
    }
}