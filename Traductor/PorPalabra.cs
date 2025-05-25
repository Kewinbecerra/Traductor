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
    public partial class PorPalabra : Form
    {
        private Padre padreForm;

        public PorPalabra(Padre padre)
        {
            InitializeComponent();
            this.padreForm = padre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabra = txtpalabra.Text;
            string idioma = CBidiomas.Text;

            string url = $"http://localhost:53311/api/palabras/Traduccionpalabra/{palabra}/{idioma}";
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
                MessageBox.Show("No se encontró la palabra.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
          "¿Deseas volver al menú principal?",
          "Confirmar salida",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
      );

            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                padreForm.Show();
            }
        }
    }
}
