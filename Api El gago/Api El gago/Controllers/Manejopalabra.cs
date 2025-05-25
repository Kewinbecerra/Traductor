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
    public class Manejopalabra : ApiController
    {
       [RoutePrefix("api/palabras")]
public class PalabrasController : ApiController
{
    // GET api/palabras/sinonimos/5
    [HttpGet]
    [Route("Traduccioncodigo/{codigo}/{idioma}")]
    public IHttpActionResult GetTraduccioncodigo(int codigo, string idioma)
    {
        using (idiomasEntities db = new idiomasEntities())
        {
                    General gb = new General();
                    
                    if (idioma == "Español")
                    {
                        try
                        {
                            dynamic palabra = db.español.FirstOrDefault(x => x.codigo == codigo);
                            if (palabra == null)
                            {
                                MessageBox.Show("Ese Codigo no se encuentra en nuestro sistema, intente otro porfavor");
                                return null;
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
                            if(palabra == null)
                            {
                                MessageBox.Show("Ese Codigo no se encuentra en nuestro sistema, intente otro porfavor");
                                return null;
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
                         MessageBox.Show("Error en la consulta"+ex.Message);
                            return null;
                        }
                    }     
                    }
        }
    }
    
    // GET api/palabras/traduccion/perro/Ingles
    [HttpGet]
    [Route("traduccion/{palabra}/{idioma}")]
            public IHttpActionResult GetTraduccion(string palabra,string idioma)
    {
                using (idiomasEntities db = new idiomasEntities())
                {
                    General gb  = new General();

                    var palabra_idioma = gb.Consultarfirst(db, idioma, palabra);

                    if (palabra_idioma == null)
                    {
                        return NotFound();
                    }

                    var sinonimo = gb.Consultarwhere(db,idioma, palabra);
                    var resultado = new Traduccion
                    {
                        Palabra = palabra_idioma.Palabra,
                        Codigo = palabra_idioma.codigo,
                        Sinonimos = sinonimo
                    };
                   return Ok(resultado);
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


       

    
