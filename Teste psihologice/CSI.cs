﻿/*
 * Date: 27.12.2016
 * Time: 21:42
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of CSI.
	/// </summary>
	public partial class CSI : Form
	{
		public CSI()
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
