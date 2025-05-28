using Newtonsoft.Json; 
using RestSharp;
using System;
using System.IO; 
using System.Net; 
using System.Web; 
using System.Windows.Forms;
namespace Traductor
{
    class DBApi
    {
        public static dynamic Get(string urlApi)
        {
            try
            {
                HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
                objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox / 23.0";
                //objPedido.CookieContainer = myCookie; 
                objPedido.Credentials = CredentialCache.DefaultCredentials;
                objPedido.Proxy = null;
                HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
                Stream objFlujo = objRespuesta.GetResponseStream();
                StreamReader objFlujoLectura = new StreamReader(objFlujo);
                //Leemos los datos 
                string datosJson = HttpUtility.HtmlDecode(objFlujoLectura.ReadToEnd());
                dynamic datos = JsonConvert.DeserializeObject(datosJson);
                return datos;
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR " + ex.Message);
                return null;
            }
          }
          
        
        public static dynamic Post(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Post;
            return operaciones(urlApi, json, autorizacion = null, op);
        }
        public static dynamic Put(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Put;
            return operaciones(urlApi, json, autorizacion = null, op);
        }
        public static dynamic Delete(string urlApi, string json, string autorizacion = null)
        {
            Method op = Method.Delete;
            return operaciones(urlApi, json, autorizacion = null, op);
        }
        private static dynamic operaciones(string urlApi, string json, string autorizacion,Method op)
        {
            try
            {
                var objCliente = new RestClient(urlApi);
                var objPedido = new RestRequest();
                objPedido.Method = op;
                objPedido.AddHeader("content-type", "application/json");
                objPedido.AddParameter("application/json", json, ParameterType.RequestBody);
                if (autorizacion != null)
                {
                    objPedido.AddHeader("Authorization", autorizacion);
                }
                RestResponse objRespuesta = objCliente.Execute(objPedido);
                 int datos = int.Parse(objRespuesta.Content);
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }

}
