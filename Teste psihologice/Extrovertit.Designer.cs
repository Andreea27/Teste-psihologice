/*
 * Date: 09.02.2017
 * Time: 18:09
 */
namespace Teste_psihologice
{
	partial class Extrovertit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extrovertit));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Gabriola", 72F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Turquoise;
			this.label1.Location = new System.Drawing.Point(248, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1028, 144);
			this.label1.TabIndex = 19;
			this.label1.Text = "Ești predominant extrovertit";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(193, 841);
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(248, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1040, 167);
			this.label2.TabIndex = 21;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Arial", 18F);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
			this.label7.Location = new System.Drawing.Point(260, 482);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(1040, 209);
			this.label7.TabIndex = 33;
			this.label7.Text = resources.GetString("label7.Text");
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe Print", 25F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label6.Location = new System.Drawing.Point(248, 422);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(1055, 60);
			this.label6.TabIndex = 32;
			this.label6.Text = "Extravertitul – ce se află dincolo de suprafață?";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Palatino Linotype", 20.5F);
			this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.button1.Location = new System.Drawing.Point(438, 743);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(599, 74);
			this.button1.TabIndex = 35;
			this.button1.TabStop = false;
			this.button1.Text = "Înapoi la pagina principală";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Extrovertit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(1362, 750);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Extrovertit";
			this.Text = "Extravertit";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
