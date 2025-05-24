namespace Traductor
{
    partial class Padre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palabraEnEspañolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarPalabraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarPalabraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarPalabraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolEspañol_Ingles = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolAlemanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.actualizaciónToolStripMenuItem,
            this.novedadesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoToolStripMenuItem,
            this.palabraEnEspañolToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // codigoToolStripMenuItem
            // 
            this.codigoToolStripMenuItem.Name = "codigoToolStripMenuItem";
            this.codigoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.codigoToolStripMenuItem.Text = "Codigo";
            // 
            // palabraEnEspañolToolStripMenuItem
            // 
            this.palabraEnEspañolToolStripMenuItem.Name = "palabraEnEspañolToolStripMenuItem";
            this.palabraEnEspañolToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.palabraEnEspañolToolStripMenuItem.Text = "Palabra en español";
            // 
            // actualizaciónToolStripMenuItem
            // 
            this.actualizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarPalabraToolStripMenuItem,
            this.eliminarPalabraToolStripMenuItem,
            this.actualizarPalabraToolStripMenuItem});
            this.actualizaciónToolStripMenuItem.Name = "actualizaciónToolStripMenuItem";
            this.actualizaciónToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.actualizaciónToolStripMenuItem.Text = "Actualización";
            // 
            // ingresarPalabraToolStripMenuItem
            // 
            this.ingresarPalabraToolStripMenuItem.Name = "ingresarPalabraToolStripMenuItem";
            this.ingresarPalabraToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.ingresarPalabraToolStripMenuItem.Text = "Ingresar palabra";
            // 
            // eliminarPalabraToolStripMenuItem
            // 
            this.eliminarPalabraToolStripMenuItem.Name = "eliminarPalabraToolStripMenuItem";
            this.eliminarPalabraToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.eliminarPalabraToolStripMenuItem.Text = "Eliminar palabra";
            // 
            // actualizarPalabraToolStripMenuItem
            // 
            this.actualizarPalabraToolStripMenuItem.Name = "actualizarPalabraToolStripMenuItem";
            this.actualizarPalabraToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.actualizarPalabraToolStripMenuItem.Text = "Actualizar Palabra";
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolEspañol_Ingles,
            this.españolToolStripMenuItem,
            this.españolAlemanToolStripMenuItem});
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            // 
            // ToolEspañol_Ingles
            // 
            this.ToolEspañol_Ingles.Name = "ToolEspañol_Ingles";
            this.ToolEspañol_Ingles.Size = new System.Drawing.Size(224, 26);
            this.ToolEspañol_Ingles.Text = "Español-Inglés";
            this.ToolEspañol_Ingles.Click += new System.EventHandler(this.ToolEspañol_Ingles_Click);
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.españolToolStripMenuItem.Text = "Español-Francés";
            // 
            // españolAlemanToolStripMenuItem
            // 
            this.españolAlemanToolStripMenuItem.Name = "españolAlemanToolStripMenuItem";
            this.españolAlemanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.españolAlemanToolStripMenuItem.Text = "Español-Alemán";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Padre";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palabraEnEspañolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarPalabraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarPalabraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarPalabraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolEspañol_Ingles;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolAlemanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

