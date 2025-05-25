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
        public Padre()
        {
            InitializeComponent();
        }

        private void ToolEspañol_Ingles_Click(object sender, EventArgs e)
        {
            Español_Ingles ingles = new Español_Ingles();
            ingles.MdiParent = this;
            ingles.Show();
        }

        private void codigoTool_Click(object sender, EventArgs e)
        {
            PorCodigo porCodigo = new PorCodigo();
            porCodigo.MdiParent = this;
            porCodigo.Show();
        }
    }
}
