using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traductor
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            string correo = tbCorreo.Text.Trim();
            string clave = tbClave.Text.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese correo y clave.");
                return;
            }

            string url = "http://localhost:53311/api/usuarios"; 
            dynamic resultado = DBApi.Get(url);

            if (resultado != null)
            {
                bool encontrado = false;
                foreach (var Usuarios in resultado)
                {
                    if (Usuarios.Correo == correo && Usuarios.Clave == clave)
                    {
                        string nombre = Usuarios.Nombre;
                        string rol = Usuarios.NombreRol;
                        MessageBox.Show($"Bienvenido {nombre} ({rol})");

                        Padre padreForm = new Padre(this, rol); 
                        padreForm.Show();
                        this.Hide();
                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("Correo o clave incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la API.");
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
          "¿Estás seguro que quieres salir de la aplicación?",
          "Confirmar salida",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
      );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
