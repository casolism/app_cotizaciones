namespace Cotizaciones
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Busqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Empresa = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Busqueda
            // 
            this.Busqueda.FormattingEnabled = true;
            this.Busqueda.Location = new System.Drawing.Point(123, 26);
            this.Busqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(288, 23);
            this.Busqueda.TabIndex = 0;
            this.Busqueda.SelectedIndexChanged += new System.EventHandler(this.Busqueda_SelectedIndexChanged);
            this.Busqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Busqueda_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.Location = new System.Drawing.Point(416, 25);
            this.BuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Size = new System.Drawing.Size(26, 22);
            this.BuscarCliente.TabIndex = 2;
            this.BuscarCliente.Text = "...";
            this.BuscarCliente.UseVisualStyleBackColor = true;
            this.BuscarCliente.Click += new System.EventHandler(this.BuscarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Correo";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(124, 64);
            this.Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(287, 23);
            this.Nombre.TabIndex = 6;
            // 
            // Empresa
            // 
            this.Empresa.Location = new System.Drawing.Point(126, 94);
            this.Empresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empresa.Name = "Empresa";
            this.Empresa.Size = new System.Drawing.Size(285, 23);
            this.Empresa.TabIndex = 7;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(127, 124);
            this.Correo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(284, 23);
            this.Correo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 438);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Empresa);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Busqueda);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sistema de cotizaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Busqueda;
        private Label label1;
        private Button BuscarCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Nombre;
        private TextBox Empresa;
        private TextBox Correo;
    }
}