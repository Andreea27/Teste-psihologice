﻿/*
 * Date: 04.01.2017
 * Time: 20:04
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of Interpersonala.
	/// </summary>
	public partial class Interpersonala : Form
	{
		public Interpersonala()
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
