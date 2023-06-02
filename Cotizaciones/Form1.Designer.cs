namespace Cotizaciones
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			textBox1 = new TextBox();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 21);
			label1.Name = "label1";
			label1.Size = new Size(133, 17);
			label1.TabIndex = 0;
			label1.Text = "Proyecto a Consultar ";
			label1.UseWaitCursor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(161, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(287, 25);
			textBox1.TabIndex = 1;
			textBox1.UseWaitCursor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(39, 62);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 27;
			dataGridView1.Size = new Size(578, 225);
			dataGridView1.TabIndex = 2;
			dataGridView1.UseWaitCursor = true;
			// 
			// button1
			// 
			button1.Location = new Point(649, 62);
			button1.Name = "button1";
			button1.Size = new Size(93, 28);
			button1.TabIndex = 3;
			button1.Text = resources.GetString("button1.Text");
			button1.UseVisualStyleBackColor = true;
			button1.UseWaitCursor = true;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "consulta";
			UseWaitCursor = true;
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private DataGridView dataGridView1;
		private Button button1;
	}
}