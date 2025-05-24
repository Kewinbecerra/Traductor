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
    public partial class Español_Ingles : Form
    {
        public Español_Ingles()
        {
            InitializeComponent();
        }

        private void lbtraducir_Click(object sender, EventArgs e)
        {
            string url = $"http://localhost:53311/api/palabras/traduccion/{txtespañol.Text}/Ingles";
            dynamic resultado = DBApi.Get(url);
            if (resultado != null)
            {
                txtingles.Text = resultado.Palabra.ToString();
                txtsinonimos.Text = string.Join("\r\n", resultado.Sinonimos);
            }
            else
            {
                MessageBox.Show("No se encontró la traducción.");
            }
        }
    }
}
