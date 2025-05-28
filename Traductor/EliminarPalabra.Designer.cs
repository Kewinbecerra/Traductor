namespace Traductor
{
    partial class EliminarPalabra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoAleman = new System.Windows.Forms.TextBox();
            this.lblCodigoAleman = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoFrances = new System.Windows.Forms.TextBox();
            this.lblCodigoFrances = new System.Windows.Forms.Label();
            this.txtCodigoIngles = new System.Windows.Forms.TextBox();
            this.lblCodigoIngles = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(605, 349);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 54);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(605, 188);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(125, 54);
            this.btnConsultar.TabIndex = 26;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(319, 279);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.ReadOnly = true;
            this.txtPalabra.Size = new System.Drawing.Size(133, 30);
            this.txtPalabra.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Palabra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 23;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(319, 217);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 30);
            this.txtCodigo.TabIndex = 22;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(210, 217);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(75, 25);
            this.lbCodigo.TabIndex = 21;
            this.lbCodigo.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Eliminar Palabra";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(605, 267);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 54);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Idioma";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles",
            "Frances",
            "Aleman"});
            this.cmbIdioma.Location = new System.Drawing.Point(319, 156);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(137, 33);
            this.cmbIdioma.TabIndex = 30;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 62;
            this.label9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 61;
            // 
            // txtCodigoAleman
            // 
            this.txtCodigoAleman.Location = new System.Drawing.Point(318, 425);
            this.txtCodigoAleman.Name = "txtCodigoAleman";
            this.txtCodigoAleman.Size = new System.Drawing.Size(133, 30);
            this.txtCodigoAleman.TabIndex = 60;
            this.txtCodigoAleman.Visible = false;
            // 
            // lblCodigoAleman
            // 
            this.lblCodigoAleman.AutoSize = true;
            this.lblCodigoAleman.Location = new System.Drawing.Point(169, 431);
            this.lblCodigoAleman.Name = "lblCodigoAleman";
            this.lblCodigoAleman.Size = new System.Drawing.Size(147, 25);
            this.lblCodigoAleman.TabIndex = 59;
            this.lblCodigoAleman.Text = "Código Alemán";
            this.lblCodigoAleman.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 58;
            // 
            // txtCodigoFrances
            // 
            this.txtCodigoFrances.Location = new System.Drawing.Point(318, 369);
            this.txtCodigoFrances.Name = "txtCodigoFrances";
            this.txtCodigoFrances.Size = new System.Drawing.Size(133, 30);
            this.txtCodigoFrances.TabIndex = 57;
            this.txtCodigoFrances.Visible = false;
            // 
            // lblCodigoFrances
            // 
            this.lblCodigoFrances.AutoSize = true;
            this.lblCodigoFrances.Location = new System.Drawing.Point(161, 372);
            this.lblCodigoFrances.Name = "lblCodigoFrances";
            this.lblCodigoFrances.Size = new System.Drawing.Size(157, 25);
            this.lblCodigoFrances.TabIndex = 56;
            this.lblCodigoFrances.Text = "Código Francés:";
            this.lblCodigoFrances.Visible = false;
            // 
            // txtCodigoIngles
            // 
            this.txtCodigoIngles.Location = new System.Drawing.Point(318, 327);
            this.txtCodigoIngles.Name = "txtCodigoIngles";
            this.txtCodigoIngles.Size = new System.Drawing.Size(133, 30);
            this.txtCodigoIngles.TabIndex = 55;
            this.txtCodigoIngles.Visible = false;
            // 
            // lblCodigoIngles
            // 
            this.lblCodigoIngles.AutoSize = true;
            this.lblCodigoIngles.Location = new System.Drawing.Point(169, 327);
            this.lblCodigoIngles.Name = "lblCodigoIngles";
            this.lblCodigoIngles.Size = new System.Drawing.Size(138, 25);
            this.lblCodigoIngles.TabIndex = 54;
            this.lblCodigoIngles.Text = "Código Inglés:";
            this.lblCodigoIngles.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 53;
            this.label5.Visible = false;
            // 
            // EliminarPalabra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodigoAleman);
            this.Controls.Add(this.lblCodigoAleman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigoFrances);
            this.Controls.Add(this.lblCodigoFrances);
            this.Controls.Add(this.txtCodigoIngles);
            this.Controls.Add(this.lblCodigoIngles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtPalabra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EliminarPalabra";
            this.Text = "EliminarPalabra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigoAleman;
        private System.Windows.Forms.Label lblCodigoAleman;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoFrances;
        private System.Windows.Forms.Label lblCodigoFrances;
        private System.Windows.Forms.TextBox txtCodigoIngles;
        private System.Windows.Forms.Label lblCodigoIngles;
        private System.Windows.Forms.Label label5;
    }
}