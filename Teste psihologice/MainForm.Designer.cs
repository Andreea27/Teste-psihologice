/*
 * Date: 27.12.2016
 * Time: 20:11
 */
namespace Teste_psihologice
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.button1.Location = new System.Drawing.Point(168, 190);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(352, 81);
			this.button1.TabIndex = 0;
			this.button1.TabStop = false;
			this.button1.Text = "Testul ADN-ului motivațional";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.button2.Location = new System.Drawing.Point(168, 297);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(352, 81);
			this.button2.TabIndex = 2;
			this.button2.TabStop = false;
			this.button2.Text = "Testul de personalitate";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.button3.Location = new System.Drawing.Point(168, 402);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(352, 81);
			this.button3.TabIndex = 3;
			this.button3.TabStop = false;
			this.button3.Text = "Testul inteligențelor multiple";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.button4.Location = new System.Drawing.Point(168, 511);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(352, 81);
			this.button4.TabIndex = 4;
			this.button4.TabStop = false;
			this.button4.Text = "Te consideri o persoană realizată?";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(214)))), ((int)(((byte)(92)))));
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.button5.Location = new System.Drawing.Point(168, 623);
			this.button5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(352, 81);
			this.button5.TabIndex = 5;
			this.button5.TabStop = false;
			this.button5.Text = "Introvertit sau extravertit?";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(2, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(333, 23);
			this.label2.TabIndex = 27;
			this.label2.Text = "Proiect realizat de: Ghiurcuța Andreea-Roxana";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Gabriola", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(65, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(576, 156);
			this.label1.TabIndex = 1;
			this.label1.Text = "Teste psihologice\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(244)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1362, 742);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(80)))), ((int)(((byte)(99)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Teste psihologice";
			this.TransparencyKey = System.Drawing.Color.White;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		
		void Button6Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
