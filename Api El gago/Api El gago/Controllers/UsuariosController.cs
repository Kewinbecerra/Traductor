using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Conector;

namespace Api_El_gago.Controllers
{
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {
        [HttpGet]
        public IEnumerable<Usuarios_roles> GetUsuario()
        {
            using (UsuariosEntities usuarios = new UsuariosEntities()) {
             
             return usuarios.Usuarios_roles.ToList();
            }
        }
    }
}