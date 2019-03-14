/*
 * Date: 09.02.2017
 * Time: 17:31
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of Introvertit_Extrovertit.
	/// </summary>
	public partial class Introvertit_Extrovertit : Form
	{
		public Introvertit_Extrovertit()
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
			int scor=0;

			if (checkBox1.Checked) scor++;
			checkBox1.Checked = false;
			
			if (checkBox2.Checked) scor++;
			checkBox2.Checked = false;
			
			if (checkBox3.Checked) scor++;
			checkBox3.Checked = false;
			
			if (checkBox4.Checked) scor++;
			checkBox4.Checked = false;
			
			if (checkBox5.Checked) scor++;
			checkBox5.Checked = false;
			
			if (checkBox6.Checked) scor++;
			checkBox6.Checked = false;
			
			if (checkBox7.Checked) scor++;
			checkBox7.Checked = false;
			
			if (checkBox8.Checked) scor++;
			checkBox8.Checked = false;
			
			if (checkBox9.Checked) scor++;
			checkBox9.Checked = false;
			
			if (checkBox10.Checked) scor++;
			checkBox10.Checked = false;
			
			if (checkBox11.Checked) scor++;
			checkBox11.Checked = false;
			
			if (checkBox12.Checked) scor++;
			checkBox12.Checked = false;
			
			
			if (scor>=12-scor) {Introvertit intr=new Introvertit(); intr.Show();	}
			else {Extrovertit extr=new Extrovertit(); extr.Show();		}
			this.Hide();
			this.Close();
		}
		
	}
}
