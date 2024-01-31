
namespace BruchRechner
{
    partial class BruchRechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BruchRechner));
            this.nenner1 = new System.Windows.Forms.TextBox();
            this.zähler1 = new System.Windows.Forms.TextBox();
            this.nenner2 = new System.Windows.Forms.TextBox();
            this.zähler2 = new System.Windows.Forms.TextBox();
            this.IstGleich = new System.Windows.Forms.Label();
            this.zählerErgebnis = new System.Windows.Forms.Label();
            this.nennerErgebnis = new System.Windows.Forms.Label();
            this.GanzZahl = new System.Windows.Forms.Label();
            this.optionen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nenner1
            // 
            this.nenner1.Location = new System.Drawing.Point(150, 156);
            this.nenner1.Name = "nenner1";
            this.nenner1.Size = new System.Drawing.Size(50, 22);
            this.nenner1.TabIndex = 2;
            this.nenner1.Text = "0";
            this.nenner1.TextChanged += new System.EventHandler(this.nenner1_TextChanged);
            // 
            // zähler1
            // 
            this.zähler1.Location = new System.Drawing.Point(150, 102);
            this.zähler1.Name = "zähler1";
            this.zähler1.Size = new System.Drawing.Size(50, 22);
            this.zähler1.TabIndex = 1;
            this.zähler1.Text = "0";
            this.zähler1.TextChanged += new System.EventHandler(this.zähler1_TextChanged);
            // 
            // nenner2
            // 
            this.nenner2.Location = new System.Drawing.Point(257, 156);
            this.nenner2.Name = "nenner2";
            this.nenner2.Size = new System.Drawing.Size(50, 22);
            this.nenner2.TabIndex = 4;
            this.nenner2.Text = "0";
            this.nenner2.TextChanged += new System.EventHandler(this.nenner2_TextChanged);
            // 
            // zähler2
            // 
            this.zähler2.Location = new System.Drawing.Point(257, 102);
            this.zähler2.Name = "zähler2";
            this.zähler2.Size = new System.Drawing.Size(50, 22);
            this.zähler2.TabIndex = 3;
            this.zähler2.Text = "0";
            this.zähler2.TextChanged += new System.EventHandler(this.zähler2_TextChanged);
            // 
            // IstGleich
            // 
            this.IstGleich.AutoSize = true;
            this.IstGleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstGleich.Location = new System.Drawing.Point(327, 127);
            this.IstGleich.Name = "IstGleich";
            this.IstGleich.Size = new System.Drawing.Size(28, 29);
            this.IstGleich.TabIndex = 4;
            this.IstGleich.Text = "=";
            // 
            // zählerErgebnis
            // 
            this.zählerErgebnis.AutoSize = true;
            this.zählerErgebnis.Location = new System.Drawing.Point(409, 108);
            this.zählerErgebnis.Name = "zählerErgebnis";
            this.zählerErgebnis.Size = new System.Drawing.Size(14, 16);
            this.zählerErgebnis.TabIndex = 5;
            this.zählerErgebnis.Text = "0";
            this.zählerErgebnis.Click += new System.EventHandler(this.zählerErgebnis_Click);
            // 
            // nennerErgebnis
            // 
            this.nennerErgebnis.AutoSize = true;
            this.nennerErgebnis.Location = new System.Drawing.Point(409, 162);
            this.nennerErgebnis.Name = "nennerErgebnis";
            this.nennerErgebnis.Size = new System.Drawing.Size(14, 16);
            this.nennerErgebnis.TabIndex = 6;
            this.nennerErgebnis.Text = "0";
            this.nennerErgebnis.Click += new System.EventHandler(this.nennerErgebnis_Click);
            // 
            // GanzZahl
            // 
            this.GanzZahl.AccessibleName = "";
            this.GanzZahl.AutoSize = true;
            this.GanzZahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GanzZahl.Location = new System.Drawing.Point(370, 132);
            this.GanzZahl.Name = "GanzZahl";
            this.GanzZahl.Size = new System.Drawing.Size(0, 25);
            this.GanzZahl.TabIndex = 11;
            // 
            // optionen
            // 
            this.optionen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optionen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionen.FormattingEnabled = true;
            this.optionen.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.optionen.Location = new System.Drawing.Point(208, 132);
            this.optionen.Name = "optionen";
            this.optionen.Size = new System.Drawing.Size(43, 24);
            this.optionen.TabIndex = 5;
            this.optionen.SelectedIndexChanged += new System.EventHandler(this.optionen_SelectedIndexChanged_1);
            // 
            // BruchRechner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 310);
            this.Controls.Add(this.optionen);
            this.Controls.Add(this.GanzZahl);
            this.Controls.Add(this.nennerErgebnis);
            this.Controls.Add(this.zählerErgebnis);
            this.Controls.Add(this.IstGleich);
            this.Controls.Add(this.zähler2);
            this.Controls.Add(this.nenner2);
            this.Controls.Add(this.zähler1);
            this.Controls.Add(this.nenner1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(652, 357);
            this.MinimumSize = new System.Drawing.Size(652, 357);
            this.Name = "BruchRechner";
            this.Text = "Bruch Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nenner1;
        private System.Windows.Forms.TextBox zähler1;
        private System.Windows.Forms.TextBox nenner2;
        private System.Windows.Forms.TextBox zähler2;
        private System.Windows.Forms.Label IstGleich;
        private System.Windows.Forms.Label zählerErgebnis;
        private System.Windows.Forms.Label nennerErgebnis;
        private System.Windows.Forms.Label GanzZahl;
        private System.Windows.Forms.ComboBox optionen;
    }
}

