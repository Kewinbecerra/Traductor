using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Traductor
{
    public partial class PorCodigo : Form
    {
        public PorCodigo()
        {
            InitializeComponent();
        }

        private void btconsulta_Click(object sender, EventArgs e)
        {
            string url = $"http://localhost:53311/api/palabras/Traduccioncodigo/{txtcodigo.Text}/{CBidiomas.Text}";
            dynamic resultado = DBApi.Get(url);
            if (resultado != null)
            {
                
                txtpalabras.Text =
                   $"Palabra en Español: {resultado.PalabraEs}\r\n" +
                   $"Sinónimos: {string.Join(", ", resultado.Sinonimos)}\r\n\r\n" +
                   $"Traducciones:\r\n" +
                   $"  Inglés: {resultado.PalabraIng}\r\n" +
                   $"  Francés: {resultado.PalabraFr}\r\n" +
                   $"  Alemán: {resultado.PalabraAl}";

            }
            else
            {
                MessageBox.Show("No se encontró la traducción.");
            }
        }
    }
}
