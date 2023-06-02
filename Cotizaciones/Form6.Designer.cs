namespace Cotizaciones
{
	partial class Form6
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			linkLabel1 = new LinkLabel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(51, 49);
			label1.Name = "label1";
			label1.Size = new Size(53, 17);
			label1.TabIndex = 0;
			label1.Text = "Usuario";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(52, 114);
			label2.Name = "label2";
			label2.Size = new Size(74, 17);
			label2.TabIndex = 1;
			label2.Text = "Contraseña";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(52, 185);
			label3.Name = "label3";
			label3.Size = new Size(74, 17);
			label3.TabIndex = 2;
			label3.Text = "Registrarse";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(188, 41);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(229, 25);
			textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(188, 106);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(229, 25);
			textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(188, 177);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(229, 25);
			textBox3.TabIndex = 5;
			// 
			// button1
			// 
			button1.Location = new Point(499, 146);
			button1.Name = "button1";
			button1.Size = new Size(128, 42);
			button1.TabIndex = 6;
			button1.Text = "Iniciar Sesión";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(499, 49);
			button2.Name = "button2";
			button2.Size = new Size(128, 42);
			button2.TabIndex = 7;
			button2.Text = "Registrarse";
			button2.UseVisualStyleBackColor = true;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(494, 238);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(133, 17);
			linkLabel1.TabIndex = 8;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Olvide mi Contraseña";
			// 
			// Form6
			// 
			AutoScaleDimensions = new SizeF(7F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 452);
			Controls.Add(linkLabel1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form6";
			Text = "Inicio de sesión";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button1;
		private Button button2;
		private LinkLabel linkLabel1;
	}
}