using Newtonsoft.Json;
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
            // Ocultar campos de traducciones al iniciar
            lblCodigoIngles.Visible = false;
            txtCodigoIngles.Visible = false;

            lblCodigoFrances.Visible = false;
            txtCodigoFrances.Visible = false;

            lblCodigoAleman.Visible = false;
            txtCodigoAleman.Visible = false;
        }

        public Palabras leerPalabras()
        {
            if (cmbIdioma.Text == "Español")
            {
                int id = Int32.Parse(txtCodigo.Text);
                string palabra = txtPalabra.Text;
                int id_ingles = Int32.Parse(txtCodigoIngles.Text);
                int id_frances = Int32.Parse(txtCodigoFrances.Text);
                int id_aleman = Int32.Parse(txtCodigoAleman.Text);
                Palabras objPalabra = new Palabras(id, palabra,id_ingles,id_frances,id_aleman);
                return objPalabra;
            }
            else
            {
                int id = Int32.Parse(txtCodigo.Text);
                string palabra = txtPalabra.Text;
                Palabras objPalabra = new Palabras(id, palabra);
                return objPalabra;
            }
        }



        private  void btnRegistrar_Click(object sender, EventArgs e)
        {
            Palabras objPalabra = leerPalabras(); // Usas tu método ya creado
            string json = JsonConvert.SerializeObject(objPalabra);

            string urlAPI = "http://localhost:53311/api/palabras/Insertar";
            dynamic respuesta = DBApi.Post(urlAPI, json);


            if (respuesta == 1)
            {
                MessageBox.Show("La palabra fue registrada exitosamente.");
                // Aquí puedes limpiar los campos si deseas
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
