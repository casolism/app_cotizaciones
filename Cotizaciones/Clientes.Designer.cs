namespace Cotizaciones
{
	partial class Clientes
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
			dataGridView1 = new DataGridView();
			menuStrip1 = new MenuStrip();
			opcionesToolStripMenuItem = new ToolStripMenuItem();
			alToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(65, 47);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(672, 383);
			dataGridView1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 25);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// opcionesToolStripMenuItem
			// 
			opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alToolStripMenuItem });
			opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
			opcionesToolStripMenuItem.Size = new Size(75, 21);
			opcionesToolStripMenuItem.Text = "Opciones";
			// 
			// alToolStripMenuItem
			// 
			alToolStripMenuItem.Name = "alToolStripMenuItem";
			alToolStripMenuItem.Size = new Size(180, 22);
			alToolStripMenuItem.Text = "Nuevo";
			// 
			// Clientes
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 510);
			Controls.Add(dataGridView1);
			Controls.Add(menuStrip1);
			Name = "Clientes";
			Text = "Listado de Clientes";
			Load += Clientes_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem opcionesToolStripMenuItem;
		private ToolStripMenuItem alToolStripMenuItem;
	}
}