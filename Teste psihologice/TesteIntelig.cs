/*
 * Date: 04.01.2017
 * Time: 18:10
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of TesteIntelig.
	/// </summary>
	public partial class TesteIntelig : Form
	{
		public TesteIntelig()
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
			int L=0,LM=0,M=0,BK=0,SV=0,Ie=0,Ia=0,n=0;
			n=Convert.ToInt32(textBox3.Text);L+=n;
			n=Convert.ToInt32(textBox6.Text);L+=n;
			n=Convert.ToInt32(textBox10.Text);L+=n;
			n=Convert.ToInt32(textBox14.Text);L+=n;
			n=Convert.ToInt32(textBox30.Text);L+=n;
			
			n=Convert.ToInt32(textBox13.Text);LM+=n;
			n=Convert.ToInt32(textBox15.Text);LM+=n;
			n=Convert.ToInt32(textBox18.Text);LM+=n;
			n=Convert.ToInt32(textBox23.Text);LM+=n;
			n=Convert.ToInt32(textBox26.Text);LM+=n;
			
			n=Convert.ToInt32(textBox1.Text);M+=n;
			n=Convert.ToInt32(textBox2.Text);M+=n;
			n=Convert.ToInt32(textBox5.Text);M+=n;
			n=Convert.ToInt32(textBox24.Text);M+=n;
			n=Convert.ToInt32(textBox33.Text);M+=n;
			
			n=Convert.ToInt32(textBox4.Text);BK+=n;
			n=Convert.ToInt32(textBox7.Text);BK+=n;
			n=Convert.ToInt32(textBox16.Text);BK+=n;
			n=Convert.ToInt32(textBox21.Text);BK+=n;
			n=Convert.ToInt32(textBox25.Text);BK+=n;
			
			n=Convert.ToInt32(textBox9.Text);SV+=n;
			n=Convert.ToInt32(textBox11.Text);SV+=n;
			n=Convert.ToInt32(textBox12.Text);SV+=n;
			n=Convert.ToInt32(textBox22.Text);SV+=n;
			n=Convert.ToInt32(textBox29.Text);SV+=n;
			
			n=Convert.ToInt32(textBox8.Text);Ie+=n;
			n=Convert.ToInt32(textBox20.Text);Ie+=n;
			n=Convert.ToInt32(textBox31.Text);Ie+=n;
			n=Convert.ToInt32(textBox32.Text);Ie+=n;
			n=Convert.ToInt32(textBox35.Text);Ie+=n;
			
			n=Convert.ToInt32(textBox17.Text);Ia+=n;
			n=Convert.ToInt32(textBox19.Text);Ia+=n;
			n=Convert.ToInt32(textBox27.Text);Ia+=n;
			n=Convert.ToInt32(textBox28.Text);Ia+=n;
			n=Convert.ToInt32(textBox34.Text);Ia+=n;
			
			if (L>=LM && L>=M && L>=BK && L>=SV && L>=Ie && L>=Ia) {Lingvistica LINGV=new Lingvistica();LINGV.Show();}
			if (LM>=L && LM>=M && LM>=BK && LM>=SV && LM>=Ie && LM>=Ia) {LogicaM LOGM=new LogicaM();LOGM.Show();}
			if (M>=LM && L<=M && M>=BK && M>=SV && M>=Ie && M>=Ia) {Muzicala MUZ=new Muzicala(); MUZ.Show();}
			if (BK>=LM && BK>=M && L<=BK && BK>=SV && BK>=Ie && BK>=Ia){Chinestezica CHINES=new Chinestezica(); CHINES.Show();}
			if (SV>=LM && SV>=M && SV>=BK && L<=SV && SV>=Ie && SV>=Ia){Vizuala VIZ=new Vizuala(); VIZ.Show();}
			if (Ie>=LM && Ie>=M && Ie>=BK && Ie>=SV && SV<=Ie && Ie>=Ia){Interpersonala INTE= new Interpersonala();INTE.Show();}
			if (Ia>=LM && Ia>=M && Ia>=BK && Ia>=SV && SV<=Ia && Ie<=Ia){Intrapersonala INTA= new Intrapersonala();INTA.Show();}
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			textBox9.Clear();
			textBox10.Clear();
			textBox11.Clear();
			textBox12.Clear();
			textBox13.Clear();
			textBox14.Clear();
			textBox15.Clear();
			textBox16.Clear();
			textBox17.Clear();
			textBox18.Clear();
			textBox19.Clear();
			textBox20.Clear();
			textBox21.Clear();
			textBox22.Clear();
			textBox23.Clear();
			textBox24.Clear();
			textBox25.Clear();
			textBox26.Clear();
			textBox27.Clear();
			textBox28.Clear();
			textBox29.Clear();
			textBox30.Clear();
			textBox31.Clear();
			textBox32.Clear();
			textBox33.Clear();
			textBox34.Clear();
			textBox35.Clear();
			
			this.Hide();
			this.Close();
		}
	}
}
