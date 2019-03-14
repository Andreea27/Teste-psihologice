/*
 * Date: 08.02.2017
 * Time: 18:04
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of PR_test.
	/// </summary>
	public partial class PR_test : Form
	{
		public PR_test()
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
			
			if (checkBox1.Checked) scor+=0;
			checkBox1.Checked = false;
			if (checkBox2.Checked) scor++;
			checkBox2.Checked = false;	

			if (checkBox3.Checked) scor++;
			checkBox3.Checked = false;
			if (checkBox4.Checked) scor+=0;
			checkBox4.Checked = false;	

			if (checkBox5.Checked) scor++;
			checkBox5.Checked = false;
			if (checkBox6.Checked) scor+=0;
			checkBox6.Checked = false;	

			if (checkBox7.Checked) scor++;
			checkBox7.Checked = false;
			if (checkBox8.Checked) scor+=0;
			checkBox8.Checked = false;	
			
			if (checkBox9.Checked) scor++;
			checkBox9.Checked = false;
			if (checkBox10.Checked) scor+=0;
			checkBox10.Checked = false;	
			
			if (checkBox11.Checked) scor++;
			checkBox11.Checked = false;
			if (checkBox12.Checked) scor+=0;
			checkBox12.Checked = false;	

			if (checkBox13.Checked) scor+=0;
			checkBox13.Checked = false;
			if (checkBox14.Checked) scor++;
			checkBox14.Checked = false;	

			if (checkBox15.Checked) scor+=0;
			checkBox15.Checked = false;
			if (checkBox16.Checked) scor++;
			checkBox16.Checked = false;	

			if (checkBox17.Checked) scor+=0;
			checkBox17.Checked = false;
			if (checkBox18.Checked) scor++;
			checkBox18.Checked = false;	
			
			if (checkBox19.Checked) scor+=0;
			checkBox19.Checked = false;
			if (checkBox20.Checked) scor++;
			checkBox20.Checked = false;	

			if (checkBox21.Checked) scor++;
			checkBox21.Checked = false;
			if (checkBox22.Checked) scor+=0;
			checkBox22.Checked = false;	

			if (checkBox23.Checked) scor+=0;
			checkBox23.Checked = false;
			if (checkBox24.Checked) scor++;
			checkBox24.Checked = false;	

			if (checkBox25.Checked) scor++;
			checkBox25.Checked = false;
			if (checkBox26.Checked) scor+=0;
			checkBox26.Checked = false;	

			if (checkBox27.Checked) scor++;
			checkBox27.Checked = false;
			if (checkBox28.Checked) scor+=0;
			checkBox28.Checked = false;	
			
			if (checkBox29.Checked) scor+=0;
			checkBox29.Checked = false;
			if (checkBox30.Checked) scor++;
			checkBox30.Checked = false;

			if (checkBox31.Checked) scor+=0;
			checkBox31.Checked = false;
			if (checkBox32.Checked) scor++;
			checkBox32.Checked = false;	

			if (checkBox33.Checked) scor++;
			checkBox33.Checked = false;
			if (checkBox34.Checked) scor+=0;
			checkBox34.Checked = false;	

			if (checkBox35.Checked) scor++;
			checkBox35.Checked = false;
			if (checkBox36.Checked) scor+=0;
			checkBox36.Checked = false;	

			if (checkBox37.Checked) scor+=0;
			checkBox37.Checked = false;
			if (checkBox38.Checked) scor++;
			checkBox38.Checked = false;	
			
			if (checkBox39.Checked) scor++;
			checkBox39.Checked = false;
			if (checkBox40.Checked) scor+=0;
			checkBox40.Checked = false;	

			if (checkBox41.Checked) scor++;
			checkBox41.Checked = false;
			if (checkBox42.Checked) scor+=0;
			checkBox42.Checked = false;	

			if (checkBox43.Checked) scor++;
			checkBox43.Checked = false;
			if (checkBox44.Checked) scor+=0;
			checkBox44.Checked = false;	

			if (checkBox45.Checked) scor++;
			checkBox45.Checked = false;
			if (checkBox46.Checked) scor+=0;
			checkBox46.Checked = false;	

			if (checkBox47.Checked) scor++;
			checkBox47.Checked = false;
			if (checkBox48.Checked) scor+=0;
			checkBox48.Checked = false;	
			
			if (checkBox49.Checked) scor+=0;
			checkBox49.Checked = false;
			if (checkBox50.Checked) scor++;
			checkBox50.Checked = false;		

			if (checkBox51.Checked) scor++;
			checkBox51.Checked = false;
			if (checkBox52.Checked) scor+=0;
			checkBox52.Checked = false;	

			if (checkBox53.Checked) scor++;
			checkBox53.Checked = false;
			if (checkBox54.Checked) scor+=0;
			checkBox54.Checked = false;	

			if (checkBox55.Checked) scor+=0;
			checkBox55.Checked = false;
			if (checkBox56.Checked) scor++;
			checkBox56.Checked = false;	

			if (checkBox57.Checked) scor+=0;
			checkBox57.Checked = false;
			if (checkBox58.Checked) scor++;
			checkBox58.Checked = false;	
			
			if (checkBox59.Checked) scor+=0;
			checkBox59.Checked = false;
			if (checkBox60.Checked) scor++;
			checkBox60.Checked = false;		

			if (checkBox61.Checked) scor+=0;
			checkBox61.Checked = false;
			if (checkBox62.Checked) scor++;
			checkBox62.Checked = false;	

			if (checkBox63.Checked) scor++;
			checkBox63.Checked = false;
			if (checkBox64.Checked) scor+=0;
			checkBox64.Checked = false;	

			if (checkBox65.Checked) scor++;
			checkBox65.Checked = false;
			if (checkBox66.Checked) scor+=0;
			checkBox66.Checked = false;	

			if (checkBox67.Checked) scor++;
			checkBox67.Checked = false;
			if (checkBox68.Checked) scor+=0;
			checkBox68.Checked = false;	
			
			if (scor>=0 && scor<=11) MessageBox.Show("Testul arată că te simți puțin realizat(ă) în viață. Cercul tău de prieteni și grupurile de care simți că aparții sunt aproape inexistente, ceea ce-ți produce frustrări puternice.Poate că te simți neînțeles(leasă) de ceilalți, dar nici tu nu faci nimic pentru a le schimba părerea despre tine. Potrnțialul tău rămâne astfel neexprimat, iar relațiile tale sociale, interpersonale, sunt puternic afectate. În plus, este foarte posibil să nu-ți cunoști corect posibilitățile profesionale, să nu privești cu suficient realism activitatea pe care o desfășori în prezent. Sau poate că nu știi deloc să gândești pozitiv și nu ți-ai fixat anumite obiective pe care să le îndeplinești. Acest test îți atrage atenția că este timpul să te ocupi mai serios de cunoașterea propriei tale personalități.");
			if (scor>=12 && scor<=24) MessageBox.Show("Testul arată că ești o persoană care ar avea de ce să se simtă împlinită și totuși nu poți spune acest lucru. Motivul poate fi acela că poate ți-ai fixat obiective prea înalte și prea greu de atins sau că îți este greu să te simți bucuros(oasă) pentru rezultatele pe care le-ai obținut. Eventual, poți relua testul pentru a analiza cu mai multă atenție unele răspunsuri pe care le-ai dat. S-ar putea ca din punct de vedere a relațiilor cu ceilalți să te simți împlinit(ă) și atunci ceea ce îți lipsește trebuie căutat în plan profesional: nu te siți suficient valorificat(ă) din punct de vedere al capacităților și aptitudinilor tale sau standardele pe care le ai sunt prea înalte. Sau poate că te simți vinovat(ă) pentru că ceea ce realizezi tu este superior realizărilor altora și ai fost educat(ă) în acest spirit? Doar tu poți răspunde corect la aceste întrebări, dar rezultatul final merită efortul!");
			if (scor>=25 && scor<=29) MessageBox.Show("Testul arată că te simți destul de realizat(ă) din toate punctele de vedere. Ai o viață plină de satisfacții, te simți util(ă) și eficient(ă) în activitatea ta, consideri că oamenii te apreciază și țin la tine. Sigur că mai ai și tu, ca orice om, momentele tale de neîncredere și de descurajare, dar reușești să le depășești destul de ușor. Știi exact pe care dintre capacitățile tale te poți baza, ai acel dar de a te face plăcut(ă) de către ceilalți și de a fi diplomat(ă) atunci când situația o cere. Și știi că poți face mai multe, că poți deveni mai bun(ă) în activitatea ta, că poți câștiga mai mulți prieteni. Ai aspirații mai înalte și de aceea s-ar putea să nu te simți, în mod subiectiv, atât de împlinit(ă) pe cât indică rezultatul acestui test. Dar ai și capacitatea de a ajunge mai sus, așa că nu trebuie decât să continui să-ți urmărești obiectivele.");
			if (scor>=30 && scor<=34) MessageBox.Show("Testul arată că te simți extraordinar de realizat(ă) pe toate planurile vieții tale. Acest lucru se reflectă în modul în care te porți cu ceilalți și acționezi pe plan profesional. Cei din jurul tău se simt probabil adeseori copleșiți de siguranța și de mulțumirea de sine pe care le afișezi, așa că stârnești destule invidii. Dacă însă reușești să te porți firesc, să eviți capcana aroganței, îi vei câștiga pe toți de partea ta. Urmărește-ți în continuare realizarea obiectivelor, șansele sunt de partea ta. Știi că niciun obstacol nu-ți poate sta în cale, ai mare încredere în posibilitățile tale, ești o fire deschisă și optimistă. Continuă!");
			
			MainForm mainform=new MainForm();
			mainform.Show();
			this.Hide();
			this.Close();
			
		}
	}
}
