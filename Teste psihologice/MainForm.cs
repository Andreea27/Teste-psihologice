/*
 * Date: 27.12.2016
 * Time: 20:11
 */
using System;
using System.Windows;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form1 TADNMform=new Form1();
			TADNMform.Show();
			this.Hide();
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Test_Personalitate TesteP= new Test_Personalitate();
			TesteP.Show();
			this.Hide();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			TesteIntelig TesteI= new TesteIntelig();
			TesteI.Show();
			this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			PR_test prtest=new PR_test();
			prtest.Show();
			this.Hide();			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Introvertit_Extrovertit I_E=new Introvertit_Extrovertit();
			I_E.Show();
			this.Hide();
		}
	}
}
