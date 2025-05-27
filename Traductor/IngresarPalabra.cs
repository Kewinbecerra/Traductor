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



        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPalabra.Text) || string.IsNullOrWhiteSpace(txtCodigo.Text) || cmbIdioma.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idioma = cmbIdioma.SelectedItem.ToString();
            string palabraTexto = txtPalabra.Text;
            int codigo;

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("El código debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Palabras nuevaPalabra = new Palabras();
            nuevaPalabra.Palabra = palabraTexto;

            // Inicializamos todos los ID como 0
            nuevaPalabra.Id_ingles = 0;
            nuevaPalabra.Id_frances = 0;
            nuevaPalabra.Id_aleman = 0;

            switch (idioma)
            {
                case "Español":
                    // Si la palabra es en español, usamos los códigos de los significados en otros idiomas
                    int idIng = 0, idFra = 0, idAle = 0;

                    int.TryParse(txtCodigoIngles.Text, out idIng);
                    int.TryParse(txtCodigoFrances.Text, out idFra);
                    int.TryParse(txtCodigoAleman.Text, out idAle);

                    nuevaPalabra.Id_ingles = idIng;
                    nuevaPalabra.Id_frances = idFra;
                    nuevaPalabra.Id_aleman = idAle;
                    break;

                case "Ingles":
                    nuevaPalabra.Id_ingles = codigo;
                    break;

                case "Frances":
                    nuevaPalabra.Id_frances = codigo;
                    break;

                case "Aleman":
                    nuevaPalabra.Id_aleman = codigo;
                    break;

                default:
                    MessageBox.Show("Idioma no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53311/api/palabras/Insertar");
                try
                {
                    string json = JsonConvert.SerializeObject(nuevaPalabra);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync("Insertar", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Palabra registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPalabra.Clear();
                        txtCodigo.Clear();
                        txtCodigoIngles.Clear();
                        txtCodigoFrances.Clear();
                        txtCodigoAleman.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar palabra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
