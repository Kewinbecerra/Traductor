using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Api_El_gago
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnTraducir_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text;
            string url = $"http://localhost:53311/api/palabras/traduccion/{palabra}/Ingles";
            dynamic resultado = DBApi.Get(url);

            if (resultado != null)
            {
                lblIngles.Text = "Inglés: " + resultado.PalabraIng;
                lblFrances.Text = "Francés: " + resultado.PalabraFr;
                lblAleman.Text = "Alemán: " + resultado.PalabraAl;
                lblSinonimos.Text = "Sinónimos: " + string.Join(", ", resultado.Sinonimos);
            }
            else
            {
                lblIngles.Text = "Inglés: No encontrado";
                lblFrances.Text = "Francés: No encontrado";
                lblAleman.Text = "Alemán: No encontrado";
                lblSinonimos.Text = "Sinónimos: No encontrados";
            }
        }

    }
}