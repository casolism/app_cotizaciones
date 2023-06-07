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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoProyecto));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtmargen = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            txtDias = new TextBox();
            label17 = new Label();
            txtTotal = new TextBox();
            label16 = new Label();
            txtSubTotal = new TextBox();
            label15 = new Label();
            txtTotalViaticos = new TextBox();
            label14 = new Label();
            txtTotalManoObra = new TextBox();
            label12 = new Label();
            txtCostoMateriales = new TextBox();
            label13 = new Label();
            cmdAgregar = new Button();
            label11 = new Label();
            txtCodigoProducto = new TextBox();
            label10 = new Label();
            label9 = new Label();
            cmbTipoConcepto = new ComboBox();
            txtCostoUnitario = new TextBox();
            label8 = new Label();
            txtConcepto = new TextBox();
            label7 = new Label();
            txtCantidad = new TextBox();
            label6 = new Label();
            gridConceptos = new DataGridView();
            tabPage4 = new TabPage();
            cmdVistaPrevia = new Button();
            groupBox1 = new GroupBox();
            txtCondiciones = new TextBox();
            tabPage5 = new TabPage();
            cmdGuardar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridConceptos).BeginInit();
            tabPage4.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1068, 720);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtmargen);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1060, 692);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos generales";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtmargen
            // 
            txtmargen.Location = new Point(190, 287);
            txtmargen.Name = "txtmargen";
            txtmargen.Size = new Size(145, 23);
            txtmargen.TabIndex = 15;
            txtmargen.TextChanged += txtmargen_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 295);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 14;
            label5.Text = "Margen de utilidad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(190, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(361, 23);
            comboBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 237);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 12;
            label4.Text = "Cliente";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(190, 177);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(361, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 183);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "Fecha";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 82);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(361, 73);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 23);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 82);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 51);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre del proyecto";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtDias);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(txtTotal);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(txtSubTotal);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(txtTotalViaticos);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(txtTotalManoObra);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(txtCostoMateriales);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(cmdAgregar);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(txtCodigoProducto);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(cmbTipoConcepto);
            tabPage3.Controls.Add(txtCostoUnitario);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(txtConcepto);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txtCantidad);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(gridConceptos);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1060, 692);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Conceptos a cotizar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(876, 20);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(100, 23);
            txtDias.TabIndex = 24;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(826, 28);
            label17.Name = "label17";
            label17.Size = new Size(29, 15);
            label17.TabIndex = 23;
            label17.Text = "Días";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location = new Point(379, 654);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 25);
            txtTotal.TabIndex = 22;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(256, 658);
            label16.Name = "label16";
            label16.Size = new Size(42, 19);
            label16.TabIndex = 21;
            label16.Text = "Total";
            label16.Click += label16_Click;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubTotal.Location = new Point(136, 654);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(100, 25);
            txtSubTotal.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(35, 658);
            label15.Name = "label15";
            label15.Size = new Size(65, 19);
            label15.TabIndex = 19;
            label15.Text = "Subtotal";
            // 
            // txtTotalViaticos
            // 
            txtTotalViaticos.Location = new Point(621, 610);
            txtTotalViaticos.Name = "txtTotalViaticos";
            txtTotalViaticos.Size = new Size(100, 23);
            txtTotalViaticos.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(520, 618);
            label14.Name = "label14";
            label14.Size = new Size(82, 15);
            label14.TabIndex = 17;
            label14.Text = "Costo Viáticos";
            // 
            // txtTotalManoObra
            // 
            txtTotalManoObra.Location = new Point(379, 610);
            txtTotalManoObra.Name = "txtTotalManoObra";
            txtTotalManoObra.Size = new Size(101, 23);
            txtTotalManoObra.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(256, 618);
            label12.Name = "label12";
            label12.Size = new Size(117, 15);
            label12.TabIndex = 15;
            label12.Text = "Costo Mano de Obra";
            // 
            // txtCostoMateriales
            // 
            txtCostoMateriales.Location = new Point(136, 610);
            txtCostoMateriales.Name = "txtCostoMateriales";
            txtCostoMateriales.Size = new Size(100, 23);
            txtCostoMateriales.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(35, 618);
            label13.Name = "label13";
            label13.Size = new Size(95, 15);
            label13.TabIndex = 13;
            label13.Text = "Costo Materiales";
            // 
            // cmdAgregar
            // 
            cmdAgregar.BackColor = Color.Gainsboro;
            cmdAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cmdAgregar.ForeColor = SystemColors.Highlight;
            cmdAgregar.Location = new Point(872, 133);
            cmdAgregar.Name = "cmdAgregar";
            cmdAgregar.Size = new Size(104, 38);
            cmdAgregar.TabIndex = 12;
            cmdAgregar.Text = "Agregar";
            cmdAgregar.UseVisualStyleBackColor = false;
            cmdAgregar.Click += cmdAgregar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(396, 169);
            label11.Name = "label11";
            label11.Size = new Size(231, 15);
            label11.TabIndex = 11;
            label11.Text = "C O N C E P T O S   D E   C O T I Z A C I Ó N";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(573, 57);
            txtCodigoProducto.Multiline = true;
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(403, 70);
            txtCodigoProducto.TabIndex = 10;
            // 
            // label10
            // 
            label10.Location = new Point(501, 65);
            label10.Name = "label10";
            label10.Size = new Size(66, 62);
            label10.TabIndex = 9;
            label10.Text = "Código del producto";
            // 
            // label9
            // 
            label9.Location = new Point(501, 23);
            label9.Name = "label9";
            label9.Size = new Size(66, 42);
            label9.TabIndex = 8;
            label9.Text = "Tipo Concepto";
            // 
            // cmbTipoConcepto
            // 
            cmbTipoConcepto.FormattingEnabled = true;
            cmbTipoConcepto.Items.AddRange(new object[] { "Materiales", "Mano de Obra", "Viáticos" });
            cmbTipoConcepto.Location = new Point(573, 20);
            cmbTipoConcepto.Name = "cmbTipoConcepto";
            cmbTipoConcepto.Size = new Size(148, 23);
            cmbTipoConcepto.TabIndex = 7;
            cmbTipoConcepto.SelectedIndexChanged += cmbTipoConcepto_SelectedIndexChanged;
            // 
            // txtCostoUnitario
            // 
            txtCostoUnitario.Location = new Point(329, 20);
            txtCostoUnitario.Name = "txtCostoUnitario";
            txtCostoUnitario.Size = new Size(151, 23);
            txtCostoUnitario.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(232, 28);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 5;
            label8.Text = "Costo unitario";
            // 
            // txtConcepto
            // 
            txtConcepto.Location = new Point(107, 57);
            txtConcepto.Multiline = true;
            txtConcepto.Name = "txtConcepto";
            txtConcepto.Size = new Size(373, 70);
            txtConcepto.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 65);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 3;
            label7.Text = "Concepto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(107, 20);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 28);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 1;
            label6.Text = "Cantidad";
            // 
            // gridConceptos
            // 
            gridConceptos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridConceptos.Location = new Point(33, 187);
            gridConceptos.Name = "gridConceptos";
            gridConceptos.RowTemplate.Height = 25;
            gridConceptos.Size = new Size(943, 403);
            gridConceptos.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cmdVistaPrevia);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1060, 692);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Vista previa";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmdVistaPrevia
            // 
            cmdVistaPrevia.Location = new Point(322, 428);
            cmdVistaPrevia.Name = "cmdVistaPrevia";
            cmdVistaPrevia.Size = new Size(148, 36);
            cmdVistaPrevia.TabIndex = 2;
            cmdVistaPrevia.Text = "Vista previa";
            cmdVistaPrevia.UseVisualStyleBackColor = true;
            cmdVistaPrevia.Click += cmdVistaPrevia_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCondiciones);
            groupBox1.Location = new Point(26, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(740, 323);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Términos y condiciones";
            // 
            // txtCondiciones
            // 
            txtCondiciones.Location = new Point(40, 44);
            txtCondiciones.Multiline = true;
            txtCondiciones.Name = "txtCondiciones";
            txtCondiciones.ScrollBars = ScrollBars.Both;
            txtCondiciones.Size = new Size(645, 211);
            txtCondiciones.TabIndex = 0;
            txtCondiciones.Text = resources.GetString("txtCondiciones.Text");
            txtCondiciones.UseWaitCursor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(cmdGuardar);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1060, 692);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Guardar y Enviar";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(471, 545);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(153, 40);
            cmdGuardar.TabIndex = 0;
            cmdGuardar.Text = "Guardar Proyecto";
            cmdGuardar.UseVisualStyleBackColor = true;
            cmdGuardar.Click += cmdGuardar_Click;
            // 
            // NuevoProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 719);
            Controls.Add(tabControl1);
            Name = "NuevoProyecto";
            Text = "Nuevo Proyecto";
            Load += NuevoProyecto_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridConceptos).EndInit();
            tabPage4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtmargen;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private DataGridView gridConceptos;
        private TextBox txtCodigoProducto;
        private Label label10;
        private Label label9;
        private ComboBox cmbTipoConcepto;
        private TextBox txtCostoUnitario;
        private Label label8;
        private TextBox txtConcepto;
        private Label label7;
        private TextBox txtCantidad;
        private Label label6;
        private TextBox txtTotal;
        private Label label16;
        private TextBox txtSubTotal;
        private Label label15;
        private TextBox txtTotalViaticos;
        private Label label14;
        private TextBox txtTotalManoObra;
        private Label label12;
        private TextBox txtCostoMateriales;
        private Label label13;
        private Button cmdAgregar;
        private Label label11;
        private TextBox txtDias;
        private Label label17;
        private Button cmdGuardar;
        private Button cmdVistaPrevia;
        private GroupBox groupBox1;
        private TextBox txtCondiciones;
    }
}