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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedItem == null || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor seleccione un idioma y escriba un código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idioma = cmbIdioma.SelectedItem.ToString();
            string codigo = txtCodigo.Text;
            string urlAPI = "";

            // Construir la URL del API según el idioma
            switch (idioma)
            {
                case "Español":
                    urlAPI = $"http://localhost:53311/api/palabras/BuscarPorId/{codigo}";
                    break;
                case "Ingles":
                    urlAPI = $"http://localhost:53311/api/palabras/BuscarPorIdIngles/{codigo}";
                    break;
                case "Frances":
                    urlAPI = $"http://localhost:53311/api/palabras/BuscarPorIdFrances/{codigo}";
                    break;
                case "Aleman":
                    urlAPI = $"http://localhost:53311/api/palabras/BuscarPorIdAleman/{codigo}";
                    break;
                default:
                    MessageBox.Show("Idioma no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Consultar al API usando tu propio método Get
            dynamic respuesta = DBApi.Get(urlAPI);
            if (respuesta != null && respuesta.Palabra != null)
            {
                txtPalabra.Text = respuesta.Palabra;
            }
            else
            {
                MessageBox.Show("Palabra no encontrada.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPalabra.Clear();
            }
        }
        private  void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedItem == null || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor seleccione un idioma y escriba un código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Palabras palabraEliminar = new Palabras
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

            // Construir objeto Palabras según idioma (solo se necesita el campo de código correspondiente)
            switch (idioma)
            {
                case "Español":
                    objPalabra = new Palabras(id, "");
                    break;
                case "Ingles":
                    objPalabra = new Palabras(0, "") { Id_ingles = id };
                    break;
                case "Frances":
                    objPalabra = new Palabras(0, "") { Id_frances = id };
                    break;
                case "Aleman":
                    objPalabra = new Palabras(0, "") { Id_aleman = id };
                    break;
                default:
                    MessageBox.Show("Idioma no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            string urlAPI = "http://localhost:53311/api/palabras/Eliminar";
            string json = JsonConvert.SerializeObject(objPalabra);
            dynamic respuesta = DBApi.Delete(urlAPI, json);

            if (respuesta == 1)
            {
                MessageBox.Show("La eliminación de la palabra fue exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Clear();
                txtPalabra.Clear();
            }
            else
            {
                MessageBox.Show("Falló la eliminación de la palabra, revise la información", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
