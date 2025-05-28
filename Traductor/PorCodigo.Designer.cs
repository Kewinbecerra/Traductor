namespace Traductor
{
    partial class PorCodigo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpalabras = new System.Windows.Forms.TextBox();
            this.btconsulta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CBidiomas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Por Codigo";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(154, 189);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(75, 25);
            this.lbCodigo.TabIndex = 1;
            this.lbCodigo.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(263, 184);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(133, 30);
            this.txtcodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Palabras:";
            // 
            // txtpalabras
            // 
            this.txtpalabras.Location = new System.Drawing.Point(159, 283);
            this.txtpalabras.Multiline = true;
            this.txtpalabras.Name = "txtpalabras";
            this.txtpalabras.ReadOnly = true;
            this.txtpalabras.Size = new System.Drawing.Size(347, 269);
            this.txtpalabras.TabIndex = 7;
            // 
            // btconsulta
            // 
            this.btconsulta.Location = new System.Drawing.Point(625, 174);
            this.btconsulta.Name = "btconsulta";
            this.btconsulta.Size = new System.Drawing.Size(125, 54);
            this.btconsulta.TabIndex = 8;
            this.btconsulta.Text = "Consultar";
            this.btconsulta.UseVisualStyleBackColor = true;
            this.btconsulta.Click += new System.EventHandler(this.btconsulta_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 54);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CBidiomas
            // 
            this.CBidiomas.FormattingEnabled = true;
            this.CBidiomas.Items.AddRange(new object[] {
            "Ingles",
            "Español",
            "Frances",
            "Aleman"});
            this.CBidiomas.Location = new System.Drawing.Point(263, 126);
            this.CBidiomas.Name = "CBidiomas";
            this.CBidiomas.Size = new System.Drawing.Size(121, 33);
            this.CBidiomas.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Idioma";
            // 
            // PorCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBidiomas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btconsulta);
            this.Controls.Add(this.txtpalabras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PorCodigo";
            this.Text = "PorCodigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpalabras;
        private System.Windows.Forms.Button btconsulta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CBidiomas;
        private System.Windows.Forms.Label label3;
    }
}