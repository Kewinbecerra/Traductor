using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_El_gago.Controllers
{
    public class Palabras
    {
       
            public int Id { get; set; }
            public string PalabraTexto { get; set; }
            public int IdIngles { get; set; }
            public int IdAleman { get; set; }
            public int IdFrances { get; set; }

            // Constructor
            public Palabras(int id, string palabraTexto, int idIngles, int idAleman, int idFrances)
            {
                Id = id;
                PalabraTexto = palabraTexto;
                IdIngles = idIngles;
                IdAleman = idAleman;
                IdFrances = idFrances;
            
             }

    }
}