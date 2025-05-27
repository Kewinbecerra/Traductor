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

        private async void btnConsultar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingrese un código válido.");
                return;
            }

            if (cmbIdioma.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un idioma.");
                return;
            }

            string idioma = cmbIdioma.SelectedItem.ToString();
            string url = $"http://localhost:53311/api/palabras/traduccioncodigo/{codigo}/{idioma}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        Traduccion traduccion = JsonSerializer.Deserialize<Traduccion>(json);
                        txtPalabra.Text = traduccion.Palabra;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la palabra.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public class Traduccion
        {

            public string Palabra { get; set; }

            public List<string> Sinonimos { get; set; }
            public int Codigo { get; set; }

        }
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Ingrese un código válido.");
                return;
            }

            if (cmbIdioma.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un idioma.");
                return;
            }

            string idioma = cmbIdioma.SelectedItem.ToString();
            string url = "http://localhost:53311/api/palabras/Actualizar";

            Traduccion traduccion = new Traduccion
            {
                Codigo = codigo,
                Palabra = txtPalabra.Text,
                Sinonimos = new List<string>() 
            };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string json = JsonSerializer.Serialize(traduccion);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync(url, content);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Palabra actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show($"Error al actualizar. Código: {response.StatusCode}");
                    }
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
    }
}
