// |  Versionsnummer  | Erstell -Datum | -Uhrzeit | erstellt durch | Whats new ???
//---------------------------------------------------------------------------------------------------------------------------------
// | Version 1.071	  | 22.10.03       | 16:00    |	CH			   |  Position_anzeigen
// | Version 1.072    | 22.10.03	   | 19:10    | CSW			   |  keine gro�en �nderungen: kein Zeitverzug beim Datagrid am Anfang / ToolTips f�r die Tabpages und ein paar Felder des Kunden (Mainframe_load)
// | Version 1.073 	  | 23.10.03	   | 01:13    | CSW			   |  Formatierung des Datagrids, �ndern der Positionen im DataGrid, �bernehmen der Daten ins DataGrid - und Kleinigkeiten wie: Anlegen einer Projekt History:-)
// | Version 1.08 	  | 23.10.03	   | 16:13    | Casi	       |  Alle Vorg�ge eines Kunden aus der DB auslesen. + Vorgang einem Kunden zuordenen in der DB 
// | Version 1.09 	  | 24.10.03	   | 16:13    | CH			   |  Vorgang Suche
// | Version 1.10	  | 26.10.03	   | 02:30	  | CSW			   |  DataGrid (L�schen&Bearbeiten) / Fl�che berechnen (Dialog) / 
// | Version 1.101	  | 26.10.03	   | 18:18    | CSW			   |  Mini-Bug-Fix beim DataGrid, Doppelklick auf ZellenRahmen hat jetzt gleichen Effekt wie Doppelklick auf Zeilenkopf (Thx@Casi)
// | Version 1.11	  | 26.10.03	   | 23:41    | CH			   |  Neue ZPositon anlegen
// | Version 1.12	  | 27.10.03	   | 22:53	  | CSW			   |  DateTimePicker eingebaut und VG.Datum entsprechend ge�ndert
// | Version 1.13	  | 29.10.03	   | 09:00	  | CH			   |  CVS System eingef�hrt, keine Erweiterung des eigentlichen Programms						
// | Version 1.14	  | 29.10.03	   | 14:00    | CSW			   |  Listbox zur Auswahl eines Kunden eingef�gt
// | Version 1.15	  | 29.10.03	   | 22:42    | CH			   |  Suche Kunde nach Name gibt jetzt auch mehrere Kunden nur bei teilweiser Eingabe des Namens aus (sorry Casi)
// | Version 1.16	  | 30.10.03	   | 20:00    | CH			   |  ComboBox "Anrede" Anbindung bei Kunde Anzeigen
// | Version 1.17	  | 30.10.03	   | 23:56    | CH			   |  ComboBox "Anrede" wird nun auch in DB geschrieben
// | Version 1.18	  | 03.11.03	   | 22:49    | CH			   |  Fehler korrigiert (Casi)
// | Version 1.19	  | 05.11.03	   | 00:39    | CSW            |  �bersichtstabseite angelegt
// | Version 1.19b    | 05.11.03	   | 21:36    | CSW			   |  Kleinere Korrekturen: Reihenfolge der Tabs; Bezeichnungen der Spalten in den Datagrids; Geldbetr�ge in den DataGrids haben jetzt ein W�hrungsformat (und nur da)
// | Version 1.20	  | 08.11.03	   | 13:01    | CSW            |  Das DataGrid in der �bersicht hat jetzt ein ContextMenu, leider hat dat noch einen Fehler, das Men� verschwindet immer erst nach der 2.Auswahl
// | Version 1.20b	  | 08.11.03	   | 13:34	  | CSW            |  Problem gel�st: W�hrend des EventHandlings muss das Datagrid wohl auf Enabled=false sein, damit dat klappt
// | Version 1.20c	  | 08.11.03	   | 14:42	  | CSW            |  Hab dat eigentliche Problem erkannt: Fehlerhafte Beschreibung im Buch vom Gartner und der MSDN, beide behaupten u.a. es g�be System.Windows.Forms.DataGrid.HitTestInfo.Type, wer dat findet bekommt von mir ein Bier ;-) 
// | Version 1.21	  | 13.11.03	   | 00:42    | CSW			   |  Automatisches Berechnen der Betr�ge (Netto/Brutto) unter Ber�cksichtigung von MwSt und Rabatt, Darstellung im W�hrungsformat, Kleinere �nderungen auf der Positionsseite, Einbinden von "alle_Vorg�nge" in der �bersicht
// | Version 1.22     | 16.11.03	   | 12:30	  | CSW			   |  Filtern der Kunden�bersicht nach Namen (auch Teile, Anfangsbuchstaben etc.)
// | Version 1.22b    | 17.11.03	   | 17:13	  | CSW			   |  Kleine �berarbeitung (Filtern -> Suchen) + Button + MessageBox
// | Version 1.22c    | 17.11.03       | 21:12    | Casi           |  VorgaengeKunden dataSet erweitert um die Kundennamen
// | Version 1.22d    | 18.11.03	   | 13:25	  | CSW			   |  Casi's Erweiterungen erweitert und eingepflegt, die �bersicht ist jetzt fast fertig (nur noch Kontext Men� fehlt)
// | Version 1.23     | 20.11.03	   | 18:18	  | Casi		   |  Erste Druckmethoden eingef�gt
// | Version 1.24	  | 21.11.03	   | 17:34    | CSW			   |  Vorgangsnamen gebastelt und Nachkalkulation vorbereitet
// | Version 1.241    | 22.11.03	   | 12:16	  | Casi		   |  Druckvorschau implementiert
// | Version 1.242a   | 25.11.03	   | 01:25    | CSW            |  Hab dat KontextMen� schon vorbereitet und die �bernahme des Kunden drin, Rest morgen
// | Version 1.242b   | 25.11.03	   | 13:16    | CSW			   |  Position �bernehmen drin, DB (RechPos) ge�ndert
// | Version 1.243    | 25.11.03	   | 19:59    | Casi		   |  DB, Vorname und Nachname in KundeVorgang eingef�gt und DB-Methoden aktualisiert
// | Version 1.244    | 26.11.03	   | 01:32	  | CSW			   |  KontextMen� f�r das Vorgangs-DataGrid fertig, dadruch ge�nderter Workflow beim �ndern&l�schen, einf�gen funktioniert noch nicht so richtig
// | Version 1.244b   | 26.11.03	   | 18:54    | CSW			   |  "alle_Vorgaenge_eines_Kunden_ausgeben()" an die neue DB angepasst, hat er nich automatisch �bernommen.
// | Version 1.245    | 27.11.03	   | 00:14	  | CSW			   |  Ich verzweifel, wenn ich eine neue Zeile einf�ge, erscheint die auch l�sst sich aber nicht bearbeiten
// | Version 1.246    | 01.12.03	   | 18:26	  | CH			   |  Kunde-Funktionalit�t im Menu
// | Version 1.25     | 05.12.03	   | 14:26	  | Casi     	   |  Erste Seite wird gedruckt --noch Fehlerbehaftet
using System;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace Layer8_CSW
{
	/// <summary>
	/// Zusammenfassung f�r Layer8.
	/// </summary>
	public class MainFrame : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		# region Labels
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label28;
		# endregion
		
		#region Buttons
		private System.Windows.Forms.Button button_�bersicht_Vorg�nge_anzeigen;
		private System.Windows.Forms.Button button_Zur�ck;
		private System.Windows.Forms.Button button_Speichern;
		private System.Windows.Forms.Button button_L�schen;
		private System.Windows.Forms.Button button_Neu;
		private System.Windows.Forms.Button button_R�ckgangig;
		private System.Windows.Forms.Button button_Vor;
		private System.Windows.Forms.Button button_XmlLesen;
		private System.Windows.Forms.Button button_XmlSchreiben;
		private System.Windows.Forms.Button button_�bernehmen;
		private System.Windows.Forms.Button button_loeschen;
		private System.Windows.Forms.Button button_Flaeche;
		private System.Windows.Forms.Button Pos_anlegen;
		private System.Windows.Forms.Button pos_Speichern; 
		private System.Windows.Forms.Button button_�bersicht_Pos_Anzeigen;
		private System.Windows.Forms.Button button_�bersicht_alle_Kunden;
		private System.Windows.Forms.Button button_allePositionen;
		private System.Windows.Forms.Button button_�bersicht_Kunden_suchen;
		private System.Windows.Forms.Button button_�bersicht_Vorgang_suchen;
		#endregion

		#region Textboxes
		
		
		private System.Windows.Forms.TextBox txtBox_�bersicht_Kundenauswahl;
		private System.Windows.Forms.TextBox txtBox_�bersicht_Vorgang_suchen;
		private System.Windows.Forms.TextBox txtbox_Name;
		private System.Windows.Forms.TextBox txtbox_Telefonnummer;
		private System.Windows.Forms.TextBox txtbox_PLZ;
		private System.Windows.Forms.TextBox txtbox_Ort;
		private System.Windows.Forms.TextBox txtbox_Strasse;
		private System.Windows.Forms.TextBox txtbox_Vorname;
		private System.Windows.Forms.TextBox txtbox_Kundennummer;
		private System.Windows.Forms.TextBox txtbox_Gesamtpreis;
		private System.Windows.Forms.TextBox txtbox_Fl�che;
		private System.Windows.Forms.TextBox txtbox_Einzelpreis;
		private System.Windows.Forms.TextBox txtbox_Langtext;
		private System.Windows.Forms.TextBox txtbox_Kurztext;
		private System.Windows.Forms.TextBox txtbox_Posnummer;
		private System.Windows.Forms.TextBox txtbox_Raum;
		private System.Windows.Forms.TextBox txtbox_VNummer;
		private System.Windows.Forms.TextBox txtbox_VBezeichnung;
		private System.Windows.Forms.TextBox txtbox_Fax;
		private System.Windows.Forms.TextBox txtbox_Email;
		private System.Windows.Forms.TextBox txtbox_Netto;
		private System.Windows.Forms.TextBox txtbox_Mwst;
		private System.Windows.Forms.TextBox txtbox_Rabatt;
		private System.Windows.Forms.TextBox txtbox_Brutto;
		private System.Windows.Forms.TextBox txtbox_PlzBau;
		private System.Windows.Forms.TextBox txtbox_OrtBau;
		private System.Windows.Forms.TextBox txtbox_StrasseBau;
		private System.Windows.Forms.TextBox txtbox_VornameBau;
		private System.Windows.Forms.TextBox txtbox_NameBau;
		private System.Windows.Forms.TextBox txtBox_realMatKosten;
		private System.Windows.Forms.TextBox txtBox_realLohnKosten;
	
		private System.Windows.Forms.TextBox txtBox_NettoRechbetrag;
		private System.Windows.Forms.TextBox txtBox_realGesamtKosten;
		private System.Windows.Forms.TextBox txtBox_Gewinn;
		private System.Windows.Forms.TextBox txtbox_K�rzel; 
		# endregion

		#region RadioButtons
		private System.Windows.Forms.RadioButton radio_Aufma�;
		private System.Windows.Forms.RadioButton radio_Angebot;
		private System.Windows.Forms.RadioButton radio_Rechnung;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		
		private System.Windows.Forms.RadioButton radio_F;
		private System.Windows.Forms.RadioButton radio_M;
		private System.Windows.Forms.RadioButton radio_Z;
		
		
		#endregion

		#region Formatierungsinformationen f�r das DataGrid
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle4;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyleKunden�bersicht;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn15;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn16;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn17;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn18;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn19;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn20;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn21;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn22;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn23;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn24;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn25;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn26;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn27;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn28;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn29;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn30;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn31;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyleVorgangsview;
		#endregion

		#region Tab
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Positionen;
		private System.Windows.Forms.TabPage Bauvorhaben;
		private System.Windows.Forms.TabPage Kunde;
		private System.Windows.Forms.TabPage Zahlung;
		private System.Windows.Forms.TabPage Nachkalkulation;
		private System.Windows.Forms.TabPage �bersicht;
		#endregion
		
		#region Men�s (Main und Context)
		private System.Windows.Forms.ContextMenu cMenu_KundenDG;
		private System.Windows.Forms.ContextMenu cMenu_VorgangDG;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuDruckenPageSetup;
		private System.Windows.Forms.MenuItem menuDruckenPrint;
		private System.Windows.Forms.MenuItem menuDruckenPrintPreview;
		
		#endregion
		
		#region DataGriddys
		private System.Windows.Forms.DataGrid DG_Nachkalkulation;
		private System.Windows.Forms.DataGrid dataGrid_Vorgang;
		private System.Windows.Forms.DataGrid DG_�bersicht;
		#endregion

		#region Groupboxes
		private System.Windows.Forms.GroupBox gbox_Vorgangstyp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gBox_Kunden�bersicht;
		private System.Windows.Forms.GroupBox gBox_Pos�bersicht;
		private System.Windows.Forms.GroupBox gBox_PosBeschr�nken;
		#endregion

		private System.Windows.Forms.ComboBox cbox_Anrede;
		private System.Windows.Forms.DateTimePicker dateTimePicker_Bau;
		private System.Windows.Forms.ListBox LBox_Kunde;
	
		// Casi's �beraus wichtige Deklarationen du Haufen------------------------------------------
		private Font maintextFont = new Font("times New Roman", 14);
        private Font subTextFont = new Font("Times New Roman" ,12);
		private PageSettings storedPageSettings;
		uint aktuelleSeite;
		int aktuellePos=0;
		int PosAnzahl;
		// ---------------------------------------------------------
		
		public DB UnsereDb;
		public DataView PosView;
		public Vorgang VG;
		private KundenVerzeichnis Verzeichnis;

		public bool bearbeiten_flag = false;
		public bool neuer_Kunde = false;
		public bool position_anlegen = false;
		//public bool position_neu = false;
		public string k�rzelstring;
		public string positionsnummerstring;
		
		private int DG_aktZeile=0;
		
		
			
		
		// CSW: wird im EventHandler von "dataGrid_Vorgang_CurrentCellChanged" benutzt und gibt mir immer denaktuellen Index des Datagrids
		private bool DG_Zeile_bearbeiten;

		//private System.Windows.Forms.ContextMenu cMenu_VorgangDG;   die mussten nach dem CVS mergen rausgenommen werden
		//private System.Windows.Forms.Button button_Speichern;		  die hier auch
		private System.Windows.Forms.Button button_abbrechen;
		private System.Windows.Forms.TextBox txtbox_Einheit;
		private System.Windows.Forms.Label Einheit;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn32;

	


		public enum Ansichtsache {Fliesen, Maurer, Zusatz, Kunden, Vorgang, Noppes };
		public Ansichtsache Ansicht; 

		
		
		public MainFrame()
		{
			//
			// Erforderlich f�r die Windows Form-Designerunterst�tzung
			//
			InitializeComponent();
			//
			// TODO: F�gen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
			
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode f�r die Designerunterst�tzung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor ge�ndert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Configuration.AppSettingsReader configurationAppSettings = new System.Configuration.AppSettingsReader();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainFrame));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Kunde = new System.Windows.Forms.TabPage();
			this.LBox_Kunde = new System.Windows.Forms.ListBox();
			this.label31 = new System.Windows.Forms.Label();
			this.txtbox_Email = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.txtbox_Fax = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.cbox_Anrede = new System.Windows.Forms.ComboBox();
			this.txtbox_Name = new System.Windows.Forms.TextBox();
			this.button_abbrechen = new System.Windows.Forms.Button();
			this.button_Speichern = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtbox_Telefonnummer = new System.Windows.Forms.TextBox();
			this.txtbox_PLZ = new System.Windows.Forms.TextBox();
			this.txtbox_Ort = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtbox_Strasse = new System.Windows.Forms.TextBox();
			this.txtbox_Vorname = new System.Windows.Forms.TextBox();
			this.txtbox_Kundennummer = new System.Windows.Forms.TextBox();
			this.txtbox_K�rzel = new System.Windows.Forms.TextBox();
			this.Positionen = new System.Windows.Forms.TabPage();
			this.button_allePositionen = new System.Windows.Forms.Button();
			this.pos_Speichern = new System.Windows.Forms.Button();
			this.Pos_anlegen = new System.Windows.Forms.Button();
			this.button_Flaeche = new System.Windows.Forms.Button();
			this.button_loeschen = new System.Windows.Forms.Button();
			this.label21 = new System.Windows.Forms.Label();
			this.txtbox_Raum = new System.Windows.Forms.TextBox();
			this.button_�bernehmen = new System.Windows.Forms.Button();
			this.button_XmlSchreiben = new System.Windows.Forms.Button();
			this.button_XmlLesen = new System.Windows.Forms.Button();
			this.dataGrid_Vorgang = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtbox_Gesamtpreis = new System.Windows.Forms.TextBox();
			this.txtbox_Fl�che = new System.Windows.Forms.TextBox();
			this.txtbox_Einzelpreis = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtbox_Langtext = new System.Windows.Forms.TextBox();
			this.txtbox_Kurztext = new System.Windows.Forms.TextBox();
			this.txtbox_Posnummer = new System.Windows.Forms.TextBox();
			this.Zahlung = new System.Windows.Forms.TabPage();
			this.label33 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label28 = new System.Windows.Forms.Label();
			this.txtbox_Netto = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.txtbox_Mwst = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.txtbox_Rabatt = new System.Windows.Forms.TextBox();
			this.txtbox_Brutto = new System.Windows.Forms.TextBox();
			this.Bauvorhaben = new System.Windows.Forms.TabPage();
			this.dateTimePicker_Bau = new System.Windows.Forms.DateTimePicker();
			this.label24 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.txtbox_VNummer = new System.Windows.Forms.TextBox();
			this.txtbox_VBezeichnung = new System.Windows.Forms.TextBox();
			this.gbox_Vorgangstyp = new System.Windows.Forms.GroupBox();
			this.radio_Rechnung = new System.Windows.Forms.RadioButton();
			this.radio_Angebot = new System.Windows.Forms.RadioButton();
			this.radio_Aufma� = new System.Windows.Forms.RadioButton();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtbox_PlzBau = new System.Windows.Forms.TextBox();
			this.txtbox_OrtBau = new System.Windows.Forms.TextBox();
			this.txtbox_StrasseBau = new System.Windows.Forms.TextBox();
			this.txtbox_VornameBau = new System.Windows.Forms.TextBox();
			this.txtbox_NameBau = new System.Windows.Forms.TextBox();
			this.�bersicht = new System.Windows.Forms.TabPage();
			this.DG_�bersicht = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTableStyle4 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTableStyleKunden�bersicht = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn15 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn16 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn17 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn18 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn25 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn21 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn19 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn20 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn22 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn23 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn24 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTableStyleVorgangsview = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn28 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn26 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn29 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn27 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn30 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn31 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.gBox_Pos�bersicht = new System.Windows.Forms.GroupBox();
			this.gBox_PosBeschr�nken = new System.Windows.Forms.GroupBox();
			this.radio_Z = new System.Windows.Forms.RadioButton();
			this.radio_M = new System.Windows.Forms.RadioButton();
			this.radio_F = new System.Windows.Forms.RadioButton();
			this.button_�bersicht_Pos_Anzeigen = new System.Windows.Forms.Button();
			this.gBox_Kunden�bersicht = new System.Windows.Forms.GroupBox();
			this.button_�bersicht_Vorgang_suchen = new System.Windows.Forms.Button();
			this.txtBox_�bersicht_Vorgang_suchen = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.button_�bersicht_Kunden_suchen = new System.Windows.Forms.Button();
			this.label34 = new System.Windows.Forms.Label();
			this.txtBox_�bersicht_Kundenauswahl = new System.Windows.Forms.TextBox();
			this.button_�bersicht_Vorg�nge_anzeigen = new System.Windows.Forms.Button();
			this.button_�bersicht_alle_Kunden = new System.Windows.Forms.Button();
			this.Nachkalkulation = new System.Windows.Forms.TabPage();
			this.txtBox_Gewinn = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.txtBox_NettoRechbetrag = new System.Windows.Forms.TextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.txtBox_realGesamtKosten = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.txtBox_realLohnKosten = new System.Windows.Forms.TextBox();
			this.txtBox_realMatKosten = new System.Windows.Forms.TextBox();
			this.DG_Nachkalkulation = new System.Windows.Forms.DataGrid();
			this.cMenu_KundenDG = new System.Windows.Forms.ContextMenu();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuDruckenPageSetup = new System.Windows.Forms.MenuItem();
			this.menuDruckenPrintPreview = new System.Windows.Forms.MenuItem();
			this.menuDruckenPrint = new System.Windows.Forms.MenuItem();
			this.cMenu_VorgangDG = new System.Windows.Forms.ContextMenu();
			this.txtbox_Einheit = new System.Windows.Forms.TextBox();
			this.Einheit = new System.Windows.Forms.Label();
			this.dataGridTextBoxColumn32 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.Kunde.SuspendLayout();
			this.Positionen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Vorgang)).BeginInit();
			this.Zahlung.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.Bauvorhaben.SuspendLayout();
			this.gbox_Vorgangstyp.SuspendLayout();
			this.�bersicht.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DG_�bersicht)).BeginInit();
			this.gBox_Pos�bersicht.SuspendLayout();
			this.gBox_PosBeschr�nken.SuspendLayout();
			this.gBox_Kunden�bersicht.SuspendLayout();
			this.Nachkalkulation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DG_Nachkalkulation)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.Kunde);
			this.tabControl1.Controls.Add(this.Positionen);
			this.tabControl1.Controls.Add(this.Zahlung);
			this.tabControl1.Controls.Add(this.Bauvorhaben);
			this.tabControl1.Controls.Add(this.�bersicht);
			this.tabControl1.Controls.Add(this.Nachkalkulation);
			this.tabControl1.Location = new System.Drawing.Point(16, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = true;
			this.tabControl1.Size = new System.Drawing.Size(996, 616);
			this.tabControl1.TabIndex = 0;
			// 
			// Kunde
			// 
			this.Kunde.Controls.Add(this.LBox_Kunde);
			this.Kunde.Controls.Add(this.label31);
			this.Kunde.Controls.Add(this.txtbox_Email);
			this.Kunde.Controls.Add(this.label30);
			this.Kunde.Controls.Add(this.txtbox_Fax);
			this.Kunde.Controls.Add(this.label29);
			this.Kunde.Controls.Add(this.cbox_Anrede);
			this.Kunde.Controls.Add(this.txtbox_Name);
			this.Kunde.Controls.Add(this.button_abbrechen);
			this.Kunde.Controls.Add(this.button_Speichern);
			this.Kunde.Controls.Add(this.label8);
			this.Kunde.Controls.Add(this.label7);
			this.Kunde.Controls.Add(this.label6);
			this.Kunde.Controls.Add(this.txtbox_Telefonnummer);
			this.Kunde.Controls.Add(this.txtbox_PLZ);
			this.Kunde.Controls.Add(this.txtbox_Ort);
			this.Kunde.Controls.Add(this.label5);
			this.Kunde.Controls.Add(this.label4);
			this.Kunde.Controls.Add(this.label3);
			this.Kunde.Controls.Add(this.label2);
			this.Kunde.Controls.Add(this.label1);
			this.Kunde.Controls.Add(this.txtbox_Strasse);
			this.Kunde.Controls.Add(this.txtbox_Vorname);
			this.Kunde.Controls.Add(this.txtbox_Kundennummer);
			this.Kunde.Controls.Add(this.txtbox_K�rzel);
			this.Kunde.Location = new System.Drawing.Point(4, 22);
			this.Kunde.Name = "Kunde";
			this.Kunde.Size = new System.Drawing.Size(988, 590);
			this.Kunde.TabIndex = 0;
			this.Kunde.Text = "Kunde";
			this.Kunde.ToolTipText = "Das ist unser Kunde und der Kunde ist K�nig!";
			// 
			// LBox_Kunde
			// 
			this.LBox_Kunde.Location = new System.Drawing.Point(40, 344);
			this.LBox_Kunde.Name = "LBox_Kunde";
			this.LBox_Kunde.Size = new System.Drawing.Size(440, 121);
			this.LBox_Kunde.TabIndex = 30;
			this.LBox_Kunde.Visible = false;
			this.LBox_Kunde.DoubleClick += new System.EventHandler(this.LBox_Kunde_DoubleClick);
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(304, 304);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(88, 23);
			this.label31.TabIndex = 28;
			this.label31.Text = "eMail";
			// 
			// txtbox_Email
			// 
			this.txtbox_Email.Location = new System.Drawing.Point(392, 304);
			this.txtbox_Email.Name = "txtbox_Email";
			this.txtbox_Email.ReadOnly = true;
			this.txtbox_Email.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Email.TabIndex = 8;
			this.txtbox_Email.Text = "";
			this.txtbox_Email.Leave += new System.EventHandler(this.txtbox_Email_Leave);
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(536, 256);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(88, 23);
			this.label30.TabIndex = 26;
			this.label30.Text = "Fax";
			// 
			// txtbox_Fax
			// 
			this.txtbox_Fax.Location = new System.Drawing.Point(624, 256);
			this.txtbox_Fax.Name = "txtbox_Fax";
			this.txtbox_Fax.ReadOnly = true;
			this.txtbox_Fax.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Fax.TabIndex = 7;
			this.txtbox_Fax.Text = "";
			this.txtbox_Fax.Leave += new System.EventHandler(this.txtbox_Fax_Leave);
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(304, 32);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(80, 23);
			this.label29.TabIndex = 24;
			this.label29.Text = "Anrede";
			// 
			// cbox_Anrede
			// 
			this.cbox_Anrede.Items.AddRange(new object[] {
															 "Herr",
															 "Frau",
															 "Firma"});
			this.cbox_Anrede.Location = new System.Drawing.Point(392, 32);
			this.cbox_Anrede.Name = "cbox_Anrede";
			this.cbox_Anrede.Size = new System.Drawing.Size(104, 21);
			this.cbox_Anrede.TabIndex = 23;
			this.cbox_Anrede.Text = "Herr";
			this.cbox_Anrede.Leave += new System.EventHandler(this.cbox_Anrede_Leave);
			// 
			// txtbox_Name
			// 
			this.txtbox_Name.Location = new System.Drawing.Point(392, 80);
			this.txtbox_Name.Name = "txtbox_Name";
			this.txtbox_Name.ReadOnly = true;
			this.txtbox_Name.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Name.TabIndex = 1;
			this.txtbox_Name.Text = "";
			this.txtbox_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtbox_Name_MouseDown);
			this.txtbox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Name_KeyPress);
			this.txtbox_Name.Leave += new System.EventHandler(this.txtbox_Name_Leave);
			// 
			// button_abbrechen
			// 
			this.button_abbrechen.Location = new System.Drawing.Point(136, 168);
			this.button_abbrechen.Name = "button_abbrechen";
			this.button_abbrechen.TabIndex = 11;
			this.button_abbrechen.Text = "Abbrechen";
			this.button_abbrechen.Visible = false;
			this.button_abbrechen.Click += new System.EventHandler(this.button_abbrechen_Click);
			// 
			// button_Speichern
			// 
			this.button_Speichern.Location = new System.Drawing.Point(32, 168);
			this.button_Speichern.Name = "button_Speichern";
			this.button_Speichern.TabIndex = 10;
			this.button_Speichern.Text = "Speichern";
			this.button_Speichern.Visible = false;
			this.button_Speichern.Click += new System.EventHandler(this.button_Speichern_Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(304, 256);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Telefonnummer";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(304, 192);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 14;
			this.label7.Text = "PLZ";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(536, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 23);
			this.label6.TabIndex = 13;
			this.label6.Text = "Ort";
			// 
			// txtbox_Telefonnummer
			// 
			this.txtbox_Telefonnummer.Location = new System.Drawing.Point(392, 256);
			this.txtbox_Telefonnummer.Name = "txtbox_Telefonnummer";
			this.txtbox_Telefonnummer.ReadOnly = true;
			this.txtbox_Telefonnummer.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Telefonnummer.TabIndex = 6;
			this.txtbox_Telefonnummer.Text = "";
			this.txtbox_Telefonnummer.Leave += new System.EventHandler(this.txtbox_Telefonnummer_Leave);
			// 
			// txtbox_PLZ
			// 
			this.txtbox_PLZ.Location = new System.Drawing.Point(392, 192);
			this.txtbox_PLZ.Name = "txtbox_PLZ";
			this.txtbox_PLZ.ReadOnly = true;
			this.txtbox_PLZ.Size = new System.Drawing.Size(104, 20);
			this.txtbox_PLZ.TabIndex = 5;
			this.txtbox_PLZ.Text = "";
			this.txtbox_PLZ.Leave += new System.EventHandler(this.txtbox_PLZ_Leave);
			// 
			// txtbox_Ort
			// 
			this.txtbox_Ort.Location = new System.Drawing.Point(624, 144);
			this.txtbox_Ort.Name = "txtbox_Ort";
			this.txtbox_Ort.ReadOnly = true;
			this.txtbox_Ort.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Ort.TabIndex = 4;
			this.txtbox_Ort.Text = "";
			this.txtbox_Ort.Leave += new System.EventHandler(this.txtbox_Ort_Leave);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(304, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Strasse";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(536, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Vorname";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(304, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Kundennummer";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "K�rzel";
			// 
			// txtbox_Strasse
			// 
			this.txtbox_Strasse.Location = new System.Drawing.Point(392, 144);
			this.txtbox_Strasse.Name = "txtbox_Strasse";
			this.txtbox_Strasse.ReadOnly = true;
			this.txtbox_Strasse.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Strasse.TabIndex = 3;
			this.txtbox_Strasse.Text = "";
			this.txtbox_Strasse.Leave += new System.EventHandler(this.txtbox_Strasse_Leave);
			// 
			// txtbox_Vorname
			// 
			this.txtbox_Vorname.Location = new System.Drawing.Point(624, 80);
			this.txtbox_Vorname.Name = "txtbox_Vorname";
			this.txtbox_Vorname.ReadOnly = true;
			this.txtbox_Vorname.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Vorname.TabIndex = 2;
			this.txtbox_Vorname.Text = "";
			this.txtbox_Vorname.Leave += new System.EventHandler(this.txtbox_Vorname_Leave);
			// 
			// txtbox_Kundennummer
			// 
			this.txtbox_Kundennummer.Location = new System.Drawing.Point(112, 80);
			this.txtbox_Kundennummer.Name = "txtbox_Kundennummer";
			this.txtbox_Kundennummer.ReadOnly = true;
			this.txtbox_Kundennummer.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Kundennummer.TabIndex = 16;
			this.txtbox_Kundennummer.Text = "";
			this.txtbox_Kundennummer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtbox_Kundennummer_MouseDown);
			// 
			// txtbox_K�rzel
			// 
			this.txtbox_K�rzel.Location = new System.Drawing.Point(112, 32);
			this.txtbox_K�rzel.Name = "txtbox_K�rzel";
			this.txtbox_K�rzel.ReadOnly = true;
			this.txtbox_K�rzel.Size = new System.Drawing.Size(104, 20);
			this.txtbox_K�rzel.TabIndex = 0;
			this.txtbox_K�rzel.Text = "";
			this.txtbox_K�rzel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtbox_K�rzel_MouseDown);
			this.txtbox_K�rzel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_K�rzel_KeyPress);
			this.txtbox_K�rzel.TextChanged += new System.EventHandler(this.txtbox_K�rzel_TextChanged);
			this.txtbox_K�rzel.Leave += new System.EventHandler(this.txtbox_K�rzel_Leave);
			// 
			// Positionen
			// 
			this.Positionen.Controls.Add(this.Einheit);
			this.Positionen.Controls.Add(this.txtbox_Einheit);
			this.Positionen.Controls.Add(this.button_allePositionen);
			this.Positionen.Controls.Add(this.pos_Speichern);
			this.Positionen.Controls.Add(this.Pos_anlegen);
			this.Positionen.Controls.Add(this.button_Flaeche);
			this.Positionen.Controls.Add(this.button_loeschen);
			this.Positionen.Controls.Add(this.label21);
			this.Positionen.Controls.Add(this.txtbox_Raum);
			this.Positionen.Controls.Add(this.button_�bernehmen);
			this.Positionen.Controls.Add(this.button_XmlSchreiben);
			this.Positionen.Controls.Add(this.button_XmlLesen);
			this.Positionen.Controls.Add(this.dataGrid_Vorgang);
			this.Positionen.Controls.Add(this.label15);
			this.Positionen.Controls.Add(this.label14);
			this.Positionen.Controls.Add(this.label13);
			this.Positionen.Controls.Add(this.txtbox_Gesamtpreis);
			this.Positionen.Controls.Add(this.txtbox_Fl�che);
			this.Positionen.Controls.Add(this.txtbox_Einzelpreis);
			this.Positionen.Controls.Add(this.label12);
			this.Positionen.Controls.Add(this.label11);
			this.Positionen.Controls.Add(this.label9);
			this.Positionen.Controls.Add(this.txtbox_Langtext);
			this.Positionen.Controls.Add(this.txtbox_Kurztext);
			this.Positionen.Controls.Add(this.txtbox_Posnummer);
			this.Positionen.Location = new System.Drawing.Point(4, 22);
			this.Positionen.Name = "Positionen";
			this.Positionen.Size = new System.Drawing.Size(988, 590);
			this.Positionen.TabIndex = 1;
			this.Positionen.Text = "Positionen";
			this.Positionen.ToolTipText = "Hier finden sich die Rechnungspositionen";
			// 
			// button_allePositionen
			// 
			this.button_allePositionen.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button_allePositionen.Location = new System.Drawing.Point(136, 40);
			this.button_allePositionen.Name = "button_allePositionen";
			this.button_allePositionen.Size = new System.Drawing.Size(30, 20);
			this.button_allePositionen.TabIndex = 24;
			this.button_allePositionen.Text = "...";
			this.button_allePositionen.Click += new System.EventHandler(this.button_allePositionen_Click);
			// 
			// pos_Speichern
			// 
			this.pos_Speichern.Location = new System.Drawing.Point(856, 160);
			this.pos_Speichern.Name = "pos_Speichern";
			this.pos_Speichern.TabIndex = 23;
			this.pos_Speichern.Text = "Speichern";
			this.pos_Speichern.Click += new System.EventHandler(this.pos_Speichern_Click);
			// 
			// Pos_anlegen
			// 
			this.Pos_anlegen.Location = new System.Drawing.Point(744, 160);
			this.Pos_anlegen.Name = "Pos_anlegen";
			this.Pos_anlegen.Size = new System.Drawing.Size(88, 23);
			this.Pos_anlegen.TabIndex = 22;
			this.Pos_anlegen.Text = "Neue Position";
			this.Pos_anlegen.Click += new System.EventHandler(this.Pos_anlegen_Click);
			// 
			// button_Flaeche
			// 
			this.button_Flaeche.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.button_Flaeche.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button_Flaeche.Location = new System.Drawing.Point(176, 112);
			this.button_Flaeche.Name = "button_Flaeche";
			this.button_Flaeche.Size = new System.Drawing.Size(30, 20);
			this.button_Flaeche.TabIndex = 21;
			this.button_Flaeche.Text = "...";
			this.button_Flaeche.Click += new System.EventHandler(this.txtbox_Fl�che_DoubleClick);
			// 
			// button_loeschen
			// 
			this.button_loeschen.Location = new System.Drawing.Point(512, 144);
			this.button_loeschen.Name = "button_loeschen";
			this.button_loeschen.Size = new System.Drawing.Size(120, 24);
			this.button_loeschen.TabIndex = 20;
			this.button_loeschen.Text = "Position l�schen";
			this.button_loeschen.Visible = false;
			this.button_loeschen.Click += new System.EventHandler(this.button_loeschen_Click);
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(48, 144);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(48, 24);
			this.label21.TabIndex = 19;
			this.label21.Text = "Raum:";
			// 
			// txtbox_Raum
			// 
			this.txtbox_Raum.Location = new System.Drawing.Point(104, 144);
			this.txtbox_Raum.Name = "txtbox_Raum";
			this.txtbox_Raum.Size = new System.Drawing.Size(200, 20);
			this.txtbox_Raum.TabIndex = 6;
			this.txtbox_Raum.Text = "";
			// 
			// button_�bernehmen
			// 
			this.button_�bernehmen.Location = new System.Drawing.Point(378, 144);
			this.button_�bernehmen.Name = "button_�bernehmen";
			this.button_�bernehmen.Size = new System.Drawing.Size(112, 23);
			this.button_�bernehmen.TabIndex = 7;
			this.button_�bernehmen.Text = "�bernehmen";
			this.button_�bernehmen.Click += new System.EventHandler(this.button_�bernehmen_Click);
			// 
			// button_XmlSchreiben
			// 
			this.button_XmlSchreiben.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_XmlSchreiben.Location = new System.Drawing.Point(168, 552);
			this.button_XmlSchreiben.Name = "button_XmlSchreiben";
			this.button_XmlSchreiben.Size = new System.Drawing.Size(96, 23);
			this.button_XmlSchreiben.TabIndex = 16;
			this.button_XmlSchreiben.Text = "XML Schreiben";
			this.button_XmlSchreiben.Click += new System.EventHandler(this.button_XmlSchreiben_Click);
			// 
			// button_XmlLesen
			// 
			this.button_XmlLesen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button_XmlLesen.Location = new System.Drawing.Point(48, 552);
			this.button_XmlLesen.Name = "button_XmlLesen";
			this.button_XmlLesen.Size = new System.Drawing.Size(96, 23);
			this.button_XmlLesen.TabIndex = 15;
			this.button_XmlLesen.Text = "XML Lesen";
			this.button_XmlLesen.Click += new System.EventHandler(this.button_XmlLesen_Click);
			// 
			// dataGrid_Vorgang
			// 
			this.dataGrid_Vorgang.AllowNavigation = false;
			this.dataGrid_Vorgang.AllowSorting = false;
			this.dataGrid_Vorgang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGrid_Vorgang.BackColor = System.Drawing.Color.DarkRed;
			this.dataGrid_Vorgang.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
			this.dataGrid_Vorgang.CaptionText = "Die Positionsliste";
			this.dataGrid_Vorgang.DataMember = "";
			this.dataGrid_Vorgang.Enabled = false;
			this.dataGrid_Vorgang.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid_Vorgang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dataGrid_Vorgang.Location = new System.Drawing.Point(14, 216);
			this.dataGrid_Vorgang.Name = "dataGrid_Vorgang";
			this.dataGrid_Vorgang.PreferredRowHeight = 18;
			this.dataGrid_Vorgang.Size = new System.Drawing.Size(964, 328);
			this.dataGrid_Vorgang.TabIndex = 14;
			this.dataGrid_Vorgang.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																										 this.dataGridTableStyle2});
			this.dataGrid_Vorgang.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGrid_Vorgang_MouseUp);
			this.dataGrid_Vorgang.CurrentCellChanged += new System.EventHandler(this.dataGrid_Vorgang_CurrentCellChanged);
			// 
			// dataGridTableStyle2
			// 
			this.dataGridTableStyle2.AllowSorting = false;
			this.dataGridTableStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.dataGridTableStyle2.DataGrid = this.dataGrid_Vorgang;
			this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn3,
																												  this.dataGridTextBoxColumn4,
																												  this.dataGridTextBoxColumn5,
																												  this.dataGridTextBoxColumn6,
																												  this.dataGridTextBoxColumn32,
																												  this.dataGridTextBoxColumn7});
			this.dataGridTableStyle2.GridLineColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridTableStyle2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle2.MappingName = "Positionen";
			this.dataGridTableStyle2.PreferredRowHeight = 20;
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "Raum";
			this.dataGridTextBoxColumn1.MappingName = "Raum";
			this.dataGridTextBoxColumn1.Width = 95;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "Position";
			this.dataGridTextBoxColumn2.MappingName = "Position";
			this.dataGridTextBoxColumn2.Width = 50;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "Kurztext";
			this.dataGridTextBoxColumn3.MappingName = "Kurztext";
			this.dataGridTextBoxColumn3.Width = 180;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "Langtext";
			this.dataGridTextBoxColumn4.MappingName = "Langtext";
			this.dataGridTextBoxColumn4.Width = 365;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumn5.Format = "C";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "Preis/Einheit";
			this.dataGridTextBoxColumn5.MappingName = "Preis/Einheit";
			this.dataGridTextBoxColumn5.Width = 73;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumn6.Format = "";
			this.dataGridTextBoxColumn6.FormatInfo = null;
			this.dataGridTextBoxColumn6.HeaderText = "Fl�che / Anzahl";
			this.dataGridTextBoxColumn6.MappingName = "Fl�che";
			this.dataGridTextBoxColumn6.Width = 73;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumn7.Format = "C";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.HeaderText = "Gesamtpreis";
			this.dataGridTextBoxColumn7.MappingName = "Gesamtpreis";
			this.dataGridTextBoxColumn7.Width = 73;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(383, 85);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 19);
			this.label15.TabIndex = 13;
			this.label15.Text = "Gesamtpreis";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(104, 88);
			this.label14.Name = "label14";
			this.label14.TabIndex = 12;
			this.label14.Text = "Fl�che/Menge";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 88);
			this.label13.Name = "label13";
			this.label13.TabIndex = 11;
			this.label13.Text = "Einzelpreis";
			// 
			// txtbox_Gesamtpreis
			// 
			this.txtbox_Gesamtpreis.Location = new System.Drawing.Point(379, 112);
			this.txtbox_Gesamtpreis.Name = "txtbox_Gesamtpreis";
			this.txtbox_Gesamtpreis.ReadOnly = true;
			this.txtbox_Gesamtpreis.Size = new System.Drawing.Size(112, 20);
			this.txtbox_Gesamtpreis.TabIndex = 10;
			this.txtbox_Gesamtpreis.Text = "";
			// 
			// txtbox_Fl�che
			// 
			this.txtbox_Fl�che.Location = new System.Drawing.Point(104, 112);
			this.txtbox_Fl�che.Name = "txtbox_Fl�che";
			this.txtbox_Fl�che.Size = new System.Drawing.Size(72, 20);
			this.txtbox_Fl�che.TabIndex = 5;
			this.txtbox_Fl�che.Text = "";
			this.txtbox_Fl�che.DoubleClick += new System.EventHandler(this.txtbox_Fl�che_DoubleClick);
			this.txtbox_Fl�che.Leave += new System.EventHandler(this.txtbox_Fl�che_Leave);
			// 
			// txtbox_Einzelpreis
			// 
			this.txtbox_Einzelpreis.Location = new System.Drawing.Point(16, 112);
			this.txtbox_Einzelpreis.Name = "txtbox_Einzelpreis";
			this.txtbox_Einzelpreis.ReadOnly = true;
			this.txtbox_Einzelpreis.Size = new System.Drawing.Size(72, 20);
			this.txtbox_Einzelpreis.TabIndex = 4;
			this.txtbox_Einzelpreis.Text = "";
			this.txtbox_Einzelpreis.Leave += new System.EventHandler(this.txtbox_Einzelpreis_Leave);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(480, 16);
			this.label12.Name = "label12";
			this.label12.TabIndex = 7;
			this.label12.Text = "Langtext";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(176, 16);
			this.label11.Name = "label11";
			this.label11.TabIndex = 6;
			this.label11.Text = "Kurztext";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(48, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(128, 23);
			this.label9.TabIndex = 4;
			this.label9.Text = "Pos.Art / Pos.Nummer";
			// 
			// txtbox_Langtext
			// 
			this.txtbox_Langtext.Location = new System.Drawing.Point(512, 40);
			this.txtbox_Langtext.Multiline = true;
			this.txtbox_Langtext.Name = "txtbox_Langtext";
			this.txtbox_Langtext.ReadOnly = true;
			this.txtbox_Langtext.Size = new System.Drawing.Size(448, 88);
			this.txtbox_Langtext.TabIndex = 3;
			this.txtbox_Langtext.Text = "";
			// 
			// txtbox_Kurztext
			// 
			this.txtbox_Kurztext.Location = new System.Drawing.Point(184, 40);
			this.txtbox_Kurztext.Name = "txtbox_Kurztext";
			this.txtbox_Kurztext.ReadOnly = true;
			this.txtbox_Kurztext.Size = new System.Drawing.Size(312, 20);
			this.txtbox_Kurztext.TabIndex = 2;
			this.txtbox_Kurztext.Text = "";
			// 
			// txtbox_Posnummer
			// 
			this.txtbox_Posnummer.Location = new System.Drawing.Point(24, 40);
			this.txtbox_Posnummer.Name = "txtbox_Posnummer";
			this.txtbox_Posnummer.Size = new System.Drawing.Size(112, 20);
			this.txtbox_Posnummer.TabIndex = 1;
			this.txtbox_Posnummer.Tag = "Yo Man";
			this.txtbox_Posnummer.Text = "";
			this.txtbox_Posnummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Posnummer_KeyPress);
			this.txtbox_Posnummer.Leave += new System.EventHandler(this.txtbox_Posnummer_Leave);
			// 
			// Zahlung
			// 
			this.Zahlung.Controls.Add(this.label33);
			this.Zahlung.Controls.Add(this.label10);
			this.Zahlung.Controls.Add(this.label32);
			this.Zahlung.Controls.Add(this.groupBox1);
			this.Zahlung.Controls.Add(this.label28);
			this.Zahlung.Controls.Add(this.txtbox_Netto);
			this.Zahlung.Controls.Add(this.label25);
			this.Zahlung.Controls.Add(this.txtbox_Mwst);
			this.Zahlung.Controls.Add(this.label26);
			this.Zahlung.Controls.Add(this.label27);
			this.Zahlung.Controls.Add(this.txtbox_Rabatt);
			this.Zahlung.Controls.Add(this.txtbox_Brutto);
			this.Zahlung.Location = new System.Drawing.Point(4, 22);
			this.Zahlung.Name = "Zahlung";
			this.Zahlung.Size = new System.Drawing.Size(988, 590);
			this.Zahlung.TabIndex = 3;
			this.Zahlung.Text = "Zahlung";
			// 
			// label33
			// 
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label33.Location = new System.Drawing.Point(384, 104);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(32, 24);
			this.label33.TabIndex = 40;
			this.label33.Text = "%";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(384, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 24);
			this.label10.TabIndex = 39;
			this.label10.Text = "%";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(244, 124);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(184, 14);
			this.label32.TabIndex = 38;
			this.label32.Text = "============================";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(24, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(160, 128);
			this.groupBox1.TabIndex = 37;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Zahlungszeitraum";
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(32, 88);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "3 Monate";
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Location = new System.Drawing.Point(32, 56);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "4 Wochen";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(32, 24);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.Text = "14 Tage";
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(240, 40);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 23);
			this.label28.TabIndex = 36;
			this.label28.Text = "Netto";
			// 
			// txtbox_Netto
			// 
			this.txtbox_Netto.Location = new System.Drawing.Point(312, 40);
			this.txtbox_Netto.Name = "txtbox_Netto";
			this.txtbox_Netto.ReadOnly = true;
			this.txtbox_Netto.TabIndex = 35;
			this.txtbox_Netto.Text = "";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(240, 104);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(72, 23);
			this.label25.TabIndex = 34;
			this.label25.Text = "MwSt.";
			// 
			// txtbox_Mwst
			// 
			this.txtbox_Mwst.Location = new System.Drawing.Point(312, 104);
			this.txtbox_Mwst.Name = "txtbox_Mwst";
			this.txtbox_Mwst.Size = new System.Drawing.Size(64, 20);
			this.txtbox_Mwst.TabIndex = 33;
			this.txtbox_Mwst.Text = "";
			this.txtbox_Mwst.Leave += new System.EventHandler(this.txtbox_Mwst_Leave);
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(240, 72);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(56, 23);
			this.label26.TabIndex = 32;
			this.label26.Text = "Rabatt";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(240, 144);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(56, 23);
			this.label27.TabIndex = 31;
			this.label27.Text = "Brutto";
			// 
			// txtbox_Rabatt
			// 
			this.txtbox_Rabatt.Location = new System.Drawing.Point(312, 72);
			this.txtbox_Rabatt.Name = "txtbox_Rabatt";
			this.txtbox_Rabatt.Size = new System.Drawing.Size(64, 20);
			this.txtbox_Rabatt.TabIndex = 30;
			this.txtbox_Rabatt.Text = "";
			this.txtbox_Rabatt.Leave += new System.EventHandler(this.txtbox_Rabatt_Leave);
			// 
			// txtbox_Brutto
			// 
			this.txtbox_Brutto.Location = new System.Drawing.Point(312, 144);
			this.txtbox_Brutto.Name = "txtbox_Brutto";
			this.txtbox_Brutto.ReadOnly = true;
			this.txtbox_Brutto.TabIndex = 29;
			this.txtbox_Brutto.Text = "";
			// 
			// Bauvorhaben
			// 
			this.Bauvorhaben.Controls.Add(this.dateTimePicker_Bau);
			this.Bauvorhaben.Controls.Add(this.label24);
			this.Bauvorhaben.Controls.Add(this.label22);
			this.Bauvorhaben.Controls.Add(this.label23);
			this.Bauvorhaben.Controls.Add(this.txtbox_VNummer);
			this.Bauvorhaben.Controls.Add(this.txtbox_VBezeichnung);
			this.Bauvorhaben.Controls.Add(this.gbox_Vorgangstyp);
			this.Bauvorhaben.Controls.Add(this.label20);
			this.Bauvorhaben.Controls.Add(this.label19);
			this.Bauvorhaben.Controls.Add(this.label18);
			this.Bauvorhaben.Controls.Add(this.label17);
			this.Bauvorhaben.Controls.Add(this.label16);
			this.Bauvorhaben.Controls.Add(this.txtbox_PlzBau);
			this.Bauvorhaben.Controls.Add(this.txtbox_OrtBau);
			this.Bauvorhaben.Controls.Add(this.txtbox_StrasseBau);
			this.Bauvorhaben.Controls.Add(this.txtbox_VornameBau);
			this.Bauvorhaben.Controls.Add(this.txtbox_NameBau);
			this.Bauvorhaben.Location = new System.Drawing.Point(4, 22);
			this.Bauvorhaben.Name = "Bauvorhaben";
			this.Bauvorhaben.Size = new System.Drawing.Size(988, 590);
			this.Bauvorhaben.TabIndex = 2;
			this.Bauvorhaben.Text = "Bauvorhaben";
			this.Bauvorhaben.ToolTipText = "Hier stehen die genauen Angaben zum Bauvorhaben wie z.B. Adresse, Name etc";
			// 
			// dateTimePicker_Bau
			// 
			this.dateTimePicker_Bau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker_Bau.Location = new System.Drawing.Point(112, 192);
			this.dateTimePicker_Bau.Name = "dateTimePicker_Bau";
			this.dateTimePicker_Bau.Size = new System.Drawing.Size(104, 20);
			this.dateTimePicker_Bau.TabIndex = 17;
			this.dateTimePicker_Bau.ValueChanged += new System.EventHandler(this.dateTimePicker_Bau_ValueChanged);
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(32, 192);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(72, 23);
			this.label24.TabIndex = 16;
			this.label24.Text = "Datum";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(208, 64);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(96, 23);
			this.label22.TabIndex = 14;
			this.label22.Text = "Vorgangsnummer";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(208, 104);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(120, 23);
			this.label23.TabIndex = 13;
			this.label23.Text = "Vorgangsbezeichnung";
			// 
			// txtbox_VNummer
			// 
			this.txtbox_VNummer.Location = new System.Drawing.Point(336, 64);
			this.txtbox_VNummer.Name = "txtbox_VNummer";
			this.txtbox_VNummer.TabIndex = 12;
			this.txtbox_VNummer.Text = "";
			// 
			// txtbox_VBezeichnung
			// 
			this.txtbox_VBezeichnung.Location = new System.Drawing.Point(336, 104);
			this.txtbox_VBezeichnung.Name = "txtbox_VBezeichnung";
			this.txtbox_VBezeichnung.TabIndex = 11;
			this.txtbox_VBezeichnung.Text = "";
			this.txtbox_VBezeichnung.Leave += new System.EventHandler(this.txtbox_VBezeichnung_Leave);
			// 
			// gbox_Vorgangstyp
			// 
			this.gbox_Vorgangstyp.Controls.Add(this.radio_Rechnung);
			this.gbox_Vorgangstyp.Controls.Add(this.radio_Angebot);
			this.gbox_Vorgangstyp.Controls.Add(this.radio_Aufma�);
			this.gbox_Vorgangstyp.Location = new System.Drawing.Point(32, 32);
			this.gbox_Vorgangstyp.Name = "gbox_Vorgangstyp";
			this.gbox_Vorgangstyp.Size = new System.Drawing.Size(144, 128);
			this.gbox_Vorgangstyp.TabIndex = 10;
			this.gbox_Vorgangstyp.TabStop = false;
			this.gbox_Vorgangstyp.Text = "Vorgangstyp";
			// 
			// radio_Rechnung
			// 
			this.radio_Rechnung.Location = new System.Drawing.Point(24, 80);
			this.radio_Rechnung.Name = "radio_Rechnung";
			this.radio_Rechnung.TabIndex = 2;
			this.radio_Rechnung.Text = "Rechnung";
			this.radio_Rechnung.CheckedChanged += new System.EventHandler(this.radio_Rechnung_CheckedChanged);
			// 
			// radio_Angebot
			// 
			this.radio_Angebot.Checked = true;
			this.radio_Angebot.Location = new System.Drawing.Point(24, 56);
			this.radio_Angebot.Name = "radio_Angebot";
			this.radio_Angebot.TabIndex = 1;
			this.radio_Angebot.TabStop = true;
			this.radio_Angebot.Text = "Angebot";
			this.radio_Angebot.CheckedChanged += new System.EventHandler(this.radio_Angebot_CheckedChanged);
			// 
			// radio_Aufma�
			// 
			this.radio_Aufma�.Location = new System.Drawing.Point(24, 32);
			this.radio_Aufma�.Name = "radio_Aufma�";
			this.radio_Aufma�.TabIndex = 0;
			this.radio_Aufma�.Text = "Aufma�";
			this.radio_Aufma�.CheckedChanged += new System.EventHandler(this.radio_Aufma�_CheckedChanged);
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(32, 272);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(72, 23);
			this.label20.TabIndex = 9;
			this.label20.Text = "Vorname";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(32, 232);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(72, 23);
			this.label19.TabIndex = 8;
			this.label19.Text = "Name";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(32, 352);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(72, 23);
			this.label18.TabIndex = 7;
			this.label18.Text = "PLZ";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(32, 392);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(72, 23);
			this.label17.TabIndex = 6;
			this.label17.Text = "Ort";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(32, 312);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(64, 23);
			this.label16.TabIndex = 5;
			this.label16.Text = "Strasse";
			// 
			// txtbox_PlzBau
			// 
			this.txtbox_PlzBau.Location = new System.Drawing.Point(112, 352);
			this.txtbox_PlzBau.Name = "txtbox_PlzBau";
			this.txtbox_PlzBau.TabIndex = 4;
			this.txtbox_PlzBau.Text = "";
			// 
			// txtbox_OrtBau
			// 
			this.txtbox_OrtBau.Location = new System.Drawing.Point(112, 392);
			this.txtbox_OrtBau.Name = "txtbox_OrtBau";
			this.txtbox_OrtBau.TabIndex = 3;
			this.txtbox_OrtBau.Text = "";
			// 
			// txtbox_StrasseBau
			// 
			this.txtbox_StrasseBau.Location = new System.Drawing.Point(112, 312);
			this.txtbox_StrasseBau.Name = "txtbox_StrasseBau";
			this.txtbox_StrasseBau.TabIndex = 2;
			this.txtbox_StrasseBau.Text = "";
			// 
			// txtbox_VornameBau
			// 
			this.txtbox_VornameBau.Location = new System.Drawing.Point(112, 272);
			this.txtbox_VornameBau.Name = "txtbox_VornameBau";
			this.txtbox_VornameBau.TabIndex = 1;
			this.txtbox_VornameBau.Text = "";
			// 
			// txtbox_NameBau
			// 
			this.txtbox_NameBau.Location = new System.Drawing.Point(112, 232);
			this.txtbox_NameBau.Name = "txtbox_NameBau";
			this.txtbox_NameBau.TabIndex = 0;
			this.txtbox_NameBau.Text = "";
			// 
			// �bersicht
			// 
			this.�bersicht.Controls.Add(this.DG_�bersicht);
			this.�bersicht.Controls.Add(this.gBox_Pos�bersicht);
			this.�bersicht.Controls.Add(this.gBox_Kunden�bersicht);
			this.�bersicht.Location = new System.Drawing.Point(4, 22);
			this.�bersicht.Name = "�bersicht";
			this.�bersicht.Size = new System.Drawing.Size(988, 590);
			this.�bersicht.TabIndex = 4;
			this.�bersicht.Text = "�bersicht";
			// 
			// DG_�bersicht
			// 
			this.DG_�bersicht.DataMember = "";
			this.DG_�bersicht.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DG_�bersicht.Location = new System.Drawing.Point(24, 160);
			this.DG_�bersicht.Name = "DG_�bersicht";
			this.DG_�bersicht.ReadOnly = true;
			this.DG_�bersicht.Size = new System.Drawing.Size(960, 416);
			this.DG_�bersicht.TabIndex = 2;
			this.DG_�bersicht.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									 this.dataGridTableStyle1,
																									 this.dataGridTableStyle3,
																									 this.dataGridTableStyle4,
																									 this.dataGridTableStyleKunden�bersicht,
																									 this.dataGridTableStyleVorgangsview});
			this.DG_�bersicht.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DG_�bersicht_MouseUp);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.DG_�bersicht;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn8,
																												  this.dataGridTextBoxColumn9,
																												  this.dataGridTextBoxColumn10,
																												  this.dataGridTextBoxColumn11,
																												  this.dataGridTextBoxColumn12,
																												  this.dataGridTextBoxColumn13,
																												  this.dataGridTextBoxColumn14});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "MPos";
			// 
			// dataGridTextBoxColumn8
			// 
			this.dataGridTextBoxColumn8.Format = "";
			this.dataGridTextBoxColumn8.FormatInfo = null;
			this.dataGridTextBoxColumn8.HeaderText = ((string)(configurationAppSettings.GetValue("dataGridTextBoxColumn8.HeaderText", typeof(string))));
			this.dataGridTextBoxColumn8.MappingName = "Posnummer";
			this.dataGridTextBoxColumn8.Width = 50;
			// 
			// dataGridTextBoxColumn9
			// 
			this.dataGridTextBoxColumn9.Format = "";
			this.dataGridTextBoxColumn9.FormatInfo = null;
			this.dataGridTextBoxColumn9.HeaderText = "Kurztext";
			this.dataGridTextBoxColumn9.MappingName = "Kurztext";
			this.dataGridTextBoxColumn9.Width = 150;
			// 
			// dataGridTextBoxColumn10
			// 
			this.dataGridTextBoxColumn10.Format = "";
			this.dataGridTextBoxColumn10.FormatInfo = null;
			this.dataGridTextBoxColumn10.HeaderText = "Langtext";
			this.dataGridTextBoxColumn10.MappingName = "Langtext";
			this.dataGridTextBoxColumn10.Width = 400;
			// 
			// dataGridTextBoxColumn11
			// 
			this.dataGridTextBoxColumn11.Format = "C";
			this.dataGridTextBoxColumn11.FormatInfo = null;
			this.dataGridTextBoxColumn11.HeaderText = "Preis";
			this.dataGridTextBoxColumn11.MappingName = "Preis";
			this.dataGridTextBoxColumn11.Width = 75;
			// 
			// dataGridTextBoxColumn12
			// 
			this.dataGridTextBoxColumn12.Format = "";
			this.dataGridTextBoxColumn12.FormatInfo = null;
			this.dataGridTextBoxColumn12.HeaderText = "Einheit";
			this.dataGridTextBoxColumn12.MappingName = "Einheit";
			this.dataGridTextBoxColumn12.Width = 60;
			// 
			// dataGridTextBoxColumn13
			// 
			this.dataGridTextBoxColumn13.Format = "C";
			this.dataGridTextBoxColumn13.FormatInfo = null;
			this.dataGridTextBoxColumn13.HeaderText = "Materialkosten";
			this.dataGridTextBoxColumn13.MappingName = "MKosten";
			this.dataGridTextBoxColumn13.Width = 90;
			// 
			// dataGridTextBoxColumn14
			// 
			this.dataGridTextBoxColumn14.Format = "";
			this.dataGridTextBoxColumn14.FormatInfo = null;
			this.dataGridTextBoxColumn14.HeaderText = "Lohnkosten";
			this.dataGridTextBoxColumn14.MappingName = "LKosten";
			this.dataGridTextBoxColumn14.Width = 90;
			// 
			// dataGridTableStyle3
			// 
			this.dataGridTableStyle3.DataGrid = this.DG_�bersicht;
			this.dataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle3.MappingName = "FPos";
			// 
			// dataGridTableStyle4
			// 
			this.dataGridTableStyle4.DataGrid = this.DG_�bersicht;
			this.dataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle4.MappingName = "ZPos";
			// 
			// dataGridTableStyleKunden�bersicht
			// 
			this.dataGridTableStyleKunden�bersicht.DataGrid = this.DG_�bersicht;
			this.dataGridTableStyleKunden�bersicht.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																																this.dataGridTextBoxColumn15,
																																this.dataGridTextBoxColumn16,
																																this.dataGridTextBoxColumn17,
																																this.dataGridTextBoxColumn18,
																																this.dataGridTextBoxColumn25,
																																this.dataGridTextBoxColumn21,
																																this.dataGridTextBoxColumn19,
																																this.dataGridTextBoxColumn20,
																																this.dataGridTextBoxColumn22,
																																this.dataGridTextBoxColumn23,
																																this.dataGridTextBoxColumn24});
			this.dataGridTableStyleKunden�bersicht.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleKunden�bersicht.MappingName = "Kunden";
			// 
			// dataGridTextBoxColumn15
			// 
			this.dataGridTextBoxColumn15.Format = "";
			this.dataGridTextBoxColumn15.FormatInfo = null;
			this.dataGridTextBoxColumn15.HeaderText = "KD-Nr.";
			this.dataGridTextBoxColumn15.MappingName = "Kundennr";
			this.dataGridTextBoxColumn15.Width = 40;
			// 
			// dataGridTextBoxColumn16
			// 
			this.dataGridTextBoxColumn16.Format = "";
			this.dataGridTextBoxColumn16.FormatInfo = null;
			this.dataGridTextBoxColumn16.HeaderText = "K�rzel";
			this.dataGridTextBoxColumn16.MappingName = "Kuerzel";
			this.dataGridTextBoxColumn16.Width = 45;
			// 
			// dataGridTextBoxColumn17
			// 
			this.dataGridTextBoxColumn17.Format = "";
			this.dataGridTextBoxColumn17.FormatInfo = null;
			this.dataGridTextBoxColumn17.HeaderText = "Anrede";
			this.dataGridTextBoxColumn17.MappingName = "Anrede";
			this.dataGridTextBoxColumn17.Width = 55;
			// 
			// dataGridTextBoxColumn18
			// 
			this.dataGridTextBoxColumn18.Format = "";
			this.dataGridTextBoxColumn18.FormatInfo = null;
			this.dataGridTextBoxColumn18.HeaderText = "Name";
			this.dataGridTextBoxColumn18.MappingName = "Name";
			this.dataGridTextBoxColumn18.Width = 105;
			// 
			// dataGridTextBoxColumn25
			// 
			this.dataGridTextBoxColumn25.Format = "";
			this.dataGridTextBoxColumn25.FormatInfo = null;
			this.dataGridTextBoxColumn25.HeaderText = "Vorname";
			this.dataGridTextBoxColumn25.MappingName = "Vorname";
			this.dataGridTextBoxColumn25.Width = 80;
			// 
			// dataGridTextBoxColumn21
			// 
			this.dataGridTextBoxColumn21.Format = "";
			this.dataGridTextBoxColumn21.FormatInfo = null;
			this.dataGridTextBoxColumn21.HeaderText = "Strasse";
			this.dataGridTextBoxColumn21.MappingName = "Strasse";
			this.dataGridTextBoxColumn21.Width = 135;
			// 
			// dataGridTextBoxColumn19
			// 
			this.dataGridTextBoxColumn19.Format = "";
			this.dataGridTextBoxColumn19.FormatInfo = null;
			this.dataGridTextBoxColumn19.HeaderText = "PLZ";
			this.dataGridTextBoxColumn19.MappingName = "PLZ";
			this.dataGridTextBoxColumn19.Width = 45;
			// 
			// dataGridTextBoxColumn20
			// 
			this.dataGridTextBoxColumn20.Format = "";
			this.dataGridTextBoxColumn20.FormatInfo = null;
			this.dataGridTextBoxColumn20.HeaderText = "Ort";
			this.dataGridTextBoxColumn20.MappingName = "Ort";
			this.dataGridTextBoxColumn20.Width = 75;
			// 
			// dataGridTextBoxColumn22
			// 
			this.dataGridTextBoxColumn22.Format = "";
			this.dataGridTextBoxColumn22.FormatInfo = null;
			this.dataGridTextBoxColumn22.HeaderText = "Telefon";
			this.dataGridTextBoxColumn22.MappingName = "Telefon";
			this.dataGridTextBoxColumn22.Width = 102;
			// 
			// dataGridTextBoxColumn23
			// 
			this.dataGridTextBoxColumn23.Format = "";
			this.dataGridTextBoxColumn23.FormatInfo = null;
			this.dataGridTextBoxColumn23.HeaderText = "Fax";
			this.dataGridTextBoxColumn23.MappingName = "Fax";
			this.dataGridTextBoxColumn23.Width = 102;
			// 
			// dataGridTextBoxColumn24
			// 
			this.dataGridTextBoxColumn24.Format = "";
			this.dataGridTextBoxColumn24.FormatInfo = null;
			this.dataGridTextBoxColumn24.HeaderText = "eMail";
			this.dataGridTextBoxColumn24.MappingName = "eMail";
			this.dataGridTextBoxColumn24.Width = 125;
			// 
			// dataGridTableStyleVorgangsview
			// 
			this.dataGridTableStyleVorgangsview.DataGrid = this.DG_�bersicht;
			this.dataGridTableStyleVorgangsview.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																															 this.dataGridTextBoxColumn28,
																															 this.dataGridTextBoxColumn26,
																															 this.dataGridTextBoxColumn29,
																															 this.dataGridTextBoxColumn27,
																															 this.dataGridTextBoxColumn30,
																															 this.dataGridTextBoxColumn31});
			this.dataGridTableStyleVorgangsview.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyleVorgangsview.MappingName = "KundenVorgaenge";
			this.dataGridTableStyleVorgangsview.PreferredColumnWidth = 200;
			// 
			// dataGridTextBoxColumn28
			// 
			this.dataGridTextBoxColumn28.Format = "";
			this.dataGridTextBoxColumn28.FormatInfo = null;
			this.dataGridTextBoxColumn28.HeaderText = "Index";
			this.dataGridTextBoxColumn28.MappingName = "Index";
			this.dataGridTextBoxColumn28.Width = 60;
			// 
			// dataGridTextBoxColumn26
			// 
			this.dataGridTextBoxColumn26.Format = "";
			this.dataGridTextBoxColumn26.FormatInfo = null;
			this.dataGridTextBoxColumn26.HeaderText = "Vorgang";
			this.dataGridTextBoxColumn26.MappingName = "Vorgang";
			this.dataGridTextBoxColumn26.Width = 200;
			// 
			// dataGridTextBoxColumn29
			// 
			this.dataGridTextBoxColumn29.Format = "D";
			this.dataGridTextBoxColumn29.FormatInfo = null;
			this.dataGridTextBoxColumn29.HeaderText = "Datum";
			this.dataGridTextBoxColumn29.MappingName = "Datum";
			this.dataGridTextBoxColumn29.Width = 180;
			// 
			// dataGridTextBoxColumn27
			// 
			this.dataGridTextBoxColumn27.Format = "";
			this.dataGridTextBoxColumn27.FormatInfo = null;
			this.dataGridTextBoxColumn27.HeaderText = "KD-Nr.";
			this.dataGridTextBoxColumn27.MappingName = "Kundennr";
			this.dataGridTextBoxColumn27.Width = 80;
			// 
			// dataGridTextBoxColumn30
			// 
			this.dataGridTextBoxColumn30.Format = "";
			this.dataGridTextBoxColumn30.FormatInfo = null;
			this.dataGridTextBoxColumn30.HeaderText = "Nachname";
			this.dataGridTextBoxColumn30.MappingName = "Name";
			this.dataGridTextBoxColumn30.Width = 200;
			// 
			// dataGridTextBoxColumn31
			// 
			this.dataGridTextBoxColumn31.Format = "";
			this.dataGridTextBoxColumn31.FormatInfo = null;
			this.dataGridTextBoxColumn31.HeaderText = "Vorname";
			this.dataGridTextBoxColumn31.MappingName = "Vorname";
			this.dataGridTextBoxColumn31.Width = 200;
			// 
			// gBox_Pos�bersicht
			// 
			this.gBox_Pos�bersicht.Controls.Add(this.gBox_PosBeschr�nken);
			this.gBox_Pos�bersicht.Controls.Add(this.button_�bersicht_Pos_Anzeigen);
			this.gBox_Pos�bersicht.Location = new System.Drawing.Point(16, 16);
			this.gBox_Pos�bersicht.Name = "gBox_Pos�bersicht";
			this.gBox_Pos�bersicht.Size = new System.Drawing.Size(456, 128);
			this.gBox_Pos�bersicht.TabIndex = 1;
			this.gBox_Pos�bersicht.TabStop = false;
			this.gBox_Pos�bersicht.Text = "Positions-�bersicht";
			// 
			// gBox_PosBeschr�nken
			// 
			this.gBox_PosBeschr�nken.Controls.Add(this.radio_Z);
			this.gBox_PosBeschr�nken.Controls.Add(this.radio_M);
			this.gBox_PosBeschr�nken.Controls.Add(this.radio_F);
			this.gBox_PosBeschr�nken.Location = new System.Drawing.Point(264, 16);
			this.gBox_PosBeschr�nken.Name = "gBox_PosBeschr�nken";
			this.gBox_PosBeschr�nken.Size = new System.Drawing.Size(176, 104);
			this.gBox_PosBeschr�nken.TabIndex = 1;
			this.gBox_PosBeschr�nken.TabStop = false;
			this.gBox_PosBeschr�nken.Text = "Beschr�nkung auf:";
			// 
			// radio_Z
			// 
			this.radio_Z.Location = new System.Drawing.Point(24, 72);
			this.radio_Z.Name = "radio_Z";
			this.radio_Z.Size = new System.Drawing.Size(130, 24);
			this.radio_Z.TabIndex = 2;
			this.radio_Z.Text = "Z - Zusatzpositionen";
			// 
			// radio_M
			// 
			this.radio_M.Location = new System.Drawing.Point(24, 44);
			this.radio_M.Name = "radio_M";
			this.radio_M.Size = new System.Drawing.Size(100, 24);
			this.radio_M.TabIndex = 1;
			this.radio_M.Text = "M - Maurer";
			// 
			// radio_F
			// 
			this.radio_F.Checked = true;
			this.radio_F.Location = new System.Drawing.Point(24, 16);
			this.radio_F.Name = "radio_F";
			this.radio_F.TabIndex = 0;
			this.radio_F.TabStop = true;
			this.radio_F.Text = "F - Fliesenleger";
			// 
			// button_�bersicht_Pos_Anzeigen
			// 
			this.button_�bersicht_Pos_Anzeigen.Location = new System.Drawing.Point(24, 24);
			this.button_�bersicht_Pos_Anzeigen.Name = "button_�bersicht_Pos_Anzeigen";
			this.button_�bersicht_Pos_Anzeigen.Size = new System.Drawing.Size(216, 32);
			this.button_�bersicht_Pos_Anzeigen.TabIndex = 0;
			this.button_�bersicht_Pos_Anzeigen.Text = "Positionen Anzeigen";
			this.button_�bersicht_Pos_Anzeigen.Click += new System.EventHandler(this.button_�bersicht_Pos_Anzeigen_Click);
			// 
			// gBox_Kunden�bersicht
			// 
			this.gBox_Kunden�bersicht.Controls.Add(this.button_�bersicht_Vorgang_suchen);
			this.gBox_Kunden�bersicht.Controls.Add(this.txtBox_�bersicht_Vorgang_suchen);
			this.gBox_Kunden�bersicht.Controls.Add(this.label35);
			this.gBox_Kunden�bersicht.Controls.Add(this.button_�bersicht_Kunden_suchen);
			this.gBox_Kunden�bersicht.Controls.Add(this.label34);
			this.gBox_Kunden�bersicht.Controls.Add(this.txtBox_�bersicht_Kundenauswahl);
			this.gBox_Kunden�bersicht.Controls.Add(this.button_�bersicht_Vorg�nge_anzeigen);
			this.gBox_Kunden�bersicht.Controls.Add(this.button_�bersicht_alle_Kunden);
			this.gBox_Kunden�bersicht.Location = new System.Drawing.Point(496, 16);
			this.gBox_Kunden�bersicht.Name = "gBox_Kunden�bersicht";
			this.gBox_Kunden�bersicht.Size = new System.Drawing.Size(480, 128);
			this.gBox_Kunden�bersicht.TabIndex = 0;
			this.gBox_Kunden�bersicht.TabStop = false;
			this.gBox_Kunden�bersicht.Text = "Kunden-�bersicht";
			// 
			// button_�bersicht_Vorgang_suchen
			// 
			this.button_�bersicht_Vorgang_suchen.Location = new System.Drawing.Point(424, 80);
			this.button_�bersicht_Vorgang_suchen.Name = "button_�bersicht_Vorgang_suchen";
			this.button_�bersicht_Vorgang_suchen.Size = new System.Drawing.Size(32, 23);
			this.button_�bersicht_Vorgang_suchen.TabIndex = 7;
			this.button_�bersicht_Vorgang_suchen.Text = "los";
			this.button_�bersicht_Vorgang_suchen.Click += new System.EventHandler(this.button_�bersicht_Vorgang_suchen_Click);
			// 
			// txtBox_�bersicht_Vorgang_suchen
			// 
			this.txtBox_�bersicht_Vorgang_suchen.Location = new System.Drawing.Point(328, 80);
			this.txtBox_�bersicht_Vorgang_suchen.Name = "txtBox_�bersicht_Vorgang_suchen";
			this.txtBox_�bersicht_Vorgang_suchen.Size = new System.Drawing.Size(96, 20);
			this.txtBox_�bersicht_Vorgang_suchen.TabIndex = 6;
			this.txtBox_�bersicht_Vorgang_suchen.Text = "";
			this.txtBox_�bersicht_Vorgang_suchen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_�bersicht_Vorgang_suchen_KeyPress);
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(256, 88);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(56, 20);
			this.label35.TabIndex = 5;
			this.label35.Text = "Suchen:";
			// 
			// button_�bersicht_Kunden_suchen
			// 
			this.button_�bersicht_Kunden_suchen.Location = new System.Drawing.Point(424, 32);
			this.button_�bersicht_Kunden_suchen.Name = "button_�bersicht_Kunden_suchen";
			this.button_�bersicht_Kunden_suchen.Size = new System.Drawing.Size(32, 23);
			this.button_�bersicht_Kunden_suchen.TabIndex = 4;
			this.button_�bersicht_Kunden_suchen.Text = "los";
			this.button_�bersicht_Kunden_suchen.Click += new System.EventHandler(this.button_�bersicht_Kunden_suchen_Click);
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(256, 32);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(56, 20);
			this.label34.TabIndex = 3;
			this.label34.Text = "Suchen:";
			// 
			// txtBox_�bersicht_Kundenauswahl
			// 
			this.txtBox_�bersicht_Kundenauswahl.Location = new System.Drawing.Point(328, 32);
			this.txtBox_�bersicht_Kundenauswahl.Name = "txtBox_�bersicht_Kundenauswahl";
			this.txtBox_�bersicht_Kundenauswahl.Size = new System.Drawing.Size(96, 20);
			this.txtBox_�bersicht_Kundenauswahl.TabIndex = 2;
			this.txtBox_�bersicht_Kundenauswahl.Text = "";
			this.txtBox_�bersicht_Kundenauswahl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_�bersicht_Kundenauswahl_KeyPress);
			// 
			// button_�bersicht_Vorg�nge_anzeigen
			// 
			this.button_�bersicht_Vorg�nge_anzeigen.Location = new System.Drawing.Point(24, 80);
			this.button_�bersicht_Vorg�nge_anzeigen.Name = "button_�bersicht_Vorg�nge_anzeigen";
			this.button_�bersicht_Vorg�nge_anzeigen.Size = new System.Drawing.Size(208, 32);
			this.button_�bersicht_Vorg�nge_anzeigen.TabIndex = 1;
			this.button_�bersicht_Vorg�nge_anzeigen.Text = "Alle Vorg�nge anzeigen";
			this.button_�bersicht_Vorg�nge_anzeigen.Click += new System.EventHandler(this.button_�bersicht_Vorg�nge_anzeigen_Click);
			// 
			// button_�bersicht_alle_Kunden
			// 
			this.button_�bersicht_alle_Kunden.Location = new System.Drawing.Point(24, 24);
			this.button_�bersicht_alle_Kunden.Name = "button_�bersicht_alle_Kunden";
			this.button_�bersicht_alle_Kunden.Size = new System.Drawing.Size(208, 32);
			this.button_�bersicht_alle_Kunden.TabIndex = 0;
			this.button_�bersicht_alle_Kunden.Text = "Alle Kunden anzeigen";
			this.button_�bersicht_alle_Kunden.Click += new System.EventHandler(this.button_�bersicht_alle_Kunden_Click);
			// 
			// Nachkalkulation
			// 
			this.Nachkalkulation.Controls.Add(this.txtBox_Gewinn);
			this.Nachkalkulation.Controls.Add(this.label40);
			this.Nachkalkulation.Controls.Add(this.label39);
			this.Nachkalkulation.Controls.Add(this.txtBox_NettoRechbetrag);
			this.Nachkalkulation.Controls.Add(this.label38);
			this.Nachkalkulation.Controls.Add(this.txtBox_realGesamtKosten);
			this.Nachkalkulation.Controls.Add(this.label37);
			this.Nachkalkulation.Controls.Add(this.label36);
			this.Nachkalkulation.Controls.Add(this.txtBox_realLohnKosten);
			this.Nachkalkulation.Controls.Add(this.txtBox_realMatKosten);
			this.Nachkalkulation.Controls.Add(this.DG_Nachkalkulation);
			this.Nachkalkulation.Location = new System.Drawing.Point(4, 22);
			this.Nachkalkulation.Name = "Nachkalkulation";
			this.Nachkalkulation.Size = new System.Drawing.Size(988, 590);
			this.Nachkalkulation.TabIndex = 5;
			this.Nachkalkulation.Text = "Nachkalkulation";
			// 
			// txtBox_Gewinn
			// 
			this.txtBox_Gewinn.Location = new System.Drawing.Point(160, 152);
			this.txtBox_Gewinn.Name = "txtBox_Gewinn";
			this.txtBox_Gewinn.TabIndex = 10;
			this.txtBox_Gewinn.Text = "";
			// 
			// label40
			// 
			this.label40.Location = new System.Drawing.Point(24, 152);
			this.label40.Name = "label40";
			this.label40.TabIndex = 9;
			this.label40.Text = "Gewinn";
			// 
			// label39
			// 
			this.label39.Location = new System.Drawing.Point(24, 120);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(136, 23);
			this.label39.TabIndex = 8;
			this.label39.Text = "Rechnungsbetrag (Netto)";
			// 
			// txtBox_NettoRechbetrag
			// 
			this.txtBox_NettoRechbetrag.Location = new System.Drawing.Point(160, 120);
			this.txtBox_NettoRechbetrag.Name = "txtBox_NettoRechbetrag";
			this.txtBox_NettoRechbetrag.TabIndex = 7;
			this.txtBox_NettoRechbetrag.Text = "";
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(24, 88);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(112, 23);
			this.label38.TabIndex = 6;
			this.label38.Text = "Reale Gesamtkosten";
			// 
			// txtBox_realGesamtKosten
			// 
			this.txtBox_realGesamtKosten.Location = new System.Drawing.Point(160, 88);
			this.txtBox_realGesamtKosten.Name = "txtBox_realGesamtKosten";
			this.txtBox_realGesamtKosten.TabIndex = 5;
			this.txtBox_realGesamtKosten.Text = "";
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(24, 56);
			this.label37.Name = "label37";
			this.label37.TabIndex = 4;
			this.label37.Text = "Reale Lohnkosten";
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(24, 24);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(112, 23);
			this.label36.TabIndex = 3;
			this.label36.Text = "Reale Materialkosten";
			// 
			// txtBox_realLohnKosten
			// 
			this.txtBox_realLohnKosten.Location = new System.Drawing.Point(160, 56);
			this.txtBox_realLohnKosten.Name = "txtBox_realLohnKosten";
			this.txtBox_realLohnKosten.TabIndex = 2;
			this.txtBox_realLohnKosten.Text = "";
			// 
			// txtBox_realMatKosten
			// 
			this.txtBox_realMatKosten.Location = new System.Drawing.Point(160, 24);
			this.txtBox_realMatKosten.Name = "txtBox_realMatKosten";
			this.txtBox_realMatKosten.TabIndex = 1;
			this.txtBox_realMatKosten.Text = "";
			// 
			// DG_Nachkalkulation
			// 
			this.DG_Nachkalkulation.DataMember = "";
			this.DG_Nachkalkulation.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DG_Nachkalkulation.Location = new System.Drawing.Point(16, 192);
			this.DG_Nachkalkulation.Name = "DG_Nachkalkulation";
			this.DG_Nachkalkulation.Size = new System.Drawing.Size(944, 384);
			this.DG_Nachkalkulation.TabIndex = 0;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem6,
																					  this.menuItem11,
																					  this.menuItem17});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem16});
			this.menuItem1.Text = "Datei";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Neu";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "�ffnen";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "Bearbeiten";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "Schlie�en";
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 4;
			this.menuItem16.Text = "";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10});
			this.menuItem6.Text = "Kunde";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "Neu";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.Text = "Bearbeiten";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "Speichern";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.Text = "L�schen";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 2;
			this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem12,
																					   this.menuItem13,
																					   this.menuItem14,
																					   this.menuItem15});
			this.menuItem11.Text = "Bauvorhaben";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 0;
			this.menuItem12.Text = "Neu";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 1;
			this.menuItem13.Text = "Bearbeiten";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 2;
			this.menuItem14.Text = "Speichern";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 3;
			this.menuItem15.Text = "L�schen";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 3;
			this.menuItem17.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuDruckenPageSetup,
																					   this.menuDruckenPrintPreview,
																					   this.menuDruckenPrint});
			this.menuItem17.Text = "Drucken";
			// 
			// menuDruckenPageSetup
			// 
			this.menuDruckenPageSetup.Index = 0;
			this.menuDruckenPageSetup.Text = "Page Setup";
			this.menuDruckenPageSetup.Click += new System.EventHandler(this.menuDruckenPageSetup_Click);
			// 
			// menuDruckenPrintPreview
			// 
			this.menuDruckenPrintPreview.Index = 1;
			this.menuDruckenPrintPreview.Text = "Print Preview";
			this.menuDruckenPrintPreview.Click += new System.EventHandler(this.menuDruckenPrintPreview_Click);
			// 
			// menuDruckenPrint
			// 
			this.menuDruckenPrint.Index = 2;
			this.menuDruckenPrint.Text = "Print";
			this.menuDruckenPrint.Click += new System.EventHandler(this.menuDruckenPrint_Click);
			// 
			// txtbox_Einheit
			// 
			this.txtbox_Einheit.Location = new System.Drawing.Point(224, 112);
			this.txtbox_Einheit.Name = "txtbox_Einheit";
			this.txtbox_Einheit.ReadOnly = true;
			this.txtbox_Einheit.Size = new System.Drawing.Size(72, 20);
			this.txtbox_Einheit.TabIndex = 25;
			this.txtbox_Einheit.Text = "";
			// 
			// Einheit
			// 
			this.Einheit.Location = new System.Drawing.Point(224, 88);
			this.Einheit.Name = "Einheit";
			this.Einheit.Size = new System.Drawing.Size(64, 24);
			this.Einheit.TabIndex = 26;
			this.Einheit.Text = "Einheit";
			// 
			// dataGridTextBoxColumn32
			// 
			this.dataGridTextBoxColumn32.Format = "";
			this.dataGridTextBoxColumn32.FormatInfo = null;
			this.dataGridTextBoxColumn32.MappingName = "Einheit";
			this.dataGridTextBoxColumn32.Width = 30;
			// 
			// MainFrame
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 646);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "MainFrame";
			this.Text = "Layer 8 ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFrame_Load);
			this.tabControl1.ResumeLayout(false);
			this.Kunde.ResumeLayout(false);
			this.Positionen.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Vorgang)).EndInit();
			this.Zahlung.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.Bauvorhaben.ResumeLayout(false);
			this.gbox_Vorgangstyp.ResumeLayout(false);
			this.�bersicht.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DG_�bersicht)).EndInit();
			this.gBox_Pos�bersicht.ResumeLayout(false);
			this.gBox_PosBeschr�nken.ResumeLayout(false);
			this.gBox_Kunden�bersicht.ResumeLayout(false);
			this.Nachkalkulation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DG_Nachkalkulation)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt f�r die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainFrame());
		   
		}

		

		private void MainFrame_Load(object sender, System.EventArgs e)
		{
		   
			VG = new Vorgang();
			UnsereDb = new DB();
			DG_Zeile_bearbeiten=false;
				
			// CSW: Das DataGrid muss sein DataBinding behalten, es hat auch versprochen ganz lieb zu sein und keinen Scheiss damit zu machen
			//dataGrid_Vorgang.SetDataBinding(VG.PosListe, "Positionen");
			PosView = new DataView(VG.PosListe.Tables[0]);
			
			dataGrid_Vorgang.SetDataBinding(PosView,null);
			PosView.AllowNew=false;
			PosView.AllowDelete=false;
			PosView.AllowEdit=false;
			//CSW: Hier folgt die Defintion der ToolTips 
			ToolTip TT_Kundenseite = new ToolTip();

			// Set up the delays for the ToolTip.
			TT_Kundenseite.AutoPopDelay = 5000; //Dauer der Anzeige
			TT_Kundenseite.InitialDelay = 300;  //Zeitverz�gerung bis der ToolTip angezeigt wird
			TT_Kundenseite.ReshowDelay = 300;	//Zeitverz�gerung zwischen Tooltips 2er verschiedener Elemente
			// Force the ToolTip text to be displayed whether or not the form is active.
			TT_Kundenseite.ShowAlways = true;
			// Set up the ToolTip text 
			TT_Kundenseite.SetToolTip(this.txtbox_K�rzel, "Bitte das K�rzel des Kunden angeben");
			TT_Kundenseite.SetToolTip(this.txtbox_Kundennummer, "Die Kundennummer des aktuellen Kunden");
			TT_Kundenseite.SetToolTip(this.txtbox_Name, "Der Nachname des aktuellen Kunden");
			TT_Kundenseite.SetToolTip(this.txtbox_Vorname, "Der Vorname des aktuellen Kunden");
			
			// TableStyles f�r das �bersichts-DataGrid, hab ich aus der Initialize Component kopiert
			this.dataGridTableStyle3.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] { this.dataGridTextBoxColumn8,this.dataGridTextBoxColumn9,this.dataGridTextBoxColumn10,this.dataGridTextBoxColumn11,this.dataGridTextBoxColumn12,this.dataGridTextBoxColumn13,this.dataGridTextBoxColumn14});
			this.dataGridTableStyle4.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] { this.dataGridTextBoxColumn8,this.dataGridTextBoxColumn9,this.dataGridTextBoxColumn10,this.dataGridTextBoxColumn11,this.dataGridTextBoxColumn12,this.dataGridTextBoxColumn13,this.dataGridTextBoxColumn14});
			
			ZahlungsTab_aktualisieren();
			Ansicht = Ansichtsache.Noppes;

		
			
		}


	#region auskommentiert
		/*private void txtbox_Posnummer_Leave(object sender, System.EventArgs e)
		{
			if (this.position_anlegen)
			{
				string tempPosnummer = this.txtbox_Posnummer.Text;
				tempPosnummer.ToLower();
				tempPosnummer.Trim();
				this.positionsnummerstring.ToLower();
				this.positionsnummerstring.Trim();
				// bool test = string.Equals(this.k�rzelstring, tempK�rzel);
				if (this.positionsnummerstring != tempPosnummer)
				{
					VG.aktPos = UnsereDb.Pos_suchen_nach_Posnummer(this.txtbox_Posnummer.Text);	// CSW 17.10.03 14:30 "K" in Unser Kunde ge�ndert/ DB zu ner Public Variablen  von Mainframe gemacht und diese bei Form1.Load initialisieren lassen
					if (VG.aktPos != null)
					{
						MessageBox.Show("Es existiert bereits eine Position mit diesem K�rzel");
					}
					else this.position_Anzeigen(VG.aktPos);		
				}
			}
		}*/

		/* private void txtbox_Posnummer_TextChanged(object sender, System.EventArgs e)
		{
			if (!this.position_neu)
			{
				if (this.position_anlegen)
				{
					this.positionsnummerstring = this.txtbox_Posnummer.Text;
				}
			}
		}
		*/
	#endregion


	#region Textbox_irgenwas
		private void txtbox_K�rzel_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{

				if(e.KeyChar == (char)13)
				{
					e.Handled=true;
					String kuerz;
					kuerz = this.txtbox_K�rzel.Text;
				
					Kunde temp = UnsereDb.Kunde_suchen_nach_Kuerzel(kuerz);	// CSW 17.10.03 14:30 "K" in Unser Kunde ge�ndert/ DB zu ner Public Variablen  von Mainframe gemacht und diese bei Form1.Load initialisieren lassen
					if (temp != null)
					{
						VG.UnserKunde = temp;
						kunde_Anzeigen(VG.UnserKunde);
					}
					else MessageBox.Show("Kunde nicht gefunden");
				}
			}

		}

		private void txtbox_K�rzel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{
				this.txtbox_K�rzel.ReadOnly = false;
				this.txtbox_Name.ReadOnly = true;
				this.txtbox_Kundennummer.ReadOnly = true;
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		private void txtbox_Name_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{
				this.txtbox_K�rzel.ReadOnly = true;
				this.txtbox_Name.ReadOnly = false;
				this.txtbox_Kundennummer.ReadOnly = true;
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		private void txtbox_Kundennummer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{
				this.txtbox_K�rzel.ReadOnly = true;
				this.txtbox_Name.ReadOnly = true;
				this.txtbox_Kundennummer.ReadOnly = false;
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		private void txtbox_K�rzel_Leave(object sender, System.EventArgs e)
		{
			if (this.bearbeiten_flag)
			{
				string tempK�rzel = this.txtbox_K�rzel.Text;
				tempK�rzel.ToLower();
				tempK�rzel.Trim();
				this.k�rzelstring.ToLower();
				this.k�rzelstring.Trim();
				// bool test = string.Equals(this.k�rzelstring, tempK�rzel);
				if (this.k�rzelstring != tempK�rzel)
				{
					Kunde temp;
					temp = UnsereDb.Kunde_suchen_nach_Kuerzel(this.txtbox_K�rzel.Text);
					if (temp != null)
					{
						MessageBox.Show("Diese K�rzel ist schon vergeben, bitte w�hlen Sie ein anderes K�rzel");
					}
					else 
					{
						VG.UnserKunde.Kuerzel = this.txtbox_K�rzel.Text;
					}
				}
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		private void txtbox_Name_Leave(object sender, System.EventArgs e)
		{
			if (this.bearbeiten_flag)
			{
				VG.UnserKunde.NName = this.txtbox_Name.Text;
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		private void txtbox_Vorname_Leave(object sender, System.EventArgs e)
		{
			VG.UnserKunde.VName = this.txtbox_Vorname.Text;
			this.kunde_Anzeigen(VG.UnserKunde);
		}

		private void txtbox_Strasse_Leave(object sender, System.EventArgs e)
		{
			VG.UnserKunde.Strasse = this.txtbox_Strasse.Text;
			this.kunde_Anzeigen(VG.UnserKunde);
		}

		private void txtbox_Ort_Leave(object sender, System.EventArgs e)
		{
			VG.UnserKunde.Ort = this.txtbox_Ort.Text;
			this.kunde_Anzeigen(VG.UnserKunde);
		}

		private void txtbox_PLZ_Leave(object sender, System.EventArgs e)
		{
			int temp = Convert.ToInt32(this.txtbox_PLZ.Text);
			VG.UnserKunde.PLZ = temp;
			this.kunde_Anzeigen(VG.UnserKunde);
		}

		private void txtbox_Telefonnummer_Leave(object sender, System.EventArgs e)
		{
			VG.UnserKunde.Telefonnummer = this.txtbox_Telefonnummer.Text;
			this.kunde_Anzeigen(VG.UnserKunde);
		}

		private void txtbox_Fax_Leave(object sender, System.EventArgs e)
		{
			VG.UnserKunde.Fax = this.txtbox_Fax.Text;
			this.kunde_Anzeigen(VG.UnserKunde);
		}

		private void txtbox_Email_Leave(object sender, System.EventArgs e)
		{
			VG.UnserKunde.Email = this.txtbox_Email.Text;
			this.kunde_Anzeigen(VG.UnserKunde);
		}

		private void txtbox_K�rzel_TextChanged(object sender, System.EventArgs e)
		{
			if (!this.neuer_Kunde)
			{
				if (this.bearbeiten_flag)
				{
					this.k�rzelstring = this.txtbox_K�rzel.Text;
				}
			}
		}

		private void txtbox_Fl�che_Leave(object sender, System.EventArgs e) //CSW - 23.10.03 01:01
		{	// Wenn ne Zahl eingegeben wird, �berpr�ft er, ob er schon den Gesamtpreis ausrechnen kann
			 
			if(!(txtbox_Einzelpreis.Text==""))
			{	
				
				try
				{
					//VG.aktPos.GPreis= Convert.ToDecimal(VG.aktPos.Flaeche*(double)VG.aktPos.EPreis);
					// und dies ist die umst�ndlichere Variante die ich nun benutzen muss:
					VG.aktPos.GPreis= Convert.ToDecimal(Convert.ToDouble(txtbox_Fl�che.Text)*Convert.ToDouble(txtbox_Einzelpreis.Text));
					txtbox_Gesamtpreis.Text=""+VG.aktPos.GPreis;
				
				}
		
				catch
				{
					txtbox_Gesamtpreis.Text="";
				}
			}
		}

		private void txtbox_Einzelpreis_Leave(object sender, System.EventArgs e)//CSW - 23.10.03 01:02
		{// Wenn ne Zahl eingegeben wird, �berpr�ft er, ob er schon den Gesamtpreis ausrechnen kann
			
			if (!this.position_anlegen)
			{

				if(!(txtbox_Fl�che.Text==""))
				
				{
					try
					{
						//VG.aktPos.GPreis= Convert.ToDecimal(VG.aktPos.Flaeche*(double)VG.aktPos.EPreis); so sollte sie sp�ter aussehen
						// und dies ist die umst�ndlichere Variante die ich nun benutzen muss:
						VG.aktPos.GPreis= Convert.ToDecimal(Convert.ToDouble(txtbox_Fl�che.Text)*Convert.ToDouble(txtbox_Einzelpreis.Text));			
						txtbox_Gesamtpreis.Text=""+VG.aktPos.GPreis;
				
					}
					catch
					{
				
						txtbox_Gesamtpreis.Text="";
					}
				}
			}
		}

		private void txtbox_Posnummer_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!this.position_anlegen)
			{
				if(e.KeyChar == (char)13)
				{
					e.Handled=true;
					String posnummer;
					posnummer = this.txtbox_Posnummer.Text;
						
					VG.aktPos = UnsereDb.Pos_suchen_nach_Posnummer(posnummer);	// CSW 17.10.03 14:30 "K" in Unser Kunde ge�ndert/ DB zu ner Public Variablen  von Mainframe gemacht und diese bei Form1.Load initialisieren lassen
					if (VG.aktPos != null)
					{
						position_Anzeigen(VG.aktPos);
						txtbox_Fl�che.Focus();
					}
					else
					{
						MessageBox.Show("Die angegebene Position konnte nicht gefunden werden","Es ist ein Fehler aufgetreten");
						this.txtbox_Posnummer.Text="";}
				}
			
			}
		}

		private void txtbox_Fl�che_DoubleClick(object sender, System.EventArgs e) // CSW - 26.10.03 
			// Diese Methode ist auch als Eventhandler f�r den Button neben der Textbox in Verwendung
		{
			Dialog_Fl�che Dialog_F = new Dialog_Fl�che();
			Dialog_F.ShowDialog();				// Modale Darstellung
			
			if (Dialog_F.DialogResult==DialogResult.OK)		// Dialog �ber OK beendet
			{	
				string msg_boxFl�che = "Folgende Fl�che wurde eingeben: ";
				msg_boxFl�che += Dialog_F.FlaechenFormel;
				msg_boxFl�che += " = "+Dialog_F.Flaeche;
				MessageBox.Show(msg_boxFl�che, "Kontrolle ist besser:");
				
				VG.aktPos.Flaeche=Dialog_F.Flaeche;
				position_Anzeigen(VG.aktPos);
			}
			else										// Dialog �ber Abbrechen beendet
			{
				VG.aktPos.Flaeche=0;
				position_Anzeigen(VG.aktPos);
			}
			

		}

		private void txtbox_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{

				if(e.KeyChar == (char)13)
				{
					e.Handled=true;
					String name;
					name = this.txtbox_Name.Text;
					
					
					this.Verzeichnis = UnsereDb.Kunde_suchen_nach_Name(name);
					//					VG.UnserKunde = UnsereDb.Kunde_suchen_nach_Kuerzel(kuerz);	// CSW 17.10.03 14:30 "K" in Unser Kunde ge�ndert/ DB zu ner Public Variablen  von Mainframe gemacht und diese bei Form1.Load initialisieren lassen
					if (this.Verzeichnis.Count !=0 )
					{
						if (this.Verzeichnis.Count == 1)
						{
							VG.UnserKunde=Verzeichnis[0];
							kunde_Anzeigen(VG.UnserKunde);
						}
						else
						{
							MessageBox.Show(Verzeichnis.Count+" Kunden mit diesem Nachnamen gefunden. Bitte w�hlen Sie aus.", "Mehrere �bereinstimmungen gefunden");
							Kundenliste_anzeigen(Verzeichnis);
							
						}
					}
					else MessageBox.Show("Kunde nicht gefunden");
				}
			}
		}

		private void txtbox_VBezeichnung_Leave(object sender, System.EventArgs e)
		{
			VG.Vorgangsbezeichnung =txtbox_VBezeichnung.Text;
		}

		private void txtbox_Rabatt_Leave(object sender, System.EventArgs e)
		{
			try 
			{
				VG.Rabatt=Convert.ToDecimal(txtbox_Rabatt.Text);
				ZahlungsTab_aktualisieren();}
			catch
			{
				MessageBox.Show("Bitte den Rabatt ohne % eingeben","Ein Fehler ist aufgetreten"); 
				txtbox_Rabatt.Text=Convert.ToString(VG.Rabatt);}
		}

		private void txtbox_Mwst_Leave(object sender, System.EventArgs e)
		{
			try 
			{
				VG.MwSt=Convert.ToDecimal(txtbox_Mwst.Text);
				ZahlungsTab_aktualisieren();}
			catch
			{
				MessageBox.Show("Bitte den Rabatt ohne % eingeben","Ein Fehler ist aufgetreten"); 
				txtbox_Mwst.Text=Convert.ToString(VG.MwSt);}
		}

		private void txtbox_Posnummer_Leave(object sender, System.EventArgs e)
		{
			if (!this.position_anlegen)
			{
				
				string posnummer;
				posnummer = this.txtbox_Posnummer.Text;
						
				VG.aktPos = UnsereDb.Pos_suchen_nach_Posnummer(posnummer);	// CSW 17.10.03 14:30 "K" in Unser Kunde ge�ndert/ DB zu ner Public Variablen  von Mainframe gemacht und diese bei Form1.Load initialisieren lassen
				if (VG.aktPos != null)
				{
					position_Anzeigen(VG.aktPos);
				}
				else
				{
					MessageBox.Show("Die angegebene Position konnte nicht gefunden werden","Es ist ein Fehler aufgetreten");
					this.txtbox_Posnummer.Text="";}
				

			}
		}

		private void txtBox_�bersicht_Kundenauswahl_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
				Ansicht = Ansichtsache.Kunden;
			if(e.KeyChar == (char)13)
			{
				e.Handled=true;
				string name;
				name = this.txtBox_�bersicht_Kundenauswahl.Text;
			
				DG_�bersicht.Enabled =false;
				DataView KundenView = new DataView(UnsereDb.alle_Kunden_ausgebenDS().Tables[0]);
				KundenView.Sort="Kundennr";
				KundenView.RowFilter = "Name LIKE '"+name+"%'" ;
				if (KundenView.Count==0)
				{
						MessageBox.Show("Keine passenden Eintr�ge gefunden.","Schade");
					KundenView.RowFilter="";
				}
				
				DG_�bersicht.SetDataBinding(KundenView,null);
				DG_�bersicht.Enabled =true;
			}
		}

		private void txtBox_�bersicht_Vorgang_suchen_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
				Ansicht = Ansichtsache.Vorgang;
			if(e.KeyChar == (char)13)
			{
				e.Handled=true;
				string name;
				name = this.txtBox_�bersicht_Vorgang_suchen.Text;
				DG_�bersicht.Enabled =false;
				DataView VorgangsView = new DataView(UnsereDb.alle_Vorgaenge_eines_Kunden_ausgeben().Tables[0]);
				VorgangsView.Sort="Index";
				VorgangsView.RowFilter = "Name LIKE '"+name+"%'" ;
				if (VorgangsView.Count==0)
				{
						MessageBox.Show("Keine passenden Eintr�ge gefunden.","Schade");
					VorgangsView.RowFilter="";
				}
				
				DG_�bersicht.SetDataBinding(VorgangsView,null);
				DG_�bersicht.Enabled =true;
			}
		}

	#endregion
						

	#region Button_irgendwas_click
		private void button_�bernehmen_Click(object sender, System.EventArgs e) //CSW
		{//MessageBox.Show("1");
			if(txtbox_Posnummer.Text!="")
		 {
		//	MessageBox.Show("2");
			 if (this.position_anlegen)
			 {}
			
			 else 
			 {

				 dataGrid_Vorgang.Enabled=true;   // That's the trick! Damit der am Anfang nicht so lange l�dt bis die erste Position angezeigt wird
				 if(Daten_in_aktPos_schreiben())	 // Eine DummyMethode, damit ich schon Daten �ndern kann (hab doch ne Pr�fung drin, deshalb die if-Abfrage)
				 {
					 if (DG_Zeile_bearbeiten==false) // boolsches Flag - im Bearbeiten Modus ist das DataGrid disabled
					 {	
						 VG.Daten_hinzufuegen();	
						 PosView=new DataView(VG.PosListe.Tables[0]);//	Einf�gen der "aktPos" in die PosListe, es werden also nicht direkt die TextboxInhalte genommen !
					 }
					 else 
					 {
						 VG.Daten_wiedereinf�gen();  // Wird eigentlich an der alten Stelle bearbeitet
							PosView=new DataView(VG.PosListe.Tables[0]);
						 DG_Zeile_bearbeiten=false;						
					 button_loeschen.Visible=false;
//					
//						 // alte Formatierung wiederherstellen
					 dataGridTableStyle2.SelectionBackColor=System.Drawing.SystemColors.ActiveCaption;
					 }
				 }
		
				 dataGrid_Vorgang.ReadOnly=true;  // Ich wei� nicht warum aber mit diesem "Trick" l�uft es schneller
				// MessageBox.Show("3");
			 }

			 ZahlungsTab_aktualisieren();
			//MessageBox.Show("4");
		 }





		else MessageBox.Show("Mit der Positionsnummer stimmt etwas nicht.","Es ist ein Fehler aufgetreten.");
		}
		
		private void button_XmlLesen_Click(object sender, System.EventArgs e)  //- CSW 18.10.03 17:00
		{
			//	VG.aktPos.Positionsnummer=VG.aktPos.Positionsnummer+1; dat war mal meine Demonstration des DataBindingProblems
			//	Positionen.CreateControl();
			
			dataGrid_Vorgang.Enabled=true;  // Gleicher Spass wie bei �bernehmen_click
			VG.XML_lesen();
			dataGrid_Vorgang.ReadOnly=true;
			dateTimePicker_Bau.Value=VG.Datum;

		
		}

		private void button_XmlSchreiben_Click(object sender, System.EventArgs e) //- CSW 18.10.03 17:00
		{
			VG.XML_schreiben();
			UnsereDb.VorgangKunde_in_DB_schreiben(VG);
		}
		
		private void button_Speichern_Click(object sender, System.EventArgs e)
		{

			/*	if (this.txtbox_K�rzel.Text.Equals(""))
				{
					MessageBox.Show("Bitte geben Sie zuerst ein K�rzel ein");
				}

				else
				{     */
			this.bearbeiten_flag = false;
			this.button_Speichern.Visible = false;
			this.button_abbrechen.Visible = false;

			if (this.neuer_Kunde)
			{
				this.neuer_Kunde = false;
				UnsereDb.Neuer_Kunde_Anlegen(VG.UnserKunde);
				this.alle_kunden_textboxen_auf_read();
			}
			else
			{

				// UnsereDb.Kunde_aendern_K�rzel(this.txtbox_K�rzel.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Name(this.txtbox_Name.Text,VG.UnserKunde);
				UnsereDb.Kunde_aendern_Ort(this.txtbox_Ort.Text, VG.UnserKunde);
				
				
				string temp = this.txtbox_PLZ.Text;
				temp.Trim();
				if (temp != "")
				{
					int PLZ = Convert.ToInt32(this.txtbox_PLZ.Text);
					UnsereDb.Kunde_aendern_PLZ(PLZ, VG.UnserKunde);
				}

				
				UnsereDb.Kunde_aendern_Strasse(this.txtbox_Strasse.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Vorname(this.txtbox_Vorname.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Tel(this.txtbox_Telefonnummer.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Fax(this.txtbox_Fax.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Email(this.txtbox_Email.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Anrede(VG.UnserKunde.Anrede, VG.UnserKunde);
				this.alle_kunden_textboxen_auf_read();
				// }
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{	
			if (this.txtbox_K�rzel.Text.Equals(""))
			{
				MessageBox.Show("Ja w�rd ich gern, wennn ein Kunde angegeben w�r! Ey!");
			}
			else
			{
				this.bearbeiten_flag = true;
				this.alle_kunden_textboxen_auf_write();
			}
		}

		private void button_Neu_Click(object sender, System.EventArgs e)
		{
			this.neuer_Kunde = true;
			this.bearbeiten_flag = true;
			this.alle_kunden_textboxen_auf_write();
			this.alle_kunden_textboxen_Inhalt_loeschen();
		}

		private void button_loeschen_Click(object sender, System.EventArgs e) // CSW - 26.10.03
		{
			VG.Position_aus_Liste_l�schen(); // l�scht die "ge-highlighted-te" Zeile
			dataGrid_Vorgang.Enabled=true;	 // und setzt die Einstellungen zur�ck auf Standard	
			button_loeschen.Visible=false;
			DG_Zeile_bearbeiten=false;

		
			dataGridTableStyle2.SelectionBackColor=System.Drawing.SystemColors.ActiveCaption;
			ZahlungsTab_aktualisieren();
		}

		private void button_allePositionen_Click(object sender, System.EventArgs e)
		{
			Dialog_Positionen DialogPos = new Dialog_Positionen();
			DialogPos.ShowDialog();

		}

		private void button_�bersicht_alle_Kunden_Click(object sender, System.EventArgs e)
		{	// Statt einem DataSet �bernehme ich hier ein DataView, damit ich die Zeilen Sortieren kann
			Ansicht=Ansichtsache.Kunden;
			DG_�bersicht.Enabled =false;
			DataView KundenView = new DataView(UnsereDb.alle_Kunden_ausgebenDS().Tables[0]);
			KundenView.Sort="Kundennr";
			DG_�bersicht.SetDataBinding(KundenView,null);
			DG_�bersicht.Enabled =true;
		}

		private void button_�bersicht_Pos_Anzeigen_Click(object sender, System.EventArgs e)
		{
			if (radio_F.Checked)
			{
				Ansicht=Ansichtsache.Fliesen;
				DG_�bersicht.SetDataBinding(UnsereDb.alle_Postionen_ausgebenDS(),"FPos");
			}
			else if (radio_M.Checked)
			{
				Ansicht=Ansichtsache.Maurer;
				DG_�bersicht.SetDataBinding(UnsereDb.alle_Postionen_ausgebenDS(),"MPos");
			}
			else
			{
				Ansicht=Ansichtsache.Zusatz;
				DG_�bersicht.SetDataBinding(UnsereDb.alle_Postionen_ausgebenDS(),"ZPos");
			}

		}

		private void button_�bersicht_Vorg�nge_anzeigen_Click(object sender, System.EventArgs e)
		{	
			Ansicht=Ansichtsache.Vorgang;
			DG_�bersicht.Enabled =false;
			
			DataView VorgangsView = new DataView(UnsereDb.alle_Vorgaenge_eines_Kunden_ausgeben().Tables[0]);
			VorgangsView.Sort="Index";
			DG_�bersicht.SetDataBinding(VorgangsView,null);
			DG_�bersicht.Enabled =true;	
		}

		private void button_�bersicht_Kunden_suchen_Click(object sender, System.EventArgs e)
		{
			Ansicht = Ansichtsache.Kunden;
			string name;
			name = this.txtBox_�bersicht_Kundenauswahl.Text;
			
			DG_�bersicht.Enabled =false;
			DataView KundenView = new DataView(UnsereDb.alle_Kunden_ausgebenDS().Tables[0]);
			KundenView.Sort="Kundennr";
			KundenView.RowFilter = "Name LIKE '"+name+"%'" ;
			if (KundenView.Count==0)
			{
					MessageBox.Show("Keine passenden Eintr�ge gefunden.","Schade");
				KundenView.RowFilter="";
			}
			
			DG_�bersicht.SetDataBinding(KundenView,null);
			DG_�bersicht.Enabled =true;
		}

		private void button_�bersicht_Vorgang_suchen_Click(object sender, System.EventArgs e)
		{	
			Ansicht = Ansichtsache.Vorgang;
			string name;
			name = this.txtBox_�bersicht_Vorgang_suchen.Text;
			DG_�bersicht.Enabled =false;
			DataView VorgangsView = new DataView(UnsereDb.alle_Vorgaenge_eines_Kunden_ausgeben().Tables[0]);
			VorgangsView.Sort="Index";
			VorgangsView.RowFilter = "Name LIKE '"+name+"%'" ;
			if (VorgangsView.Count==0)
			{
				MessageBox.Show("Keine passenden Eintr�ge gefunden.","Schade");
				VorgangsView.RowFilter="";
			}
			
			DG_�bersicht.SetDataBinding(VorgangsView,null);
			DG_�bersicht.Enabled =true;
		}

		// Sind auch Buttons heissen aber nicht so ;-)
		private void Pos_anlegen_Click(object sender, System.EventArgs e)
		{
			this.position_anlegen = true;
			this.position_Textboxen_loeschen();
			this.position_Textboxen_auf_write();
		}

		private void pos_Speichern_Click(object sender, System.EventArgs e)
		{
			this.position_anlegen = false;
			VG.aktPos.Positionsnummer = this.txtbox_Posnummer.Text;
			VG.aktPos.Kurztext = this.txtbox_Kurztext.Text;
			VG.aktPos.Langtext = this.txtbox_Langtext.Text;
			VG.aktPos.Einheit = this.txtbox_Einheit.Text;
			this.position_Textboxen_auf_read();
			decimal epreis;
			try 
			{
				epreis = Convert.ToDecimal(this.txtbox_Einzelpreis.Text);
			}
			catch 
			{
				epreis = 1;
			}
			VG.aktPos.EPreis = epreis;
			
			
			try
			{
				UnsereDb.Neue_Pos_Anlegen(VG.aktPos);
			}

			catch
			{
				MessageBox.Show("Es ist ein Fehler beim Anlegen der Position aufgetreten.");
			}

			this.position_Anzeigen(VG.aktPos);
		}

	#endregion


	#region TabSeitenInhalte anzeigen/aktualisieren
		private void kunde_Anzeigen (Kunde K) //- CH 18.10.03 19:34
		{
			this.txtbox_K�rzel.Text = K.Kuerzel;
			this.k�rzelstring = this.txtbox_K�rzel.Text;
			this.txtbox_Name.Text = K.NName;
			
			if (K.Kundennummer == 0)
				this.txtbox_Kundennummer.Text = null;
			else this.txtbox_Kundennummer.Text = ""+K.Kundennummer;
			
			
			this.txtbox_Ort.Text = K.Ort;
			
	
			if (K.PLZ == 0)
				this.txtbox_PLZ.Text = null;
			else this.txtbox_PLZ.Text = ""+K.PLZ;
				
			this.txtbox_Strasse.Text = K.Strasse;
			this.txtbox_Vorname.Text = K.VName;
			this.txtbox_Telefonnummer.Text = K.Telefonnummer;
			this.txtbox_Fax.Text = K.Fax;
			this.txtbox_Email.Text = K.Email;
			switch (K.Anrede)
			{
				case "Herr": this.cbox_Anrede.SelectedIndex = 0;
					break;	
				case "Frau": this.cbox_Anrede.SelectedIndex = 1;
					break;
				case "Firma": this.cbox_Anrede.SelectedIndex = 2;
					break;

			
			}
				
		}
		
		private void position_Anzeigen (Position K) //- CH 22.10.03 14:34
		{
			this.txtbox_Posnummer.Text = K.Positionsnummer;
			this.txtbox_Kurztext.Text = K.Kurztext;
			this.txtbox_Langtext.Text = K.Langtext;	
			this.txtbox_Einzelpreis.Text = ""+K.EPreis;
			this.txtbox_Fl�che.Text = ""+K.Flaeche;
			this.txtbox_Einheit.Text = K.Einheit;
			this.txtbox_Gesamtpreis.Text = ""+K.GPreis;
			this.txtbox_Raum.Text = K.Raum;		
		}

		private void bauvorhaben_Anzeigen (Vorgang V) //- CH 12.11.03 17:11
		{
			this.txtbox_VNummer.Text = ""+V.Vorgangsnummer;
			this.txtbox_VBezeichnung.Text = V.Vorgangsbezeichnung;
			this.dateTimePicker_Bau.Text = ""+V.Datum;	
			this.txtbox_NameBau.Text = V.BauNName;
			this.txtbox_VornameBau.Text = V.BauVName;
			this.txtbox_StrasseBau.Text = V.BauStrasse;
			this.txtbox_OrtBau.Text = V.BauOrt;
			this.txtbox_PlzBau.Text = ""+V.BauPLZ;
			switch (V.Typ)
			{
				case "Aufma�": this.radio_Aufma�.Select();
					break;	
				case "Angebot": this.radio_Angebot.Select();
					break;
				case "Rechnung": this.radio_Rechnung.Select();
					break;
			}
		}

		private void ZahlungsTab_aktualisieren()
		{// k�nnte auch ZahlungsTab_Anzeigen heissen
			txtbox_Mwst.Text=Convert.ToString(VG.MwSt);
			txtbox_Rabatt.Text=Convert.ToString(VG.Rabatt);
			txtbox_Netto.Text=string.Format( "{0:C}",VG.Netto);
			txtbox_Brutto.Text=string.Format( "{0:C}",VG.Brutto);
		}

	#endregion

		
	#region KontextMen� - inkl. EventHandler und DataGrid_MouseUp
		private void Kunde_�bernehmen_aus_�bersicht (object sender, System.EventArgs e)
		{	
			
			int KDNr = Convert.ToInt32( DG_�bersicht[DG_�bersicht.CurrentRowIndex,0]);
			//MessageBox.Show(Convert.ToString(KDNr));
			VG.UnserKunde=new Kunde();
			VG.UnserKunde=UnsereDb.Kunde_suchen_nach_Kundennummer(KDNr);
			kunde_Anzeigen(VG.UnserKunde);
			tabControl1.SelectedTab = Kunde;
			

			
		}
		
		private void Position_�bernehmen_aus_�bersicht (object sender, System.EventArgs e)
		{
			string PosNr = Convert.ToString (DG_�bersicht[DG_�bersicht.CurrentRowIndex,0]);
			VG.aktPos = UnsereDb.Pos_suchen_nach_Posnummer(PosNr);	
			if (VG.aktPos != null)
			{
				position_Anzeigen(VG.aktPos);
				tabControl1.SelectedTab = Positionen;
				txtbox_Fl�che.Focus();
			}
			else
			{
				MessageBox.Show("Die angegebene Position konnte nicht gefunden werden","Es ist ein Fehler aufgetreten");
			}
					
		}	
			
		private void Vorgang_laden_aus_�bersicht (object sender, System.EventArgs e)
		{
			
			
			VG = new Vorgang();
			VG.Dateiname = Convert.ToString (DG_�bersicht[DG_�bersicht.CurrentRowIndex,1]);
			VG.hat_Namen=true;
			dataGrid_Vorgang.Enabled=true;  // Gleicher Spass wie bei �bernehmen_click
			VG.XML_lesen();
			dataGrid_Vorgang.SetDataBinding(VG.PosListe, "Positionen");
			dataGrid_Vorgang.ReadOnly=true;
			dateTimePicker_Bau.Value=VG.Datum;
			kunde_Anzeigen(VG.UnserKunde);
			bauvorhaben_Anzeigen(VG) ;
			ZahlungsTab_aktualisieren();
			tabControl1.SelectedTab = Zahlung;
			// Bauvorhaben-Tabseite aktualisieren
		}

		private void dataGrid_Vorgang_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				System.Windows.Forms.DataGrid.HitTestInfo myHitTest;
				myHitTest = dataGrid_Vorgang.HitTest(e.X,e.Y);
				if (myHitTest.Type == System.Windows.Forms.DataGrid.HitTestType.Cell)
				{
					cMenu_VorgangDG.MenuItems.Clear();
					cMenu_VorgangDG_Anlegen();
					dataGrid_Vorgang.UnSelect(dataGrid_Vorgang.CurrentRowIndex);
					dataGrid_Vorgang.CurrentRowIndex=myHitTest.Row;
					DG_aktZeile=dataGrid_Vorgang.CurrentRowIndex;
					dataGrid_Vorgang.Select(DG_aktZeile);
					cMenu_VorgangDG.Show(dataGrid_Vorgang,new Point(e.X,e.Y));
				}		
			}
		}	
		private void Position_bearbeiten (object sender, System.EventArgs e)
		{
			try
			{
				if (DG_Zeile_bearbeiten==false) //so ist der Doppelklick deaktiviert w�hrend noch eine Zeile bearbeitet wird.
				{	
					button_loeschen.Visible=true;
					// �bernimmt die doppelt-geklickte Zeile als aktPos und l�scht sie aus der PosListe
					// DG_aktZeile = dataGrid_Vorgang.CurrentRowIndex; Sollte schon belegt sein ( in dataGrid_Vorgang_MouseUp)
					VG.Position_aus_Liste_�ndern(DG_aktZeile);
					// Formatierung �ndern, um die Zeile hervorzuheben
					
				dataGridTableStyle2.SelectionBackColor=System.Drawing.Color.DarkRed;
				dataGrid_Vorgang.Select(DG_aktZeile);
					DG_Zeile_bearbeiten=true;
					position_Anzeigen(VG.aktPos);
					dataGrid_Vorgang.Enabled=false;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show("Fehler in Posbearbeiten");
			}

		}
		private void Position_l�schen (object sender, System.EventArgs e)
		{
			if(MessageBox.Show("Wollen sie die Position wirklich l�schen?", "www.nervige-Nachfrage.de",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
			{
				VG.Position_aus_Liste_�ndern(DG_aktZeile);
				VG.Position_aus_Liste_l�schen(); 
				ZahlungsTab_aktualisieren();
			}
			else MessageBox.Show("Dann halt nicht","www.nutzloser-Kommentar.de");
			
			
		}
		private void Position_einf�gen (object sender, System.EventArgs e)
		{
//
			DataTable derEine;
			derEine = VG.PosListe.Tables[0];
			
				object[] rowVals = new object[7];
			 
			// Add and return the new row.
			//			 		myNewRow = rc.Add(rowVals);	
			
			DataRow DR = VG.PosListe.Tables[0].NewRow();
			DR[0] = "-";
			DR[1] = "-";
			DR[2] = "-";
			DR[3] = "-";
			DR[4] = 0;
			DR[5] = 0;
			DR[6] = "-";
			DR[7] = 0;
			//			
			
			derEine.Rows.InsertAt(DR,DG_aktZeile );
			
			VG.PosListe.Tables.Clear();
			VG.PosListe.Tables.Add(derEine) ;
		

			//dataGrid_Vorgang.SetDataBinding(VG.PosListe, "Positionen");
			PosView=new DataView(VG.PosListe.Tables[0]);
			MessageBox.Show(Convert.ToString("Index:"+DG_aktZeile));
			MessageBox.Show(Convert.ToString("Anzahl der Zeilen:"+VG.PosListe.Tables[0].Rows.Count));
			dataGrid_Vorgang.Select(DG_aktZeile);
			dataGrid_Vorgang.CurrentRowIndex=DG_aktZeile;
		
	//		Position_bearbeiten(sender,e);
//						
		}

		
//			 		DataRowCollection rc; 
//			 		DataRow myNewRow;
//			 		//ein Array f�r die 7 Spalten
////					rc = new DataRowCollection();
//				object[] rowVals = new object[7];
//			 
//			 		// Add and return the new row.
////			 		myNewRow = rc.Add(rowVals);	
//			
//			DataRow DR = VG.PosListe.Tables[0].NewRow();
//			DR[0] = "";
//			DR[1] = "";
//			DR[2] = "";
//			DR[3] = "";
//			DR[4] = 0;
//			DR[5] = 0;
//			DR[6] = 0;
//			
//			VG.PosListe.Tables[0].Rows.InsertAt(DR,dataGrid_Vorgang.CurrentRowIndex );// (new object[]{"",0,"","",0,0,0});
//			dataGrid_Vorgang.SetDataBinding(null,null);
//			dataGrid_Vorgang.SetDataBinding(VG.PosListe, "Positionen");
//			if(MessageBox.Show("Noch nicht implementiert", "Not Yet Done",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
//					MessageBox.Show("Wirklich noch nicht", "Not Yet Done");
//				else
//					MessageBox.Show("Ich schw����r, Alder", "Glaubste nich, oder was",MessageBoxButtons.AbortRetryIgnore);
//			//VG.PosListe.Tables[0].Rows.
			//DG_Test();
		//dataGrid_Vorgang.i
	
		
		

		private void DG_�bersicht_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				System.Windows.Forms.DataGrid.HitTestInfo myHitTest;
				myHitTest = DG_�bersicht.HitTest(e.X,e.Y);
				cMenu_KundenDG.MenuItems.Clear();
				cMenu_KundenDG_Anlegen(); // Standard-Elemente

				if (myHitTest.Type == System.Windows.Forms.DataGrid.HitTestType.Cell)
				{
					DG_�bersicht.UnSelect(DG_�bersicht.CurrentRowIndex);
					DG_�bersicht.CurrentRowIndex=myHitTest.Row;
					DG_�bersicht.Select(DG_�bersicht.CurrentRowIndex);
					cMenu_KundenDG.MenuItems.Add("-");
					switch (Ansicht)
					{
						case Ansichtsache.Fliesen:
							cMenu_KundenDG.MenuItems.Add("Position �bernehmen",new System.EventHandler(Position_�bernehmen_aus_�bersicht));
							break;
						case Ansichtsache.Kunden:
							cMenu_KundenDG.MenuItems.Add("Kunden �bernehmen",new System.EventHandler(Kunde_�bernehmen_aus_�bersicht));	
							break;
						case Ansichtsache.Vorgang:
							cMenu_KundenDG.MenuItems.Add("Vorgang laden",new System.EventHandler(Vorgang_laden_aus_�bersicht));
							break;
						case Ansichtsache.Maurer:
							cMenu_KundenDG.MenuItems.Add("Position �bernehmen",new System.EventHandler(Position_�bernehmen_aus_�bersicht));
							break;
						case Ansichtsache.Zusatz:
							cMenu_KundenDG.MenuItems.Add("Position �bernehmen",new System.EventHandler(Position_�bernehmen_aus_�bersicht));
							break;
						default:
							break;
					}
					
					
					//DG_�bersicht.
					
					// Use the DataGrid control's HitTest method with the x and y properties.
					
				}
				cMenu_KundenDG.Show(DG_�bersicht,new Point(e.X,e.Y));
				//if(DG_�bersicht.HitTest(e.X,e.Y).Type.ToString()=="Cell")
			}
		}

		private void cMenu_KundenDG_Anlegen()
		{
			switch (Ansicht)
			{
				case Ansichtsache.Fliesen:
					cMenu_KundenDG.MenuItems.Add("alle Kunden",new System.EventHandler(this.button_�bersicht_alle_Kunden_Click));
					cMenu_KundenDG.MenuItems.Add("alle Vorg�nge",new System.EventHandler(this.button_�bersicht_Vorg�nge_anzeigen_Click));
					cMenu_KundenDG.MenuItems.Add("-");
					cMenu_KundenDG.MenuItems.Add("Aktuell: Fliesenleger-Positionen anzeigen",new System.EventHandler(FPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Maurer-Positionen anzeigen",new System.EventHandler(MPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Zusatz-Positionen anzeigen",new System.EventHandler(ZPos_dummy));	
					break;
				case Ansichtsache.Kunden:
					cMenu_KundenDG.MenuItems.Add("Aktuell: alle Kunden",new System.EventHandler(this.button_�bersicht_alle_Kunden_Click));
					cMenu_KundenDG.MenuItems.Add("alle Vorg�nge",new System.EventHandler(this.button_�bersicht_Vorg�nge_anzeigen_Click));
					cMenu_KundenDG.MenuItems.Add("-");
					cMenu_KundenDG.MenuItems.Add("Fliesenleger-Positionen anzeigen",new System.EventHandler(FPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Maurer-Positionen anzeigen",new System.EventHandler(MPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Zusatz-Positionen anzeigen",new System.EventHandler(ZPos_dummy));	
					break;
				case Ansichtsache.Vorgang:
					cMenu_KundenDG.MenuItems.Add("alle Kunden",new System.EventHandler(this.button_�bersicht_alle_Kunden_Click));
					cMenu_KundenDG.MenuItems.Add("Aktuell: alle Vorg�nge",new System.EventHandler(this.button_�bersicht_Vorg�nge_anzeigen_Click));
					cMenu_KundenDG.MenuItems.Add("-");
					cMenu_KundenDG.MenuItems.Add("Fliesenleger-Positionen anzeigen",new System.EventHandler(FPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Maurer-Positionen anzeigen",new System.EventHandler(MPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Zusatz-Positionen anzeigen",new System.EventHandler(ZPos_dummy));	
					break;
				case Ansichtsache.Maurer:
					cMenu_KundenDG.MenuItems.Add("alle Kunden",new System.EventHandler(this.button_�bersicht_alle_Kunden_Click));
					cMenu_KundenDG.MenuItems.Add("alle Vorg�nge",new System.EventHandler(this.button_�bersicht_Vorg�nge_anzeigen_Click));
					cMenu_KundenDG.MenuItems.Add("-");
					cMenu_KundenDG.MenuItems.Add("Fliesenleger-Positionen anzeigen",new System.EventHandler(FPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Aktuell: Maurer-Positionen anzeigen",new System.EventHandler(MPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Zusatz-Positionen anzeigen",new System.EventHandler(ZPos_dummy));	
					break;
				case Ansichtsache.Zusatz:
					cMenu_KundenDG.MenuItems.Add("alle Kunden",new System.EventHandler(this.button_�bersicht_alle_Kunden_Click));
					cMenu_KundenDG.MenuItems.Add("alle Vorg�nge",new System.EventHandler(this.button_�bersicht_Vorg�nge_anzeigen_Click));
					cMenu_KundenDG.MenuItems.Add("-");
					cMenu_KundenDG.MenuItems.Add("Fliesenleger-Positionen anzeigen",new System.EventHandler(FPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Maurer-Positionen anzeigen",new System.EventHandler(MPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Aktuell: Zusatz-Positionen anzeigen",new System.EventHandler(ZPos_dummy));	
					break;
				default:
					cMenu_KundenDG.MenuItems.Add("alle Kunden",new System.EventHandler(this.button_�bersicht_alle_Kunden_Click));
					cMenu_KundenDG.MenuItems.Add("alle Vorg�nge",new System.EventHandler(this.button_�bersicht_Vorg�nge_anzeigen_Click));
					cMenu_KundenDG.MenuItems.Add("-");
					cMenu_KundenDG.MenuItems.Add("Fliesenleger-Positionen anzeigen",new System.EventHandler(FPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Maurer-Positionen anzeigen",new System.EventHandler(MPos_dummy));	
					cMenu_KundenDG.MenuItems.Add("Zusatz-Positionen anzeigen",new System.EventHandler(ZPos_dummy));	
					break;
			}
		}
		private void cMenu_VorgangDG_Anlegen()
		{
			cMenu_VorgangDG.MenuItems.Add("Neue Position hier einf�gen",new System.EventHandler(Position_einf�gen));	
			cMenu_VorgangDG.MenuItems.Add("Diese Position bearbeiten",new System.EventHandler(Position_bearbeiten));	
			cMenu_VorgangDG.MenuItems.Add("-");
			cMenu_VorgangDG.MenuItems.Add("Diese Position l�schen",new System.EventHandler(Position_l�schen));	

		}
		private void FPos_dummy(object sender, System.EventArgs e)
		{
			DG_�bersicht.Enabled =false;
			radio_F.Checked=true;
			this.button_�bersicht_Pos_Anzeigen_Click(sender, e);
			DG_�bersicht.Enabled =true;	

		}
		private void MPos_dummy(object sender, System.EventArgs e)
		{
			DG_�bersicht.Enabled =false;
			radio_M.Checked=true;
			this.button_�bersicht_Pos_Anzeigen_Click(sender, e);
			DG_�bersicht.Enabled =true;

		}
		private void ZPos_dummy(object sender, System.EventArgs e)
		{
			DG_�bersicht.Enabled =false;
			radio_Z.Checked=true;
			this.button_�bersicht_Pos_Anzeigen_Click(sender, e);
			DG_�bersicht.Enabled =true;
			

		}

	#endregion
	
		
	#region Casi's Druck-Ger�mpel
		private void menuDruckenPageSetup_Click(object sender, System.EventArgs e)
		{
			try
			{
				PageSetupDialog psDlg = new PageSetupDialog();
				// Erzeugen eines PageSetting-objektes, falls noch keines erzeugt wurde
				if(this.storedPageSettings == null ) 
					this.storedPageSettings = new PageSettings();

				psDlg.PageSettings = this.storedPageSettings;
				psDlg.ShowDialog();
			}
			catch(Exception ex)
			{
			MessageBox.Show(ex.Message);
			}
		}

		private void menuDruckenPrint_Click(object sender, System.EventArgs e)
		{
			if (VG.UnserKunde.Kundennummer==0)
			{
				MessageBox.Show("Bitte dem zudruckenden Auftrag einen Kunden zuweisen.");
				return;
			}
			try
			{
				PrintDocument pd = new PrintDocument();
				aktuelleSeite = 1;
				pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);

				if(this.storedPageSettings != null)
					pd.DefaultPageSettings = this.storedPageSettings;
				PrintDialog dlg = new PrintDialog();
				dlg.Document = pd;
				DialogResult result = dlg.ShowDialog();
				if(result == System.Windows.Forms.DialogResult.OK)
					pd.Print();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		private string[] ZeilenZ�hler(string Text){
		
		
		int maxCharInLine=38;	
		int count=0; // Zeilen des Ergebinsarrays mit druckbaren Zeichenl�ngen
		int i=0; // Index des "W�rterarrays"
		string myString = Text;
		string [] myStringArray;
		string [] Zeilen = new string[25];
		myStringArray = myString.Split(null,100); // Zerlegt den String in Worte und speichert sie sequenziel in ein Array
     		
			while(i<myStringArray.Length) 
			{
			
				if(Zeilen[count]==null)
				{
					
					Zeilen[count]=myStringArray[i];
					i++;}
				else
				{

					if(Zeilen[count].Length + myStringArray[i].Length < maxCharInLine) // Wenn die Zeichen der aktuellen Zeile plus die Zeichen des n�chsten WOrtes kleiner als 25 ist, d.h noch gedruckt werden k�nnen, dann wird das WOrt der Zeile hinzugef�gt.
					{ 
					
						Zeilen[count]=Zeilen[count]+" "+myStringArray[i];
						i++;
					}
					else
						count++; // Das n�chste Wort passt nicht mehr in die Zeile, es wird in der n�chsten Zeile begonnen
				}

			}
				return Zeilen;
			}
			

		private void pd_PrintPage(object sender, PrintPageEventArgs e){
		    
           
			
			string s_Anrede;
			string s_Strasse;
			string s_Ort;
			string s_Kuerzel;
			string s_Datum;
			string s_Bauadresse;
			string s_Bestellung;
			string s_Rechnung;
			string [] langText;
       // Abst�nde zum linken Rand --> hier mal als Tab bezeichnet
			
			const float ersterTab=61F;
			const float zweiterTab= 94.88F;
			const float MitteTab=183F;
			const float DatumsTab=452.05F;
			const float AnzahlEinheitTab= 109.05F;
			const float KuerzelTab=452.05F;
			const float RechnungsTabS1= 354.33F;
			const float PreisTab=439.4F;
			const float SummeTab=490.4F;
            PosAnzahl= VG.PosListe.Tables[0].Rows.Count;
            int maxLine=58;
            
			int x=0; //Schleifenz�hler
	int aktline= 0;
            e.Graphics.PageUnit = GraphicsUnit.Point; // PrintingPoints statt Pixel
			if(aktuelleSeite == 1)
			{
			
			
		  // Strings erzeugen
            s_Anrede= VG.UnserKunde.Anrede.Trim();
			s_Anrede+=" "+VG.UnserKunde.NName.Trim();
            s_Strasse=VG.UnserKunde.Strasse.Trim();
			s_Ort = VG.UnserKunde.PLZ.ToString();
            s_Ort += " "+VG.UnserKunde.Ort;
            s_Datum = VG.Datum.Day.ToString();
			s_Datum +="."+VG.Datum.Month.ToString();
			s_Datum +="."+VG.Datum.Year.ToString();
			s_Kuerzel= VG.UnserKunde.Kuerzel.ToString();
            s_Bauadresse= VG.BauStrasse.ToString();
			s_Bauadresse+="   "+VG.BauPLZ.ToString();
            s_Bauadresse+=" "+VG.BauOrt.ToString();
            s_Bestellung="Bestellung: 0007/45000007762/ip";
			s_Rechnung="RECHNUNG Nr.: "+VG.Vorgangsnummer.ToString();
		
			// Strings drucken
		  
		    e.Graphics.DrawString(s_Anrede,this.subTextFont, Brushes.Black, zweiterTab, 13*this.subTextFont.SizeInPoints);
			e.Graphics.DrawString(s_Strasse,this.subTextFont, Brushes.Black, zweiterTab, 14*this.subTextFont.SizeInPoints);
            e.Graphics.DrawString(s_Ort,this.subTextFont, Brushes.Black, zweiterTab, (16*this.subTextFont.SizeInPoints));
            e.Graphics.DrawString(s_Datum,this.subTextFont, Brushes.Black, DatumsTab, 20*this.subTextFont.SizeInPoints);
			e.Graphics.DrawString(s_Kuerzel, this.subTextFont, Brushes.Black,KuerzelTab, 21*this.subTextFont.SizeInPoints );
            e.Graphics.DrawString(s_Bauadresse, this.subTextFont, Brushes.Black,zweiterTab, 23*this.subTextFont.SizeInPoints);
	        e.Graphics.DrawString(s_Bestellung, this.subTextFont, Brushes.Black,zweiterTab, 24*this.subTextFont.SizeInPoints);
		    e.Graphics.DrawString(s_Rechnung, this.subTextFont, Brushes.Black,RechnungsTabS1, 24*this.subTextFont.SizeInPoints); // Hier fehlt noch der Test, ob der string in die Zeile passt
            aktline=26;
				//  proprit�re L�sung, sehr unflexibel!
			    
				while(aktline<=maxLine && PosAnzahl>0){
                 
	    		   langText = this.ZeilenZ�hler(VG.PosListe.Tables[0].Rows[aktuellePos][3].ToString());
					if(langText.Length+aktline>maxLine)
					{
						e.HasMorePages=true;
					}
					else
					{

						string PosNummer = VG.PosListe.Tables[0].Rows[aktuellePos][1].ToString();
						string AnzahlEinheit = VG.PosListe.Tables[0].Rows[aktuellePos][5].ToString();
						e.Graphics.DrawString(PosNummer, this.subTextFont, Brushes.Black, ersterTab,aktline*this.subTextFont.SizeInPoints);
						e.Graphics.DrawString(AnzahlEinheit, this.subTextFont, Brushes.Black, AnzahlEinheitTab,aktline*this.subTextFont.SizeInPoints);
						x=0;
						while(x <langText.Length && langText[x]!=null)
						{
							
							e.Graphics.DrawString(langText[x],this.subTextFont, Brushes.Black,MitteTab,aktline*this.subTextFont.SizeInPoints);
							aktline++;
							x++;
						}
                   
					e.Graphics.DrawString(VG.PosListe.Tables[0].Rows[aktuellePos][4].ToString(),this.subTextFont,Brushes.Black,PreisTab,(aktline-1)*this.subTextFont.SizeInPoints);
                    e.Graphics.DrawString(VG.PosListe.Tables[0].Rows[aktuellePos][6].ToString(),this.subTextFont,Brushes.Black,SummeTab,(aktline-1)*this.subTextFont.SizeInPoints);
					aktuellePos++;
					MessageBox.Show(aktuellePos.ToString());
					PosAnzahl--;
					aktline++;
					
					}
				   
				}
				
			
			}
			else
			{ 
					e.Graphics.DrawString("Dies �sollte nicht dat Deckblatt sein ;-)",this.maintextFont, Brushes.Black, 10,10);
			        e.HasMorePages=false;	
			}

		}


		private void menuDruckenPrintPreview_Click(object sender, System.EventArgs e)
		{
     			
			if (VG.UnserKunde.Kundennummer==0)
			{
			MessageBox.Show("Bitte dem zudruckenden Auftrag einen Kunden zuweisen.");
				return;
			}
			try
			{
				aktuelleSeite=1;
				PrintDocument pd = new PrintDocument();
				pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
				if(this.storedPageSettings != null)
					pd.DefaultPageSettings = this.storedPageSettings;
				PrintPreviewDialog dlg = new PrintPreviewDialog();
				dlg.Document = pd;
				dlg.ShowDialog();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

	#endregion


		private void radio_Aufma�_CheckedChanged(object sender, System.EventArgs e)
		{
		if(radio_Aufma�.Checked==true)
			VG.Vorgangstyp="AUF";
		}

		private void radio_Angebot_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radio_Angebot.Checked==true)
				VG.Vorgangstyp="ANG";
		}

		private void radio_Rechnung_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radio_Rechnung.Checked==true)
				VG.Vorgangstyp="RE";
		}

	
		private void LBox_Kunde_DoubleClick(object sender, System.EventArgs e)
		{
				int index = LBox_Kunde.SelectedIndex;
			VG.UnserKunde = Verzeichnis[index];
			kunde_Anzeigen(VG.UnserKunde);
			LBox_Kunde.Visible=false;
		}

		private void LBox_Kunde_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			MessageBox.Show(""+LBox_Kunde.SelectedIndex);

		}


		private void cbox_Anrede_Leave(object sender, System.EventArgs e)
		{
			if (this.bearbeiten_flag)
			{
				if (this.cbox_Anrede.SelectedIndex == 0)
					VG.UnserKunde.Anrede = "Herr";
				if (this.cbox_Anrede.SelectedIndex == 1)
					VG.UnserKunde.Anrede = "Frau";
				else if (this.cbox_Anrede.SelectedIndex == 2)
					VG.UnserKunde.Anrede = "Firma";

				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		
		private void dateTimePicker_Bau_ValueChanged(object sender, System.EventArgs e)
		{
			VG.Datum = dateTimePicker_Bau.Value;
		}


	
	
		private void dataGrid_Vorgang_CurrentCellChanged(object sender, System.EventArgs e) //CSW - 23.10.03 00:01
		{	
			// Schreibt mir den aktuellen Zeilenindex in eine nette Variable, dies war das einzige verl�ssliche Event
			//this.DG_aktZeile=dataGrid_Vorgang.CurrentRowIndex;
			
		}

		public void Kundenliste_anzeigen (KundenVerzeichnis Verzeichnis)
		{
			LBox_Kunde.Visible=true;
			LBox_Kunde.Items.Clear();
			for(int i=0;i< Verzeichnis.Count;i++)
			{
				string Lboxtext = Verzeichnis[i].NName +", "+ Verzeichnis[i].VName;
				Lboxtext += "   -   " + Verzeichnis[i].Strasse + "   -   " +  Verzeichnis[i].PLZ + " " +Verzeichnis[i].Ort;
				LBox_Kunde.Items.Add(Lboxtext);
			}
		}

		
		private void position_Textboxen_loeschen()
		{
			this.txtbox_Posnummer.Text = "";
			this.txtbox_Kurztext.Text = "";
			this.txtbox_Langtext.Text = "";	
			this.txtbox_Einzelpreis.Text = "";
			this.txtbox_Fl�che.Text = "";
			this.txtbox_Gesamtpreis.Text = "";
			this.txtbox_Einheit.Text ="";
			this.txtbox_Raum.Text = "";
		}

		private void position_Textboxen_auf_write () //- CH 26.10.03 21:00
		{
			this.txtbox_Posnummer.ReadOnly = true; //Posnummer wird automatisch von DB vergeben
			this.txtbox_Kurztext.ReadOnly = false;
			this.txtbox_Langtext.ReadOnly = false;	
			this.txtbox_Einzelpreis.ReadOnly = false;
			this.txtbox_Einheit.ReadOnly =false;
			this.txtbox_Fl�che.ReadOnly = true;  // da die Eingabe der Fl�che nicht ben�tigt wird
			// Gesamtpreis bleibt unver�ndert
			// bei ZPositions eingabe wird keine Raum ben�tigt, daher w�rde es nur verwirren, wenn man hier eine Eingabe zulassen w�rde.		
		}

		private void position_Textboxen_auf_read () //- CH 26.10.03 21:00
		{
			this.txtbox_Posnummer.ReadOnly = false; //wieder zur�ck
			this.txtbox_Kurztext.ReadOnly = true;
			this.txtbox_Langtext.ReadOnly = true;	
			this.txtbox_Einzelpreis.ReadOnly = true;
			this.txtbox_Einheit.ReadOnly =true;
			this.txtbox_Fl�che.ReadOnly = false;  // jetzt wieder im normalen Modus
			// Gesamtpreis bleibt unver�ndert
			// bei ZPositions eingabe wird keine Raum ben�tigt, daher w�rde es nur verwirren, wenn man hier eine Eingabe zulassen w�rde.		
		}

		
		private void alle_kunden_textboxen_auf_write()
		{
			this.txtbox_K�rzel.ReadOnly = false;
			this.txtbox_Name.ReadOnly = false;
			// this.txtbox_Kundennummer.ReadOnly = false;
			this.txtbox_Ort.ReadOnly = false;
			this.txtbox_PLZ.ReadOnly = false;
			this.txtbox_Strasse.ReadOnly = false;
			this.txtbox_Vorname.ReadOnly = false;
			this.txtbox_Telefonnummer.ReadOnly = false;
			this.txtbox_Fax.ReadOnly = false;
			this.txtbox_Email.ReadOnly = false;
			this.kunde_Anzeigen(VG.UnserKunde);
		}
		
		private void alle_kunden_textboxen_Inhalt_loeschen()
		{
			VG.UnserKunde.Kuerzel = "";
			VG.UnserKunde.NName = "";
			VG.UnserKunde.Kundennummer = 0;	
			// this.txtbox_Kundennummer.ReadOnly = false;
			VG.UnserKunde.Ort = "";
			VG.UnserKunde.PLZ = 0;
			VG.UnserKunde.Strasse = "";
			VG.UnserKunde.VName = "";
			VG.UnserKunde.Telefonnummer = "";
			VG.UnserKunde.Fax = "";
			VG.UnserKunde.Email = "";
			this.kunde_Anzeigen(VG.UnserKunde);
		}

		private void alle_kunden_textboxen_auf_read()
		{
			this.txtbox_K�rzel.ReadOnly = true;
			this.txtbox_Name.ReadOnly = true;
			// this.txtbox_Kundennummer.ReadOnly = true;
			this.txtbox_Ort.ReadOnly = true;
			this.txtbox_PLZ.ReadOnly = true;
			this.txtbox_Strasse.ReadOnly = true;
			this.txtbox_Vorname.ReadOnly = true;
			this.txtbox_Telefonnummer.ReadOnly = true;
			this.txtbox_Fax.ReadOnly = true;
			this.txtbox_Email.ReadOnly = true;
			this.kunde_Anzeigen(VG.UnserKunde);
		}
	
		
		
		private bool Daten_in_aktPos_schreiben() //CSW - 23.10.03 01:01
		{
			// einfache DummyFunktion ohne jegliche �berpr�fung  - UPDATE: Shit! Ohne lief dat eh nicht ordentlich :-) also soch mit Pr�fung
			// Sollte durch eine bessere ersetzt oder erweitert werden
			// Sie errechnet auch den Gesamtpreis selbst�ndig (!)
			VG.aktPos.Raum=txtbox_Raum.Text;
			VG.aktPos.Positionsnummer=txtbox_Posnummer.Text;
			VG.aktPos.Kurztext=txtbox_Kurztext.Text;
			VG.aktPos.Langtext=txtbox_Langtext.Text;
			VG.aktPos.Einheit=txtbox_Einheit.Text;
			try 
			{	
				VG.aktPos.EPreis=Convert.ToDecimal(txtbox_Einzelpreis.Text);
			}
			catch	
			{
				MessageBox.Show("Den Preis bitte als Dezimal-Zahl angeben (z.B.: 10,50)", "Ein Fehler ist aufgetreten");
				return false;
			}

			try 
			{
				VG.aktPos.Flaeche=Convert.ToDouble(txtbox_Fl�che.Text);
			}
			catch	
			{	
				MessageBox.Show("Die Fl�che bitte als Zahl in Quadratmeter angeben ", "Ein Fehler ist aufgetreten");
				return false;
			}
			
			VG.aktPos.GPreis= Convert.ToDecimal(VG.aktPos.Flaeche*(double)VG.aktPos.EPreis);
			return true;
		}

		
		private void DG_Test()
		{
		for (int i=0;i<VG.PosListe.Tables[0].Rows.Count; i++)
		{MessageBox.Show(VG.PosListe.Tables[0].Rows[i][1].ToString());}



		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			this.tabControl1.SelectedTab = Kunde;
			this.neuer_Kunde = true;
			this.bearbeiten_flag = true;
			this.alle_kunden_textboxen_auf_write();
			this.alle_kunden_textboxen_Inhalt_loeschen();
			this.button_Speichern.Visible = true;
			this.button_abbrechen.Visible = true;
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			if (this.tabControl1.SelectedTab == Kunde)
			{
				if (this.txtbox_K�rzel.Text.Equals(""))
				{
					MessageBox.Show("Ja w�rd ich gern, wennn ein Kunde angegeben w�r! Ey!");
				}
				else
				{
					this.bearbeiten_flag = true;
					this.alle_kunden_textboxen_auf_write();
				}
				}
			else 
			{
				this.tabControl1.SelectedTab = Kunde;
				MessageBox.Show("Sie m�ssen noch einen Kunden zum Bearbeiten angeben.");

			}
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			

			/*	if (this.txtbox_K�rzel.Text.Equals(""))
				{
					MessageBox.Show("Bitte geben Sie zuerst ein K�rzel ein");
				}

				else
				{     */
			this.bearbeiten_flag = false;
			this.button_Speichern.Visible = false;
			this.button_abbrechen.Visible = false;

			if (this.neuer_Kunde)
			{
				this.neuer_Kunde = false;
				UnsereDb.Neuer_Kunde_Anlegen(VG.UnserKunde);
				this.alle_kunden_textboxen_auf_read();
			}
			else
			{

				// UnsereDb.Kunde_aendern_K�rzel(this.txtbox_K�rzel.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Name(this.txtbox_Name.Text,VG.UnserKunde);
				UnsereDb.Kunde_aendern_Ort(this.txtbox_Ort.Text, VG.UnserKunde);
				
				
				string temp = this.txtbox_PLZ.Text;
				temp.Trim();
				if (temp != "")
				{
					int PLZ = Convert.ToInt32(this.txtbox_PLZ.Text);
					UnsereDb.Kunde_aendern_PLZ(PLZ, VG.UnserKunde);
				}

				
				UnsereDb.Kunde_aendern_Strasse(this.txtbox_Strasse.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Vorname(this.txtbox_Vorname.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Tel(this.txtbox_Telefonnummer.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Fax(this.txtbox_Fax.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Email(this.txtbox_Email.Text, VG.UnserKunde);
				UnsereDb.Kunde_aendern_Anrede(VG.UnserKunde.Anrede, VG.UnserKunde);
				this.alle_kunden_textboxen_auf_read();
				// }
			}
		}

		private void button_abbrechen_Click(object sender, System.EventArgs e)
		{
			this.bearbeiten_flag = false;
			this.alle_kunden_textboxen_auf_read();
			this.button_Speichern.Visible = false;
			this.button_abbrechen.Visible = false;
		}

	
	
}


	public class Kunde 
	{
		#region Private Variablen - Kunde

		private int m_Kundennummer;
		private string m_Kuerzel;
		private string m_Firma;
		private string m_Anrede;
		private string m_NName;
		private string m_VName;
		private string m_Strasse;
		private int m_PLZ;
		private string m_Ort;
		private string m_Telefonnummer;
		private string m_Fax;
		private string m_Email;
		private int m_BLZ;
		private int m_Kontonr;
		private string m_Bank;
		#endregion
		
		#region Properties - Kunde

		public int BLZ
		{
			get{return m_BLZ;}
			set{this.m_BLZ = value;}
		}
		public string Bank
		{
			get{return m_Bank;}
			set{this.m_Bank = value;}
		}
		public int Kontonr
		{
			get{return m_Kontonr;}
			set{this.m_Kontonr = value;}
		}
		public int Kundennummer
		{
			get{return m_Kundennummer;}
			set{this.m_Kundennummer = value;}
		}
		public string Kuerzel
		{
			get{return m_Kuerzel;}
			set{this.m_Kuerzel = value;}
		}
		public string Firma
		{
			get{return m_Firma;}
			set{this.m_Firma = value;}
		}
		public string Anrede
		{
			get{return m_Anrede;}
			set{this.m_Anrede = value;}
		}

		public string NName
		{
			get{return m_NName;}
			set{this.m_NName = value;}
		}
		public string VName
		{
			get{return m_VName;}
			set{this.m_VName = value;}
		}
		public string Strasse
		{
			get{return m_Strasse;}
			set{this.m_Strasse= value;}
		}
		public int PLZ
		{
			get{return m_PLZ;}
			set{this.m_PLZ= value;}
		}
		public string Ort
		{
			get{return m_Ort;}
			set{this.m_Ort= value;}
		}
		public string Telefonnummer
		{
			get{return m_Telefonnummer;}
			set{this.m_Telefonnummer= value;}
		}
		public string Fax
		{
			get{return m_Fax;}
			set{this.m_Fax= value;}
		}
		public string Email
		{
			get{return m_Email;}
			set{this.m_Email= value;}
		}


		#endregion

		#region Konstruktoren/Destruktoren - Kunde
		public Kunde () //Konstruktor	Wieder reingenommen - CSW 18.10.03 17:00
		{
			// Dummy Datensatz
			m_Kundennummer=0;
			m_Kuerzel="";
			m_Anrede="";
			m_NName="";
			m_VName="";
			m_Strasse="";
			m_PLZ=0;
			m_Ort="";
			m_Telefonnummer="";
			m_Fax="";
			m_Email="";
		}

		#endregion

		#region Funktionen - Kunde
		
		/* Die Equals-Methode wird �berschrieben. Diese
		* Methode wird bei Vergleichen zweier Objekte
		* dieser Klasse verwendet. Unter anderem ruft die
		* IndexOf-Methode einer Collection diese Methode
		* auf */
		public override bool Equals(object obj)
		{
			Kunde p = (Kunde)obj;
			if (this.Kundennummer == p.Kundennummer)
				/* zwei Objekte mit gleicher Kundennummer
				* werden als gleich gewertet */
				return true;
			else
				return false;
		}
		public	bool suche_nach_Name (string Name)
		{
			return true;
			// das ist die umst�ndliche Variante, da mehr als ein Kunde zur�ckkommen k�nnte wenn der Name nicht eindeutig ist
			// Vielleicht k�nnen wir das ja wie in DIAK mit einem DropdownFeld realisieren
			// Bitte auf die Variablen-Namen achten, habe sie so gew�hlt, damit sie die aus der Klasse nicht �berdecken.
		}

		public bool suche_nach_Kuerzel (string Kurz)
		{
			return true;
			// Suche in der DB nach dem eindeutigen Kuerzel
			// Bitte auf die Variablen-Namen achten, habe sie so gew�hlt, damit sie die aus der Klasse nicht �berdecken.
		}

		public bool suche_nach_Kundennummer (int KDNr)
		{
			return true;
			// Suche in der DB nach der eindeutigen Kundennummer
			// Bitte auf die Variablen-Namen achten, habe sie so gew�hlt, damit sie die aus der Klasse nicht �berdecken.
		}

		public bool in_DB_schreiben()
		{
			return true;
			// in unserem Brainstorm stand als Parameter noch ein "INDEX" drin
		}

		public bool Kunde_loeschen_nach_Kundennummer (int KDNr)
		{
			return true;
			// Bitte auf die Variablen-Namen achten, habe sie so gew�hlt, damit sie die aus der Klasse nicht �berdecken.
		}

		public bool Kunde_loeschen_nach_Kuerzel (string Kurz)
		{
			return true;
			// Bitte auf die Variablen-Namen achten, habe sie so gew�hlt, damit sie die aus der Klasse nicht �berdecken.
		}

		public bool Kunde_loeschen (/*den hier l�schen*/)
		{
			return true;
			// Hier kann man ja eine der beiden oberen benutzen
		}

		public bool Kunde_anlegen (/*den hier anlegen*/)
		{
			return true;
			// Dann muss vorher nat�rlich eine Vollst�ndigkeitspr�fung erfolgen
		}

		// Kunde �ndern ist nur ein speichern der aktuellen Variableninhalte
		#endregion
	}
	
	public class KundenVerzeichnis: DictionaryBase
	{
		#region KundenVerzeichnis
	
		public Kunde Add(int index,Kunde p)
		{
			Dictionary.Add(index, p);
			return p;
		}
		public bool Contains(int key)
		{
			return Dictionary.Contains(key);
		}
		public void Remove(int Kundennummer)
		{
			Dictionary.Remove(Kundennummer);
		}
																															
		public System.Collections.ICollection Values
		{
			get {return Dictionary.Values;}
		}
		/* Die schreibgesch�tzte Keys-Eigenschaft */
		public System.Collections.ICollection Keys
		{
			get {return Dictionary.Keys;}
		}
		//		Schlie�lich erm�glicht noch ein Indizierer den Zugriff auf die Personen:
		public Kunde this[int Kundennummer]
		{
			set {Dictionary[Kundennummer] = value;}
			get {return (Kunde)Dictionary[Kundennummer];}
		}
	}

	
	
	
	#endregion


	public class Vorgang
	{
		#region Private Variablen - Vorgang
		//allgemeine Variablen
		private string m_Dateiname;
		private DataRow bearbeiteteZeile;

		// zweites Tab (Bauvorhaben)
		private string m_Typ;
	
		private DateTime m_Datum; 
		private string m_BauNName; // extra f�r Hegi
		private string m_BauVName;
		private string m_BauStrasse;
		private int m_BauPLZ;
		private string m_BauOrt;
		private int m_Vorgangsnummer;
		private string m_Vorgangsbezeichnung; // evt. sowas wie Renovierung Umbau Sanierung oder so

		// drittes Tab	(Positionen)
			
		private decimal m_Netto;
		private decimal m_Brutto;
		private decimal m_MwSt;
		private decimal m_Rabatt;
		// Zus�tzlich die Variablen aus Position (Langtext/Kurztext/Preis/ etc.)

		#endregion
		 
		#region �ffentliche Variablen - Vorgang
		// erstes Tab (Kunde)
		public Kunde UnserKunde; //bzw alle seine Variablen
		public string Vorgangstyp;
		// drittes Tab (Positionen)
		public Position aktPos;		//@Casi: Hier bitte die Daten reinrocken
		public DataSet PosListe;	//Die DataSource f�r das NittyGrittyDataGriddy

		

		public bool hat_Namen;
		#endregion

		#region Properties - Vorgang
		
		public string BauNName
		{
			get{return m_BauNName;}
			set{this.m_BauNName=value;}
		}

		public string BauVName
		{
			get{return m_BauVName;}
			set{this.m_BauVName=value;}
		}
		public string Typ
		{
			get {return m_Typ;}
			set{this.m_Typ=value;}
		}
		
		public DateTime Datum // Hier ein DatenFormat raussuchen und einf�gen !!!
		{
			get {return m_Datum;}
			set {this.m_Datum=value;}
		}

		public string BauStrasse
		{
			get {return m_BauStrasse;}
			set{this.m_BauStrasse=value;}
		}

		public int BauPLZ
		{
			get {return m_BauPLZ;}
			set{this.m_BauPLZ=value;}
		}

		public string BauOrt
		{
			get {return m_BauOrt;}
			set{this.m_BauOrt=value;}
		}

		public decimal Netto
		{
			get {m_Netto = Betrag_berechnen(); 
				return m_Netto;}
			set{this.m_Netto=value;}
		}

		public decimal Brutto
		{
			get {decimal multiplikator = (MwSt*0.01m)+1;
				 decimal abzug = m_Netto*(Rabatt*0.01m);
				decimal zwischensumme =m_Netto-abzug;
				
				m_Brutto = zwischensumme*multiplikator;
				return m_Brutto;}
			set{this.m_Brutto=value;}
		}

		public decimal MwSt
		{
			get {return m_MwSt;}
			set{this.m_MwSt=value;}
		}

		public string Dateiname
		{
			get {return m_Dateiname;}
			set{this.m_Dateiname=value;}
		}

		public int Vorgangsnummer
		{
			get {return m_Vorgangsnummer;}
			set {this.m_Vorgangsnummer=value;}
		}

		public string Vorgangsbezeichnung
		{
			get {return m_Vorgangsbezeichnung ;}
			set{this.m_Vorgangsbezeichnung=value;}
		}

		public decimal Rabatt
		{
			get {return m_Rabatt;}
			set{this.m_Rabatt=value;}
		}


		#endregion

		#region Konstruktoren/Destruktoren - Vorgang
		public Vorgang ()
		{
			m_Typ= "A";
			UnserKunde = new Kunde();
			aktPos = new Position();
		
			m_Datum= DateTime.Today; // Hier ein DatenFormat raussuchen und einf�gen !!!
			m_BauNName="na"; //damit es initialisiert wird und keinen Terror macht
			m_BauVName="na";
			m_BauStrasse="Baustrasse 15";
			m_BauPLZ=49148;
			m_BauOrt="Baustelle";
			m_Netto= 0m;
			m_Brutto=0m;
			m_MwSt=16m;
			m_Dateiname="testDatei.xml";
			m_Vorgangsnummer=1;
			m_Vorgangsbezeichnung="";
			m_Rabatt=0m;
			PosListe = new DataSet("PosListe");
			InitializeDataSet();
			Vorgangstyp="ANG";
			hat_Namen = false;

		}
		#endregion

		#region Funktionen - Vorgang
		
		private void InitializeDataSet() // CSW: Anlegen der Struktur des DataSets
		{
		
			// Tabelle f�rs DataSet anlegen
			DataTable tblPos = new DataTable("Positionen");
			
			tblPos.Columns.Add("Raum", typeof(System.String));
			tblPos.Columns.Add("Position", typeof(System.String));
			tblPos.Columns.Add("Kurztext", typeof(System.String));
			tblPos.Columns.Add("Langtext", typeof(System.String));
			tblPos.Columns.Add("Preis/Einheit", typeof(System.Decimal));
			tblPos.Columns.Add("Fl�che", typeof(System.Double));
			tblPos.Columns.Add("Einheit", typeof(System.String));
			tblPos.Columns.Add("Gesamtpreis", typeof(System.Decimal));

			this.PosListe.Tables.Add(tblPos);
		}

	
		public void XML_schreiben()  // Methode um alle aktuellen Daten in ein XML-Dokument zu schreiben - CSW 18.10.03 17:00
		{	
			string Datei = Vorgangsnamen_basteln();
			
			Betrag_berechnen();
			PosListe.WriteXml(@"..\..\products.xml");	
			XmlTextWriter W = new XmlTextWriter(@"..\..\Daten\"+Datei+".xml",null);
			XmlTextReader R = new XmlTextReader(@"..\..\products.xml");
			R.Read();
			R.Read();
			R.Read();
			W.Formatting = Formatting.Indented; //Einr�ckung festlegen
		
			W.WriteStartDocument();
		
			W.WriteStartElement("Vorgang");
			W.WriteStartElement("Kunde");

			W.WriteStartElement("Kuerzel");
			W.WriteString(UnserKunde.Kuerzel);
			W.WriteEndElement();
				
			W.WriteStartElement("Kundennummer");
			W.WriteString(""+UnserKunde.Kundennummer);
			W.WriteEndElement();	
				
			W.WriteStartElement("Anrede");
			W.WriteString(UnserKunde.Anrede);
			W.WriteEndElement();
				
			W.WriteStartElement("Nachname");
			W.WriteString(UnserKunde.NName);
			W.WriteEndElement();

			W.WriteStartElement("Vorname");
			W.WriteString(UnserKunde.VName);
			W.WriteEndElement();
		
			W.WriteStartElement("Strasse");
			W.WriteString(UnserKunde.Strasse);
			W.WriteEndElement();
		
			W.WriteStartElement("PLZ");
			W.WriteString(""+UnserKunde.PLZ);
			W.WriteEndElement();

			W.WriteStartElement("Ort");
			W.WriteString(UnserKunde.Ort);
			W.WriteEndElement();

				
			W.WriteStartElement("Telefon");
			W.WriteString(UnserKunde.Telefonnummer);
			W.WriteEndElement();

			W.WriteStartElement("Fax");
			W.WriteString(UnserKunde.Fax);
			W.WriteEndElement();

			W.WriteStartElement("eMail");
			W.WriteString(UnserKunde.Email);
			W.WriteEndElement();

			W.WriteEndElement();
		
			W.WriteStartElement("Bauvorhaben");
			
			W.WriteStartElement("Vorgangsbezeichnung");
			W.WriteString(Vorgangsbezeichnung);
			W.WriteEndElement();
		
			W.WriteStartElement("Typ");
			W.WriteString(Typ);
			W.WriteEndElement();
		
			W.WriteStartElement("Vorgangsnummer");
			W.WriteString(""+Vorgangsnummer);
			W.WriteEndElement();

			W.WriteStartElement("Datum");
			string Datumstring = Convert.ToString(Datum);
			W.WriteString(Datumstring);
			W.WriteEndElement();

			W.WriteStartElement("BauNName");
			W.WriteString(BauNName);
			W.WriteEndElement();

			W.WriteStartElement("BauVName");
			W.WriteString(BauVName);
			W.WriteEndElement();

			W.WriteStartElement("BauStrasse");
			W.WriteString(BauStrasse);
			W.WriteEndElement();

			W.WriteStartElement("BauPLZ");
			W.WriteString(""+BauPLZ);
			W.WriteEndElement();

			W.WriteStartElement("BauOrt");
			W.WriteString(BauOrt);
			W.WriteEndElement();

			W.WriteStartElement("Netto");
			W.WriteString(""+Netto);
			W.WriteEndElement();
				
			W.WriteStartElement("MwSt");
			W.WriteString(""+MwSt);
			W.WriteEndElement();

			W.WriteStartElement("Brutto");
			W.WriteString(""+Brutto);
			W.WriteEndElement();


			W.WriteStartElement("Rabatt");
			W.WriteString(""+Rabatt);
			W.WriteEndElement();
	

			W.WriteStartElement("Dateiname");
			W.WriteString(Dateiname);
			W.WriteEndElement();

			W.WriteEndElement();
			
			W.WriteNode(R,false); // Die PosListe wird eingelesen
		
			W.WriteEndElement();
			W.WriteEndDocument();
			W.Close();
			R.Close();
			MessageBox.Show("Speichern abgeschlossen", "XML Schreibvorgang");
			// Schreiben des DataSets 
	
		
		}

	
		public void XML_lesen() // Methode um alle Daten einzulesen, hier brauchte ich dat DataBinding nochmal f�r alles - CSW 18.10.03 17:00
		{
				if (this.hat_Namen==true)
			{
				
				XmlTextReader R = new XmlTextReader(@"..\..\Daten\"+this.Dateiname+".xml");		// genau wie beim Schreiben nur sind die Dateinamen vertauscht, die Positionen werden nachher in products.xml geschrieben und am Ende der Methode ins DataSet gelesen
		
				R.Read();
				R.Read();
				R.Read();
				R.Read();
				R.Read(); //3 Reads bis Vorgang 4 reads liefern nix, 5 reads bis Kunde, 6 Reads bis zum Kuerzel 
				R.Read();
				// Hier sind alle Kundendaten
				UnserKunde.Kuerzel = R.ReadElementString();
				UnserKunde.Kundennummer = Convert.ToInt32(R.ReadElementString());
				UnserKunde.Anrede = R.ReadElementString();
				UnserKunde.NName = R.ReadElementString();
				UnserKunde.VName = R.ReadElementString();
				UnserKunde.Strasse = R.ReadElementString();
				UnserKunde.PLZ = Convert.ToInt32(R.ReadElementString());
				UnserKunde.Ort = R.ReadElementString();
				UnserKunde.Telefonnummer =R.ReadElementString();
				UnserKunde.Fax = R.ReadElementString();
				UnserKunde.Email = R.ReadElementString();
				R.Read();
				R.Read();
				R.Read();
				R.Read();
				// Hier sind alle Vorgangsdaten
				Vorgangsbezeichnung= R.ReadElementString();	
				Typ=R.ReadElementString();
				Vorgangsnummer=Convert.ToInt32(R.ReadElementString());
				Datum=Convert.ToDateTime(R.ReadElementString());
				BauNName=R.ReadElementString();
				BauVName=R.ReadElementString();
				BauStrasse=R.ReadElementString();
				BauPLZ=Convert.ToInt32(R.ReadElementString());
				BauOrt=R.ReadElementString();
				Netto=Convert.ToDecimal(R.ReadElementString());
				MwSt=Convert.ToDecimal(R.ReadElementString());
				Brutto = Convert.ToDecimal(R.ReadElementString());
				Rabatt=Convert.ToDecimal(R.ReadElementString());
				Dateiname=R.ReadElementString();
				R.Read();
				R.Read();
				R.Read();
				// Hier wird der Rest der Datei als String (inkl. Tags) ausgelesen
				string Inhalt = R.ReadInnerXml();
				// Der Reader wird geschlossen (sehr wichtig)
				R.Close();
		
				// products.xml wird geschrieben
				XmlTextWriter W = new XmlTextWriter(@"..\..\products.xml",null);
				W.WriteStartDocument();
				W.WriteStartElement("PosListe");	// das Stammelement muss manuell geschrieben werden, auch wenn es aus der anderen Datei mitkopiert werden k�nnte
				W.WriteRaw(Inhalt);					// Der String wird roh hier reingeschrieben, ich hoffe die Strings sind immer lang genug, wenn der String zu lang w�rde gingen Element verloren, dann m�ssten wir uns was �berlegen
				W.WriteEndElement();
				W.WriteEndDocument();
				//auch den Writer schliessen, dat ist noch viel wichtiger !!
				W.Close();
		

				PosListe.Tables[0].Clear(); // L�scht vorher alle Zeilen aus der DataSet.DataTable, das bremst leider mal wieder das System, arrrgh

				PosListe.ReadXml(@"..\..\products.xml");
				MessageBox.Show("Einlesen abgeschlossen", "XML Lesevorgang"); // kommt nachher raus bzw. wird ge�ndert
			}
		else MessageBox.Show (" Es ist kein Vorgang aktiviert", "Es ist ein 'unerwarteter' Fehler aufgetreten");

		
		}

		
		
		public void Daten_hinzufuegen() //CSW - 23.10.03 01:02 (UPDATE)
		{	// Das ist die Kurzform von dem was dann drunter steht
			DataRow r = PosListe.Tables[0].Rows.Add(new object[]{aktPos.Raum,aktPos.Positionsnummer,aktPos.Kurztext,aktPos.Langtext,aktPos.EPreis,aktPos.Flaeche,aktPos.Einheit,aktPos.GPreis});
				


			//		// Ist nur Copy&Paste&Assimilate
			//		DataRowCollection rc; 
			//		DataRow myNewRow;
			//		// ein Array f�r die 7 Spalten
			//		rc =PosListe.Tables[0].Rows;
			//		object[] rowVals = new object[7];
			//		
			//		rowVals[0] = aktPos.Raum;
			//		rowVals[1] = aktPos.Positionsnummer;
			//		rowVals[2] = aktPos.Kurztext;
			//		rowVals[3] = aktPos.Langtext;
			//		rowVals[4] = aktPos.EPreis;
			//		rowVals[5] = aktPos.Flaeche;
			//		rowVals[6] = aktPos.GPreis;
			//		// Add and return the new row.
			//		myNewRow = rc.Add(rowVals);			
		}

		
		public void Daten_wiedereinf�gen() //CSW - 25.10.03 01:02 
		{			
			// an der Position, an der die Position auch vorher stand werden die einzelnen Spalten ge�ndert

			try
			{

				bearbeiteteZeile[0]=aktPos.Raum;

				bearbeiteteZeile[1]=aktPos.Positionsnummer;
				bearbeiteteZeile[2]=aktPos.Kurztext;
				bearbeiteteZeile[3]=aktPos.Langtext;
				bearbeiteteZeile[4]=aktPos.EPreis;
				bearbeiteteZeile[5]=aktPos.Flaeche;
				bearbeiteteZeile[6]=aktPos.Einheit;
				bearbeiteteZeile[7]=aktPos.GPreis;
			} 
			catch (Exception ex)
			{
			MessageBox.Show("Fehler:"+ex);
			}
					
		}




		public bool speichern ()
		{
			return true;
			// laut Brainstorming war hier Vorgang X als Parameter geplant, 
			// hab keine Verwendung daf�r gehabt
		}


		public string Vorgangsnamen_basteln ()
		{	StringBuilder Name;
			StringBuilder Dummy;
			DateTime jetzt = DateTime.Now;
		
			if (hat_Namen == false)
			
			{
				hat_Namen=true;
				Name = new StringBuilder(Vorgangstyp,80);
				Name.Append("_");
				Name.Append(UnserKunde.NName);
				
				Dummy = new StringBuilder(UnserKunde.VName);
					if (Dummy.Length>1)
					Dummy.Remove(1,Dummy.Length-1);
            	Name.Append(Dummy.ToString());
				Name.Append("_");
				Name.Append(Vorgangsbezeichnung);
				Name.Append("_");
				Name.Replace(" ","");
				Dummy= new StringBuilder(jetzt.ToString());
                Dummy.Replace(" ","(");
				Dummy.Append(")");
				Name.Append(Dummy.ToString());
				Name.Replace(".","");
				Name.Replace(":","");
				Name.Replace("?","");
				Name.Replace("/","");
				Name.Replace(@"\","");
				Name.Replace("*","");
				Name.Replace("'","");
				Name.Replace("<","");
				Name.Replace(">","");
				Name.Replace("|","");
				//MessageBox.Show(Name.ToString());
				
				Dateiname = Name.ToString();
				return Dateiname;
			}
			else 
				return Dateiname;
			
			// Frage: Wie bekommen wir den eindeutig ??
		}

	
		public bool �ffnen (string DatName)
		{
			return true;
		}


		public void Rechnung_erstellen (Vorgang X)
		{
			// Hier wei� ich auch nicht was dat soll, wenn es sich nicht auf "this" bezieht
			// Wenn es ne Klassenfunktion werden soll, m�ssen wir es noch static machen
		}


		public void Vorgang_drucken ()
		{
			// Ich bezweifle zwar, dat wir dazu ne Methode brauchen, aber drin ist sie schon mal
		}
		

		public void Angebot_erstellen()
		{
		}
	

		public void Aufmass_erstellen()
		{
		}
	

		public void Relation_in_DB ()
		{
			// Die Verbindung Kunde-Vorgang muss ja irgendwo gespeichert werden
		}


		public void Position_aus_Liste_�ndern (int Zeile)//CSW - 23.10.03 01:02
		{
			// Bekommt den Index einer Zeile des DataSets/DataGrids, liest die einzelnen Werte aus und l�scht dann die Zeile aus der Tabelle
			// In der n�chsten Version f�gt er sie evt auch da wieder ein, wo sie hingeh�rt. (Mal sehen ob dat geht)
			// Update: wurde realisiert !
			// Diese Methode stellt nur die Daten aus der DataGrid Zeile dar.
			MessageBox.Show("ge�nderte Zeile:"+Zeile);
			try
			{
				bearbeiteteZeile= PosListe.Tables[0].Rows[Zeile];
				DataRow R =PosListe.Tables[0].Rows[Zeile];
				aktPos.Raum = Convert.ToString(R[0]);
				aktPos.Positionsnummer = Convert.ToString(R[1]);
				aktPos.Kurztext=Convert.ToString(R[2]);
				aktPos.Langtext=Convert.ToString(R[3]);
				aktPos.EPreis=Convert.ToDecimal(R[4]);
				aktPos.Flaeche=Convert.ToDouble(R[5]);
				aktPos.Einheit=Convert.ToString(R[6]);
				aktPos.GPreis=Convert.ToDecimal(R[7]);

				
			}
			catch(Exception ex) {MessageBox.Show("Fehler in Pos aus Liste �ndern"); }
		}

		public void Position_aus_Liste_l�schen()
		{	MessageBox.Show("l�schen");
			bearbeiteteZeile.Delete();
		}

		public decimal Betrag_berechnen()
		{decimal summe=0;
		
			foreach (DataRow DR in PosListe.Tables[0].Rows	)
			{ summe += Convert.ToDecimal(DR[7]);}
			
			return summe;
		}

		#endregion
	}



	public class Position
	{
		#region Private Variablen - Position
		private string m_Raum;
		private double m_Flaeche;
		private string m_Positionsnummer; 		// definiert die DB (M|F|Z)
	
		private string m_Kurztext;
		private string m_Langtext;
		private decimal m_EPreis;
		private decimal m_GPreis; // also Fl�che*ePreis - brauchen wir wahrscheinlich gar nicht wirklich
		private string m_Einheit;
		private	decimal m_realMatKosten;
		private decimal m_realLohnKosten;
		private decimal m_realGesamtKosten; 		//= Fl�che*(realMatKosten+realLohnKosten)
		#endregion

		#region Properties - Position
		public string Raum
		{
			get{return m_Raum;}
			set{this.m_Raum=value;}
		}
		public string Einheit
		{
			get{return m_Einheit;}
			set{this.m_Einheit=value;}
		}
		public double Flaeche
		{
			get{return m_Flaeche;}
			set{this.m_Flaeche = value;}
		}
	
		public string Positionsnummer
		{
			get{return m_Positionsnummer;}
			set{this.m_Positionsnummer = value;}
		}
		public string Kurztext
		{
			get{return m_Kurztext;}
			set{this.m_Kurztext = value;}
		}
		public string Langtext
		{
			get{return m_Langtext;}
			set{this.m_Langtext = value;}
		}

		public decimal EPreis
		{
			get{return m_EPreis;}
			set{this.m_EPreis = value;}
		}

		public decimal GPreis // also Fl�che*ePreis - brauchen wir wahrscheinlich gar nicht wirklich
		{
			get{return m_GPreis;}
			set{this.m_GPreis = value;}
		}

		public	decimal realMatKosten
		{
			get{return m_realMatKosten;}
			set{this.m_realMatKosten = value;}
		}

		public decimal realLohnKosten
		{
			get{return m_realLohnKosten;}
			set{this.m_realLohnKosten = value;}
		}

		public decimal realGesamtKosten
		{
			get{return m_realGesamtKosten;}
			set{this.m_realGesamtKosten = value;}
		}

		#endregion

		#region Konstruktoren/Destruktoren - Position
		
		public Position ()
		{
			m_Raum = "";
			m_Flaeche=0;
		
			m_Positionsnummer="";
			m_Kurztext="";
			m_Langtext="";
			m_EPreis=0;
			m_GPreis=0; // also Fl�che*ePreis - brauchen wir wahrscheinlich gar nicht wirklich
			m_realMatKosten=0;
			m_realLohnKosten=0;
			m_realGesamtKosten=0; 		
		}

		#endregion

		#region Funktionen - Position
		#endregion

	}

	public class DB
	{
		#region Private Variablen - DB
		string s_connection;
		OleDbConnection myconnection;
	   

		#endregion
		
		#region Properties -DB
		#endregion
		
		#region Konstruktoren/Destruktoren - DB
		public DB()
		{
			/// Hier wird die verbindung zur Acces-DB aufgebaut und �ber die Laufzeit des Programmmes aufrecht 
			/// erhalten. Da nur ein Single-Userbetrieb vorgesehen ist, d�rfte das kein Problem darstellne.
			this.s_connection = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\layer.mdb;Persist Security Info=False";
			;
			this.myconnection = new OleDbConnection(s_connection);
			myconnection.Open();
		
		}
		~DB()
		{
			//myconnection.Close();
		}

		#endregion
		
		#region Funktionen - DB
 		public KundenVerzeichnis Kunde_suchen_nach_Name (string nam)
		{
			int Count=0;
		
			KundenVerzeichnis Verzeichnis = new KundenVerzeichnis();
			OleDbCommand sucheNNamen = new OleDbCommand("SELECT * FROM Kunde WHERE Name LIKE '"+nam+"%'", myconnection);  //hab die SQL Abfrage erweitert, so dass man auch nur Teile eines Namens eingeben kann
		
			OleDbDataReader dataReader2 = null;
		
			try 
			{
				dataReader2 =sucheNNamen.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			while (dataReader2.Read())
			{
				Kunde myKunde = new Kunde();
		
			
				if (!(dataReader2.IsDBNull(0)))
					myKunde.Kundennummer= dataReader2.GetInt32(0);
				if (!(dataReader2.IsDBNull(1)))
					myKunde.Kuerzel= dataReader2.GetString(1);
				if (!(dataReader2.IsDBNull(2)))
					myKunde.Firma= dataReader2.GetString(2);
				if (!(dataReader2.IsDBNull(3)))
					myKunde.Anrede= dataReader2.GetString(3);
				if (!(dataReader2.IsDBNull(4)))
					myKunde.NName= dataReader2.GetString(4);
				if (!(dataReader2.IsDBNull(5)))
					myKunde.VName= dataReader2.GetString(5);
				if (!(dataReader2.IsDBNull(6)))
					myKunde.Strasse= dataReader2.GetString(6);
				if (!(dataReader2.IsDBNull(7)))
					myKunde.Ort=dataReader2.GetString(7);
				if (!(dataReader2.IsDBNull(8)))
					myKunde.PLZ= dataReader2.GetInt32(8);
				if (!(dataReader2.IsDBNull(9)))
					myKunde.Kontonr=dataReader2.GetInt32(9);
				if (!(dataReader2.IsDBNull(10)))
					myKunde.BLZ=dataReader2.GetInt32(10);
				if (!(dataReader2.IsDBNull(11)))
					myKunde.Bank= dataReader2.GetString(11);
				if (!(dataReader2.IsDBNull(12)))
					myKunde.Telefonnummer= dataReader2.GetString(12);
				if (!(dataReader2.IsDBNull(13)))
					myKunde.Fax=  dataReader2.GetString(13);
				if (!(dataReader2.IsDBNull(14)))
					myKunde.Email = dataReader2.GetString(14);
			
				Verzeichnis.Add(Count, myKunde);
				myKunde=null;
				Count++;
			}

			dataReader2.Close();

			return Verzeichnis;
		}
		public DataSet alle_Kunden_ausgebenDS()
			/// Diese Methode erfordert keinen �bergabewert, sie liefert alle in der DB 
			/// gespeicherten Kunden in einem dataSet nur f�r Waller zur�ck.
		{
		
		
			DataSet myDataSet = new DataSet("Kunden");
		
			DataTable Kunden = myDataSet.Tables.Add("Kunden");
			Kunden.Columns.Add("Kundennummer",typeof(int));
			Kunden.Columns.Add("Kuerzel",typeof(string));
			Kunden.Columns.Add("Firma",typeof(string));
			Kunden.Columns.Add("Anrede",typeof(string));
			Kunden.Columns.Add("Name",typeof(string));
			Kunden.Columns.Add("Vorname",typeof(string));
			Kunden.Columns.Add("Strasse",typeof(string));
			Kunden.Columns.Add("Ort",typeof(string));
			Kunden.Columns.Add("PLZ",typeof(int));
			Kunden.Columns.Add("Kontonr",typeof(int));
			Kunden.Columns.Add("BLZ",typeof(int));
			Kunden.Columns.Add("Bank",typeof(string));
			Kunden.Columns.Add("Telefon",typeof(string));
			Kunden.Columns.Add("Fax",typeof(string));
			Kunden.Columns.Add("eMail",typeof(string));
			Kunden.PrimaryKey = new DataColumn[]{Kunden.Columns["Kundenummer"]};
			OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("SELECT *  FROM Kunde",myconnection);
			try
			{
				myDataAdapter.Fill(myDataSet,"Kunden");
			}
			catch(Exception ex)
			{
				
				MessageBox.Show(""+ex);
				return null;
			}
		
		
			return myDataSet;
		}
		public DataSet alle_Postionen_ausgebenDS()
		{
		
		
			DataSet myDataSet = new DataSet("Positionen");

			DataTable MPos = myDataSet.Tables.Add("MPos");
			DataTable FPos = myDataSet.Tables.Add("FPos");
			DataTable ZPos = myDataSet.Tables.Add("ZPos");
			MPos.Columns.Add("PosNummer",typeof(string));
			MPos.PrimaryKey = new DataColumn[]{MPos.Columns["PosNummer"]};
			OleDbDataAdapter myDataAdapterMPos= new OleDbDataAdapter("SELECT *  FROM RechPos WHERE PosNummer LIKE 'M%'" ,myconnection);
			FPos.Columns.Add("PosNummer",typeof(string));
			FPos.PrimaryKey = new DataColumn[]{FPos.Columns["PosNummer"]};
			OleDbDataAdapter myDataAdapterFPos= new OleDbDataAdapter("SELECT *  FROM RechPos WHERE PosNummer LIKE 'F%'" ,myconnection);
			ZPos.Columns.Add("PosNummer",typeof(string));
			ZPos.PrimaryKey = new DataColumn[]{ZPos.Columns["PosNummer"]};
			OleDbDataAdapter myDataAdapterZPos= new OleDbDataAdapter("SELECT *  FROM RechPos WHERE PosNummer LIKE 'Z%'" ,myconnection);
			
			try
			{
				myDataAdapterMPos.Fill(myDataSet,"MPos");
			}
			catch(Exception ex)
			{
				
				MessageBox.Show(""+ex);
				return null;
			}
			try
			{
				myDataAdapterFPos.Fill(myDataSet,"FPos");
			}
			catch(Exception ex)
			{
				
				MessageBox.Show(""+ex);
				return null;
			}
			try
			{
				myDataAdapterZPos.Fill(myDataSet,"ZPos");
			}
			catch(Exception ex)
			{
				
				MessageBox.Show(""+ex);
				return null;
			}
		    
			
//			
//			MessageBox.Show(""+MPos.Rows[0]["PosNummer"]);
//			MessageBox.Show(""+FPos.Rows[0]["PosNummer"]);
//			MessageBox.Show(""+ZPos.Rows[0]["PosNummer"]);

			return myDataSet;
		}
		
		
		public KundenVerzeichnis alle_Kunden_ausgeben ()
			/// Diese Methode erfordert keinen �bergabewert, sie liefert alle in der DB 
			/// gespeicherten Kunden in einem KundenVerzeichnis:DictonaryBase zur�ck.
		{
			int Count=0;
		
			KundenVerzeichnis Verzeichnis = new KundenVerzeichnis();
			OleDbCommand sucheAlleKunden= new OleDbCommand("SELECT * FROM Kunde", myconnection);
		
			OleDbDataReader dataReaderAK = null;
		
			try 
			{
				dataReaderAK =sucheAlleKunden.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			while (dataReaderAK.Read())
			{
				Kunde myKunde = new Kunde();
		
			
				if (!(dataReaderAK.IsDBNull(0)))
					myKunde.Kundennummer= dataReaderAK.GetInt32(0);
				if (!(dataReaderAK.IsDBNull(1)))
					myKunde.Kuerzel= dataReaderAK.GetString(1);
				if (!(dataReaderAK.IsDBNull(2)))
					myKunde.Firma= dataReaderAK.GetString(2);
				if (!(dataReaderAK.IsDBNull(3)))
					myKunde.Anrede= dataReaderAK.GetString(3);
				if (!(dataReaderAK.IsDBNull(4)))
					myKunde.NName= dataReaderAK.GetString(4);
				if (!(dataReaderAK.IsDBNull(5)))
					myKunde.VName= dataReaderAK.GetString(5);
				if (!(dataReaderAK.IsDBNull(6)))
					myKunde.Strasse= dataReaderAK.GetString(6);
				if (!(dataReaderAK.IsDBNull(7)))
					myKunde.Ort=dataReaderAK.GetString(7);
				if (!(dataReaderAK.IsDBNull(8)))
					myKunde.PLZ= dataReaderAK.GetInt32(8);
				if (!(dataReaderAK.IsDBNull(9)))
					myKunde.Kontonr=dataReaderAK.GetInt32(9);
				if (!(dataReaderAK.IsDBNull(10)))
					myKunde.BLZ=dataReaderAK.GetInt32(10);
				if (!(dataReaderAK.IsDBNull(11)))
					myKunde.Bank= dataReaderAK.GetString(11);
				if (!(dataReaderAK.IsDBNull(12)))
					myKunde.Telefonnummer= dataReaderAK.GetString(12);
				if (!(dataReaderAK.IsDBNull(13)))
					myKunde.Fax=  dataReaderAK.GetString(13);
				if (!(dataReaderAK.IsDBNull(14)))
					myKunde.Email = dataReaderAK.GetString(14);
			
				Verzeichnis.Add(Count, myKunde);
				myKunde=null;
				Count++;
			}

			dataReaderAK.Close();

			return Verzeichnis;
		}
		public Kunde Kunde_suchen_nach_Kundennummer (int Kundennummer)
		{
       
			Kunde myKunde = new Kunde();
			OleDbCommand sucheKundennummer = new OleDbCommand("SELECT * FROM Kunde WHERE Kundennr ="+Kundennummer+"", myconnection);
			OleDbDataReader dataReader3=null;
			try
			{	
				dataReader3 = sucheKundennummer.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			if(dataReader3.Read())
			{
				if (!(dataReader3.IsDBNull(0)))
					myKunde.Kundennummer= dataReader3.GetInt32(0);
				if (!(dataReader3.IsDBNull(1)))
					myKunde.Kuerzel= dataReader3.GetString(1);
				if (!(dataReader3.IsDBNull(2)))
					myKunde.Firma= dataReader3.GetString(2);
				if (!(dataReader3.IsDBNull(3)))
					myKunde.Anrede= dataReader3.GetString(3);
				if (!(dataReader3.IsDBNull(4)))
					myKunde.NName= dataReader3.GetString(4);
				if (!(dataReader3.IsDBNull(5)))
					myKunde.VName= dataReader3.GetString(5);
				if (!(dataReader3.IsDBNull(6)))
					myKunde.Strasse= dataReader3.GetString(6);
				if (!(dataReader3.IsDBNull(7)))
					myKunde.Ort=dataReader3.GetString(7);
				if (!(dataReader3.IsDBNull(8)))
					myKunde.PLZ= dataReader3.GetInt32(8);
				if (!(dataReader3.IsDBNull(9)))
					myKunde.Kontonr=dataReader3.GetInt32(9);
				if (!(dataReader3.IsDBNull(10)))
					myKunde.BLZ=dataReader3.GetInt32(10);
				if (!(dataReader3.IsDBNull(11)))
					myKunde.Bank= dataReader3.GetString(11);
				if (!(dataReader3.IsDBNull(12)))
					myKunde.Telefonnummer= dataReader3.GetString(12);
				if (!(dataReader3.IsDBNull(13)))
					myKunde.Fax=  dataReader3.GetString(13);
				if (!(dataReader3.IsDBNull(14)))
					myKunde.Email = dataReader3.GetString(14);

				dataReader3.Close();
		
				return myKunde;
			}
			else 
				dataReader3.Close();
			return null;
		}		
		public Kunde Kunde_suchen_nach_Kuerzel (string Kzl)
		{
       
			Kunde myKunde = new Kunde();
			OleDbCommand suchekuerzel = new OleDbCommand("SELECT * FROM Kunde WHERE Kuerzel ='"+Kzl+"'", myconnection);
			OleDbDataReader dataReader1=null;
			try
			{	
				dataReader1 = suchekuerzel.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			if(dataReader1.Read())
			{
				if (!(dataReader1.IsDBNull(0)))
					myKunde.Kundennummer= dataReader1.GetInt32(0);
				if (!(dataReader1.IsDBNull(1)))
					myKunde.Kuerzel= dataReader1.GetString(1);
				if (!(dataReader1.IsDBNull(2)))
					myKunde.Firma= dataReader1.GetString(2);
				if (!(dataReader1.IsDBNull(3)))
					myKunde.Anrede= dataReader1.GetString(3);
				if (!(dataReader1.IsDBNull(4)))
					myKunde.NName= dataReader1.GetString(4);
				if (!(dataReader1.IsDBNull(5)))
					myKunde.VName= dataReader1.GetString(5);
				if (!(dataReader1.IsDBNull(6)))
					myKunde.Strasse= dataReader1.GetString(6);
				if (!(dataReader1.IsDBNull(7)))
					myKunde.Ort=dataReader1.GetString(7);
				if (!(dataReader1.IsDBNull(8)))
					myKunde.PLZ= dataReader1.GetInt32(8);
				if (!(dataReader1.IsDBNull(9)))
					myKunde.Kontonr=dataReader1.GetInt32(9);
				if (!(dataReader1.IsDBNull(10)))
					myKunde.BLZ=dataReader1.GetInt32(10);
				if (!(dataReader1.IsDBNull(11)))
					myKunde.Bank= dataReader1.GetString(11);
				if (!(dataReader1.IsDBNull(12)))
					myKunde.Telefonnummer= dataReader1.GetString(12);
				if (!(dataReader1.IsDBNull(13)))
					myKunde.Fax=  dataReader1.GetString(13);
				if (!(dataReader1.IsDBNull(14)))
					myKunde.Email = dataReader1.GetString(14);

				dataReader1.Close();
		
				return myKunde;
			}
			else 
				dataReader1.Close();
			return null;
		}
		
		public int Kunde_aendern_Kuerzel(string Kuerzel,Kunde k)
		{
			/// Diese Methode schreibt ein neues Kuerzel(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neuesKuerzel= Kuerzel;
			Kunde myKunde = k;
			OleDbCommand Kuerzel_aendern= null ;
			try	
			{	
				Kuerzel_aendern= new OleDbCommand("UPDATE Kunde SET Kuerzel='"+neuesKuerzel+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Kuerzel_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}
		public int Kunde_aendern_Firma(string Firma, Kunde k)
		{
			/// Diese Methode schreibt eine neue Firma(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neueFirma= Firma;
			Kunde myKunde = k;
			OleDbCommand Firma_aendern= null ;
			try	
			{	
				Firma_aendern= new OleDbCommand("UPDATE Kunde SET Firma='"+neueFirma+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Firma_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}
		public int Kunde_aendern_Anrede(string Anrede, Kunde k)
		{
			/// Diese Methode schreibt eine neue Anrede(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neueAnrede= Anrede;
			Kunde myKunde = k;
			OleDbCommand Anrede_aendern= null ;
			try	
			{	
				Anrede_aendern= new OleDbCommand("UPDATE Kunde SET Anrede='"+neueAnrede+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Anrede_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}
		
		public int Kunde_aendern_Name(string name,Kunde k)
		{
			/// Diese Methode schreibt den neuen Namen(Heirat?) des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neuerName= name;
			Kunde myKunde = k;
			OleDbCommand Name_aendern= null ;
			OleDbCommand Name_aendern2= null ;
			try	
			{	
				Name_aendern= new OleDbCommand("UPDATE Kunde SET Name='"+neuerName+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				Name_aendern2= new OleDbCommand("UPDATE KundeVorgang SET Name='"+neuerName+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Name_aendern.ExecuteNonQuery();
				�nderungen+= Name_aendern2.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}

		public int Kunde_aendern_Vorname(string Vorname,Kunde k)
		{
			/// Diese Methode schreibt den neuen Vornamen(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neuerVorName= Vorname;
			Kunde myKunde = k;
			OleDbCommand VorName_aendern= null ;
			OleDbCommand VorName_aendern2= null ;
			try	
			{	
				VorName_aendern= new OleDbCommand("UPDATE Kunde SET Vorname='"+neuerVorName+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				VorName_aendern= new OleDbCommand("UPDATE KundeVorgang SET Vorname='"+neuerVorName+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =VorName_aendern.ExecuteNonQuery();
			    �nderungen =VorName_aendern2.ExecuteNonQuery();
			}

			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}

		public int Kunde_aendern_Strasse(string strasse,Kunde k)
		{
			/// Diese Methode schreibt die neue Strasse des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neuestrasse= strasse;
			Kunde myKunde = k;
			OleDbCommand Strasse_aendern= null ;
			try	
			{	
				Strasse_aendern= new OleDbCommand("UPDATE Kunde SET Strasse='"+neuestrasse+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Strasse_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;
		}
		public int Kunde_aendern_Ort(string Ort,Kunde k)
		{
			/// Diese Methode schreibt den neue Ort des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neuerOrt= Ort;
			Kunde myKunde = k;
			OleDbCommand Ort_aendern= null ;
			try	
			{	
				Ort_aendern= new OleDbCommand("UPDATE Kunde SET Ort='"+neuerOrt+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Ort_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;
		}
		public int Kunde_aendern_PLZ(int PLZ,Kunde k)
		{
			/// Diese Methode schreibt die neue PLZ des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			int neuePLZ= PLZ;
			Kunde myKunde = k;
			OleDbCommand PLZ_aendern= null ;
			try	
			{	
				PLZ_aendern= new OleDbCommand("UPDATE Kunde SET PLZ="+neuePLZ+" WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =PLZ_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;
		}
		
		public int Kunde_aendern_Kontonr(int Kontonr,Kunde k)
		{
			/// Diese Methode schreibt die neue Kontonummer des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			int neueKontonr= Kontonr;
			Kunde myKunde = k;
			OleDbCommand Kontonr_aendern= null ;
			try	
			{	
				Kontonr_aendern= new OleDbCommand("UPDATE Kunde SET Kontonr="+neueKontonr+" WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Kontonr_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;
		}
		
		public int Kunde_aendern_BLZ(int BLZ,Kunde k)
		{
			/// Diese Methode schreibt die neue BLZ des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			int neueBLZ= BLZ;
			Kunde myKunde = k;
			OleDbCommand BLZ_aendern= null ;
			try	
			{	
				BLZ_aendern= new OleDbCommand("UPDATE Kunde SET BLZ="+neueBLZ+" WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =BLZ_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;
		}
		
		public int Kunde_aendern_Bank(string Bank,Kunde k)
		{
			/// Diese Methode schreibt den neue Bank des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neueBank= Bank;
			Kunde myKunde = k;
			OleDbCommand Bank_aendern= null ;
			try	
			{	
				Bank_aendern= new OleDbCommand("UPDATE Kunde SET Bank='"+neueBank+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Bank_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;
		}
		
		public int Kunde_aendern_Tel(string Tel,Kunde k)
		{
			/// Diese Methode schreibt die neue Telefonnummer des Referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neueTele= Tel;
			Kunde myKunde = k;
			OleDbCommand Tel_aendern= null ;
			try	
			{	
				Tel_aendern= new OleDbCommand("UPDATE Kunde SET Telefon='"+neueTele+"' WHERE Kundennr ="+myKunde.Kundennummer, myconnection);
				�nderungen =Tel_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;
		}
		
		public int Kunde_aendern_Fax(string Fax,Kunde k)
		{
			/// Diese Methode schreibt die neue Faxnummer(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neueFax= Fax;
			Kunde myKunde = k;
			OleDbCommand Fax_aendern= null ;
			try	
			{	
				Fax_aendern= new OleDbCommand("UPDATE Kunde SET Fax='"+neueFax+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Fax_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}

		public int Kunde_aendern_Email(string Email,Kunde k)
		{
			/// Diese Methode schreibt die neue E-mailadresse(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int �nderungen=0; 
			string neuerEmail= Email;
			Kunde myKunde = k;
			OleDbCommand Email_aendern= null ;
			try	
			{	
				Email_aendern= new OleDbCommand("UPDATE Kunde SET eMail='"+neuerEmail+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Email_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}

		public int Kunde_in_DB_schreiben(Kunde k)
		{
			/// Diese Methode schreibt den referenzierten Kunden, mit allen neuen Werten in die Datenbank.
			int �nderungen=0; 
			Kunde myKunde = k;
			OleDbCommand Kunde_aendern= null ;
			OleDbCommand Kunde_aendern2= null ;
			try	
			{	
				Kunde_aendern= new OleDbCommand("UPDATE Kunde SET Kuerzel='"+myKunde.Kuerzel+"' Firma='"+myKunde.Firma+" Anrede = '"+myKunde.Anrede+"' Name = '"+myKunde.NName+"' Vorname= '"+myKunde.VName+"' Strasse= '"+myKunde.Strasse+"' Ort= '"+myKunde.Ort+"' PLZ="+myKunde.PLZ+" Kontonr ="+myKunde.Kontonr+" BLZ ="+myKunde.BLZ+" Bank = '"+myKunde.Bank+"' Telefon ='"+myKunde.Telefonnummer+"' Fax= '"+myKunde.Fax+"' '  eMail='"+myKunde.Email+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				Kunde_aendern2= new OleDbCommand("UPDATE KundeVorgang SET  Name = '"+myKunde.NName+"' Vorname= '"+myKunde.VName+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				�nderungen =Kunde_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}

		public int Neuer_Kunde_Anlegen(Kunde K)
		{
			int count=1;
			int �nderungen =0;
			Kunde myKunde = K;
			OleDbCommand PS = new OleDbCommand("SELECT * FROM Kunde", myconnection);
		
			OleDbDataReader dataReaderPS = null;
		
			try 
			{
				dataReaderPS = PS.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			while (dataReaderPS.Read())
			{
				count++;
			}
			dataReaderPS.Close();
			OleDbCommand Kunde_anlegen= null ;
			try	
			{	
				Kunde_anlegen= new OleDbCommand("INSERT INTO Kunde(Kundennr,Kuerzel, Firma, Anrede, Name, Vorname, Strasse, Ort, PLZ, Kontonr, BLZ, Bank, Telefon, Fax, eMail) VALUES ("+count+", '"+myKunde.Kuerzel+"','"+myKunde.Firma+"','"+myKunde.Anrede+"','"+myKunde.NName+"','"+myKunde.VName+"','"+myKunde.Strasse+"','"+myKunde.Ort+"', "+myKunde.PLZ+", "+myKunde.Kontonr+","+myKunde.BLZ+",'"+myKunde.Bank+"','"+myKunde.Telefonnummer+"','"+myKunde.Fax+"','"+myKunde.Email+"')", myconnection);
				�nderungen =Kunde_anlegen.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;
		
		}
		public int Kunde_in_transienten_Zustand_versetzen(Kunde K)
		{
			int �nderungen =0;
			Kunde myKunde = K;
			OleDbCommand Kunde_l�schen= null ;
			try	
			{	
				Kunde_l�schen= new OleDbCommand("DELETE FROM Kunde WHERE Kundennr="+myKunde.Kundennummer+"" ,myconnection);
				�nderungen =Kunde_l�schen.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(""+ex);
				return 0;}
			return �nderungen;
		
		}
        


		public Position Pos_suchen_nach_Posnummer (string Pos)
		{
       
			Position myPos = new Position();
			OleDbCommand suchePos = new OleDbCommand("SELECT * FROM RechPos WHERE PosNummer ='"+Pos+"'", myconnection);
			OleDbDataReader dataReader4=null;
			try
			{	
				dataReader4 = suchePos.ExecuteReader();
			}
			catch(Exception ex)
			{
				MessageBox.Show(""+ex);
				return null;
			}
		
			if(dataReader4.Read())
			{
				if (!(dataReader4.IsDBNull(0)))
					myPos.Positionsnummer= dataReader4.GetString(0);
				if (!(dataReader4.IsDBNull(1)))
					myPos.Langtext= dataReader4.GetString(1);
				if (!(dataReader4.IsDBNull(2)))
					myPos.Kurztext= dataReader4.GetString(2);
				if (!(dataReader4.IsDBNull(3)))
					myPos.EPreis= dataReader4.GetDecimal(3);
				if (!(dataReader4.IsDBNull(4)))
					myPos.Einheit= dataReader4.GetString(4);
				if (!(dataReader4.IsDBNull(5)))
					myPos.realMatKosten= dataReader4.GetDecimal(5);
				if (!(dataReader4.IsDBNull(6)))
					myPos.realLohnKosten= dataReader4.GetDecimal(6);
				
				dataReader4.Close();
		
				return myPos;
			}
			else 
				dataReader4.Close();
			return null;
		}

		public string Neue_Pos_Anlegen(Position K)
		{
			int count=0;
			string �nderungen ="";
			Position myPos = K;
			OleDbCommand PS = new OleDbCommand("SELECT * FROM RechPos", myconnection);
		
			OleDbDataReader dataReaderPS = null;
		
			try 
			{
				dataReaderPS = PS.ExecuteReader();
			}
			catch(Exception ex)
			{
				MessageBox.Show(""+ex);
				return "";}
		
			while (dataReaderPS.Read())
			{
				count++;
			}
			dataReaderPS.Close();
			OleDbCommand Pos_anlegen= null ;
			try	
			{	
				Pos_anlegen= new OleDbCommand("INSERT INTO RechPos(PosNummer,Langtext,Kurztext,preis,Einheit, MKosten,LKosten) VALUES ('Z"+(count*10)+"', '"+myPos.Langtext+"','"+myPos.Kurztext+"','"+myPos.EPreis+"','"+myPos.Einheit+"',"+myPos.realMatKosten+","+myPos.realLohnKosten+")", myconnection);
				Pos_anlegen.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			�nderungen="Z"+(count+10);
			MessageBox.Show(""+�nderungen);
			return �nderungen;
		
		}
		
		
		public int Position_in_DB_schreiben(Position k)
		{
			/// Diese Methode schreibt die referenzierte postition, mit allen neuen Werten in die Datenbank.
			int �nderungen=0; 
			Position myPos = k;
			OleDbCommand Position_aendern= null ;
			try	
			{	
				Position_aendern= new OleDbCommand("UPDATE Position SET Langtext='"+myPos.Langtext+"' Kurztext='"+myPos.Kurztext+" preis = "+myPos.GPreis+" Einheit = '"+myPos.Einheit+"' MKosten= "+myPos.realMatKosten+" LKosten= "+myPos.realLohnKosten+"  WHERE PosNummer ="+myPos.Positionsnummer+"", myconnection);
				�nderungen =Position_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}
		
		public int VorgangKunde_in_DB_schreiben(Vorgang V)
		{
			/// Diese Methode schreibt, den Namen des �bergebenen Vorgangs und den zugeh�rigen Kunden in die DB.
			/// Die Methode liefert einen int zur�ck, der die Anzahl der ge�nderten Datens�tze beschreibt.
			/// 
 

			int �nderungen=0; 
			int count=0;
			Vorgang myVor = V;
			OleDbCommand KV = new OleDbCommand("SELECT * FROM KundeVorgang", myconnection);
			OleDbCommand Vorgang_schreiben= null ;
			OleDbDataReader dataReaderKV = null;
		
			try 
			{
				dataReaderKV = KV.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			while (dataReaderKV.Read())
			{
				count++;
			}
			dataReaderKV.Close();
		
			
			try	
			{	
				Vorgang_schreiben= new OleDbCommand("INSERT INTO KundeVorgang VALUES ("+myVor.UnserKunde.Kundennummer+", '"+myVor.Dateiname+"','"+myVor.Datum+"',"+count+",'"+myVor.UnserKunde.VName+"','"+myVor.UnserKunde.NName+"')", myconnection);
				�nderungen = Vorgang_schreiben.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return �nderungen;}

		public string[] alle_Vorgaenge_eines_Kunde_ausgeben (Kunde K)
			/// 
		{
			int count=0;
			Kunde myKunde = K;
			
			OleDbCommand sucheAlleVorg�nge= new OleDbCommand("SELECT * FROM KundeVorgang WHERE Kundennr="+myKunde.Kundennummer+"", myconnection);
			OleDbDataReader dataReaderCount = null;
		
			try 
			{
				dataReaderCount =sucheAlleVorg�nge.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			while (dataReaderCount.Read())
			{
				count++;
			}
			dataReaderCount.Close();
			string[] Vorg�nge =new string[count];
			count=0;
			OleDbDataReader dataReaderAV = null;
		
			try 
			{
				dataReaderAV =sucheAlleVorg�nge.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			while (dataReaderAV.Read())
			{
				if (!(dataReaderAV.IsDBNull(1)))
					Vorg�nge[count] = dataReaderAV.GetString(1);
				count++;
			}

			dataReaderAV.Close();

			return Vorg�nge;
		}

		
	
		public DataSet alle_Vorgaenge_eines_Kunden_ausgeben()
			
		{
		
		
			DataSet myDataSet = new DataSet("KundenVorgaenge");
			DataTable KundenVorgaenge = myDataSet.Tables.Add("KundenVorgaenge");
			DataTable Kunde = myDataSet.Tables.Add("Kunde");
			Kunde.Columns.Add("Kundennr",typeof(int));
			
			Kunde.Columns.Add("Name",typeof(string));
			Kunde.Columns.Add("Vorname",typeof(string));
			KundenVorgaenge.Columns.Add("Kundennr",typeof(int));
			KundenVorgaenge.Columns.Add("Vorgang",typeof(string));
			KundenVorgaenge.Columns.Add("Index",typeof(int));
			KundenVorgaenge.Columns.Add("Datum",typeof(DateTime));
			KundenVorgaenge.Columns.Add("Vorname",typeof(string));
			KundenVorgaenge.Columns.Add("Name",typeof(string));
			KundenVorgaenge.PrimaryKey = new DataColumn[]{KundenVorgaenge.Columns["Index"]};
			Kunde.PrimaryKey = new DataColumn[]{Kunde.Columns["Kundennr"]};
			OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("SELECT * FROM KundeVorgang",myconnection);
			OleDbDataAdapter myDataAdapter2 = new OleDbDataAdapter("SELECT * FROM Kunde ORDER BY Kundennr",myconnection);
			
			try
			{
		
				myDataAdapter.Fill(myDataSet,"KundenVorgaenge");
                myDataAdapter2.Fill(myDataSet,"Kunde");
			}
			catch(Exception ex)
			{
				
				MessageBox.Show(""+ex);
				return null;
			}
			
			//KundenVorgaenge.Columns.Add("Name",typeof(string));
			//KundenVorgaenge.Columns.Add("Vorname",typeof(string));
			
			
			// Hab es drin gelassen damit Du den Quelltext lesen kannst, wie man in einem DataSet auf die Zeilen zugreifen kann 

//			DataRow aktKD;
//			DataRow aktV;
//		
//			int kdnr;
//		for (int i = 0; i<KundenVorgaenge.Rows.Count;i++)
//			{
//				aktV = KundenVorgaenge.Rows[i];  // die i-te Zeile
//
//				kdnr = Convert.ToInt32(aktV[0]);
//				
//				aktKD =  Kunde.Rows[kdnr-1];
//		
//			if (Convert.ToString(aktKD[1])=="")
//				{
//				aktV[4]= "Kunde nicht gefunden";   // 4 ist hier der Spaltenindex
//				aktV[5]= "Kunde nicht gefunden";
//				}
//			else
//				{
//				aktV[4] = aktKD[1];
//				aktV[5] = aktKD[2];
//				}
//
//			}
			myDataSet.Tables[1].Dispose();
			return myDataSet;
		}


		#endregion

	
	
	}




}
