// |  Versionsnummer  | Erstell -Datum | -Uhrzeit | erstellt durch | Whats new ???
//---------------------------------------------------------------------------------------------------------------------------------
// | Version 1.071	  | 22.10.03       | 16:00    |	CH			   |  Position_anzeigen
// | Version 1.072    | 22.10.03	   | 19:10    | CSW			   |  keine großen Änderungen: kein Zeitverzug beim Datagrid am Anfang / ToolTips für die Tabpages und ein paar Felder des Kunden (Mainframe_load)
// | Version 1.073 	  | 23.10.03	   | 01:13    | CSW			   |  Formatierung des Datagrids, Ändern der Positionen im DataGrid, Übernehmen der Daten ins DataGrid - und Kleinigkeiten wie: Anlegen einer Projekt History:-)
// | Version 1.08 	  | 23.10.03	   | 16:13    | Casi	       |  Alle Vorgäge eines Kunden aus der DB auslesen. + Vorgang einem Kunden zuordenen in der DB 
// | Version 1.09 	  | 24.10.03	   | 16:13    | CH			   |  Vorgang Suche
// | Version 1.10	  | 26.10.03	   | 02:30	  | CSW			   |  DataGrid (Löschen&Bearbeiten) / Fläche berechnen (Dialog) / 
// | Version 1.101	  | 26.10.03	   | 18:18    | CSW			   |  Mini-Bug-Fix beim DataGrid, Doppelklick auf ZellenRahmen hat jetzt gleichen Effekt wie Doppelklick auf Zeilenkopf (Thx@Casi)
// | Version 1.11	  | 26.10.03	   | 23:41    | CH			   |  Neue ZPositon anlegen
// | Version 1.12	  | 27.10.03	   | 22:53	  | CSW			   |  DateTimePicker eingebaut und VG.Datum entsprechend geändert
// | Version 1.13	  | 29.10.03	   | 09:00	  | CH			   |  CVS System eingeführt, keine Erweiterung des eigentlichen Programms

