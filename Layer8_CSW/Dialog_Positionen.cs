using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Layer8_CSW
{
	/// <summary>
	/// Zusammenfassung f�r Dialog_Positionen.
	/// </summary>
	public class Dialog_Positionen : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox gBox_PosArt;
		private System.Windows.Forms.RadioButton radioButtonM;
		private System.Windows.Forms.RadioButton radioButtonF;
		private System.Windows.Forms.RadioButton radioButtonZ;
		private System.Windows.Forms.Button button_�bernehmen;
		private System.Windows.Forms.Button button_zur�ck;
		private System.Windows.Forms.DataGrid DG_Pos;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Dialog_Positionen()
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
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Dialog_Positionen));
			this.gBox_PosArt = new System.Windows.Forms.GroupBox();
			this.radioButtonZ = new System.Windows.Forms.RadioButton();
			this.radioButtonF = new System.Windows.Forms.RadioButton();
			this.radioButtonM = new System.Windows.Forms.RadioButton();
			this.button_�bernehmen = new System.Windows.Forms.Button();
			this.button_zur�ck = new System.Windows.Forms.Button();
			this.DG_Pos = new System.Windows.Forms.DataGrid();
			this.gBox_PosArt.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DG_Pos)).BeginInit();
			this.SuspendLayout();
			// 
			// gBox_PosArt
			// 
			this.gBox_PosArt.Controls.Add(this.radioButtonZ);
			this.gBox_PosArt.Controls.Add(this.radioButtonF);
			this.gBox_PosArt.Controls.Add(this.radioButtonM);
			this.gBox_PosArt.Location = new System.Drawing.Point(24, 16);
			this.gBox_PosArt.Name = "gBox_PosArt";
			this.gBox_PosArt.Size = new System.Drawing.Size(344, 54);
			this.gBox_PosArt.TabIndex = 0;
			this.gBox_PosArt.TabStop = false;
			this.gBox_PosArt.Text = "Positions-Art:";
			// 
			// radioButtonZ
			// 
			this.radioButtonZ.Location = new System.Drawing.Point(256, 24);
			this.radioButtonZ.Name = "radioButtonZ";
			this.radioButtonZ.Size = new System.Drawing.Size(80, 16);
			this.radioButtonZ.TabIndex = 2;
			this.radioButtonZ.Text = "Z- Zusatz";
			// 
			// radioButtonF
			// 
			this.radioButtonF.Location = new System.Drawing.Point(136, 24);
			this.radioButtonF.Name = "radioButtonF";
			this.radioButtonF.Size = new System.Drawing.Size(110, 16);
			this.radioButtonF.TabIndex = 1;
			this.radioButtonF.Text = "F - Fliesenleger";
			// 
			// radioButtonM
			// 
			this.radioButtonM.Location = new System.Drawing.Point(16, 24);
			this.radioButtonM.Name = "radioButtonM";
			this.radioButtonM.Size = new System.Drawing.Size(110, 16);
			this.radioButtonM.TabIndex = 0;
			this.radioButtonM.Text = "M - Maurer";
			// 
			// button_�bernehmen
			// 
			this.button_�bernehmen.Location = new System.Drawing.Point(384, 24);
			this.button_�bernehmen.Name = "button_�bernehmen";
			this.button_�bernehmen.Size = new System.Drawing.Size(152, 40);
			this.button_�bernehmen.TabIndex = 1;
			this.button_�bernehmen.Text = "�bernehmen";
			this.button_�bernehmen.Click += new System.EventHandler(this.button_�bernehmen_Click);
			// 
			// button_zur�ck
			// 
			this.button_zur�ck.Location = new System.Drawing.Point(552, 24);
			this.button_zur�ck.Name = "button_zur�ck";
			this.button_zur�ck.Size = new System.Drawing.Size(152, 40);
			this.button_zur�ck.TabIndex = 2;
			this.button_zur�ck.Text = "Zur�ck";
			this.button_zur�ck.Click += new System.EventHandler(this.button_zur�ck_Click);
			// 
			// DG_Pos
			// 
			this.DG_Pos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.DG_Pos.DataMember = "";
			this.DG_Pos.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.DG_Pos.Location = new System.Drawing.Point(24, 88);
			this.DG_Pos.Name = "DG_Pos";
			this.DG_Pos.Size = new System.Drawing.Size(680, 440);
			this.DG_Pos.TabIndex = 3;
			// 
			// Dialog_Positionen
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(730, 552);
			this.ControlBox = false;
			this.Controls.Add(this.DG_Pos);
			this.Controls.Add(this.button_zur�ck);
			this.Controls.Add(this.button_�bernehmen);
			this.Controls.Add(this.gBox_PosArt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dialog_Positionen";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Alle Positionen:";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.gBox_PosArt.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DG_Pos)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button_�bernehmen_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.OK;
			this.Close();
		}

		private void button_zur�ck_Click(object sender, System.EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
			this.Close();
		}
	}
}
