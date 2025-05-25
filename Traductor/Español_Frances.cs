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
    public partial class Español_Frances : Form
    {
        private Padre padreForm;

        public Español_Frances(Padre padre)
        {
            InitializeComponent();
            this.padreForm = padre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = $"http://localhost:53311/api/palabras/traduccion/{txespanol.Text}/Frances";
            dynamic resultado = DBApi.Get(url);
            if (resultado != null)
            {
                txtfrances.Text = resultado.Palabra.ToString();
                txsinonimosFr.Text = string.Join("\r\n", resultado.Sinonimos);
            }
            else
            {
                MessageBox.Show("No se encontró la traducción al francés.");
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
