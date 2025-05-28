using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.Json;
using Newtonsoft.Json;




namespace Traductor
{
    public partial class ActualizarPalabra : Form
    {
        private Padre padreForm;
        public ActualizarPalabra(Padre padre)
        {
            InitializeComponent();
            this.padreForm = padre;
        }
        public Palabras leerPalabras()
        {
            int id = int.Parse(txtCodigo.Text);
            string palabra = txtPalabra.Text;

   
            int? id_ingles = null;
            int? id_frances = null;
            int? id_aleman = null;

            if (cmbIdioma.Text == "Español")
            {
                id_ingles = int.Parse(txtCodigoIngles.Text);
                id_frances = int.Parse(txtCodigoFrances.Text);
                id_aleman = int.Parse(txtCodigoAleman.Text);
            }

            Palabras objPalabra = new Palabras()
            {
                Id = id,
                Palabra = palabra,
                Id_ingles = id_ingles,
                Id_frances = id_frances,
                Id_aleman = id_aleman
            };

            return objPalabra;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text;

            string url = $"http://localhost:53311/api/palabras/Traduccion/{palabra}/{cmbIdioma.Text}";
            dynamic resultado = DBApi.Get(url);

            if (resultado != null)
            {
                MessageBox.Show("Ingrese los valores a actualizar");
                btnActualizar.Visible = true;
                txtCodigo.Visible = true;
            }
            else
            {
                MessageBox.Show("Esa palabra no se encuentra en nuestra base de datos.");
            }

        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string url = $"http://localhost:53311/api/palabras/Actualizar/{cmbIdioma.Text}";
            Palabras objPalabra = leerPalabras();
            string json = JsonConvert.SerializeObject(objPalabra);
            int resultado = DBApi.Put(url,json);
            if (resultado == 1) {
                MessageBox.Show("Actualización relizada");
            }
            else
            {
                MessageBox.Show("ERROR DE ACTUALIZACIÓN");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esEspanol = cmbIdioma.SelectedItem.ToString() == "Español";

            lblCodigoIngles.Visible = esEspanol;
            txtCodigoIngles.Visible = esEspanol;

            lblCodigoFrances.Visible = esEspanol;
            txtCodigoFrances.Visible = esEspanol;

            lblCodigoAleman.Visible = esEspanol;
            txtCodigoAleman.Visible = esEspanol;
        }
    }
}
