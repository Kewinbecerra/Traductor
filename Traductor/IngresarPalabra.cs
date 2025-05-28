using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace Traductor
{
    public partial class IngresarPalabra : Form
    {
        private Padre padreForm;
        public IngresarPalabra(Padre padre)
        {
            InitializeComponent();
            this.padreForm = padre;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            lblCodigoIngles.Visible = false;
            txtCodigoIngles.Visible = false;

            lblCodigoFrances.Visible = false;
            txtCodigoFrances.Visible = false;

            lblCodigoAleman.Visible = false;
            txtCodigoAleman.Visible = false;
        }

        public Palabras leerPalabras()
        {
            int id = int.Parse(txtCodigo.Text);
            string palabra = txtPalabra.Text;

            // Valores nulos por defecto
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



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Palabras objPalabra = leerPalabras(); 
                string json = JsonConvert.SerializeObject(objPalabra);

                string urlAPI = $"http://localhost:53311/api/palabras/Insertar/{cmbIdioma.Text}";
                int respuesta = DBApi.Post(urlAPI, json);

 

                if (respuesta == 1)
                {
                    MessageBox.Show("La palabra fue registrada exitosamente.");
                    txtCodigo.Clear();
                    txtPalabra.Clear();
                    txtCodigoIngles.Clear();
                    txtCodigoFrances.Clear();
                    txtCodigoAleman.Clear();
                }
                else
                {
                    MessageBox.Show("Falló el registro de la palabra. Verifique la información.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
