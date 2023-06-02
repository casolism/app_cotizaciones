namespace Cotizaciones
{
	partial class frmSistemaCotizaciones
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistemaCotizaciones));
			menuStrip1 = new MenuStrip();
			proyectosToolStripMenuItem = new ToolStripMenuItem();
			nuevoToolStripMenuItem = new ToolStripMenuItem();
			consultarToolStripMenuItem = new ToolStripMenuItem();
			catálogosToolStripMenuItem = new ToolStripMenuItem();
			clientesToolStripMenuItem = new ToolStripMenuItem();
			proveedoresToolStripMenuItem = new ToolStripMenuItem();
			costosToolStripMenuItem = new ToolStripMenuItem();
			herramientasToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { proyectosToolStripMenuItem, catálogosToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(836, 25);
			menuStrip1.TabIndex = 9;
			menuStrip1.Text = "menuStrip1";
			// 
			// proyectosToolStripMenuItem
			// 
			proyectosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, consultarToolStripMenuItem });
			proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
			proyectosToolStripMenuItem.Size = new Size(77, 21);
			proyectosToolStripMenuItem.Text = "Proyectos";
			// 
			// nuevoToolStripMenuItem
			// 
			nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			nuevoToolStripMenuItem.Size = new Size(131, 22);
			nuevoToolStripMenuItem.Text = "Nuevo";
			nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
			// 
			// consultarToolStripMenuItem
			// 
			consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			consultarToolStripMenuItem.Size = new Size(131, 22);
			consultarToolStripMenuItem.Text = "Consultar";
			// 
			// catálogosToolStripMenuItem
			// 
			catálogosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, proveedoresToolStripMenuItem, costosToolStripMenuItem, herramientasToolStripMenuItem });
			catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
			catálogosToolStripMenuItem.Size = new Size(79, 21);
			catálogosToolStripMenuItem.Text = "Catálogos";
			// 
			// clientesToolStripMenuItem
			// 
			clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			clientesToolStripMenuItem.Size = new Size(154, 22);
			clientesToolStripMenuItem.Text = "Clientes";
			// 
			// proveedoresToolStripMenuItem
			// 
			proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
			proveedoresToolStripMenuItem.Size = new Size(154, 22);
			proveedoresToolStripMenuItem.Text = "Proveedores";
			// 
			// costosToolStripMenuItem
			// 
			costosToolStripMenuItem.Name = "costosToolStripMenuItem";
			costosToolStripMenuItem.Size = new Size(154, 22);
			costosToolStripMenuItem.Text = "Costos";
			// 
			// herramientasToolStripMenuItem
			// 
			herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			herramientasToolStripMenuItem.Size = new Size(154, 22);
			herramientasToolStripMenuItem.Text = "Herramientas";
			// 
			// frmSistemaCotizaciones
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(836, 496);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Margin = new Padding(3, 2, 3, 2);
			Name = "frmSistemaCotizaciones";
			Text = "Sistema de cotizaciones";
			WindowState = FormWindowState.Maximized;
			Load += frmSistemaCotizaciones_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem proyectosToolStripMenuItem;
		private ToolStripMenuItem nuevoToolStripMenuItem;
		private ToolStripMenuItem consultarToolStripMenuItem;
		private ToolStripMenuItem catálogosToolStripMenuItem;
		private ToolStripMenuItem clientesToolStripMenuItem;
		private ToolStripMenuItem proveedoresToolStripMenuItem;
		private ToolStripMenuItem costosToolStripMenuItem;
		private ToolStripMenuItem herramientasToolStripMenuItem;
	}
}