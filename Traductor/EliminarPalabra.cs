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
using System.Net;

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
     
            string url = $"http://localhost:53311/api/palabras/Traduccioncodigo/{txtCodigo.Text}/{cmbIdioma.Text}";
            dynamic resultado = DBApi.Get(url);
            if (resultado != null)
            {

                switch (cmbIdioma.Text)
                {
                    case "Español":
                      txtPalabra.Text = resultado.PalabraEs;
                        break;
                  
                    case "Ingles":
                        txtPalabra.Text = resultado.PalabraIng;
                        break;

                    case "Aleman":
                        txtPalabra.Text = resultado.PalabraAl;
                        break;

                    case "Frances":
                        txtPalabra.Text = resultado.PalabraFr;
                        break;

                }

            }
            else
            {
                MessageBox.Show("No se encontró la traducción.");
            }
        }

        public Palabras leerPalabras()
        {
            int id = int.Parse(txtCodigo.Text);
            string palabra = txtPalabra.Text;


            int? id_ingles = null;
            int? id_frances = null;
            int? id_aleman = null;

           
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedItem == null || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor seleccione un idioma y escriba un código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
   

            string url = $"http://localhost:53311/api/palabras/Actualizar/{cmbIdioma.Text}";
            Palabras objPalabra = leerPalabras();
            string json = JsonConvert.SerializeObject(objPalabra);
            int resultado = DBApi.Put(url, json);
            if (resultado == 1)
            {
                MessageBox.Show("Eliminación relizada");
            }
            else
            {
                MessageBox.Show("ERROR DE Eliminación");
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
           
        }
    }
}
