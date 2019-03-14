/*
 * Date: 29.12.2016
 * Time: 18:40
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Teste_psihologice
{
	/// <summary>
	/// Description of Test_Personalitate.
	/// </summary>
	public partial class Test_Personalitate : Form
	{
		public Test_Personalitate()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void C1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Cutezător. Cel care ia inițiative noi și îndrăznețe cu hotărîrea de a le coordona.");
		}
		void L1C2Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Adaptabil. Se acomodează ușor și se simte confortabil în orice situație");			
		}
		void S1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Animat. Plin de viață, cu gesturi vii ale mâinilor și mimică expresivă a feței.");			
		}
		
		void M1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Analitic. Îi place să examineze componentele unui întreg pentru a vedea relațiile logice.");			
		}
		
		void M2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Perseverent. Urmărește un proiect până la finalizarea lui înainte de a începe altul.");			
		}
		
		void S2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Voios. Plin de bună dispoziție și umor");			
		}
		
		void C2Click(object sender, EventArgs e)
		{
			MessageBox.Show("Răzbătător. Convinge mai degrabă prin logică și fapte decât prin farmec și putere.");			
		}
		
		void Label27Click(object sender, EventArgs e)
		{
			MessageBox.Show("Pașnic. Pare netulburat și liniștit și evită orice conflict.");			
		}
		
		void Label34Click(object sender, EventArgs e)
		{
			MessageBox.Show("Docil. Acceptă cu ușurință punctul de vedere sau dorința altcuiva, fără să simtă nevoia de a-și susține opinia.");			
		}
		
		void S3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sociabil. Cel care vede în prezența altora mai degrabă o ocazie de a fi prietenos și amuzant decât o provocare sau o oportunitare de afaceri");			
		}
		
		void C3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dârz. Cel care este hotărît să urmeze propria cale.");			
		}
		
		void M4Click(object sender, EventArgs e)
		{
			MessageBox.Show("Amabil. Îl interesează nevoile și sentimentele celorlalți.");			
		}
		
		void Label37Click(object sender, EventArgs e)
		{
			MessageBox.Show("Autocontrolat. Are trăiri emoționale, dar rareori le afișază");			
		}
		
		void C4Click(object sender, EventArgs e)
		{
			MessageBox.Show("Combatant. Transformă toate situațiile, întâmplările sau jocurile într-un concurs și întotdeauna joacă pentru a câștiga.");			
		}
		
		void S4Click(object sender, EventArgs e)
		{
			MessageBox.Show("Convingător. Poate să te câștige în orice domeniu prin farmecul total al personalității sale.");			
		}
		
		void S5Click(object sender, EventArgs e)
		{
			MessageBox.Show("Stimulator. Revigorează și impulsionează sau îi face pe ceilalți să se simtă bine.");			
		}
		
		void M5Click(object sender, EventArgs e)
		{
			MessageBox.Show("Respectuos. Îi tratează pe ceilalți cu respect, onestitate și considerație.");			
		}
		
		void Label40Click(object sender, EventArgs e)
		{
			MessageBox.Show("Rezervat. Autorestrictiv în exprimarea emoției sau a entuziasmului.");			
		}
		
		void C5Click(object sender, EventArgs e)
		{
			MessageBox.Show("Capabil. Apt să acționeze repede și eficient în toate situațiile posibile.");
		}
		
		void Label46Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nepretențios. O persoană care acceptă cu ușurință orice împrejurare sau situație.");
		}
		
		void M6Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sensibil. Se interesează cu intensitate de ceilalți și de ce se întâmplă.");			
		}
		
		void C6Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sigur pe sine. O persoană sigură care are încredere deplină în propriile capacități, judecăți și resurse.");			
		}
		
		void S6Click(object sender, EventArgs e)
		{
          	MessageBox.Show("Vivace. Plin de viață și de emoție.");			
		}
		
		void M7Click(object sender, EventArgs e)
		{
			MessageBox.Show("Prevăzător. Preferă să realizeze cu anticipație un plan detaliat pentru îndeplinirea unui proiect sau obiectiv și se implică mai degrabă în stadiile de planificare și finalizare decât în cele de execuție.");			
		}
		
		void Label49Click(object sender, EventArgs e)
		{
			MessageBox.Show("Răbdător. Neafectat de întârziere, rămâne calm și tolerant.");					
		}
		
		void C7Click(object sender, EventArgs e)
		{
			MessageBox.Show("Pozitiv. Este convins că va finaliza orice acțiune dacă depinde numai de el.");				
		}
		
		void S7Click(object sender, EventArgs e)
		{
			MessageBox.Show("Inițiator. Prin farmecul propriei personalități îi îndeamnă sau îi constrânge pe ceilalți să i se alăture, să participe sau să investească.");			
		}
		
		void C8Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ferm. Încrezător, rareori ezită sau oscilează.");				
		}
		
		void S8Click(object sender, EventArgs e)
		{
			MessageBox.Show("Spontan. Preferă ca totul în viață să fie activitate impetuoasă, nepremeditată, nerestricționată de planuri.");				
		}
		
		void M8Click(object sender, EventArgs e)
		{
			MessageBox.Show("Organizat. Trăiește și acționează conform unui plan zilnic; nu îi place ca planul său să fie perturbat.");				
		}
		
		void Label51Click(object sender, EventArgs e)
		{
			MessageBox.Show("Timid. Liniștit, nu provoacă pre ușor o conversație.");				
		}
		
		void M9Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ordonat. O persoană care își aranjează metodic, sistematic lucrurile.");	
		}
		
		void Label57Click(object sender, EventArgs e)
		{
			MessageBox.Show("Flexibil. Se acomodează ușor și este gata rapid să procedeze altfel.");				
		}
		
		void S9Click(object sender, EventArgs e)
		{
			MessageBox.Show("Optimist. Întotdeauna bine dispus; se autoconvinge și îi convinge pe ceilalți că totul se va rezolva cu bine.");				
		}
		
		void Label62Click(object sender, EventArgs e)
		{
			MessageBox.Show("Prietenos. Mai degrabă reacționează decât inițiază, rareori începe o conversație.");				
		}
		
		void M10Click(object sender, EventArgs e)
		{
			MessageBox.Show("Statornic. De nădejde, credincios, devotat și încrezător, uneori fără motiv.");				
		}
		
		void S10Click(object sender, EventArgs e)
		{
			MessageBox.Show("Amuzant. Are un simț al umorului efervescent, care ar putea transforma orice povestire într-un eveniment umoristic.");				
		}
		
		void C10Click(object sender, EventArgs e)
		{
			MessageBox.Show("Puternic. O personalitate care comandă și căreia ceilalți ezită să i se împotrivească.");				
		}
		
		void C11Click(object sender, EventArgs e)
		{
			MessageBox.Show("Temerar. Doritor să își asume riscurile; fără teamă, cutezător.");					
		}
		
		void S11Click(object sender, EventArgs e)
		{
			MessageBox.Show("Încântător. O persoană cu care este amuzant să fii.");			
		}
		
		void Label64Click(object sender, EventArgs e)
		{
			MessageBox.Show("Diplomat. Se poartă cu oamenii cu tact, sensibilitate și răbdare.");			
		}
		
		void M11Click(object sender, EventArgs e)
		{
			MessageBox.Show("Meticulos. Face totul în ordinea corectă, amintindu-și clar tot ce s-a întâmplat.");			
		}
		
		void S12Click(object sender, EventArgs e)
		{
			MessageBox.Show("Vesel. Permanent în stare de spirit bună, inducând fericire și altora.");	
		}
		
		void Label69Click(object sender, EventArgs e)
		{
			MessageBox.Show("Consecvent. Este stabil memoțional, reacționând așa cum este de așteptat.");			
		}
		
		void M12Click(object sender, EventArgs e)
		{
			MessageBox.Show("Cultivat. Persoană ale cărei interese implică și ocupații intelectuale și artistice, cum ar fi teatrul, concertele, baletul.");			
		}
		
		void C12Click(object sender, EventArgs e)
		{
			MessageBox.Show("Încrezător. Sigur pe sine și convins de propriile aptitudini și de succesul său.");			
		}
		
		void M13Click(object sender, EventArgs e)
		{
			MessageBox.Show("Idealist. Vede lucrurile în forma lor perfectă și simte nevoia de a se ridica el însuși la acel standard.");
		}
		
		void C13Click(object sender, EventArgs e)
		{
			MessageBox.Show("Independent. Se bizuie pe propriile sale forțe, autonom, cu încredere în sine și pare să aibă puțină nevoie de ajutor.");
		}
		
		void Label72Click(object sender, EventArgs e)
		{
			MessageBox.Show("Inofensiv. O persoană care niciodată nu spune, nici nu provoacă ceva neplăcut sau nedorit.");
		}
		
		void S13Click(object sender, EventArgs e)
		{
			MessageBox.Show("Antrenant. Îi încurajază pe ceilalți să muncească, să i se alăture sau să se implice și face ca totul să fie distractiv.");
		}
		
		void S14Click(object sender, EventArgs e)
		{
			MessageBox.Show("Expansiv. Își exprimă emoția deschis, în special afecțiunea, și nu ezită să îi atingă pe ceilalți în timp ce le vorbește.");
		}
		
		void C14Click(object sender, EventArgs e)
		{
			MessageBox.Show("Decis. O persoană cu abilitatea de a lua rapid și definitiv o hotărâre.");
		}
		
		void Label76Click(object sender, EventArgs e)
		{
			MessageBox.Show("Spiritual. Etalează un umor sec, care poate fi sarcastic.");
		}
		
		void Label75Click(object sender, EventArgs e)
		{
			MessageBox.Show("Profund. Intens și adesea introspectiv, cu; îi displac conversația și lucrurile superficiale.");
		}
		
		void Label82Click(object sender, EventArgs e)
		{
			MessageBox.Show("Pacificator. Adesea se regăsește în rolul de a aplana divergențele pentru a evita un conflict.");
		}
		
		void Label81Click(object sender, EventArgs e)
		{
			MessageBox.Show("Iubitor de muzică. Participă sau are o profundă apreciere pentru muzică; este implicat în muzică mai degrabă ca formă a artei decât ca distracție oferită de un spectacol.");
		}
		
		void C15Click(object sender, EventArgs e)
		{
			MessageBox.Show("Activ. Simte nevoia de a fi productiv; este un conducător pe care ceilalți îl urmează și găsește că e dificil să stea liniștit.");
		}
		
		void S15Click(object sender, EventArgs e)
		{
			MessageBox.Show("Atașabil. Îi plac petrecerile și abia așteaptă să cunoască fiecare invitat; toți îi devin prieteni încă din primul moment.");
		}
		
		void Label86Click(object sender, EventArgs e)
		{
			MessageBox.Show("Manierat. O persoană plicticoasă care își amintește ocaziile speciale și face cu promptitudine un gest amabil.");
		}
		
		void C16Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tenace. Este ferm, îndărătnic și nu se va lăsa până când obiectivul nu va fi realizat.");
		}
		
		void S16Click(object sender, EventArgs e)
		{
			MessageBox.Show("Volubil. Vorbește în permanență, spune în general povestiri caraghioase și îi distrează pe cei din jur, simte nevoia de a umple tăcerea pentru a-i face pe ceilalți să se simtă bine.");
		}
		
		void Label83Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tolerant. Acceptă cu ușurință gândurile și modul de a fi al celorlalți, fără să simtă nevoia de a li se împotrivi sau de a le schimba.");
		}
		
		void Label90Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bun ascultător. Pare întotdeauna doritor să asculte ce ai de spus.");
		}
		
		void Label89Click(object sender, EventArgs e)
		{
			MessageBox.Show("Loial. Credincios unei persoane, unui ideal sau unui loc de munca, uneori fără motiv.");
		}
		
		void C17Click(object sender, EventArgs e)
		{
			MessageBox.Show("Lider. Un conducător înnăscut căruia îi place să se afle la 'cârmă' și adesea consideră greu de crezut că altcineva poate face treaba la fel de bine.");
		}
		
		void S17Click(object sender, EventArgs e)
		{
			MessageBox.Show("Energic. Plin de viață, viguros,energic.");
		}
		
		void Label94Click(object sender, EventArgs e)
		{
			MessageBox.Show("Mulțumit. Satisfăcut cu ușurință de ceea ce are, rareori invidios.");
		}
		
		void C18Click(object sender, EventArgs e)
		{
			MessageBox.Show("Conducător. Are capacitatea de a conduce și așteaptă ca oamenii să îl urmeze.");
		}
		
		void Label92Click(object sender, EventArgs e)
		{
			MessageBox.Show("Riguros. Își organizează viața, sarcinile și rezolvă problemele făcând liste, scheme sau grafice.");
		}
		
		void S18Click(object sender, EventArgs e)
		{
			MessageBox.Show("Agreabil. Simpatic, adorabil, centrul atenției.");
		}
		
		void Label98Click(object sender, EventArgs e)
		{
			MessageBox.Show("Perfecționist. Stabilește standarde înalte pentru el și adesea pentru alții, dorind ca totul să fie în ordine în orice moment.");
		}
		
		void Label97Click(object sender, EventArgs e)
		{
			MessageBox.Show("Plăcut. Agreabil; conversația cu el este o plăcere.");
		}
		
		void C19Click(object sender, EventArgs e)
		{
			MessageBox.Show("Productiv. Trebuie în permanență să lucreze sau să acumuleze; adesea găsește că este foarte dificil să se odihnească.");
		}
		
		void S19Click(object sender, EventArgs e)
		{
			MessageBox.Show("Popular. Reprezintă sufletul petrecerii și de aceea este foarte dorit ca gazdă a petrecerii.");
		}
		
		void S20Click(object sender, EventArgs e)
		{
			MessageBox.Show("Entuziast. O personalitate spumoasă, plină de viață, de energie.");
		}
		
		void C20Click(object sender, EventArgs e)
		{
			MessageBox.Show("Îndrăzneț. Fără frică, cutezător, fără teamă de risc.");
		}
		
		void Label100Click(object sender, EventArgs e)
		{
			MessageBox.Show("Decent. Urmărește constant să facă totul în modul cel mai cuviincios.");
		}
		
		void Label99Click(object sender, EventArgs e)
		{
			MessageBox.Show("Echilibrat. Stabil, moderat, nu îi plac extremele.");
		}
		
		void Label153Click(object sender, EventArgs e)
		{
			MessageBox.Show("Inexpresiv. O persoană a cărei față nu îi trădează emoțiile.");
		}
		
		void Label152Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sfios. Se sfiește să atragă atenția, ca rezultat al complexelor de care suferă.");
		}
		
		void Label151Click(object sender, EventArgs e)
		{
			MessageBox.Show("Obraznic. Bătător la ochi, strident, intervine necuviincios, prea zgomotos.");
		}
		
		void Label150Click(object sender, EventArgs e)
		{
			MessageBox.Show("Despotic. Comandă, domină, uneori exercitându-și puterea peste limită în relațiile cu adulții");
		}
		
		void Label139Click(object sender, EventArgs e)
		{
			MessageBox.Show("Indisciplinat. O persoană la care dezordinea pune stăpânire pe orice aspect al vieții.");
		}
		
		void Label138Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nepăsător. Găsește dificil să se raporteze la probleme sau durerile altora.");
		}
		
		void Label137Click(object sender, EventArgs e)
		{
			MessageBox.Show("Apatic. Tinde să nu se entuziasmeze, adesea simțind că oricum nu poate ieși nimic bun.");
		}
		
		void Label136Click(object sender, EventArgs e)
		{
			MessageBox.Show("Neînduplecat. Cel care are dificultăți în a ierta sau a uita o nedreptate care i s-a făcut, capabil să poarte ranchiună.");
		}
		
		void Label135Click(object sender, EventArgs e)
		{
			MessageBox.Show("Reticent. Nu dorește implicarea sau luptă împotriva acesteia, în special în situații dificile.");
		}
		
		void Label134Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ranchiunos. Adeseori nutrește sentimente negative ca rezultat al unor ofense reale sau imaginare pe care nu le uită.");
		}
		
		void Label133Click(object sender, EventArgs e)
		{
			MessageBox.Show("Potrivnic. Se împotrivește, acționează împotrivă sau ezită să accepte orice altă cale, cu excepția celei proprii.");
		}
		
		void Label132Click(object sender, EventArgs e)
		{
			MessageBox.Show("Obositor. Repovestește istorii și incidente pentru a te amuza, fără să realizeze că deja a mai spus povestea de câteva ori; în permanență simte nevoia să spună ceva.");
		}
		
		void Label131Click(object sender, EventArgs e)
		{
			MessageBox.Show("Scabros. Insistent asupra unor problemele sau aspecte neînsemnate, accentuând detaliile triviale.");
		}
		
		void Label130Click(object sender, EventArgs e)
		{
			MessageBox.Show("Fricos. Deseori încercă sentimente de profundă îngrijoare, neîncredere sau anxietate.");
		}
		
		void Label129Click(object sender, EventArgs e)
		{
			MessageBox.Show("Neatent. Lipsă a memoriei, care de obicei este legată de o lipsă de desciplină și o lipsă de interes pentru întregirea mintală a lucrurilor care nu sunt distractive.");
		}
		
		void Label128Click(object sender, EventArgs e)
		{
			MessageBox.Show("Franc. Direct, sincer; nu îl deranjază să spună exact ce gândește.");
		}
		
		void Label127Click(object sender, EventArgs e)
		{
			MessageBox.Show("Intolerant. O persoană care găsește că este dificil să suporte iritarea altora sau să îi aștepte pe alții.");
		}
		
		void Label126Click(object sender, EventArgs e)
		{
			MessageBox.Show("Temător. Cel care este temător sau îi lipsește încredere.");
		}
		
		void Label125Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nehotărît. Persoana care găsește dificil să ia orice decizie.(Nu este vorba de acea personalitate care se pleacă mult asupra fiecărei decizii pentru a o găsi pe cea perfectă.)");
		}
		
		void Label124Click(object sender, EventArgs e)
		{
			MessageBox.Show("Care întrerupe. O persoană care mai mult vorbește decât ascultă, care începe să vorbească fără măcar să realizeze că deja vorbea altcineva.");
		}

		void Label123Click(object sender, EventArgs e)
		{
			MessageBox.Show("Tipicar. O persoană a cărei intensitate și nevoie de perfecțiune poate să-i îndepărteze pe ceilalți.");
		}
		
		void Label122Click(object sender, EventArgs e)
		{
			MessageBox.Show("Neimplicat. Nu își dorește să asculte sau să devină interesat de cluburi, grupuri, activități sau viețile celorlalți.");
		}
		
		void Label121Click(object sender, EventArgs e)
		{
			MessageBox.Show("Imprevizibil. Poate fi extaziat într-un moment și indiferent în următorul, sau promite să ajute, dar apoi dispare, sau promite că vine, dar apoi uită să-și facă apariția.");
		}
		
		void Label120Click(object sender, EventArgs e)
		{
			MessageBox.Show("Interiorizat. Găsește că este dificil să îți arăți în mod deschis, verbal sau fizic, tandrețea.");
		}
		
		void Label119Click(object sender, EventArgs e)
		{
			MessageBox.Show("Încăpățânat. Insistă să își urmeze propria cale.");
		}
		
		void Label118Click(object sender, EventArgs e)
		{
			MessageBox.Show("Imprudent. Nu are o manieră logică de a face lucrurile.");
		}
		
		void Label117Click(object sender, EventArgs e)
		{
			MessageBox.Show("Pretențios. O persoană ale cărei standarde sunt atât de înalte, încât este dificil să le satisfaci vreodată.");
		}
		
		void Label116Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ezitant. Lent în a începe o mișcare și greu să fie implicate în ceva.");
		}
		
		void Label115Click(object sender, EventArgs e)
		{
			MessageBox.Show("Anost. O personalitate de mijloc, fără manifestări extreme, care își manifestă în mică măsură sau deloc sentimentele.");
		}
		
		void Label114Click(object sender, EventArgs e)
		{
			MessageBox.Show("Pesimist. Chiar dacă speră la ce este mai bine, această persoană în general vede întâi partea negativă a lucrurilor.");
		}
		
		void Label113Click(object sender, EventArgs e)
		{
			MessageBox.Show("Trufaș. Persoana cu o stimă de sine puternică, care crede că are dreptate și că este cea mai potrivită pentru o sarcină.");
		}
		
		void Label112Click(object sender, EventArgs e)
		{
			MessageBox.Show("Indulgent. Permite celorlalți (inclusiv copiilor) să facă ce le place, cu scopul de a evita să fie dezagreabil.");
		}
		
		void Label111Click(object sender, EventArgs e)
		{
			MessageBox.Show("Necumpătat. Cel care se supără copilărește, se manifestă foarte violent, dar îi trece și uită aproape instantaneu.");
		}
		
		void Label110Click(object sender, EventArgs e)
		{
			MessageBox.Show("Placid. Nu este o persoană care să își stabilească obiective și nici nu dorește să devină așa.");
		}
		
		void Label109Click(object sender, EventArgs e)
		{
			MessageBox.Show("Certăreț. Provoacă discuții în general pe motiv că are dreptate, indiferent de situație.");
		}
		
		void Label108Click(object sender, EventArgs e)
		{
			MessageBox.Show("Stingher. Se simte marginalizat, adesea din cauza nesiguranței sau de teamă că ceilalți nu îi apreciază cu adevărat compania.");
		}
		
		void Label107Click(object sender, EventArgs e)
		{
			MessageBox.Show("Naiv. Are o perspectivă simplă și copilărească, este lipsit de experiență sau de capacitatea de a înțelege aspectele mai profunde ale vieții.");
		}
		
		void Label106Click(object sender, EventArgs e)
		{
			MessageBox.Show("Negativist. Cel a cărei atitudine este rareori pozitivă și adesea nu poate să vadă decât partea negativă sau întunecată a unei situații.");
		}
		
		void Label105Click(object sender, EventArgs e)
		{
			MessageBox.Show("Înfipt. Plin de încredere, fermitate, curaj, adeseori în sens negativ.");
		}
		
		void Label104Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nonșalant. Indolent, nepăsător, indiferent.");
		}
		
		void Label193Click(object sender, EventArgs e)
		{
			MessageBox.Show("Neliniștit. Se simte în mod constant nesigur, tulburat sau anxios.");
		}
		
		void Label192Click(object sender, EventArgs e)
		{
			MessageBox.Show("Închistat. O persoană care se retrage în ea însăși și are nevoie de mult timp de singurătate și izolare.");
		}
		
		void Label191Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dependent de muncă. O persoană care stabilește cu agresivitate obiective și care trebuie să fie în mod constant productivă, simțindu-se vinovat când se odihnește; este condus doar de nevoia de recompensare și realizare.");
		}
		
		void Label190Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dorește încredere. Îi priește încrederea sau aprobarea din partea altora. Ca animator, este alimentat de aplauze, de cei ce râd și/sau de aprobarea din partea spectatorilor.");
		}
		void Label189Click(object sender, EventArgs e)
		{
			MessageBox.Show("Susceptibil. Peste măsură de introspectiv; se simte jignit cu ușurință când nu este înțeles.");
		}
		
		void Label188Click(object sender, EventArgs e)
		{
			MessageBox.Show("Lipsit de tact. Uneori se exprimă într-o formă cumva jignitoare și nechibzuită.");
		}
		
		void Label187Click(object sender, EventArgs e)
		{
			MessageBox.Show("Laș. Se retrage din situațiile dificile.");
		}
		
		void Label186Click(object sender, EventArgs e)
		{
			MessageBox.Show("Flecar. Un vorbitor antrenant, forțat, căruia îi este greu să asculte.");
		}
		void Label185Click(object sender, EventArgs e)
		{
			MessageBox.Show("Sceptic. Caracterizat de îndoială și de lipsa încrederii că va reuși vreodată.");
		}
		
		void Label184Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dezorganizat. Îi lipsește capacitatea de a-și pune în ordine viața.");
		}
		
		void Label183Click(object sender, EventArgs e)
		{
			MessageBox.Show("Poruncitor. Preia cu forța controlul situațiilor și/sau al oamenilor spunându-le de obicei celorlalți ce să facă.");
		}
		
		void Label182Click(object sender, EventArgs e)
		{
			MessageBox.Show("Depresiv. O persoană care este tristă majoritatea timpului.");
		}
		void Label181Click(object sender, EventArgs e)
		{
			MessageBox.Show("Capricios. Inconsecvent, contradictoriu, cu acțiuni sau emoții care nu se bazează pe logică");
		}
		
		void Label180Click(object sender, EventArgs e)
		{
			MessageBox.Show("Introvertit. O persoană ale cărei gânduri și interese sunt orientate către interior; trăiește în ea însăși.");
		}
		
		void Label179Click(object sender, EventArgs e)
		{
			MessageBox.Show("Inflexibil. Este incapabil să înțeleagă sau să accepte atitudinea altora, punctele lor de vedere sau maniera lor de a acționa.");
		}
		
		void Label178Click(object sender, EventArgs e)
		{
			MessageBox.Show("Indiferent. O persoană pentru care cele mai multe lucruri nu contează dacă sunt așa sau altfel.");
		}
		void Label177Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dezordonat. Trăind într-o stare de dezordine, incapabil să își găsească lucrurile.");
		}
		
		void Label176Click(object sender, EventArgs e)
		{
			MessageBox.Show("Irascibil. Nu ajunge la un nuvel emoțional foarte înalt, dar alunecă ușor într-o stare de nemulțumire , deseori când simte că nu este apreciat.");
		}
		
		void Label175Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bombănitor. Vorbește încet în barbă când este împins de la spate, nu se obosește să vorbească cu claritate.");
		}
		
		void Label174Click(object sender, EventArgs e)
		{
			MessageBox.Show("Manipulator. Influențează sau conduce lucrurile, subtil sau cu viclenie, în avantajul său; va obține cumva ceea ce vrea.");
		}
		void Label173Click(object sender, EventArgs e)
		{
			MessageBox.Show("Mocăit. Adesea nu acționează sau nu gândește repede; ar fi prea multă bătaie de cap.");
		}
		
		void Label172Click(object sender, EventArgs e)
		{
			MessageBox.Show("Încăpățânat. Hotărât să-și exercite voința proprie, nu se lasă ușor convins, îndărătnic.");
		}
		
		void Label171Click(object sender, EventArgs e)
		{
			MessageBox.Show("Încrezut. Simte nevoia să fie în centrul atenției, dorește să fie privit.");
		}
		
		void Label170Click(object sender, EventArgs e)
		{
			MessageBox.Show("Suspicios. Nu crede, se întreabă cu privire la motivul din spatele cuvintelor.");
		}
		void Label169Click(object sender, EventArgs e)
		{
			MessageBox.Show("Singuratic. Are nevoie de mult timp pentru el și tinde să evite alți oameni.");
		}
		
		void Label168Click(object sender, EventArgs e)
		{
			MessageBox.Show("Dominator. Nu ezită să te anunțe că el are dreptate sau că el deține controlul.");
		}
		
		void Label167Click(object sender, EventArgs e)
		{
			MessageBox.Show("Leneș. Evaluează munca sau activitatea în funcție de câtă energie trebuie depusă.");
		}
		
		void Label166Click(object sender, EventArgs e)
		{
			MessageBox.Show("Gălăgios. O persoană al cărei râset sau voce se aude peste vocile celorlalți.");
		}
		void Label165Click(object sender, EventArgs e)
		{
			MessageBox.Show("Trândav. Greu de pornit, are nevoie de îndemnuri pentru a se motiva.");
		}
		
		void Label164Click(object sender, EventArgs e)
		{
			MessageBox.Show("Neîncrezător. Tinde să-i suspecteze sau să nu aibă încredere în alții sau în ideile lor.");
		}
		
		void Label163Click(object sender, EventArgs e)
		{
			MessageBox.Show("Arțăgos. Se înfurie, este nerăbdător și îi sare țandăra repede. Își manifestă furia când ceilalți nu se mișcă suficient de repede sau nu au îndeplinit ce li s-a cerut să facă.");
		}
		
		void Label162Click(object sender, EventArgs e)
		{
			MessageBox.Show("Absent. Îi lipsește puterea de concentrare sau atenția; distrat.");
		}
		void Label161Click(object sender, EventArgs e)
		{
			MessageBox.Show("Răzbunător. În mod conștient este ranchiunos și îl pedepsește pe cel ce l-a jignit, adeseori refuză subtil prietenia sau afecțiunea.");
		}
		
		void Label160Click(object sender, EventArgs e)
		{
			MessageBox.Show("Nestatornic. Caută mereu activitățile noi, deoarece nu este distractiv să facă același lucru tot timpul.");
		}
		
		void Label159Click(object sender, EventArgs e)
		{
			MessageBox.Show("Impasibil. Care nu vrea sau se opune implicării.");
		}
		
		void Label158Click(object sender, EventArgs e)
		{
			MessageBox.Show("Pripit. Poate acționa precipitat, fără a judeca lucrurile, în general din cauza nerăbdării.");
		}
		void Label157Click(object sender, EventArgs e)
		{
			MessageBox.Show("Împăciuitorist. Deseori își slăbește poziția, chiar când are dreptate, pentru a evita conflictul.");
		}
		
		void Label156Click(object sender, EventArgs e)
		{
			MessageBox.Show("Critic. Evaluează în mod constant și judecă, adesea gândind sau exprimând reacții negative.");
		}
		
		void Label155Click(object sender, EventArgs e)
		{
			MessageBox.Show("Viclean. Șiret, unul care întotdeauna poate găsi o cale să ajungă la finalul dorit.");
		}
		
		void Label154Click(object sender, EventArgs e)
		{
			MessageBox.Show("Instabil. Copilăros, nu este prea atent și are nevoie de multe schimbări și varietate pentru a nu se lictisi.");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int Sangvinic=0,Coleric=0,Melancolic=0,Flegmatic=0;
			
			if (checkBoxS1.Checked) Sangvinic++;
			checkBoxS1.Checked = false;	
			if (checkBoxS2.Checked) Sangvinic++;
			checkBoxS2.Checked = false;
			if (checkBoxS3.Checked) Sangvinic++;
			checkBoxS3.Checked = false;
			if (checkBoxS4.Checked) Sangvinic++;
			checkBoxS4.Checked = false;	
			if (checkBoxS5.Checked) Sangvinic++;
			checkBoxS5.Checked = false;	
			if (checkBoxS6.Checked) Sangvinic++;
			checkBoxS6.Checked = false;
			if (checkBoxS7.Checked) Sangvinic++;
			checkBoxS7.Checked = false;
			if (checkBoxS8.Checked) Sangvinic++;
			checkBoxS8.Checked = false;
			if (checkBoxS9.Checked) Sangvinic++;
			checkBoxS9.Checked = false;
			if (checkBoxS10.Checked) Sangvinic++;
			checkBoxS10.Checked = false;	
			if (checkBoxS11.Checked) Sangvinic++;
			checkBoxS11.Checked = false;
			if (checkBoxS12.Checked) Sangvinic++;
			checkBoxS12.Checked = false;
			if (checkBoxS13.Checked) Sangvinic++;
			checkBoxS13.Checked = false;
			if (checkBoxS14.Checked) Sangvinic++;
			checkBoxS14.Checked = false;		
			if (checkBoxS15.Checked) Sangvinic++;
			checkBoxS15.Checked = false;	
			if (checkBoxS16.Checked) Sangvinic++;
			checkBoxS16.Checked = false;
			if (checkBoxS17.Checked) Sangvinic++;
			checkBoxS17.Checked = false;
			if (checkBoxS18.Checked) Sangvinic++;
			checkBoxS18.Checked = false;
			if (checkBoxS19.Checked) Sangvinic++;
			checkBoxS19.Checked = false;	
			if (checkBoxS20.Checked) Sangvinic++;
			checkBoxS20.Checked = false;	
			if (checkBoxS21.Checked) Sangvinic++;
			checkBoxS21.Checked = false;
			if (checkBoxS22.Checked) Sangvinic++;
			checkBoxS22.Checked = false;
			if (checkBoxS23.Checked) Sangvinic++;
			checkBoxS23.Checked = false;
			if (checkBoxS24.Checked) Sangvinic++;
			checkBoxS24.Checked = false;		
			if (checkBoxS25.Checked) Sangvinic++;
			checkBoxS25.Checked = false;	
			if (checkBoxS26.Checked) Sangvinic++;
			checkBoxS26.Checked = false;
			if (checkBoxS27.Checked) Sangvinic++;
			checkBoxS27.Checked = false;
			if (checkBoxS28.Checked) Sangvinic++;
			checkBoxS28.Checked = false;
			if (checkBoxS29.Checked) Sangvinic++;
			checkBoxS29.Checked = false;	
			if (checkBoxS30.Checked) Sangvinic++;
			checkBoxS30.Checked = false;	
			if (checkBoxS31.Checked) Sangvinic++;
			checkBoxS31.Checked = false;
			if (checkBoxS32.Checked) Sangvinic++;
			checkBoxS32.Checked = false;
			if (checkBoxS33.Checked) Sangvinic++;
			checkBoxS33.Checked = false;
			if (checkBoxS34.Checked) Sangvinic++;
			checkBoxS34.Checked = false;		
			if (checkBoxS35.Checked) Sangvinic++;
			checkBoxS35.Checked = false;	
			if (checkBoxS36.Checked) Sangvinic++;
			checkBoxS36.Checked = false;
			if (checkBoxS37.Checked) Sangvinic++;
			checkBoxS37.Checked = false;
			if (checkBoxS38.Checked) Sangvinic++;
			checkBoxS38.Checked = false;
			if (checkBoxS39.Checked) Sangvinic++;
			checkBoxS39.Checked = false;	
			if (checkBoxS40.Checked) Sangvinic++;
			checkBoxS40.Checked = false;	




			if (checkBoxC1.Checked) Coleric++;
            checkBoxC1.Checked = false;    
            if (checkBoxC2.Checked) Coleric++;
            checkBoxC2.Checked = false;
            if (checkBoxC3.Checked) Coleric++;
            checkBoxC3.Checked = false;
            if (checkBoxC4.Checked) Coleric++;
            checkBoxC4.Checked = false;    
            if (checkBoxC5.Checked) Coleric++;
            checkBoxC5.Checked = false;    
            if (checkBoxC6.Checked) Coleric++;
            checkBoxC6.Checked = false;
            if (checkBoxC7.Checked) Coleric++;
            checkBoxC7.Checked = false;
            if (checkBoxC8.Checked) Coleric++;
            checkBoxC8.Checked = false;
            if (checkBoxC9.Checked) Coleric++;
            checkBoxC9.Checked = false;
            if (checkBoxC10.Checked) Coleric++;
            checkBoxC10.Checked = false;    
            if (checkBoxC11.Checked) Coleric++;
            checkBoxC11.Checked = false;
            if (checkBoxC12.Checked) Coleric++;
            checkBoxC12.Checked = false;
            if (checkBoxC13.Checked) Coleric++;
            checkBoxC13.Checked = false;
            if (checkBoxC14.Checked) Coleric++;
            checkBoxC14.Checked = false;        
            if (checkBoxC15.Checked) Coleric++;
            checkBoxC15.Checked = false;    
            if (checkBoxC16.Checked) Coleric++;
            checkBoxC16.Checked = false;
            if (checkBoxC17.Checked) Coleric++;
            checkBoxC17.Checked = false;
            if (checkBoxC18.Checked) Coleric++;
            checkBoxC18.Checked = false;
            if (checkBoxC19.Checked) Coleric++;
            checkBoxC19.Checked = false;    
            if (checkBoxC20.Checked) Coleric++;
            checkBoxC20.Checked = false;    
            if (checkBoxC21.Checked) Coleric++;
            checkBoxC21.Checked = false;
            if (checkBoxC22.Checked) Coleric++;
            checkBoxC22.Checked = false;
            if (checkBoxC23.Checked) Coleric++;
            checkBoxC23.Checked = false;
            if (checkBoxC24.Checked) Coleric++;
            checkBoxC24.Checked = false;        
            if (checkBoxC25.Checked) Coleric++;
            checkBoxC25.Checked = false;    
            if (checkBoxC26.Checked) Coleric++;
            checkBoxC26.Checked = false;
            if (checkBoxC27.Checked) Coleric++;
            checkBoxC27.Checked = false;
            if (checkBoxC28.Checked) Coleric++;
            checkBoxC28.Checked = false;
            if (checkBoxC29.Checked) Coleric++;
            checkBoxC29.Checked = false;    
            if (checkBoxC30.Checked) Coleric++;
            checkBoxC30.Checked = false;    
            if (checkBoxC31.Checked) Coleric++;
            checkBoxC31.Checked = false;
            if (checkBoxC32.Checked) Coleric++;
            checkBoxC32.Checked = false;
            if (checkBoxC33.Checked) Coleric++;
            checkBoxC33.Checked = false;
            if (checkBoxC34.Checked) Coleric++;
            checkBoxC34.Checked = false;        
            if (checkBoxC35.Checked) Coleric++;
            checkBoxC35.Checked = false;    
            if (checkBoxC36.Checked) Coleric++;
            checkBoxC36.Checked = false;
            if (checkBoxC37.Checked) Coleric++;
            checkBoxC37.Checked = false;
            if (checkBoxC38.Checked) Coleric++;
            checkBoxC38.Checked = false;
            if (checkBoxC39.Checked) Coleric++;
            checkBoxC39.Checked = false;    
            if (checkBoxC40.Checked) Coleric++;
            checkBoxC40.Checked = false;




			if (checkBoxM1.Checked) Melancolic++;
            checkBoxM1.Checked = false;    
            if (checkBoxM2.Checked) Melancolic++;
            checkBoxM2.Checked = false;
            if (checkBoxM3.Checked) Melancolic++;
            checkBoxM3.Checked = false;
            if (checkBoxM4.Checked) Melancolic++;
            checkBoxM4.Checked = false;    
            if (checkBoxM5.Checked) Melancolic++;
            checkBoxM5.Checked = false;    
            if (checkBoxM6.Checked) Melancolic++;
            checkBoxM6.Checked = false;
            if (checkBoxM7.Checked) Melancolic++;
            checkBoxM7.Checked = false;
            if (checkBoxM8.Checked) Melancolic++;
            checkBoxM8.Checked = false;
            if (checkBoxM9.Checked) Melancolic++;
            checkBoxM9.Checked = false;
            if (checkBoxM10.Checked) Melancolic++;
            checkBoxM10.Checked = false;    
            if (checkBoxM11.Checked) Melancolic++;
            checkBoxM11.Checked = false;
            if (checkBoxM12.Checked) Melancolic++;
            checkBoxM12.Checked = false;
            if (checkBoxM13.Checked) Melancolic++;
            checkBoxM13.Checked = false;
            if (checkBoxM14.Checked) Melancolic++;
            checkBoxM14.Checked = false;        
            if (checkBoxM15.Checked) Melancolic++;
            checkBoxM15.Checked = false;    
            if (checkBoxM16.Checked) Melancolic++;
            checkBoxM16.Checked = false;
            if (checkBoxM17.Checked) Melancolic++;
            checkBoxM17.Checked = false;
            if (checkBoxM18.Checked) Melancolic++;
            checkBoxM18.Checked = false;
            if (checkBoxM19.Checked) Melancolic++;
            checkBoxM19.Checked = false;    
            if (checkBoxM20.Checked) Melancolic++;
            checkBoxM20.Checked = false;    
            if (checkBoxM21.Checked) Melancolic++;
            checkBoxM21.Checked = false;
            if (checkBoxM22.Checked) Melancolic++;
            checkBoxM22.Checked = false;
            if (checkBoxM23.Checked) Melancolic++;
            checkBoxM23.Checked = false;
            if (checkBoxM24.Checked) Melancolic++;
            checkBoxM24.Checked = false;        
            if (checkBoxM25.Checked) Melancolic++;
            checkBoxM25.Checked = false;    
            if (checkBoxM26.Checked) Melancolic++;
            checkBoxM26.Checked = false;
            if (checkBoxM27.Checked) Melancolic++;
            checkBoxM27.Checked = false;
            if (checkBoxM28.Checked) Melancolic++;
            checkBoxM28.Checked = false;
            if (checkBoxM29.Checked) Melancolic++;
            checkBoxM29.Checked = false;    
            if (checkBoxM30.Checked) Melancolic++;
            checkBoxM30.Checked = false;    
            if (checkBoxM31.Checked) Melancolic++;
            checkBoxM31.Checked = false;
            if (checkBoxM32.Checked) Melancolic++;
            checkBoxM32.Checked = false;
            if (checkBoxM33.Checked) Melancolic++;
            checkBoxM33.Checked = false;
            if (checkBoxM34.Checked) Melancolic++;
            checkBoxM34.Checked = false;        
            if (checkBoxM35.Checked) Melancolic++;
            checkBoxM35.Checked = false;    
            if (checkBoxM36.Checked) Melancolic++;
            checkBoxM36.Checked = false;
            if (checkBoxM37.Checked) Melancolic++;
            checkBoxM37.Checked = false;
            if (checkBoxM38.Checked) Melancolic++;
            checkBoxM38.Checked = false;
            if (checkBoxM39.Checked) Melancolic++;
            checkBoxM39.Checked = false;    
            if (checkBoxM40.Checked) Melancolic++;
            checkBoxM40.Checked = false;





			if (checkBoxF1.Checked) Flegmatic++;
            checkBoxF1.Checked = false;    
            if (checkBoxF2.Checked) Flegmatic++;
            checkBoxF2.Checked = false;
            if (checkBoxF3.Checked) Flegmatic++;
            checkBoxF3.Checked = false;
            if (checkBoxF4.Checked) Flegmatic++;
            checkBoxF4.Checked = false;    
            if (checkBoxF5.Checked) Flegmatic++;
            checkBoxF5.Checked = false;    
            if (checkBoxF6.Checked) Flegmatic++;
            checkBoxF6.Checked = false;
            if (checkBoxF7.Checked) Flegmatic++;
            checkBoxF7.Checked = false;
            if (checkBoxF8.Checked) Flegmatic++;
            checkBoxF8.Checked = false;
            if (checkBoxF9.Checked) Flegmatic++;
            checkBoxF9.Checked = false;
            if (checkBoxF10.Checked) Flegmatic++;
            checkBoxF10.Checked = false;    
            if (checkBoxF11.Checked) Flegmatic++;
            checkBoxF11.Checked = false;
            if (checkBoxF12.Checked) Flegmatic++;
            checkBoxF12.Checked = false;
            if (checkBoxF13.Checked) Flegmatic++;
            checkBoxF13.Checked = false;
            if (checkBoxF14.Checked) Flegmatic++;
            checkBoxF14.Checked = false;        
            if (checkBoxF15.Checked) Flegmatic++;
            checkBoxF15.Checked = false;    
            if (checkBoxF16.Checked) Flegmatic++;
            checkBoxF16.Checked = false;
            if (checkBoxF17.Checked) Flegmatic++;
            checkBoxF17.Checked = false;
            if (checkBoxF18.Checked) Flegmatic++;
            checkBoxF18.Checked = false;
            if (checkBoxF19.Checked) Flegmatic++;
            checkBoxF19.Checked = false;    
            if (checkBoxF20.Checked) Flegmatic++;
            checkBoxF20.Checked = false;    
            if (checkBoxF21.Checked) Flegmatic++;
            checkBoxF21.Checked = false;
            if (checkBoxF22.Checked) Flegmatic++;
            checkBoxF22.Checked = false;
            if (checkBoxF23.Checked) Flegmatic++;
            checkBoxF23.Checked = false;
            if (checkBoxF24.Checked) Flegmatic++;
            checkBoxF24.Checked = false;        
            if (checkBoxF25.Checked) Flegmatic++;
            checkBoxF25.Checked = false;    
            if (checkBoxF26.Checked) Flegmatic++;
            checkBoxF26.Checked = false;
            if (checkBoxF27.Checked) Flegmatic++;
            checkBoxF27.Checked = false;
            if (checkBoxF28.Checked) Flegmatic++;
            checkBoxF28.Checked = false;
            if (checkBoxF29.Checked) Flegmatic++;
            checkBoxF29.Checked = false;    
            if (checkBoxF30.Checked) Flegmatic++;
            checkBoxF30.Checked = false;    
            if (checkBoxF31.Checked) Flegmatic++;
            checkBoxF31.Checked = false;
            if (checkBoxF32.Checked) Flegmatic++;
            checkBoxF32.Checked = false;
            if (checkBoxF33.Checked) Flegmatic++;
            checkBoxF33.Checked = false;
            if (checkBoxF34.Checked) Flegmatic++;
            checkBoxF34.Checked = false;        
            if (checkBoxF35.Checked) Flegmatic++;
            checkBoxF35.Checked = false;    
            if (checkBoxF36.Checked) Flegmatic++;
            checkBoxF36.Checked = false;
            if (checkBoxF37.Checked) Flegmatic++;
            checkBoxF37.Checked = false;
            if (checkBoxF38.Checked) Flegmatic++;
            checkBoxF38.Checked = false;
            if (checkBoxF39.Checked) Flegmatic++;
            checkBoxF39.Checked = false;    
            if (checkBoxF40.Checked) Flegmatic++;
            checkBoxF40.Checked = false;
			
            if (Sangvinic>Coleric && Sangvinic>Melancolic && Sangvinic>Flegmatic) {Form_Sangvinic frms=new Form_Sangvinic(); frms.Show();}
            if (Coleric>Sangvinic && Coleric>Melancolic && Coleric>Flegmatic){Form_Coleric frmc=new Form_Coleric(); frmc.Show();}
            if (Melancolic>Sangvinic && Melancolic>Coleric && Melancolic>Flegmatic){Form_Melancolic frmm=new Form_Melancolic(); frmm.Show();}
            if (Flegmatic>Sangvinic && Flegmatic>Coleric && Flegmatic>Melancolic){Form_Flegmatic frmf=new Form_Flegmatic(); frmf.Show();}
            this.Hide();
            this.Close();
		}
	}
}