using System;
using System.Drawing;
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
	/// Zusammenfassung für Layer8.
	/// </summary>
	public class MainFrame : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		# region Labels
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
		private System.Windows.Forms.Button button_Zurück;
		private System.Windows.Forms.Button button_Speichern;
		private System.Windows.Forms.Button button_Löschen;
		private System.Windows.Forms.Button button_Neu;
		private System.Windows.Forms.Button button_Rückgangig;
		private System.Windows.Forms.Button button_Vor;
		private System.Windows.Forms.Button button_XmlLesen;
		private System.Windows.Forms.Button button_XmlSchreiben;
		private System.Windows.Forms.Button button_Übernehmen;
		private System.Windows.Forms.Button button_loeschen;
		private System.Windows.Forms.Button button_Flaeche;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Pos_anlegen;
		private System.Windows.Forms.Button pos_Speichern; 
		#endregion
		#region Textboxes
		private System.Windows.Forms.TextBox txtbox_Name;
		private System.Windows.Forms.TextBox txtbox_Telefonnummer;
		private System.Windows.Forms.TextBox txtbox_PLZ;
		private System.Windows.Forms.TextBox txtbox_Ort;
		private System.Windows.Forms.TextBox txtbox_Strasse;
		private System.Windows.Forms.TextBox txtbox_Vorname;
		private System.Windows.Forms.TextBox txtbox_Kundennummer;
		private System.Windows.Forms.TextBox txtbox_Gesamtpreis;
		private System.Windows.Forms.TextBox txtbox_Fläche;
		private System.Windows.Forms.TextBox txtbox_Einzelpreis;
		private System.Windows.Forms.TextBox txtbox_Langtext;
		private System.Windows.Forms.TextBox txtbox_Kurztext;
		private System.Windows.Forms.TextBox txtbox_Posnummer;
		private System.Windows.Forms.TextBox txtbox_Raum;
		private System.Windows.Forms.TextBox txtbox_PlzTab2;
		private System.Windows.Forms.TextBox txtbox_OrtTab2;
		private System.Windows.Forms.TextBox txtbox_StrasseTab2;
		private System.Windows.Forms.TextBox txtbox_VornameTab2;
		private System.Windows.Forms.TextBox txtbox_NameTab2;
		private System.Windows.Forms.TextBox txtbox_VNummer;
		private System.Windows.Forms.TextBox txtbox_VBezeichnung;
		private System.Windows.Forms.TextBox txtbox_Datum;
		private System.Windows.Forms.TextBox txtbox_Fax;
		private System.Windows.Forms.TextBox txtbox_Email;
		private System.Windows.Forms.TextBox txtbox_Netto;
		private System.Windows.Forms.TextBox txtbox_Mwst;
		private System.Windows.Forms.TextBox txtbox_Rabatt;
		private System.Windows.Forms.TextBox txtbox_Brutto;
		
		private System.Windows.Forms.TextBox txtbox_Kürzel; 
		# endregion
		#region RadioButtons
		private System.Windows.Forms.RadioButton radio_Aufmaß;
		private System.Windows.Forms.RadioButton radio_Angebot;
		private System.Windows.Forms.RadioButton radio_Rechnung;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		#endregion
		#region Formatierungsinformationen für das DataGrid
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		#endregion
		#region Tab
		private System.Windows.Forms.TabPage Positionen;
		private System.Windows.Forms.TabPage Bauvorhaben;
		private System.Windows.Forms.TabPage Kunde;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Zahlung;
		#endregion

		private System.Windows.Forms.DataGrid dataGrid_Vorgang;
				
		private System.Windows.Forms.GroupBox gbox_Vorgangstyp;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbox_Anrede;
		
		
		public DB UnsereDb;
		public Vorgang VG;
		public bool bearbeiten_flag = false;
		public bool neuer_Kunde = false;
		public bool position_anlegen = false;
		//public bool position_neu = false;
		public string kürzelstring;
		public string positionsnummerstring;
		private int DG_aktZeile;
		private System.Windows.Forms.DateTimePicker dateTimePicker_Bau;
		
		// CSW: wird im EventHandler von "dataGrid_Vorgang_CurrentCellChanged" benutzt und gibt mir immer denaktuellen Index des Datagrids
		private bool DG_Zeile_bearbeiten;
		
		
		
		
		public MainFrame()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
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
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainFrame));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Kunde = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.label31 = new System.Windows.Forms.Label();
			this.txtbox_Email = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.txtbox_Fax = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.cbox_Anrede = new System.Windows.Forms.ComboBox();
			this.txtbox_Name = new System.Windows.Forms.TextBox();
			this.button_Rückgangig = new System.Windows.Forms.Button();
			this.button_Neu = new System.Windows.Forms.Button();
			this.button_Löschen = new System.Windows.Forms.Button();
			this.button_Speichern = new System.Windows.Forms.Button();
			this.button_Zurück = new System.Windows.Forms.Button();
			this.button_Vor = new System.Windows.Forms.Button();
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
			this.txtbox_Kürzel = new System.Windows.Forms.TextBox();
			this.Bauvorhaben = new System.Windows.Forms.TabPage();
			this.label24 = new System.Windows.Forms.Label();
			this.txtbox_Datum = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.txtbox_VNummer = new System.Windows.Forms.TextBox();
			this.txtbox_VBezeichnung = new System.Windows.Forms.TextBox();
			this.gbox_Vorgangstyp = new System.Windows.Forms.GroupBox();
			this.radio_Rechnung = new System.Windows.Forms.RadioButton();
			this.radio_Angebot = new System.Windows.Forms.RadioButton();
			this.radio_Aufmaß = new System.Windows.Forms.RadioButton();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtbox_PlzTab2 = new System.Windows.Forms.TextBox();
			this.txtbox_OrtTab2 = new System.Windows.Forms.TextBox();
			this.txtbox_StrasseTab2 = new System.Windows.Forms.TextBox();
			this.txtbox_VornameTab2 = new System.Windows.Forms.TextBox();
			this.txtbox_NameTab2 = new System.Windows.Forms.TextBox();
			this.Positionen = new System.Windows.Forms.TabPage();
			this.pos_Speichern = new System.Windows.Forms.Button();
			this.Pos_anlegen = new System.Windows.Forms.Button();
			this.button_Flaeche = new System.Windows.Forms.Button();
			this.button_loeschen = new System.Windows.Forms.Button();
			this.label21 = new System.Windows.Forms.Label();
			this.txtbox_Raum = new System.Windows.Forms.TextBox();
			this.button_Übernehmen = new System.Windows.Forms.Button();
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
			this.txtbox_Fläche = new System.Windows.Forms.TextBox();
			this.txtbox_Einzelpreis = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtbox_Langtext = new System.Windows.Forms.TextBox();
			this.txtbox_Kurztext = new System.Windows.Forms.TextBox();
			this.txtbox_Posnummer = new System.Windows.Forms.TextBox();
			this.Zahlung = new System.Windows.Forms.TabPage();
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
			this.dateTimePicker_Bau = new System.Windows.Forms.DateTimePicker();
			this.tabControl1.SuspendLayout();
			this.Kunde.SuspendLayout();
			this.Bauvorhaben.SuspendLayout();
			this.gbox_Vorgangstyp.SuspendLayout();
			this.Positionen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Vorgang)).BeginInit();
			this.Zahlung.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.Kunde);
			this.tabControl1.Controls.Add(this.Bauvorhaben);
			this.tabControl1.Controls.Add(this.Positionen);
			this.tabControl1.Controls.Add(this.Zahlung);
			this.tabControl1.Location = new System.Drawing.Point(16, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = true;
			this.tabControl1.Size = new System.Drawing.Size(996, 616);
			this.tabControl1.TabIndex = 0;
			// 
			// Kunde
			// 
			this.Kunde.Controls.Add(this.button1);
			this.Kunde.Controls.Add(this.label31);
			this.Kunde.Controls.Add(this.txtbox_Email);
			this.Kunde.Controls.Add(this.label30);
			this.Kunde.Controls.Add(this.txtbox_Fax);
			this.Kunde.Controls.Add(this.label29);
			this.Kunde.Controls.Add(this.cbox_Anrede);
			this.Kunde.Controls.Add(this.txtbox_Name);
			this.Kunde.Controls.Add(this.button_Rückgangig);
			this.Kunde.Controls.Add(this.button_Neu);
			this.Kunde.Controls.Add(this.button_Löschen);
			this.Kunde.Controls.Add(this.button_Speichern);
			this.Kunde.Controls.Add(this.button_Zurück);
			this.Kunde.Controls.Add(this.button_Vor);
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
			this.Kunde.Controls.Add(this.txtbox_Kürzel);
			this.Kunde.Location = new System.Drawing.Point(4, 22);
			this.Kunde.Name = "Kunde";
			this.Kunde.Size = new System.Drawing.Size(988, 590);
			this.Kunde.TabIndex = 0;
			this.Kunde.Text = "Kunde";
			this.Kunde.ToolTipText = "Das ist unser Kunde und der Kunde ist König!";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 200);
			this.button1.Name = "button1";
			this.button1.TabIndex = 29;
			this.button1.Text = "Bearbeiten";
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.txtbox_Email.TabIndex = 27;
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
			this.txtbox_Fax.TabIndex = 25;
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
			// 
			// txtbox_Name
			// 
			this.txtbox_Name.Location = new System.Drawing.Point(392, 80);
			this.txtbox_Name.Name = "txtbox_Name";
			this.txtbox_Name.ReadOnly = true;
			this.txtbox_Name.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Name.TabIndex = 22;
			this.txtbox_Name.Text = "";
			this.txtbox_Name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtbox_Name_MouseDown);
			this.txtbox_Name.Leave += new System.EventHandler(this.txtbox_Name_Leave);
			// 
			// button_Rückgangig
			// 
			this.button_Rückgangig.Location = new System.Drawing.Point(136, 296);
			this.button_Rückgangig.Name = "button_Rückgangig";
			this.button_Rückgangig.TabIndex = 21;
			this.button_Rückgangig.Text = "Rückgängig";
			// 
			// button_Neu
			// 
			this.button_Neu.Location = new System.Drawing.Point(32, 152);
			this.button_Neu.Name = "button_Neu";
			this.button_Neu.TabIndex = 20;
			this.button_Neu.Text = "Neu";
			this.button_Neu.Click += new System.EventHandler(this.button_Neu_Click);
			// 
			// button_Löschen
			// 
			this.button_Löschen.Location = new System.Drawing.Point(32, 296);
			this.button_Löschen.Name = "button_Löschen";
			this.button_Löschen.TabIndex = 19;
			this.button_Löschen.Text = "Löschen";
			// 
			// button_Speichern
			// 
			this.button_Speichern.Location = new System.Drawing.Point(32, 248);
			this.button_Speichern.Name = "button_Speichern";
			this.button_Speichern.TabIndex = 18;
			this.button_Speichern.Text = "Speichern";
			this.button_Speichern.Click += new System.EventHandler(this.button_Speichern_Click);
			// 
			// button_Zurück
			// 
			this.button_Zurück.Location = new System.Drawing.Point(136, 248);
			this.button_Zurück.Name = "button_Zurück";
			this.button_Zurück.TabIndex = 17;
			this.button_Zurück.Text = "Zurück";
			// 
			// button_Vor
			// 
			this.button_Vor.Location = new System.Drawing.Point(136, 200);
			this.button_Vor.Name = "button_Vor";
			this.button_Vor.TabIndex = 16;
			this.button_Vor.Text = "Vor";
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
			this.txtbox_Telefonnummer.TabIndex = 12;
			this.txtbox_Telefonnummer.Text = "";
			this.txtbox_Telefonnummer.Leave += new System.EventHandler(this.txtbox_Telefonnummer_Leave);
			// 
			// txtbox_PLZ
			// 
			this.txtbox_PLZ.Location = new System.Drawing.Point(392, 192);
			this.txtbox_PLZ.Name = "txtbox_PLZ";
			this.txtbox_PLZ.ReadOnly = true;
			this.txtbox_PLZ.Size = new System.Drawing.Size(104, 20);
			this.txtbox_PLZ.TabIndex = 11;
			this.txtbox_PLZ.Text = "";
			this.txtbox_PLZ.Leave += new System.EventHandler(this.txtbox_PLZ_Leave);
			// 
			// txtbox_Ort
			// 
			this.txtbox_Ort.Location = new System.Drawing.Point(624, 144);
			this.txtbox_Ort.Name = "txtbox_Ort";
			this.txtbox_Ort.ReadOnly = true;
			this.txtbox_Ort.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Ort.TabIndex = 10;
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
			this.label1.Text = "Kürzel";
			// 
			// txtbox_Strasse
			// 
			this.txtbox_Strasse.Location = new System.Drawing.Point(392, 144);
			this.txtbox_Strasse.Name = "txtbox_Strasse";
			this.txtbox_Strasse.ReadOnly = true;
			this.txtbox_Strasse.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Strasse.TabIndex = 4;
			this.txtbox_Strasse.Text = "";
			this.txtbox_Strasse.Leave += new System.EventHandler(this.txtbox_Strasse_Leave);
			// 
			// txtbox_Vorname
			// 
			this.txtbox_Vorname.Location = new System.Drawing.Point(624, 80);
			this.txtbox_Vorname.Name = "txtbox_Vorname";
			this.txtbox_Vorname.ReadOnly = true;
			this.txtbox_Vorname.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Vorname.TabIndex = 3;
			this.txtbox_Vorname.Text = "";
			this.txtbox_Vorname.Leave += new System.EventHandler(this.txtbox_Vorname_Leave);
			// 
			// txtbox_Kundennummer
			// 
			this.txtbox_Kundennummer.Location = new System.Drawing.Point(112, 80);
			this.txtbox_Kundennummer.Name = "txtbox_Kundennummer";
			this.txtbox_Kundennummer.ReadOnly = true;
			this.txtbox_Kundennummer.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Kundennummer.TabIndex = 1;
			this.txtbox_Kundennummer.Text = "";
			this.txtbox_Kundennummer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtbox_Kundennummer_MouseDown);
			// 
			// txtbox_Kürzel
			// 
			this.txtbox_Kürzel.Location = new System.Drawing.Point(112, 32);
			this.txtbox_Kürzel.Name = "txtbox_Kürzel";
			this.txtbox_Kürzel.ReadOnly = true;
			this.txtbox_Kürzel.Size = new System.Drawing.Size(104, 20);
			this.txtbox_Kürzel.TabIndex = 0;
			this.txtbox_Kürzel.Text = "";
			this.txtbox_Kürzel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtbox_Kürzel_MouseDown);
			this.txtbox_Kürzel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Kürzel_KeyPress);
			this.txtbox_Kürzel.TextChanged += new System.EventHandler(this.txtbox_Kürzel_TextChanged);
			this.txtbox_Kürzel.Leave += new System.EventHandler(this.txtbox_Kürzel_Leave);
			// 
			// Bauvorhaben
			// 
			this.Bauvorhaben.Controls.Add(this.dateTimePicker_Bau);
			this.Bauvorhaben.Controls.Add(this.label24);
			this.Bauvorhaben.Controls.Add(this.txtbox_Datum);
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
			this.Bauvorhaben.Controls.Add(this.txtbox_PlzTab2);
			this.Bauvorhaben.Controls.Add(this.txtbox_OrtTab2);
			this.Bauvorhaben.Controls.Add(this.txtbox_StrasseTab2);
			this.Bauvorhaben.Controls.Add(this.txtbox_VornameTab2);
			this.Bauvorhaben.Controls.Add(this.txtbox_NameTab2);
			this.Bauvorhaben.Location = new System.Drawing.Point(4, 22);
			this.Bauvorhaben.Name = "Bauvorhaben";
			this.Bauvorhaben.Size = new System.Drawing.Size(988, 590);
			this.Bauvorhaben.TabIndex = 2;
			this.Bauvorhaben.Text = "Bauvorhaben";
			this.Bauvorhaben.ToolTipText = "Hier stehen die genauen Angaben zum Bauvorhaben wie z.B. Adresse, Name etc";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(32, 192);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(72, 23);
			this.label24.TabIndex = 16;
			this.label24.Text = "Datum";
			// 
			// txtbox_Datum
			// 
			this.txtbox_Datum.Location = new System.Drawing.Point(248, 192);
			this.txtbox_Datum.Name = "txtbox_Datum";
			this.txtbox_Datum.Size = new System.Drawing.Size(208, 20);
			this.txtbox_Datum.TabIndex = 15;
			this.txtbox_Datum.TabStop = false;
			this.txtbox_Datum.Text = "Bin durch was Besseres ersetzt worden :-(";
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
			// 
			// gbox_Vorgangstyp
			// 
			this.gbox_Vorgangstyp.Controls.Add(this.radio_Rechnung);
			this.gbox_Vorgangstyp.Controls.Add(this.radio_Angebot);
			this.gbox_Vorgangstyp.Controls.Add(this.radio_Aufmaß);
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
			// 
			// radio_Angebot
			// 
			this.radio_Angebot.Checked = true;
			this.radio_Angebot.Location = new System.Drawing.Point(24, 56);
			this.radio_Angebot.Name = "radio_Angebot";
			this.radio_Angebot.TabIndex = 1;
			this.radio_Angebot.TabStop = true;
			this.radio_Angebot.Text = "Angebot";
			// 
			// radio_Aufmaß
			// 
			this.radio_Aufmaß.Location = new System.Drawing.Point(24, 32);
			this.radio_Aufmaß.Name = "radio_Aufmaß";
			this.radio_Aufmaß.TabIndex = 0;
			this.radio_Aufmaß.Text = "Aufmaß";
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
			// txtbox_PlzTab2
			// 
			this.txtbox_PlzTab2.Location = new System.Drawing.Point(112, 352);
			this.txtbox_PlzTab2.Name = "txtbox_PlzTab2";
			this.txtbox_PlzTab2.TabIndex = 4;
			this.txtbox_PlzTab2.Text = "";
			// 
			// txtbox_OrtTab2
			// 
			this.txtbox_OrtTab2.Location = new System.Drawing.Point(112, 392);
			this.txtbox_OrtTab2.Name = "txtbox_OrtTab2";
			this.txtbox_OrtTab2.TabIndex = 3;
			this.txtbox_OrtTab2.Text = "";
			// 
			// txtbox_StrasseTab2
			// 
			this.txtbox_StrasseTab2.Location = new System.Drawing.Point(112, 312);
			this.txtbox_StrasseTab2.Name = "txtbox_StrasseTab2";
			this.txtbox_StrasseTab2.TabIndex = 2;
			this.txtbox_StrasseTab2.Text = "";
			// 
			// txtbox_VornameTab2
			// 
			this.txtbox_VornameTab2.Location = new System.Drawing.Point(112, 272);
			this.txtbox_VornameTab2.Name = "txtbox_VornameTab2";
			this.txtbox_VornameTab2.TabIndex = 1;
			this.txtbox_VornameTab2.Text = "";
			// 
			// txtbox_NameTab2
			// 
			this.txtbox_NameTab2.Location = new System.Drawing.Point(112, 232);
			this.txtbox_NameTab2.Name = "txtbox_NameTab2";
			this.txtbox_NameTab2.TabIndex = 0;
			this.txtbox_NameTab2.Text = "";
			// 
			// Positionen
			// 
			this.Positionen.Controls.Add(this.pos_Speichern);
			this.Positionen.Controls.Add(this.Pos_anlegen);
			this.Positionen.Controls.Add(this.button_Flaeche);
			this.Positionen.Controls.Add(this.button_loeschen);
			this.Positionen.Controls.Add(this.label21);
			this.Positionen.Controls.Add(this.txtbox_Raum);
			this.Positionen.Controls.Add(this.button_Übernehmen);
			this.Positionen.Controls.Add(this.button_XmlSchreiben);
			this.Positionen.Controls.Add(this.button_XmlLesen);
			this.Positionen.Controls.Add(this.dataGrid_Vorgang);
			this.Positionen.Controls.Add(this.label15);
			this.Positionen.Controls.Add(this.label14);
			this.Positionen.Controls.Add(this.label13);
			this.Positionen.Controls.Add(this.txtbox_Gesamtpreis);
			this.Positionen.Controls.Add(this.txtbox_Fläche);
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
			this.button_Flaeche.Location = new System.Drawing.Point(304, 112);
			this.button_Flaeche.Name = "button_Flaeche";
			this.button_Flaeche.Size = new System.Drawing.Size(30, 20);
			this.button_Flaeche.TabIndex = 21;
			this.button_Flaeche.Text = "...";
			this.button_Flaeche.Click += new System.EventHandler(this.txtbox_Fläche_DoubleClick);
			// 
			// button_loeschen
			// 
			this.button_loeschen.Location = new System.Drawing.Point(512, 144);
			this.button_loeschen.Name = "button_loeschen";
			this.button_loeschen.Size = new System.Drawing.Size(120, 24);
			this.button_loeschen.TabIndex = 20;
			this.button_loeschen.Text = "Position löschen";
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
			// button_Übernehmen
			// 
			this.button_Übernehmen.Location = new System.Drawing.Point(378, 144);
			this.button_Übernehmen.Name = "button_Übernehmen";
			this.button_Übernehmen.Size = new System.Drawing.Size(112, 23);
			this.button_Übernehmen.TabIndex = 7;
			this.button_Übernehmen.Text = "Übernehmen";
			this.button_Übernehmen.Click += new System.EventHandler(this.button_Übernehmen_Click);
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
			this.dataGrid_Vorgang.DoubleClick += new System.EventHandler(this.dataGrid_Vorgang_DoubleClick);
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
			this.dataGridTextBoxColumn5.Format = "";
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
			this.dataGridTextBoxColumn6.HeaderText = "Fläche";
			this.dataGridTextBoxColumn6.MappingName = "Fläche";
			this.dataGridTextBoxColumn6.Width = 73;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
			this.dataGridTextBoxColumn7.Format = "";
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
			this.label14.Location = new System.Drawing.Point(184, 88);
			this.label14.Name = "label14";
			this.label14.TabIndex = 12;
			this.label14.Text = "Fläche/Menge";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(48, 88);
			this.label13.Name = "label13";
			this.label13.TabIndex = 11;
			this.label13.Text = "Einzelpreis/Stück";
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
			// txtbox_Fläche
			// 
			this.txtbox_Fläche.Location = new System.Drawing.Point(184, 112);
			this.txtbox_Fläche.Name = "txtbox_Fläche";
			this.txtbox_Fläche.Size = new System.Drawing.Size(120, 20);
			this.txtbox_Fläche.TabIndex = 5;
			this.txtbox_Fläche.Text = "";
			this.txtbox_Fläche.DoubleClick += new System.EventHandler(this.txtbox_Fläche_DoubleClick);
			this.txtbox_Fläche.Leave += new System.EventHandler(this.txtbox_Fläche_Leave);
			// 
			// txtbox_Einzelpreis
			// 
			this.txtbox_Einzelpreis.Location = new System.Drawing.Point(48, 112);
			this.txtbox_Einzelpreis.Name = "txtbox_Einzelpreis";
			this.txtbox_Einzelpreis.ReadOnly = true;
			this.txtbox_Einzelpreis.Size = new System.Drawing.Size(112, 20);
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
			this.txtbox_Posnummer.Location = new System.Drawing.Point(48, 40);
			this.txtbox_Posnummer.Name = "txtbox_Posnummer";
			this.txtbox_Posnummer.Size = new System.Drawing.Size(112, 20);
			this.txtbox_Posnummer.TabIndex = 1;
			this.txtbox_Posnummer.Tag = "Yo Man";
			this.txtbox_Posnummer.Text = "";
			this.txtbox_Posnummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Posnummer_KeyPress);
			// 
			// Zahlung
			// 
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
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(232, 120);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(280, 23);
			this.label32.TabIndex = 38;
			this.label32.Text = "________________________________";
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
			this.label28.Location = new System.Drawing.Point(240, 144);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(64, 23);
			this.label28.TabIndex = 36;
			this.label28.Text = "Netto";
			// 
			// txtbox_Netto
			// 
			this.txtbox_Netto.Location = new System.Drawing.Point(312, 144);
			this.txtbox_Netto.Name = "txtbox_Netto";
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
			this.txtbox_Mwst.TabIndex = 33;
			this.txtbox_Mwst.Text = "";
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
			this.label27.Location = new System.Drawing.Point(240, 40);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(56, 23);
			this.label27.TabIndex = 31;
			this.label27.Text = "Brutto";
			// 
			// txtbox_Rabatt
			// 
			this.txtbox_Rabatt.Location = new System.Drawing.Point(312, 72);
			this.txtbox_Rabatt.Name = "txtbox_Rabatt";
			this.txtbox_Rabatt.TabIndex = 30;
			this.txtbox_Rabatt.Text = "";
			// 
			// txtbox_Brutto
			// 
			this.txtbox_Brutto.Location = new System.Drawing.Point(312, 40);
			this.txtbox_Brutto.Name = "txtbox_Brutto";
			this.txtbox_Brutto.TabIndex = 29;
			this.txtbox_Brutto.Text = "";
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
			// MainFrame
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1028, 646);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainFrame";
			this.Text = "Layer 8 ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFrame_Load);
			this.tabControl1.ResumeLayout(false);
			this.Kunde.ResumeLayout(false);
			this.Bauvorhaben.ResumeLayout(false);
			this.gbox_Vorgangstyp.ResumeLayout(false);
			this.Positionen.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid_Vorgang)).EndInit();
			this.Zahlung.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
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
			dataGrid_Vorgang.SetDataBinding(VG.PosListe, "Positionen");
			

			//CSW: Hier folgt die Defintion der ToolTips 
			ToolTip TT_Kundenseite = new ToolTip();

			// Set up the delays for the ToolTip.
			TT_Kundenseite.AutoPopDelay = 5000; //Dauer der Anzeige
			TT_Kundenseite.InitialDelay = 300;  //Zeitverzögerung bis der ToolTip angezeigt wird
			TT_Kundenseite.ReshowDelay = 300;	//Zeitverzögerung zwischen Tooltips 2er verschiedener Elemente
			// Force the ToolTip text to be displayed whether or not the form is active.
			TT_Kundenseite.ShowAlways = true;
      		// Set up the ToolTip text 
			TT_Kundenseite.SetToolTip(this.txtbox_Kürzel, "Bitte das Kürzel des Kunden angeben");
			TT_Kundenseite.SetToolTip(this.txtbox_Kundennummer, "Die Kundennummer des aktuellen Kunden");
			TT_Kundenseite.SetToolTip(this.txtbox_Name, "Der Nachname des aktuellen Kunden");
			TT_Kundenseite.SetToolTip(this.txtbox_Vorname, "Der Vorname des aktuellen Kunden");

			// Daten_binden();
			
		}


		/* public void Daten_binden()//CSW
		{
		// CSW 17.10.03 14:30 hab DataBinding wieder reingenommen, bei den Kunden sachen gibt es NullpointerExceptions, hab es deshalb erstmal rausgelassen
			
			// Hier sind die DataBindings der Kunden-TabSeite - im Konstruktor sind die DummyDaten wieder aktiv - CSW 18.10.03 17:00
			cbox_Anrede.DataBindings.Add("Text",VG.UnserKunde,"Anrede");
			this.txtbox_Name.DataBindings.Add("Text",VG.UnserKunde,"NName");
			txtbox_Telefonnummer.DataBindings.Add("Text",VG.UnserKunde,"Telefonnummer");
			txtbox_PLZ.DataBindings.Add("Text",VG.UnserKunde,"PLZ");
			txtbox_Ort.DataBindings.Add("Text",VG.UnserKunde,"Ort");
			txtbox_Strasse.DataBindings.Add("Text",VG.UnserKunde,"Strasse");
			txtbox_Vorname.DataBindings.Add("Text",VG.UnserKunde,"VName");
			txtbox_Kundennummer.DataBindings.Add("Text",VG.UnserKunde,"Kundennummer");
			txtbox_Kürzel.DataBindings.Add("Text",VG.UnserKunde,"Kuerzel");
			txtbox_Fax.DataBindings.Add("Text",VG.UnserKunde,"Fax");
			txtbox_Email.DataBindings.Add("Text",VG.UnserKunde,"Email");

			txtbox_Gesamtpreis.DataBindings.Add("Text",VG.aktPos,"GPreis");
			txtbox_Fläche.DataBindings.Add("Text",VG.aktPos,"Flaeche");
			txtbox_Einzelpreis.DataBindings.Add("Text",VG.aktPos,"EPreis");
			txtbox_Langtext.DataBindings.Add("Text",VG.aktPos,"Langtext");
			txtbox_Kurztext.DataBindings.Add("Text",VG.aktPos,"Kurztext");
			txtbox_Posnummer.DataBindings.Add("Text",VG.aktPos,"Positionsnummer");
			txtbox_Raum.DataBindings.Add("Text",VG.aktPos,"Raum");

			txtbox_PlzTab2.DataBindings.Add("Text",VG,"BauPLZ");
			txtbox_OrtTab2.DataBindings.Add("Text",VG,"BauOrt");
			txtbox_StrasseTab2.DataBindings.Add("Text",VG,"BauStrasse");
			txtbox_VornameTab2.DataBindings.Add("Text",VG,"BauVName");
			txtbox_NameTab2.DataBindings.Add("Text",VG,"BauNName");
			txtbox_VNummer.DataBindings.Add("Text",VG,"Vorgangsnummer");
			txtbox_VBezeichnung.DataBindings.Add("Text",VG,"Vorgangsbezeichnung");
			txtbox_Datum.DataBindings.Add("Text",VG,"Datum");
			txtbox_Netto.DataBindings.Add("Text",VG,"Netto");
			txtbox_Mwst.DataBindings.Add("Text",VG,"MwSt");
			txtbox_Rabatt.DataBindings.Add("Text",VG,"Rabatt");
			txtbox_Brutto.DataBindings.Add("Text",VG,"Brutto");


		}
		
		*/



		private void button_Übernehmen_Click(object sender, System.EventArgs e) //CSW
		{


			if (this.position_anlegen)
			{}
			
			else 
			{

				dataGrid_Vorgang.Enabled=true;   // That's the trick! Damit der am Anfang nicht so lange lädt bis die erste Position angezeigt wird
				if(Daten_in_aktPos_schreiben())	 // Eine DummyMethode, damit ich schon Daten ändern kann (hab doch ne Prüfung drin, deshalb die if-Abfrage)
				{
					if (DG_Zeile_bearbeiten==false) // boolsches Flag - im Bearbeiten Modus ist das DataGrid disabled
					{	
						VG.Daten_hinzufuegen();	   //	Einfügen der "aktPos" in die PosListe, es werden also nicht direkt die TextboxInhalte genommen !
					}
					else 
					{
						VG.Daten_wiedereinfügen();  // Wird eigentlich an der alten Stelle bearbeitet
						DG_Zeile_bearbeiten=false;						
						button_loeschen.Visible=false;
					
						// alte Formatierung wiederherstellen
						dataGridTableStyle2.SelectionBackColor=System.Drawing.SystemColors.ActiveCaption;
					}
				}
		
				dataGrid_Vorgang.ReadOnly=true;  // Ich weiß nicht warum aber mit diesem "Trick" läuft es schneller
			}
		}


		private void txtbox_Kürzel_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{

				if(e.KeyChar == (char)13)
				{
					e.Handled=true;
					String kuerz;
					kuerz = this.txtbox_Kürzel.Text;
				
					VG.UnserKunde = UnsereDb.Kunde_suchen_nach_Kuerzel(kuerz);	// CSW 17.10.03 14:30 "K" in Unser Kunde geändert/ DB zu ner Public Variablen  von Mainframe gemacht und diese bei Form1.Load initialisieren lassen
					if (VG.UnserKunde != null)
					{
						kunde_Anzeigen(VG.UnserKunde);
					}
					else MessageBox.Show("Kunde nicht gefunden");
				}
			}

		}

		private void txtbox_Kürzel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{
				this.txtbox_Kürzel.ReadOnly = false;
				this.txtbox_Name.ReadOnly = true;
				this.txtbox_Kundennummer.ReadOnly = true;
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		private void txtbox_Name_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{
				this.txtbox_Kürzel.ReadOnly = true;
				this.txtbox_Name.ReadOnly = false;
				this.txtbox_Kundennummer.ReadOnly = true;
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		private void txtbox_Kundennummer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (!this.bearbeiten_flag)
			{
				this.txtbox_Kürzel.ReadOnly = true;
				this.txtbox_Name.ReadOnly = true;
				this.txtbox_Kundennummer.ReadOnly = false;
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

		private void button_XmlLesen_Click(object sender, System.EventArgs e)  //- CSW 18.10.03 17:00
		{
			//	VG.aktPos.Positionsnummer=VG.aktPos.Positionsnummer+1; dat war mal meine Demonstration des DataBindingProblems
			//	Positionen.CreateControl();
			
			dataGrid_Vorgang.Enabled=true;  // Gleicher Spass wie bei Übernehmen_click
			VG.XML_lesen();
			dataGrid_Vorgang.ReadOnly=true;
			dateTimePicker_Bau.Value=VG.Datum;

		
		}

		private void button_XmlSchreiben_Click(object sender, System.EventArgs e) //- CSW 18.10.03 17:00
		{
			VG.XML_schreiben();
		}
		
		private void kunde_Anzeigen (Kunde K) //- CH 18.10.03 19:34
		{
			this.txtbox_Kürzel.Text = K.Kuerzel;
			this.kürzelstring = this.txtbox_Kürzel.Text;
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
			/*
			switch (K.Anrede)
			{
				case "Herr": this.cbox_Anrede.Text.Equals("Herr");
					break;
				case "Frau": this.cbox_Anrede.Text.Equals("Frau");
					break;
			
			}
			*/	
		}
		

		private void position_Anzeigen (Position K) //- CH 22.10.03 14:34
		{
			this.txtbox_Posnummer.Text = K.Positionsnummer;
			this.txtbox_Kurztext.Text = K.Kurztext;
			this.txtbox_Langtext.Text = K.Langtext;	
			this.txtbox_Einzelpreis.Text = ""+K.EPreis;
			this.txtbox_Fläche.Text = ""+K.Flaeche;
			this.txtbox_Gesamtpreis.Text = ""+K.GPreis;
			this.txtbox_Raum.Text = K.Raum;		
		}


		private void position_Textboxen_loeschen()
		{
			this.txtbox_Posnummer.Text = "";
			this.txtbox_Kurztext.Text = "";
			this.txtbox_Langtext.Text = "";	
			this.txtbox_Einzelpreis.Text = "";
			this.txtbox_Fläche.Text = "";
			this.txtbox_Gesamtpreis.Text = "";
			this.txtbox_Raum.Text = "";
		}

		private void position_Textboxen_auf_write () //- CH 26.10.03 21:00
		{
			this.txtbox_Posnummer.ReadOnly = true; //Posnummer wird automatisch von DB vergeben
			this.txtbox_Kurztext.ReadOnly = false;
			this.txtbox_Langtext.ReadOnly = false;	
			this.txtbox_Einzelpreis.ReadOnly = false;
			this.txtbox_Fläche.ReadOnly = true;  // da die Eingabe der Fläche nicht benötigt wird
			// Gesamtpreis bleibt unverändert
			// bei ZPositions eingabe wird keine Raum benötigt, daher würde es nur verwirren, wenn man hier eine Eingabe zulassen würde.		
		}

		private void position_Textboxen_auf_read () //- CH 26.10.03 21:00
		{
			this.txtbox_Posnummer.ReadOnly = false; //wieder zurück
			this.txtbox_Kurztext.ReadOnly = true;
			this.txtbox_Langtext.ReadOnly = true;	
			this.txtbox_Einzelpreis.ReadOnly = true;
			this.txtbox_Fläche.ReadOnly = false;  // jetzt wieder im normalen Modus
			// Gesamtpreis bleibt unverändert
			// bei ZPositions eingabe wird keine Raum benötigt, daher würde es nur verwirren, wenn man hier eine Eingabe zulassen würde.		
		}

		private void alle_kunden_textboxen_auf_write()
		{
			this.txtbox_Kürzel.ReadOnly = false;
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
			this.txtbox_Kürzel.ReadOnly = true;
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
	

		private void button_Speichern_Click(object sender, System.EventArgs e)
		{

			/*	if (this.txtbox_Kürzel.Text.Equals(""))
				{
					MessageBox.Show("Bitte geben Sie zuerst ein Kürzel ein");
				}

				else
				{     */
			this.bearbeiten_flag = false;

			if (this.neuer_Kunde)
			{
				this.neuer_Kunde = false;
				UnsereDb.Neuer_Kunde_Anlegen(VG.UnserKunde);
				this.alle_kunden_textboxen_auf_read();
			}
			else
			{

				// UnsereDb.Kunde_aendern_Kürzel(this.txtbox_Kürzel.Text, VG.UnserKunde);
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
				// UnsereDb.Kunde_aendern_Fax(this.txtbox_Fax.Text, VG.UnserKunde);			Casi ich will sie haben!
				// UnsereDb.Kunde_aendern_Email(this.txtbox_Email.Text, VG.UnserKunde);		Casi ich will sie haben!
				this.alle_kunden_textboxen_auf_read();
				// }
			}
		}

	
		private void txtbox_Kürzel_Leave(object sender, System.EventArgs e)
		{
			if (this.bearbeiten_flag)
			{
				string tempKürzel = this.txtbox_Kürzel.Text;
				tempKürzel.ToLower();
				tempKürzel.Trim();
				this.kürzelstring.ToLower();
				this.kürzelstring.Trim();
				// bool test = string.Equals(this.kürzelstring, tempKürzel);
				if (this.kürzelstring != tempKürzel)
				{
					Kunde temp;
					temp = UnsereDb.Kunde_suchen_nach_Kuerzel(this.txtbox_Kürzel.Text);
					if (temp != null)
					{
						MessageBox.Show("Diese Kürzel ist schon vergeben, bitte wählen Sie ein anderes Kürzel");
					}
					else 
					{
						VG.UnserKunde.Kuerzel = this.txtbox_Kürzel.Text;
					}
				}
				this.kunde_Anzeigen(VG.UnserKunde);
			}
		}

	
		private void button1_Click(object sender, System.EventArgs e)
		{	
			if (this.txtbox_Kürzel.Text.Equals(""))
			{
				MessageBox.Show("Ja würd ich gern, wennn ein Kunde angegeben wär! Ey!");
			}
			else
			{
				this.bearbeiten_flag = true;
				this.alle_kunden_textboxen_auf_write();
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

		
		private void txtbox_Kürzel_TextChanged(object sender, System.EventArgs e)
		{
			if (!this.neuer_Kunde)
			{
				if (this.bearbeiten_flag)
				{
					this.kürzelstring = this.txtbox_Kürzel.Text;
				}
			}
		}

	
		private void button_Neu_Click(object sender, System.EventArgs e)
		{
			this.neuer_Kunde = true;
			this.bearbeiten_flag = true;
			this.alle_kunden_textboxen_auf_write();
			this.alle_kunden_textboxen_Inhalt_loeschen();
		}

		
		private void dataGrid_Vorgang_CurrentCellChanged(object sender, System.EventArgs e) //CSW - 23.10.03 00:01
		{	
			// Schreibt mir den aktuellen Zeilenindex in eine nette Variable, dies war das einzige verlässliche Event
			this.DG_aktZeile=dataGrid_Vorgang.CurrentRowIndex;
			
		}


		private void dataGrid_Vorgang_DoubleClick(object sender, System.EventArgs e)//CSW - Update: 26.10.03
		{
				if (DG_Zeile_bearbeiten==false) //so ist der Doppelklick deaktiviert während noch eine Zeile bearbeitet wird.
				{	
					button_loeschen.Visible=true;
					// Übernimmt die doppelt-geklickte Zeile als aktPos und löscht sie aus der PosListe
					VG.Position_aus_Liste_ändern(DG_aktZeile);
					// Formatierung ändern, um die Zeile hervorzuheben
					
					dataGridTableStyle2.SelectionBackColor=System.Drawing.Color.DarkRed;
					dataGrid_Vorgang.Select(DG_aktZeile);
					DG_Zeile_bearbeiten=true;
					position_Anzeigen(VG.aktPos);

					dataGrid_Vorgang.Enabled=false;
				}
		}

		private bool Daten_in_aktPos_schreiben() //CSW - 23.10.03 01:01
		{
			// einfache DummyFunktion ohne jegliche Überprüfung  - UPDATE: Shit! Ohne lief dat eh nicht ordentlich :-) also soch mit Prüfung
			// Sollte durch eine bessere ersetzt oder erweitert werden
			// Sie errechnet auch den Gesamtpreis selbständig (!)
			VG.aktPos.Raum=txtbox_Raum.Text;
			VG.aktPos.Positionsnummer=txtbox_Posnummer.Text;
			VG.aktPos.Kurztext=txtbox_Kurztext.Text;
			VG.aktPos.Langtext=txtbox_Langtext.Text;
			try 
				{	
				VG.aktPos.EPreis=Convert.ToDecimal(txtbox_Einzelpreis.Text);
				}
			catch	
				{
				MessageBox.Show("Den Preis bitte als Dezimal-Zahl angeben (z.B.: 10,50)", "Ein Fehler ist aufgetreten");
				return false;
				}

			try {
				VG.aktPos.Flaeche=Convert.ToDouble(txtbox_Fläche.Text);
				}
			catch	
				{	
				MessageBox.Show("Die Fläche bitte als Zahl in Quadratmeter angeben ", "Ein Fehler ist aufgetreten");
				return false;
				}
			
			VG.aktPos.GPreis= Convert.ToDecimal(VG.aktPos.Flaeche*(double)VG.aktPos.EPreis);
			return true;
		}

		

		private void txtbox_Fläche_Leave(object sender, System.EventArgs e) //CSW - 23.10.03 01:01
		{	// Wenn ne Zahl eingegeben wird, überprüft er, ob er schon den Gesamtpreis ausrechnen kann
			 
			if(!(txtbox_Einzelpreis.Text==""))
			{	
				
				try
				{
					//VG.aktPos.GPreis= Convert.ToDecimal(VG.aktPos.Flaeche*(double)VG.aktPos.EPreis);
					// und dies ist die umständlichere Variante die ich nun benutzen muss:
					VG.aktPos.GPreis= Convert.ToDecimal(Convert.ToDouble(txtbox_Fläche.Text)*Convert.ToDouble(txtbox_Einzelpreis.Text));
					txtbox_Gesamtpreis.Text=""+VG.aktPos.GPreis;
				
				}
		
				catch{
						txtbox_Gesamtpreis.Text="";
				}
			}
		}

		private void txtbox_Einzelpreis_Leave(object sender, System.EventArgs e)//CSW - 23.10.03 01:02
		{// Wenn ne Zahl eingegeben wird, überprüft er, ob er schon den Gesamtpreis ausrechnen kann
			
			if (!this.position_anlegen)
			{

				if(!(txtbox_Fläche.Text==""))
				
				{
					try
					{
						//VG.aktPos.GPreis= Convert.ToDecimal(VG.aktPos.Flaeche*(double)VG.aktPos.EPreis); so sollte sie später aussehen
						// und dies ist die umständlichere Variante die ich nun benutzen muss:
						VG.aktPos.GPreis= Convert.ToDecimal(Convert.ToDouble(txtbox_Fläche.Text)*Convert.ToDouble(txtbox_Einzelpreis.Text));			
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
						
					VG.aktPos = UnsereDb.Pos_suchen_nach_Posnummer(posnummer);	// CSW 17.10.03 14:30 "K" in Unser Kunde geändert/ DB zu ner Public Variablen  von Mainframe gemacht und diese bei Form1.Load initialisieren lassen
					if (VG.aktPos != null)
					{
						position_Anzeigen(VG.aktPos);
					}
					else MessageBox.Show("Die angegebene Position konnte nicht gefunden werden","Es ist ein Fehler aufgetreten");
				}

			}
		}

		private void button_loeschen_Click(object sender, System.EventArgs e) // CSW - 26.10.03
		{
			VG.Position_aus_Liste_löschen(); // löscht die "ge-highlighted-te" Zeile
			dataGrid_Vorgang.Enabled=true;	 // und setzt die Einstellungen zurück auf Standard	
			button_loeschen.Visible=false;
			DG_Zeile_bearbeiten=false;

		
			dataGridTableStyle2.SelectionBackColor=System.Drawing.SystemColors.ActiveCaption;

		}

		private void txtbox_Fläche_DoubleClick(object sender, System.EventArgs e) // CSW - 26.10.03 
			// Diese Methode ist auch als Eventhandler für den Button neben der Textbox in Verwendung
		{
			Dialog_Fläche Dialog_F = new Dialog_Fläche();
			Dialog_F.ShowDialog();				// Modale Darstellung

			if (Dialog_F.DialogResult==DialogResult.OK)		// Dialog über OK beendet
			{	
				string msg_boxFläche = "Folgende Fläche wurde eingeben: ";
				msg_boxFläche += Dialog_F.FlaechenFormel;
				msg_boxFläche += " = "+Dialog_F.Flaeche;
				MessageBox.Show(msg_boxFläche, "Kontrolle ist besser:");
				
				VG.aktPos.Flaeche=Dialog_F.Flaeche;
				position_Anzeigen(VG.aktPos);
			}
			else										// Dialog über Abbrechen beendet
			{
				VG.aktPos.Flaeche=0;
				position_Anzeigen(VG.aktPos);
			}
			

		}

		/*private void txtbox_Posnummer_Leave(object sender, System.EventArgs e)
		{
			if (this.position_anlegen)
			{
				string tempPosnummer = this.txtbox_Posnummer.Text;
				tempPosnummer.ToLower();
				tempPosnummer.Trim();
				this.positionsnummerstring.ToLower();
				this.positionsnummerstring.Trim();
				// bool test = string.Equals(this.kürzelstring, tempKürzel);
				if (this.positionsnummerstring != tempPosnummer)
				{
					VG.aktPos = UnsereDb.Pos_suchen_nach_Posnummer(this.txtbox_Posnummer.Text);	// CSW 17.10.03 14:30 "K" in Unser Kunde geändert/ DB zu ner Public Variablen  von Mainframe gemacht und diese bei Form1.Load initialisieren lassen
					if (VG.aktPos != null)
					{
						MessageBox.Show("Es existiert bereits eine Position mit diesem Kürzel");
					}
					else this.position_Anzeigen(VG.aktPos);		
				}
			}
		}*/

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

		private void dateTimePicker_Bau_ValueChanged(object sender, System.EventArgs e)
		{
			VG.Datum = dateTimePicker_Bau.Value;
		}

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
		
		/* Die Equals-Methode wird überschrieben. Diese
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
			// das ist die umständliche Variante, da mehr als ein Kunde zurückkommen könnte wenn der Name nicht eindeutig ist
			// Vielleicht können wir das ja wie in DIAK mit einem DropdownFeld realisieren
			// Bitte auf die Variablen-Namen achten, habe sie so gewählt, damit sie die aus der Klasse nicht überdecken.
		}

		public bool suche_nach_Kuerzel (string Kurz)
		{
			return true;
			// Suche in der DB nach dem eindeutigen Kuerzel
			// Bitte auf die Variablen-Namen achten, habe sie so gewählt, damit sie die aus der Klasse nicht überdecken.
		}

		public bool suche_nach_Kundennummer (int KDNr)
		{
			return true;
			// Suche in der DB nach der eindeutigen Kundennummer
			// Bitte auf die Variablen-Namen achten, habe sie so gewählt, damit sie die aus der Klasse nicht überdecken.
		}

		public bool in_DB_schreiben()
		{
			return true;
			// in unserem Brainstorm stand als Parameter noch ein "INDEX" drin
		}

		public bool Kunde_loeschen_nach_Kundennummer (int KDNr)
		{
			return true;
			// Bitte auf die Variablen-Namen achten, habe sie so gewählt, damit sie die aus der Klasse nicht überdecken.
		}

		public bool Kunde_loeschen_nach_Kuerzel (string Kurz)
		{
			return true;
			// Bitte auf die Variablen-Namen achten, habe sie so gewählt, damit sie die aus der Klasse nicht überdecken.
		}

		public bool Kunde_loeschen (/*den hier löschen*/)
		{
			return true;
			// Hier kann man ja eine der beiden oberen benutzen
		}

		public bool Kunde_anlegen (/*den hier anlegen*/)
		{
			return true;
			// Dann muss vorher natürlich eine Vollständigkeitsprüfung erfolgen
		}

		// Kunde ändern ist nur ein speichern der aktuellen Variableninhalte
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
		/* Die schreibgeschützte Keys-Eigenschaft */
		public System.Collections.ICollection Keys
		{
			get {return Dictionary.Keys;}
		}
		//		Schließlich ermöglicht noch ein Indizierer den Zugriff auf die Personen:
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
	
	private DateTime m_Datum; // Hier ein DatenFormat raussuchen und einfügen !!!
	private string m_BauNName; // extra für Hegi
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
	private int m_Rabatt;
	// Zusätzlich die Variablen aus Position (Langtext/Kurztext/Preis/ etc.)

	#endregion
		 
	#region Öffentliche Variablen - Vorgang
	// erstes Tab (Kunde)
	public Kunde UnserKunde; //bzw alle seine Variablen

	// drittes Tab (Positionen)
	public Position aktPos;		//@Casi: Hier bitte die Daten reinrocken
	public DataSet PosListe;	//Die DataSource für das NittyGrittyDataGriddy

	// XML File: XML-Reader bzw. XML-Writer oder so ;-)


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
		
	public DateTime Datum // Hier ein DatenFormat raussuchen und einfügen !!!
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
		get {return m_Netto;}
		set{this.m_Netto=value;}
	}

	public decimal Brutto
	{
		get {return m_Brutto;}
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

	public int Rabatt
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
		
		m_Datum= DateTime.Today; // Hier ein DatenFormat raussuchen und einfügen !!!
		m_BauNName="na"; //damit es initialisiert wird und keinen Terror macht
		m_BauVName="na";
		m_BauStrasse="Baustrasse 15";
		m_BauPLZ=49148;
		m_BauOrt="Baustelle";
		m_Netto= 10.5m;
		m_Brutto=9.47m;
		m_MwSt=1.65m;
		m_Dateiname="testDatei.xml";
		m_Vorgangsnummer=1;
		m_Vorgangsbezeichnung="Angebot";
		m_Rabatt=5;
		PosListe = new DataSet("PosListe");
		InitializeDataSet();
		
			

	}
	#endregion

	#region Funktionen - Vorgang
		
	private void InitializeDataSet() // CSW: Anlegen der Struktur des DataSets
	{
		
		// Tabelle fürs DataSet anlegen
		DataTable tblPos = new DataTable("Positionen");
			
		tblPos.Columns.Add("Raum", typeof(System.String));
		tblPos.Columns.Add("Position", typeof(System.String));
		tblPos.Columns.Add("Kurztext", typeof(System.String));
		tblPos.Columns.Add("Langtext", typeof(System.String));
		tblPos.Columns.Add("Preis/Einheit", typeof(System.Decimal));
		tblPos.Columns.Add("Fläche", typeof(System.Double));
		tblPos.Columns.Add("Gesamtpreis", typeof(System.Decimal));

		this.PosListe.Tables.Add(tblPos);
	}

	
	public void XML_schreiben()  // Methode um alle aktuellen Daten in ein XML-Dokument zu schreiben - CSW 18.10.03 17:00
	{
		PosListe.WriteXml(@"..\..\products.xml");	
		XmlTextWriter W = new XmlTextWriter(@"..\..\KundeX.xml",null);
		XmlTextReader R = new XmlTextReader(@"..\..\products.xml");
		R.Read();
		R.Read();
		R.Read();
		W.Formatting = Formatting.Indented; //Einrückung festlegen
		
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

	
	public void XML_lesen() // Methode um alle Daten einzulesen, hier brauchte ich dat DataBinding nochmal für alles - CSW 18.10.03 17:00
	{
		
		XmlTextReader R = new XmlTextReader(@"..\..\KundeX.xml");		// genau wie beim Schreiben nur sind die Dateinamen vertauscht, die Positionen werden nachher in products.xml geschrieben und am Ende der Methode ins DataSet gelesen
		
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
		Rabatt=Convert.ToInt32(R.ReadElementString());
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
		W.WriteStartElement("PosListe");	// das Stammelement muss manuell geschrieben werden, auch wenn es aus der anderen Datei mitkopiert werden könnte
		W.WriteRaw(Inhalt);					// Der String wird roh hier reingeschrieben, ich hoffe die Strings sind immer lang genug, wenn der String zu lang würde gingen Element verloren, dann müssten wir uns was überlegen
		W.WriteEndElement();
		W.WriteEndDocument();
		//auch den Writer schliessen, dat ist noch viel wichtiger !!
		W.Close();
		

		PosListe.Tables[0].Clear(); // Löscht vorher alle Zeilen aus der DataSet.DataTable, das bremst leider mal wieder das System, arrrgh

		PosListe.ReadXml(@"..\..\products.xml");
		MessageBox.Show("Einlesen abgeschlossen", "XML Lesevorgang"); // kommt nachher raus bzw. wird geändert

		
	}


	public void Daten_hinzufuegen() //CSW - 23.10.03 01:02 (UPDATE)
	{	// Das ist die Kurzform von dem was dann drunter steht
		DataRow r = PosListe.Tables[0].Rows.Add(new object[]{aktPos.Raum,aktPos.Positionsnummer,aktPos.Kurztext,aktPos.Langtext,aktPos.EPreis,aktPos.Flaeche,aktPos.GPreis});
				


					//		// Ist nur Copy&Paste&Assimilate
					//		DataRowCollection rc; 
					//		DataRow myNewRow;
					//		// ein Array für die 7 Spalten
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

		
	public void Daten_wiedereinfügen() //CSW - 25.10.03 01:02 
	{			
		// an der Position, an der die Position auch vorher stand werden die einzelnen Spalten geändert
									
					bearbeiteteZeile[0]=aktPos.Raum;
					bearbeiteteZeile[1]=aktPos.Positionsnummer;
					bearbeiteteZeile[2]=aktPos.Kurztext;
					bearbeiteteZeile[3]=aktPos.Langtext;
					bearbeiteteZeile[4]=aktPos.EPreis;
					bearbeiteteZeile[5]=aktPos.Flaeche;
					bearbeiteteZeile[6]=aktPos.GPreis;
					
	}




	public bool speichern ()
	{
		return true;
		// laut Brainstorming war hier Vorgang X als Parameter geplant, 
		// hab keine Verwendung dafür gehabt
	}


	public string Vorgangsnamen_basteln ()
	{
		return "hassenichtgesehen";
		// Frage: Wie bekommen wir den eindeutig ??
	}

	
	public bool öffnen (string DatName)
	{
		return true;
	}


	public void Rechnung_erstellen (Vorgang X)
	{
		// Hier weiß ich auch nicht was dat soll, wenn es sich nicht auf "this" bezieht
		// Wenn es ne Klassenfunktion werden soll, müssen wir es noch static machen
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


	public void Position_aus_Liste_ändern (int Zeile)//CSW - 23.10.03 01:02
	{
		// Bekommt den Index einer Zeile des DataSets/DataGrids, liest die einzelnen Werte aus und löscht dann die Zeile aus der Tabelle
		// In der nächsten Version fügt er sie evt auch da wieder ein, wo sie hingehört. (Mal sehen ob dat geht)
		// Update: wurde realisiert !
		// Diese Methode stellt nur die Daten aus der DataGrid Zeile dar.

		DataRow R =PosListe.Tables[0].Rows[Zeile];
		aktPos.Raum = Convert.ToString(R[0]);
		aktPos.Positionsnummer = Convert.ToString(R[1]);
		aktPos.Kurztext=Convert.ToString(R[2]);
		aktPos.Langtext=Convert.ToString(R[3]);
		aktPos.EPreis=Convert.ToDecimal(R[4]);
		aktPos.Flaeche=Convert.ToDouble(R[5]);
		aktPos.GPreis=Convert.ToDecimal(R[6]);

		bearbeiteteZeile= PosListe.Tables[0].Rows[Zeile];
	}

	public void Position_aus_Liste_löschen()
	{
	bearbeiteteZeile.Delete();
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
	private decimal m_GPreis; // also Fläche*ePreis - brauchen wir wahrscheinlich gar nicht wirklich
	private string m_Einheit;
	private	decimal m_realMatKosten;
	private decimal m_realLohnKosten;
	private decimal m_realGesamtKosten; 		//= Fläche*(realMatKosten+realLohnKosten)
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

	public decimal GPreis // also Fläche*ePreis - brauchen wir wahrscheinlich gar nicht wirklich
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
		m_GPreis=0; // also Fläche*ePreis - brauchen wir wahrscheinlich gar nicht wirklich
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
			/// Hier wird die verbindung zur Acces-DB aufgebaut und über die Laufzeit des Programmmes aufrecht 
			/// erhalten. Da nur ein Single-Userbetrieb vorgesehen ist, dürfte das kein Problem darstellne.
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
			OleDbCommand sucheNNamen = new OleDbCommand("SELECT * FROM Kunde WHERE Name ='"+nam+"'", myconnection);
		
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
		public KundenVerzeichnis alle_Kunden_ausgeben ()
		/// Diese Methode erfordert keinen Übergabewert, sie liefert alle in der DB 
		/// gespeicherten Kunden in einem KundenVerzeichnis:DictonaryBase zurück.
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
			int änderungen=0; 
			string neuesKuerzel= Kuerzel;
			Kunde myKunde = k;
			OleDbCommand Kuerzel_aendern= null ;
			try	
			{	
				Kuerzel_aendern= new OleDbCommand("UPDATE Kunde SET Kuerzel='"+neuesKuerzel+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Kuerzel_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}
		public int Kunde_aendern_Firma(string Firma, Kunde k)
		{
			/// Diese Methode schreibt eine neue Firma(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neueFirma= Firma;
			Kunde myKunde = k;
			OleDbCommand Firma_aendern= null ;
			try	
			{	
				Firma_aendern= new OleDbCommand("UPDATE Kunde SET Firma='"+neueFirma+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Firma_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}
		public int Kunde_aendern_Anrede(string Anrede, Kunde k)
		{
			/// Diese Methode schreibt eine neue Anrede(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neueAnrede= Anrede;
			Kunde myKunde = k;
			OleDbCommand Anrede_aendern= null ;
			try	
			{	
				Anrede_aendern= new OleDbCommand("UPDATE Kunde SET Anrede='"+neueAnrede+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Anrede_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}
		
        public int Kunde_aendern_Name(string name,Kunde k)
		{
			/// Diese Methode schreibt den neuen Namen(Heirat?) des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neuerName= name;
			Kunde myKunde = k;
			OleDbCommand Name_aendern= null ;
			try	
			{	
				Name_aendern= new OleDbCommand("UPDATE Kunde SET Name='"+neuerName+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Name_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}

		public int Kunde_aendern_Vorname(string Vorname,Kunde k)
		{
			/// Diese Methode schreibt den neuen Vornamen(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neuerVorName= Vorname;
			Kunde myKunde = k;
			OleDbCommand VorName_aendern= null ;
			try	
			{	
				VorName_aendern= new OleDbCommand("UPDATE Kunde SET Vorname='"+neuerVorName+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =VorName_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}

		public int Kunde_aendern_Strasse(string strasse,Kunde k)
		{
			/// Diese Methode schreibt die neue Strasse des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neuestrasse= strasse;
			Kunde myKunde = k;
			OleDbCommand Strasse_aendern= null ;
			try	
			{	
				Strasse_aendern= new OleDbCommand("UPDATE Kunde SET Strasse='"+neuestrasse+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Strasse_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		}
		public int Kunde_aendern_Ort(string Ort,Kunde k)
		{
			/// Diese Methode schreibt den neue Ort des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neuerOrt= Ort;
			Kunde myKunde = k;
			OleDbCommand Ort_aendern= null ;
			try	
			{	
				Ort_aendern= new OleDbCommand("UPDATE Kunde SET Ort='"+neuerOrt+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Ort_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		}
		public int Kunde_aendern_PLZ(int PLZ,Kunde k)
		{
			/// Diese Methode schreibt die neue PLZ des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			int neuePLZ= PLZ;
			Kunde myKunde = k;
			OleDbCommand PLZ_aendern= null ;
			try	
			{	
				PLZ_aendern= new OleDbCommand("UPDATE Kunde SET PLZ="+neuePLZ+" WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =PLZ_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		}
		
		public int Kunde_aendern_Kontonr(int Kontonr,Kunde k)
		{
			/// Diese Methode schreibt die neue Kontonummer des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			int neueKontonr= Kontonr;
			Kunde myKunde = k;
			OleDbCommand Kontonr_aendern= null ;
			try	
			{	
				Kontonr_aendern= new OleDbCommand("UPDATE Kunde SET Kontonr="+neueKontonr+" WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Kontonr_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		}
		
		public int Kunde_aendern_BLZ(int BLZ,Kunde k)
		{
			/// Diese Methode schreibt die neue BLZ des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			int neueBLZ= BLZ;
			Kunde myKunde = k;
			OleDbCommand BLZ_aendern= null ;
			try	
			{	
				BLZ_aendern= new OleDbCommand("UPDATE Kunde SET BLZ="+neueBLZ+" WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =BLZ_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		}
		
        public int Kunde_aendern_Bank(string Bank,Kunde k)
		{
			/// Diese Methode schreibt den neue Bank des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neueBank= Bank;
			Kunde myKunde = k;
			OleDbCommand Bank_aendern= null ;
			try	
			{	
				Bank_aendern= new OleDbCommand("UPDATE Kunde SET Bank='"+neueBank+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Bank_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		}
		
		public int Kunde_aendern_Tel(string Tel,Kunde k)
		{
			/// Diese Methode schreibt die neue Telefonnummer des Referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neueTele= Tel;
			Kunde myKunde = k;
			OleDbCommand Tel_aendern= null ;
			try	
			{	
				Tel_aendern= new OleDbCommand("UPDATE Kunde SET Telefon='"+neueTele+"' WHERE Kundennr ="+myKunde.Kundennummer, myconnection);
				änderungen =Tel_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		}
		
        public int Kunde_aendern_Fax(string Fax,Kunde k)
		{
			/// Diese Methode schreibt die neue Faxnummer(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neueFax= Fax;
			Kunde myKunde = k;
			OleDbCommand Fax_aendern= null ;
			try	
			{	
				Fax_aendern= new OleDbCommand("UPDATE Kunde SET Fax='"+neueFax+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Fax_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}

		public int Kunde_aendern_Email(string Email,Kunde k)
		{
			/// Diese Methode schreibt die neue E-mailadresse(Irrtum beim ersten Eintrag?) des referenzierten Kunden in die Datenbank.
			int änderungen=0; 
			string neuerEmail= Email;
			Kunde myKunde = k;
			OleDbCommand Email_aendern= null ;
			try	
			{	
				Email_aendern= new OleDbCommand("UPDATE Kunde SET eMail='"+neuerEmail+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Email_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}

		public int Kunde_in_DB_schreiben(Kunde k)
		{
			/// Diese Methode schreibt den referenzierten Kunden, mit allen neuen Werten in die Datenbank.
			int änderungen=0; 
			Kunde myKunde = k;
			OleDbCommand Kunde_aendern= null ;
			try	
			{	
				Kunde_aendern= new OleDbCommand("UPDATE Kunde SET Kuerzel='"+myKunde.Kuerzel+"' Firma='"+myKunde.Firma+" Anrede = '"+myKunde.Anrede+"' Name = '"+myKunde.NName+"' Vorname= '"+myKunde.VName+"' Strasse= '"+myKunde.Strasse+"' Ort= '"+myKunde.Ort+"' PLZ="+myKunde.PLZ+" Kontonr ="+myKunde.Kontonr+" BLZ ="+myKunde.BLZ+" Bank = '"+myKunde.Bank+"' Telefon ='"+myKunde.Telefonnummer+"' Fax= '"+myKunde.Fax+"' '  eMail='"+myKunde.Email+"' WHERE Kundennr ="+myKunde.Kundennummer+"", myconnection);
				änderungen =Kunde_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}

		public int Neuer_Kunde_Anlegen(Kunde K)
		{
		    int count=0;
			int änderungen =0;
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
				änderungen =Kunde_anlegen.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		
		}
		public int Kunde_in_transienten_Zustand_versetzen(Kunde K)
		{
			int änderungen =0;
			Kunde myKunde = K;
			OleDbCommand Kunde_löschen= null ;
			try	
			{	
				Kunde_löschen= new OleDbCommand("DELETE FROM Kunde WHERE Kundennr="+myKunde.Kundennummer+"" ,myconnection);
				änderungen =Kunde_löschen.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;
		
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
			catch(Exception ex){MessageBox.Show(""+ex);}
		
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
			string änderungen ="";
			Position myPos = K;
			OleDbCommand PS = new OleDbCommand("SELECT * FROM RechPos", myconnection);
		
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
			OleDbCommand Pos_anlegen= null ;
			try	
			{	
				Pos_anlegen= new OleDbCommand("INSERT INTO RechPos(PosNummer,Langtext,Kurztext,preis,Einheit, MKosten,LKosten) VALUES ('Z"+(count*10)+"', '"+myPos.Langtext+"','"+myPos.Kurztext+"','"+myPos.EPreis+"','"+myPos.Einheit+"',"+myPos.realMatKosten+","+myPos.realLohnKosten+")", myconnection);
				Pos_anlegen.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			änderungen="Z"+(count+10);
			MessageBox.Show(""+änderungen);
			return änderungen;
		
		}
		
		
		public int Position_in_DB_schreiben(Position k)
		{
			/// Diese Methode schreibt die referenzierte postition, mit allen neuen Werten in die Datenbank.
			int änderungen=0; 
			Position myPos = k;
			OleDbCommand Position_aendern= null ;
			try	
			{	
				Position_aendern= new OleDbCommand("UPDATE Position SET Langtext='"+myPos.Langtext+"' Kurztext='"+myPos.Kurztext+" preis = "+myPos.GPreis+" Einheit = '"+myPos.Einheit+"' MKosten= "+myPos.realMatKosten+" LKosten= "+myPos.realLohnKosten+"  WHERE PosNummer ="+myPos.Positionsnummer+"", myconnection);
				änderungen =Position_aendern.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}
		
		public int VorgangKunde_in_DB_schreiben(Vorgang V)
		{
			/// Diese Methode schreibt, den Namen des übergebenen Vorganmgs und den zugehörigen Kunden in die DB.
			/// Die Methode liefert einen int zurück, der die Anzahl der geänderten Datensätze beschreibt.
			/// 
 

			int änderungen=0; 
			int count=0;
			Vorgang myVor = V;
			OleDbCommand KV = new OleDbCommand("SELECT * FROM RechPos", myconnection);
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
				Vorgang_schreiben= new OleDbCommand("INSERT INTO KundeVorgang(Kundennr,Vorgang,Datum,Index) VALUES ("+myVor.UnserKunde.Kundennummer+", '"+myVor.Dateiname+"','"+myVor.Datum+"','"+count+"')", myconnection);
				änderungen =Vorgang_schreiben.ExecuteNonQuery();
			}
			catch (Exception ex){MessageBox.Show(""+ex);}
			return änderungen;}

		public string[] alle_Vorgaenge_eines_Kunde_ausgeben (Kunde K)
			/// 
		{
			int count=0;
		   Kunde myKunde = K;
			
			OleDbCommand sucheAlleVorgänge= new OleDbCommand("SELECT * FROM KundeVorgang WHERE Kundennr="+myKunde.Kundennummer+"", myconnection);
		OleDbDataReader dataReaderCount = null;
		
			try 
			{
				dataReaderCount =sucheAlleVorgänge.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			while (dataReaderCount.Read()){
			count++;
			}
			dataReaderCount.Close();
			 string[] Vorgänge =new string[count];
            count=0;
			OleDbDataReader dataReaderAV = null;
		
			try 
			{
				dataReaderAV =sucheAlleVorgänge.ExecuteReader();
			}
			catch(Exception ex){MessageBox.Show(""+ex);}
		
			while (dataReaderAV.Read())
			{
				if (!(dataReaderAV.IsDBNull(1)))
					Vorgänge[count] = dataReaderAV.GetString(1);
					count++;
			}

			dataReaderAV.Close();

			return Vorgänge;
		}

		
		
		#endregion

	
	
	}




}
