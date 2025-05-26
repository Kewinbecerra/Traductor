using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Windows.Forms;
using Api_El_gago.Controllers;
using Conector;

namespace Api_El_gago.Models
{
    public class General_controllers  : ApiController
    {
      
        //metodo para consultar la palabra para su idioma correspondiente
        public dynamic Consultarfirst(idiomasEntities db, string idioma, string palabra)
        {
            var palabra_español = db.español.FirstOrDefault(x => x.Palabra == palabra);
            if (palabra_español == null)
            {
                return NotFound();
                
            }
            switch (idioma)
            {
                case "Ingles":
                    return db.Ingles.FirstOrDefault(p => p.codigo == palabra_español.codigoingles);
                case "Frances":
                    return db.Frances.FirstOrDefault(p => p.codigo == palabra_español.codigofrances);
                case "Aleman":
                    return db.Aleman.FirstOrDefault(p => p.codigo == palabra_español.codigoaleman);
                default:
                    MessageBox.Show("Idioma erroneo");
                    return NotFound();
            }
        }
        
        //metodo para obtener la lista de sinonimos
        public dynamic Consultarwhere(idiomasEntities db, string idioma, string palabra)
        {
            var palabra_español = db.español.FirstOrDefault(x => x.Palabra == palabra);
            if (palabra_español == null)
            {
                return NotFound();
            }
            switch (idioma)
            {
                case "Ingles":
                    return db.español.Where(p => p.codigoingles == palabra_español.codigoingles && p.Palabra != palabra)
                    .Select(x => x.Palabra).ToList();
                case "Frances":
                    return db.español.Where(p => p.codigofrances == palabra_español.codigofrances && p.Palabra != palabra)
                     .Select(x => x.Palabra).ToList();
                case "Aleman":
                    return db.español.Where(p => p.codigoaleman == palabra_español.codigoaleman && p.Palabra != palabra)
                     .Select(x => x.Palabra).ToList();
                default:
                    MessageBox.Show("Idioma erroneo en consulta where");
                    return NotFound();
            }        
        }
        public dynamic ConsultaTraducciones(string palabra_español, idiomasEntities db)
        {
            var palabra_ingles = Consultarfirst(db, "Ingles", palabra_español);
            var palabra_frances = Consultarfirst(db, "Frances", palabra_español);
            var palabra_aleman = Consultarfirst(db, "Aleman", palabra_español);
            var sinonimo = Consultarwhere(db, "Ingles", palabra_español);
            var resultado = new Traducciones
            {
                PalabraEs = palabra_español,
                PalabraIng = palabra_ingles.Palabra,
                PalabraFr = palabra_frances.Palabra,
                PalabraAl = palabra_aleman.Palabra,
                Sinonimos = sinonimo
            };
            return resultado;
        }
    }
}