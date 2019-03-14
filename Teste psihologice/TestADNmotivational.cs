/*
 * Date: 27.12.2016
 * Time: 20:12
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
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
			int A=0,B=0,C=0,D=0,E=0,F=0;
			
			if (checkBox1.Checked) C++;
			checkBox1.Checked = false;
			
			if (checkBox2.Checked) A++;
			checkBox2.Checked = false;
			
			if (checkBox3.Checked) F++;
			checkBox3.Checked = false;
			
			if (checkBox4.Checked) D++;
			checkBox4.Checked = false;
			
			if (checkBox5.Checked) E++;
			checkBox5.Checked = false;
			
			if (checkBox6.Checked) B++;
			checkBox6.Checked = false;
			
			if (checkBox7.Checked) C++;
			checkBox7.Checked = false;
			
			if (checkBox8.Checked) A++;
			checkBox8.Checked = false;
			
			if (checkBox9.Checked) F++;
			checkBox9.Checked = false;
			
			if (checkBox10.Checked) D++;
			checkBox10.Checked = false;
			
			if (checkBox11.Checked) E++;
			checkBox11.Checked = false;
			
			if (checkBox12.Checked) B++;
			checkBox12.Checked = false;
			
			if (checkBox13.Checked) D++;
			checkBox13.Checked = false;
			
			if (checkBox14.Checked) F++;
			checkBox14.Checked = false;
			
			if (checkBox15.Checked) A++;
			checkBox15.Checked = false;
			
			if (checkBox16.Checked) C++;
			checkBox16.Checked = false;
			
			if (checkBox17.Checked) E++;
			checkBox17.Checked = false;
			
			if (checkBox18.Checked) B++;
			checkBox18.Checked = false;
			
			if (checkBox19.Checked) C++;
			checkBox19.Checked = false;
			
			if (checkBox20.Checked) A++;
			checkBox20.Checked = false;
			
			if (checkBox21.Checked) E++;
			checkBox21.Checked = false;
			
			if (checkBox22.Checked) B++;
			checkBox22.Checked = false;
			
			if (checkBox23.Checked) D++;
			checkBox23.Checked = false;
			
			if (checkBox24.Checked) F++;
			checkBox24.Checked = false;
			
			if (checkBox25.Checked) A++;
			checkBox25.Checked = false;
			
			if (checkBox26.Checked) C++;
			checkBox26.Checked = false;
			
			if (checkBox27.Checked) F++;
			checkBox27.Checked = false;
			
			if (checkBox28.Checked) D++;
			checkBox28.Checked = false;
			
			if (checkBox29.Checked) B++;
			checkBox29.Checked = false;
			
			if (checkBox30.Checked) E++;
			checkBox30.Checked = false;
			
			if (checkBox31.Checked) C++;
			checkBox31.Checked = false;
			
			if (checkBox32.Checked) A++;
			checkBox32.Checked = false;
			
			if (checkBox33.Checked) D++;
			checkBox33.Checked = false;
			
			if (checkBox34.Checked) F++;
			checkBox34.Checked = false;
			
			if (checkBox35.Checked) E++;
			checkBox35.Checked = false;
			
			if (checkBox36.Checked) B++;
			checkBox36.Checked = false;
			
			if (checkBox37.Checked) A++;
			checkBox37.Checked = false;
			
			if (checkBox38.Checked) C++;
			checkBox38.Checked = false;
			
			if (checkBox39.Checked) B++;
			checkBox39.Checked = false;
			
			if (checkBox40.Checked) E++;
			checkBox40.Checked = false;
			
			if (checkBox41.Checked) F++;
			checkBox41.Checked = false;
			
			if (checkBox42.Checked) D++;
			checkBox42.Checked = false;
			
			bool Producator=false,Conector=false,Stabilizator=false,Variabil=false,Intern=false,Extern=false;
			if (A>C) Producator=true;else Conector=true;
			if (D>F) Stabilizator=true;else Variabil=true;
			if (B>E) Intern=true; else Extern=true;
			
			if (Producator==true && Stabilizator==true && Intern==true) {PSI psi=new PSI(); psi.Show();}
			if (Producator==true && Variabil==true && Intern==true) {PVI pvi=new PVI(); pvi.Show();}
			if (Producator==true && Stabilizator==true && Extern==true) {PSE pse=new PSE(); pse.Show();}
			if (Producator==true && Variabil==true && Extern==true) {PVE pve=new PVE(); pve.Show();}
			if (Conector==true && Stabilizator==true && Intern==true) {CSI csi=new CSI(); csi.Show();}
			if (Conector==true && Variabil==true && Intern==true) {CVI cvi=new CVI(); cvi.Show();}
			if (Conector==true && Stabilizator==true && Extern==true) {CSE cse=new CSE(); cse.Show();}
			if (Conector==true && Variabil==true && Extern==true) {CVE cve=new CVE(); cve.Show();}
			this.Hide();
			this.Close();
			
		}
		
	}
}
