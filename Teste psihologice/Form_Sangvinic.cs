﻿/*
 * Date: 30.12.2016
 * Time: 19:45
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of Form_Sangvinic.
	/// </summary>
	public partial class Form_Sangvinic : Form
	{
		public Form_Sangvinic()
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
			MainForm mainForm= new MainForm();
			mainForm.Show();
			this.Hide();	
			this.Close();			
		}
	}
}
