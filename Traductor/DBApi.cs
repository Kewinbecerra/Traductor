using Newtonsoft.Json; 
using RestSharp; 
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
            catch
            {
                return null;
            }
        }
    }
}
