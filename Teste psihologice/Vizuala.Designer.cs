﻿/*
 * Date: 04.01.2017
 * Time: 20:04
 */
namespace Teste_psihologice
{
	partial class Vizuala
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vizuala));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
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
			this.pictureBox1.Size = new System.Drawing.Size(171, 726);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Gabriola", 72F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Turquoise;
			this.label1.Location = new System.Drawing.Point(308, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(845, 148);
			this.label1.TabIndex = 18;
			this.label1.Text = "Inteligența spațială";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Palatino Linotype", 20.5F);
			this.button1.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.button1.Location = new System.Drawing.Point(474, 645);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(599, 74);
			this.button1.TabIndex = 37;
			this.button1.TabStop = false;
			this.button1.Text = "Înapoi la pagina principală";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
			this.label17.Location = new System.Drawing.Point(330, 506);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(958, 122);
			this.label17.TabIndex = 36;
			this.label17.Text = "Domeniile de performanță pentru persoanele care au inteligență spațială sunt : pr" +
			"oiectarea, arhitectura, artele plastice etc.";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label10.Location = new System.Drawing.Point(330, 227);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(291, 44);
			this.label10.TabIndex = 34;
			this.label10.Text = "Inteligența spațială:";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label11.Location = new System.Drawing.Point(330, 233);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(947, 240);
			this.label11.TabIndex = 35;
			this.label11.Text = resources.GetString("label11.Text");
			// 
			// Vizuala
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoScrollMargin = new System.Drawing.Size(0, 13);
			this.BackColor = System.Drawing.Color.MintCream;
			this.ClientSize = new System.Drawing.Size(1362, 750);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Vizuala";
			this.Text = "Inteligența spațială";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
