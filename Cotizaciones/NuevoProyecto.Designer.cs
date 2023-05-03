namespace Cotizaciones
{
    partial class NuevoProyecto
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnGuardarProyecto = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 34);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del proyecto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 65);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 65);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 73);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnGuardarProyecto
            // 
            btnGuardarProyecto.Location = new Point(293, 211);
            btnGuardarProyecto.Name = "btnGuardarProyecto";
            btnGuardarProyecto.Size = new Size(125, 35);
            btnGuardarProyecto.TabIndex = 4;
            btnGuardarProyecto.Text = "Guardar proyecto";
            btnGuardarProyecto.UseVisualStyleBackColor = true;
            btnGuardarProyecto.Click += btnGuardarProyecto_Click;
            // 
            // NuevoProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarProyecto);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NuevoProyecto";
            Text = "Nuevo Proyecto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnGuardarProyecto;
    }
}