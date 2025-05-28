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
using Api_El_gago.Models;
using System.Windows.Forms;
namespace Api_El_gago.Controllers
{

    [RoutePrefix("api/palabras")]
    public class PalabrasController : ApiController
    {
        // Metodo Get para  hacer las consultas por codigo
        // GET api/palabras/sinonimos/5
        [HttpGet]
        [Route("Traduccioncodigo/{codigo}/{idioma}")]
        public IHttpActionResult GetTraduccioncodigo(int codigo, string idioma)
        {
            using (idiomasEntities db = new idiomasEntities())
            {
                General_controllers gb = new General_controllers();

                if (idioma == "Español")
                {
                    try
                    {
                        dynamic palabra = db.español.FirstOrDefault(x => x.codigo == codigo);
                        if (palabra == null)
                        {
                         
                            return NotFound();
                        }
                        string palabra_español = palabra.Palabra.ToString();
                        var resultado = gb.ConsultaTraducciones(palabra_español,db);
                        return Ok(resultado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error en la consulta" + ex.Message);
                        return null;
                    }
                }
                else
                {
                    try
                    {
                        dynamic palabra = db.español.FirstOrDefault(x => x.codigoingles == codigo);
                        if (palabra == null)
                        {
                            return NotFound();
                        }
                        string palabra_español = palabra.Palabra.ToString();
                        var palabra_ingles = gb.Consultarfirst(db, "Ingles", palabra_español);
                        var palabra_frances = gb.Consultarfirst(db, "Frances", palabra_español);
                        var palabra_aleman = gb.Consultarfirst(db, "Aleman", palabra_español);
                        var sinonimo = gb.Consultarwhere(db, "Ingles", palabra_español);
                        var resultado = new Traducciones
                        {
                            PalabraEs = palabra_español,
                            PalabraIng = palabra_ingles.Palabra,
                            PalabraFr = palabra_frances.Palabra,
                            PalabraAl = palabra_aleman.Palabra,
                            Sinonimos = sinonimo
                        };
                        return Ok(resultado);
                    }
                    catch (Exception ex) {
                        return InternalServerError(ex);
                    }
                }
            }
        }
    
    //Metodos Get para hacer las consultas por palabras y para traducir
    // GET api/palabras/traduccion/perro/Ingles
    [HttpGet]
        [Route("traduccion/{palabra}/{idioma}")]
        public IHttpActionResult GetTraduccion(string palabra, string idioma)
        {
            using (idiomasEntities db = new idiomasEntities())
            {
                try
                {
                    General_controllers gb = new General_controllers();
                    if (idioma == "Español")
                    {
                        var resultado = gb.ConsultaTraducciones(palabra, db);
                        return Ok(resultado);

                    }
                    else
                    {

                        var palabra_idioma = gb.Consultarfirst(db, idioma, palabra);

                        if (palabra_idioma == null)
                        {
                            MessageBox.Show("ERROR, Palabra llego null");
                            return NotFound();
                        }

                        var sinonimo = gb.Consultarwhere(db, idioma, palabra);
                        if (sinonimo == null)
                        {
                            return NotFound();
                        }
                        var resultado = new Traduccion
                        {
                            Palabra = palabra_idioma.Palabra,
                            Codigo = palabra_idioma.codigo,
                            Sinonimos = sinonimo
                        };
                        if (resultado == null)
                        {
                            return NotFound();
                        }

                        return Ok(resultado);
                    }
                }catch (Exception ex) { return InternalServerError(ex); }
            }
        }
        [HttpPost]
        [Route("Insertar/{idioma}")]
        public HttpResponseMessage Post([FromBody] Palabrass palabras,string idioma)
        {
            try
            {
                int resp = 0;
                using (var ctx = new idiomasEntities())
                {
                    switch (idioma)
                    {
                        case "Español":
                            español esp = new español
                            {
                                codigo = palabras.Id,
                                Palabra = palabras.Palabra,
                                codigoingles = palabras.Id_ingles,
                                codigoaleman = palabras.Id_aleman,
                                codigofrances = palabras.Id_frances
                            };
                            ctx.español.Add(esp);
                            break;

                        case "Ingles":
                            Ingles ing = new Ingles
                            {
                                codigo = palabras.Id,
                                Palabra = palabras.Palabra
                            };
                            ctx.Ingles.Add(ing);
                            break;

                        case "Aleman":
                            Aleman ale = new Aleman
                            {
                                codigo = palabras.Id,
                                Palabra = palabras.Palabra
                            };
                            ctx.Aleman.Add(ale);
                            break;

                        case "Frances":
                            Frances fra = new Frances
                            {
                                codigo = palabras.Id,
                                Palabra = palabras.Palabra
                            };
                            ctx.Frances.Add(fra);
                            break;

                        default:
                            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Idioma no válido");
                    }

                    resp = ctx.SaveChanges();
                }

                return Request.CreateResponse(HttpStatusCode.OK, resp);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpPut]
        [Route("Actualizar/idioma")]
        public HttpResponseMessage Put([FromBody] Palabrass palabras,string idioma)
        {
            return null;
            

        }
        [HttpDelete]
        [Route("DELETE")]
        public HttpResponseMessage Delete([FromBody] Palabrass palabras)
        {

            EntityState entidad = EntityState.Deleted;
            return opercion(palabras, entidad);

        }
        private HttpResponseMessage opercion([FromBody] Palabrass objpalabra, EntityState operacion)
        {
            int resp = 0;
            HttpResponseMessage objMenRespuesta = null;
            try
            {
                using (idiomasEntities objEntidad = new idiomasEntities())
                {
                    objEntidad.Entry(objpalabra).State = operacion;
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


       

    
