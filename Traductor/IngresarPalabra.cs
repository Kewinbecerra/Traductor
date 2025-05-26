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

            switch (idioma)
            {
                case "Español":
                    nuevaPalabra.Palabra = palabraTexto;
                    nuevaPalabra.Id_ingles = 0;
                    nuevaPalabra.Id_frances = 0;
                    nuevaPalabra.Id_aleman = 0;
                    break;
                case "Ingles":
                    nuevaPalabra.Palabra = palabraTexto;
                    nuevaPalabra.Id_ingles = codigo;
                    break;
                case "Frances":
                    nuevaPalabra.Palabra = palabraTexto;
                    nuevaPalabra.Id_frances = codigo;
                    break;
                case "Aleman":
                    nuevaPalabra.Palabra = palabraTexto;
                    nuevaPalabra.Id_aleman = codigo;
                    break;
                default:
                    MessageBox.Show("Idioma no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53311/api/palabras/");
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
    }
}
