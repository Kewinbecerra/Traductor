using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traductor
{
    public partial class Padre : Form
    {
        private Login LoginForm;
        private string RolUsuario;
        public Padre(Login login, string rolUsuario)
        {
            InitializeComponent();
            this.LoginForm = login;
            this.RolUsuario = rolUsuario;
            ConfigurarAccesoPorRol();
        }

        private void ConfigurarAccesoPorRol()
        {
            if (RolUsuario == "Usuario")
            {
                ingresarPalabraToolStripMenuItem.Enabled = false;
                eliminarPalabraToolStripMenuItem.Enabled = false;
                actualizarPalabraToolStripMenuItem.Enabled = false;
                ToolEspañol_Ingles.Enabled = true;
                españolAlemanToolStripMenuItem.Enabled = true;
                españolToolStripMenuItem.Enabled = true;
                palabraEnEspañolToolStripMenuItem.Enabled = true;
                codigoTool.Enabled = true;

            }
            else if (RolUsuario == "Administrador")
            {
                ingresarPalabraToolStripMenuItem.Enabled = true;
                eliminarPalabraToolStripMenuItem.Enabled = true;
                actualizarPalabraToolStripMenuItem.Enabled = true;
                ToolEspañol_Ingles.Enabled = true;
                españolAlemanToolStripMenuItem.Enabled = true;
                españolToolStripMenuItem.Enabled = true;
                palabraEnEspañolToolStripMenuItem.Enabled = true;
                codigoTool.Enabled = true;
            }
        }


        private void ToolEspañol_Ingles_Click(object sender, EventArgs e)
        {
            Español_Ingles formEspIng = new Español_Ingles(this);
            formEspIng.Show();
            this.Hide();
        }

        private void codigoTool_Click(object sender, EventArgs e)
        {
            PorCodigo porCodigo = new PorCodigo();
            porCodigo.MdiParent = this;
            porCodigo.Show();
        }

        private void españolAlemanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Español_Aleman formEspAle = new Español_Aleman(this);
            formEspAle.Show();
            this.Hide();
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Español_Frances formEspFra = new Español_Frances(this);
            formEspFra.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ingresarPalabraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarPalabra frmIngresar = new IngresarPalabra();
            frmIngresar.Show(); 
            this.Hide();
        }

        private void eliminarPalabraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPalabra frmIngresar = new EliminarPalabra();
            frmIngresar.Show();
            this.Hide();
        }

        private void actualizarPalabraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarPalabra frmIngresar = new ActualizarPalabra();
            frmIngresar.Show();
            this.Hide();
        }

        private void palabraEnEspañolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PorPalabra frmIngresar = new PorPalabra(this);
            frmIngresar.Show();
            this.Hide();
        }
    }
}
