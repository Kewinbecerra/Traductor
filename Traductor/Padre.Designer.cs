﻿namespace Traductor
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
            this.codigoTool = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoTool,
            this.palabraEnEspañolToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // codigoTool
            // 
            this.codigoTool.Name = "codigoTool";
            this.codigoTool.Size = new System.Drawing.Size(173, 22);
            this.codigoTool.Text = "Codigo";
            this.codigoTool.Click += new System.EventHandler(this.codigoTool_Click);
            // 
            // palabraEnEspañolToolStripMenuItem
            // 
            this.palabraEnEspañolToolStripMenuItem.Name = "palabraEnEspañolToolStripMenuItem";
            this.palabraEnEspañolToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.palabraEnEspañolToolStripMenuItem.Text = "Palabra en español";
            this.palabraEnEspañolToolStripMenuItem.Click += new System.EventHandler(this.palabraEnEspañolToolStripMenuItem_Click);
            // 
            // actualizaciónToolStripMenuItem
            // 
            this.actualizaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarPalabraToolStripMenuItem,
            this.eliminarPalabraToolStripMenuItem,
            this.actualizarPalabraToolStripMenuItem});
            this.actualizaciónToolStripMenuItem.Name = "actualizaciónToolStripMenuItem";
            this.actualizaciónToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.actualizaciónToolStripMenuItem.Text = "Actualización";
            // 
            // ingresarPalabraToolStripMenuItem
            // 
            this.ingresarPalabraToolStripMenuItem.Name = "ingresarPalabraToolStripMenuItem";
            this.ingresarPalabraToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ingresarPalabraToolStripMenuItem.Text = "Ingresar palabra";
            this.ingresarPalabraToolStripMenuItem.Click += new System.EventHandler(this.ingresarPalabraToolStripMenuItem_Click);
            // 
            // eliminarPalabraToolStripMenuItem
            // 
            this.eliminarPalabraToolStripMenuItem.Name = "eliminarPalabraToolStripMenuItem";
            this.eliminarPalabraToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eliminarPalabraToolStripMenuItem.Text = "Eliminar palabra";
            this.eliminarPalabraToolStripMenuItem.Click += new System.EventHandler(this.eliminarPalabraToolStripMenuItem_Click);
            // 
            // actualizarPalabraToolStripMenuItem
            // 
            this.actualizarPalabraToolStripMenuItem.Name = "actualizarPalabraToolStripMenuItem";
            this.actualizarPalabraToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.actualizarPalabraToolStripMenuItem.Text = "Actualizar Palabra";
            this.actualizarPalabraToolStripMenuItem.Click += new System.EventHandler(this.actualizarPalabraToolStripMenuItem_Click);
            // 
            // novedadesToolStripMenuItem
            // 
            this.novedadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolEspañol_Ingles,
            this.españolToolStripMenuItem,
            this.españolAlemanToolStripMenuItem});
            this.novedadesToolStripMenuItem.Name = "novedadesToolStripMenuItem";
            this.novedadesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.novedadesToolStripMenuItem.Text = "Novedades";
            // 
            // ToolEspañol_Ingles
            // 
            this.ToolEspañol_Ingles.Name = "ToolEspañol_Ingles";
            this.ToolEspañol_Ingles.Size = new System.Drawing.Size(161, 22);
            this.ToolEspañol_Ingles.Text = "Español-Inglés";
            this.ToolEspañol_Ingles.Click += new System.EventHandler(this.ToolEspañol_Ingles_Click);
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.españolToolStripMenuItem.Text = "Español-Francés";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // españolAlemanToolStripMenuItem
            // 
            this.españolAlemanToolStripMenuItem.Name = "españolAlemanToolStripMenuItem";
            this.españolAlemanToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.españolAlemanToolStripMenuItem.Text = "Español-Alemán";
            this.españolAlemanToolStripMenuItem.Click += new System.EventHandler(this.españolAlemanToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem codigoTool;
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

