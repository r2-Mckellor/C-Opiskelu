
namespace Form_tehtävä_17
{
    partial class Muistio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muistio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uusiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avaaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tallennaNimelläToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tulostuksenEsikatseluToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tulostaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.poistuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.muokkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kopioiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leikkaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liitäToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valitseKaikkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muotoileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirjasinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinKorotusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstinRivitysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tietoa = new System.Windows.Forms.ToolStripMenuItem();
            this.TekstilaatikkoRTB = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.muokkaaToolStripMenuItem,
            this.muotoileToolStripMenuItem,
            this.tietoaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uusiToolStripMenuItem1,
            this.avaaToolStripMenuItem1,
            this.tallennaToolStripMenuItem1,
            this.tallennaNimelläToolStripMenuItem1,
            this.toolStripSeparator1,
            this.tulostuksenEsikatseluToolStripMenuItem1,
            this.tulostaToolStripMenuItem1,
            this.toolStripSeparator2,
            this.poistuToolStripMenuItem1});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiToolStripMenuItem1
            // 
            this.uusiToolStripMenuItem1.Name = "uusiToolStripMenuItem1";
            this.uusiToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.uusiToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.uusiToolStripMenuItem1.Text = "Uusi";
            this.uusiToolStripMenuItem1.Click += new System.EventHandler(this.uusiToolStripMenuItem1_Click);
            // 
            // avaaToolStripMenuItem1
            // 
            this.avaaToolStripMenuItem1.Name = "avaaToolStripMenuItem1";
            this.avaaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.avaaToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.avaaToolStripMenuItem1.Text = "Avaa";
            this.avaaToolStripMenuItem1.Click += new System.EventHandler(this.avaaToolStripMenuItem1_Click);
            // 
            // tallennaToolStripMenuItem1
            // 
            this.tallennaToolStripMenuItem1.Name = "tallennaToolStripMenuItem1";
            this.tallennaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tallennaToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.tallennaToolStripMenuItem1.Text = "Tallenna";
            this.tallennaToolStripMenuItem1.Click += new System.EventHandler(this.tallennaToolStripMenuItem1_Click);
            // 
            // tallennaNimelläToolStripMenuItem1
            // 
            this.tallennaNimelläToolStripMenuItem1.Name = "tallennaNimelläToolStripMenuItem1";
            this.tallennaNimelläToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.tallennaNimelläToolStripMenuItem1.Text = "Tallenna nimellä";
            this.tallennaNimelläToolStripMenuItem1.Click += new System.EventHandler(this.tallennaNimelläToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // tulostuksenEsikatseluToolStripMenuItem1
            // 
            this.tulostuksenEsikatseluToolStripMenuItem1.Name = "tulostuksenEsikatseluToolStripMenuItem1";
            this.tulostuksenEsikatseluToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.tulostuksenEsikatseluToolStripMenuItem1.Text = "Tulostuksen esikatselu";
            this.tulostuksenEsikatseluToolStripMenuItem1.Click += new System.EventHandler(this.tulostuksenEsikatseluToolStripMenuItem1_Click);
            // 
            // tulostaToolStripMenuItem1
            // 
            this.tulostaToolStripMenuItem1.Name = "tulostaToolStripMenuItem1";
            this.tulostaToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tulostaToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.tulostaToolStripMenuItem1.Text = "Tulosta";
            this.tulostaToolStripMenuItem1.Click += new System.EventHandler(this.tulostaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // poistuToolStripMenuItem1
            // 
            this.poistuToolStripMenuItem1.Name = "poistuToolStripMenuItem1";
            this.poistuToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.poistuToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.poistuToolStripMenuItem1.Text = "Poistu";
            this.poistuToolStripMenuItem1.Click += new System.EventHandler(this.poistuToolStripMenuItem1_Click);
            // 
            // muokkaaToolStripMenuItem
            // 
            this.muokkaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.kopioiToolStripMenuItem,
            this.leikkaaToolStripMenuItem,
            this.liitäToolStripMenuItem,
            this.poistaToolStripMenuItem,
            this.valitseKaikkiToolStripMenuItem});
            this.muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            this.muokkaaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.muokkaaToolStripMenuItem.Text = "Muokkaa";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(179, 6);
            // 
            // kopioiToolStripMenuItem
            // 
            this.kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            this.kopioiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopioiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kopioiToolStripMenuItem.Text = "Kopioi";
            this.kopioiToolStripMenuItem.Click += new System.EventHandler(this.kopioiToolStripMenuItem_Click);
            // 
            // leikkaaToolStripMenuItem
            // 
            this.leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            this.leikkaaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.leikkaaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.leikkaaToolStripMenuItem.Text = "Leikkaa";
            this.leikkaaToolStripMenuItem.Click += new System.EventHandler(this.leikkaaToolStripMenuItem_Click);
            // 
            // liitäToolStripMenuItem
            // 
            this.liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            this.liitäToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.liitäToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.liitäToolStripMenuItem.Text = "Liitä";
            this.liitäToolStripMenuItem.Click += new System.EventHandler(this.liitäToolStripMenuItem_Click);
            // 
            // poistaToolStripMenuItem
            // 
            this.poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            this.poistaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.poistaToolStripMenuItem.Text = "Poista";
            this.poistaToolStripMenuItem.Click += new System.EventHandler(this.poistaToolStripMenuItem_Click);
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            this.valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            this.valitseKaikkiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.valitseKaikkiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            this.valitseKaikkiToolStripMenuItem.Click += new System.EventHandler(this.valitseKaikkiToolStripMenuItem_Click);
            // 
            // muotoileToolStripMenuItem
            // 
            this.muotoileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kirjasinToolStripMenuItem,
            this.tekstinKorotusToolStripMenuItem,
            this.tekstinRivitysToolStripMenuItem});
            this.muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            this.muotoileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.muotoileToolStripMenuItem.Text = "Muotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            this.kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            this.kirjasinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kirjasinToolStripMenuItem.Text = "Kirjasin";
            this.kirjasinToolStripMenuItem.Click += new System.EventHandler(this.kirjasinToolStripMenuItem_Click);
            // 
            // tekstinKorotusToolStripMenuItem
            // 
            this.tekstinKorotusToolStripMenuItem.Name = "tekstinKorotusToolStripMenuItem";
            this.tekstinKorotusToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tekstinKorotusToolStripMenuItem.Text = "Tekstin korotus";
            this.tekstinKorotusToolStripMenuItem.Click += new System.EventHandler(this.tekstinKorotusToolStripMenuItem_Click);
            // 
            // tekstinRivitysToolStripMenuItem
            // 
            this.tekstinRivitysToolStripMenuItem.Name = "tekstinRivitysToolStripMenuItem";
            this.tekstinRivitysToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tekstinRivitysToolStripMenuItem.Text = "Tekstin rivitys";
            this.tekstinRivitysToolStripMenuItem.Click += new System.EventHandler(this.tekstinRivitysToolStripMenuItem_Click);
            // 
            // tietoaToolStripMenuItem
            // 
            this.tietoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tietoa});
            this.tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            this.tietoaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tietoaToolStripMenuItem.Text = "Apua";
            // 
            // tietoa
            // 
            this.tietoa.Name = "tietoa";
            this.tietoa.Size = new System.Drawing.Size(180, 22);
            this.tietoa.Text = "Tietoa";
            this.tietoa.Click += new System.EventHandler(this.tietoaToolStripMenuItem_Click);
            // 
            // TekstilaatikkoRTB
            // 
            this.TekstilaatikkoRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TekstilaatikkoRTB.Location = new System.Drawing.Point(0, 24);
            this.TekstilaatikkoRTB.Name = "TekstilaatikkoRTB";
            this.TekstilaatikkoRTB.Size = new System.Drawing.Size(736, 384);
            this.TekstilaatikkoRTB.TabIndex = 1;
            this.TekstilaatikkoRTB.Text = "";
            this.TekstilaatikkoRTB.TabStopChanged += new System.EventHandler(this.TekstilaatikkoRTB_TabStopChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Muistio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 408);
            this.Controls.Add(this.TekstilaatikkoRTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Muistio";
            this.Text = "Muistio / Arttu Mäkelä";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uusiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avaaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tallennaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tallennaNimelläToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tulostaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poistuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem muokkaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kopioiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leikkaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liitäToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muotoileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirjasinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekstinKorotusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekstinRivitysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tietoa;
        private System.Windows.Forms.RichTextBox TekstilaatikkoRTB;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

