namespace Cotizaciones
{
    partial class frmConsultaProyectos
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
            gridProyectos = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridProyectos).BeginInit();
            SuspendLayout();
            // 
            // gridProyectos
            // 
            gridProyectos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProyectos.Location = new Point(45, 60);
            gridProyectos.Name = "gridProyectos";
            gridProyectos.RowTemplate.Height = 25;
            gridProyectos.Size = new Size(716, 358);
            gridProyectos.TabIndex = 0;
            gridProyectos.CellDoubleClick += gridProyectos_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 16);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresa el nombre del proyecto a buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(686, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmConsultaProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(gridProyectos);
            Name = "frmConsultaProyectos";
            Text = "Consulta de proyectos";
            ((System.ComponentModel.ISupportInitialize)gridProyectos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridProyectos;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}