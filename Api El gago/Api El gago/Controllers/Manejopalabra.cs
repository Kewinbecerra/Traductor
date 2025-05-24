using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Conector;
using System.Web.Http;
using System.Data.Entity;
using System.Net.Http;
using System.Net;
using Microsoft.Ajax.Utilities;
namespace Api_El_gago.Controllers
{
    public class Manejopalabra : ApiController
    {
       [RoutePrefix("api/palabras")]
public class PalabrasController : ApiController
{
    // GET api/palabras/sinonimos/5
    [HttpGet]
    [Route("sinonimos/{codigoIngles}")]
    public IHttpActionResult GetSinonimos(int codigoIngles)
    {
        using (idiomasEntities db = new idiomasEntities())
        {
            var sinonimos = db.español
                              .Where(p => p.codigoingles == codigoIngles)
                              .ToList();

            if (!sinonimos.Any())
            {
                return NotFound();
            }

            return Ok(sinonimos);
        }
    }

    // GET api/palabras/traduccion/perro/Ingles
    [HttpGet]
    [Route("traduccion/{palabra}/{idioma}")]
            public IHttpActionResult GetTraduccion(string palabra,string idioma)
    {
                using (idiomasEntities db = new idiomasEntities())
                {
                    var idiomas = Idiomas(idioma, db);

                    var palabra_idioma = Consultarfirst(db, idioma, palabra);

                    if (palabra_idioma == null)
                    {
                        return NotFound();
                    }

                    var sinonimo = Consultarwhere(db,idioma, palabra);
                    var resultado = new Traduccion
                    {
                        Palabra = palabra_idioma.Palabra,
                        Codigo = palabra_idioma.codigo,
                        Sinonimos = sinonimo
                    };
                   return Ok(resultado);
             }   
             }
            //metodo para obtener las tablas de cada idioma relacionado
            public dynamic Idiomas(string idioma, idiomasEntities db)
            {
                switch (idioma) {
                    case "Ingles":
                        return db.Ingles;
                    case "Frances":
                        return db.Frances;
                    case "Aleman":
                       return db.Aleman;
                    default:
                        return NotFound();
                }

            }
            //metodo para consultar la palabra para su idioma correspondiente
            public dynamic Consultarfirst(idiomasEntities db, string idioma,string palabra)
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
                        return NotFound();
                }
            }

            private HttpResponseMessage opercion([FromBody] Palabras objCuenta, EntityState operacion)
            {
                int resp = 0;
                HttpResponseMessage objMenRespuesta = null;
                try
                {
                    using (idiomasEntities objEntidad = new idiomasEntities())
                    {
                        objEntidad.Entry(objCuenta).State = operacion;
                        resp = objEntidad.SaveChanges();
                        objMenRespuesta = Request.CreateResponse(HttpStatusCode.OK, resp);
                    }
                }
                catch (Exception er)
                {
                    objMenRespuesta = Request.CreateErrorResponse(HttpStatusCode.InternalServerError, er.Message);
                }
                return objMenRespuesta;
            }
        }
    }
}

       

    
