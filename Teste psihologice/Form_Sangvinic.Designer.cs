/*
 * Date: 30.12.2016
 * Time: 19:45
 */
namespace Teste_psihologice
{
	partial class Form_Sangvinic
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sangvinic));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(134, 950);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Gabriola", 72F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Turquoise;
			this.label1.Location = new System.Drawing.Point(182, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(472, 144);
			this.label1.TabIndex = 5;
			this.label1.Text = "Sangvinicul";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label5.Location = new System.Drawing.Point(201, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1037, 183);
			this.label5.TabIndex = 9;
			this.label5.Text = resources.GetString("label5.Text");
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(201, 410);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1037, 164);
			this.label2.TabIndex = 10;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
			this.label3.Location = new System.Drawing.Point(201, 607);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(1037, 251);
			this.label3.TabIndex = 11;
			this.label3.Text = resources.GetString("label3.Text");
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label4.Location = new System.Drawing.Point(201, 188);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(354, 43);
			this.label4.TabIndex = 12;
			this.label4.Text = "Personalitatea sangvinică";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label6.Location = new System.Drawing.Point(212, 404);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(470, 41);
			this.label6.TabIndex = 13;
			this.label6.Text = "Tipul de personalitate sangvinică";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Palatino Linotype", 20.5F);
			this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.button1.Location = new System.Drawing.Point(484, 863);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(599, 74);
			this.button1.TabIndex = 31;
			this.button1.TabStop = false;
			this.button1.Text = "Înapoi la pagina principală";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form_Sangvinic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoScrollMargin = new System.Drawing.Size(0, 13);
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(1362, 750);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_Sangvinic";
			this.Text = "Sangvinic";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
