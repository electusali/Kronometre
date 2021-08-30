namespace Kronometre
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
			this.components = new System.ComponentModel.Container();
			this.lblSaat = new System.Windows.Forms.Label();
			this.btnBasla = new System.Windows.Forms.Button();
			this.lblDakika = new System.Windows.Forms.Label();
			this.lblSaniye = new System.Windows.Forms.Label();
			this.gbxKronomotre = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btndurdur = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnsifirla = new System.Windows.Forms.Button();
			this.gbxKronomotre.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSaat
			// 
			this.lblSaat.AutoSize = true;
			this.lblSaat.Location = new System.Drawing.Point(33, 97);
			this.lblSaat.Name = "lblSaat";
			this.lblSaat.Size = new System.Drawing.Size(0, 13);
			this.lblSaat.TabIndex = 0;
			// 
			// btnBasla
			// 
			this.btnBasla.Location = new System.Drawing.Point(198, 53);
			this.btnBasla.Name = "btnBasla";
			this.btnBasla.Size = new System.Drawing.Size(114, 40);
			this.btnBasla.TabIndex = 1;
			this.btnBasla.Text = "BAŞLAT";
			this.btnBasla.UseVisualStyleBackColor = true;
			this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
			// 
			// lblDakika
			// 
			this.lblDakika.AutoSize = true;
			this.lblDakika.Location = new System.Drawing.Point(80, 97);
			this.lblDakika.Name = "lblDakika";
			this.lblDakika.Size = new System.Drawing.Size(0, 13);
			this.lblDakika.TabIndex = 2;
			// 
			// lblSaniye
			// 
			this.lblSaniye.AutoSize = true;
			this.lblSaniye.Location = new System.Drawing.Point(140, 97);
			this.lblSaniye.Name = "lblSaniye";
			this.lblSaniye.Size = new System.Drawing.Size(0, 13);
			this.lblSaniye.TabIndex = 3;
			// 
			// gbxKronomotre
			// 
			this.gbxKronomotre.Controls.Add(this.btnsifirla);
			this.gbxKronomotre.Controls.Add(this.label3);
			this.gbxKronomotre.Controls.Add(this.label);
			this.gbxKronomotre.Controls.Add(this.label1);
			this.gbxKronomotre.Controls.Add(this.btndurdur);
			this.gbxKronomotre.Controls.Add(this.lblSaat);
			this.gbxKronomotre.Controls.Add(this.lblSaniye);
			this.gbxKronomotre.Controls.Add(this.btnBasla);
			this.gbxKronomotre.Controls.Add(this.lblDakika);
			this.gbxKronomotre.Location = new System.Drawing.Point(98, 51);
			this.gbxKronomotre.Name = "gbxKronomotre";
			this.gbxKronomotre.Size = new System.Drawing.Size(355, 234);
			this.gbxKronomotre.TabIndex = 4;
			this.gbxKronomotre.TabStop = false;
			this.gbxKronomotre.Text = "KRONOMETRE";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(127, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "SANİYE";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(71, 67);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(46, 13);
			this.label.TabIndex = 6;
			this.label.Text = "DAKİKA";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "SAAT";
			// 
			// btndurdur
			// 
			this.btndurdur.Location = new System.Drawing.Point(198, 113);
			this.btndurdur.Name = "btndurdur";
			this.btndurdur.Size = new System.Drawing.Size(114, 40);
			this.btndurdur.TabIndex = 4;
			this.btndurdur.Text = "DURDUR";
			this.btndurdur.UseVisualStyleBackColor = true;
			this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnsifirla
			// 
			this.btnsifirla.Location = new System.Drawing.Point(198, 171);
			this.btnsifirla.Name = "btnsifirla";
			this.btnsifirla.Size = new System.Drawing.Size(114, 40);
			this.btnsifirla.TabIndex = 8;
			this.btnsifirla.Text = "SIFIRLA";
			this.btnsifirla.UseVisualStyleBackColor = true;
			this.btnsifirla.Click += new System.EventHandler(this.btnsifirla_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 297);
			this.Controls.Add(this.gbxKronomotre);
			this.Name = "Form1";
			this.Text = "Form1";
			this.gbxKronomotre.ResumeLayout(false);
			this.gbxKronomotre.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblSaat;
		private System.Windows.Forms.Button btnBasla;
		private System.Windows.Forms.Label lblDakika;
		private System.Windows.Forms.Label lblSaniye;
		private System.Windows.Forms.GroupBox gbxKronomotre;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btndurdur;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnsifirla;
	}
}

