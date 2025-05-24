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

            // GET api/palabras/traduccion/perro
            [HttpGet]
            [Route("traduccion/{palabra}")]
            public IHttpActionResult GetTraduccion(string palabra)
            {
                using (idiomasEntities db = new idiomasEntities())
                {
                    var palabra_espanol = db.español.FirstOrDefault(x => x.Palabra == palabra);

                    if (palabra_espanol == null)
                    {
                        return NotFound();
                    }

                    var palabra_ingles = db.Ingles.FirstOrDefault(x => x.codigo == palabra_espanol.codigoingles);

                    if (palabra_ingles == null)
                    {
                        return NotFound();
                    }

                    return Ok(palabra_ingles);
                }
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