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
using System.Net.Http.Headers;

namespace Traductor
{
    public partial class EliminarPalabra : Form
    {
        private Padre padreForm;
        public EliminarPalabra(Padre padre)
        {
            InitializeComponent();
            this.padreForm = padre;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || cmbIdioma.SelectedItem == null)
            {
                MessageBox.Show("Debe ingresar un código y seleccionar un idioma.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idioma = cmbIdioma.SelectedItem.ToString();
            string codigo = txtCodigo.Text;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53311/api/palabras/traduccion/"); 

                try
                {
                    HttpResponseMessage response = await client.GetAsync($"Traduccioncodigo/{codigo}/{idioma}");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();

                       
                        dynamic resultado = JsonConvert.DeserializeObject(json);
                        txtPalabra.Text = resultado.PalabraEs;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la palabra para el código e idioma especificados.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la palabra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPalabra.Text))
            {
                MessageBox.Show("Debe consultar una palabra antes de eliminarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Palabras palabraEliminar = new Palabras ()
            {
                Palabra = txtPalabra.Text
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:53311/api/palabras/traduccion/"); 
                try
                {
                    var jsonContent = JsonConvert.SerializeObject(palabraEliminar);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Delete,
                        RequestUri = new Uri(client.BaseAddress, "DELETE"),
                        Content = content
                    };

                    HttpResponseMessage response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Palabra eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigo.Clear();
                        txtPalabra.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la palabra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la palabra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
