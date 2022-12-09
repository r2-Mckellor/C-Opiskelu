using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Form_tehtävä_17
{
    public partial class Muistio : Form
    {
        string tiedostopolku = "";

        public Muistio()
        {
            InitializeComponent();
        }

        //UUSI
        private void uusiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB.Text != "")
            {
                tallennaToolStripMenuItem1_Click(sender, e);
                TekstilaatikkoRTB.Text = "";
            }
            else
            {
                TekstilaatikkoRTB.Text = "";
            }
        }

        //AVAA
        private void avaaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog atk = new OpenFileDialog() { Filter = "TextDocument|*.txt|Rich Text Format|*.rft", ValidateNames = true, Multiselect = false })
            {
                if (atk.ShowDialog()==DialogResult.OK)
                {
                    using(StreamReader jonolukija = new StreamReader (atk.FileName))
                    {
                        tiedostopolku = atk.FileName;
                        Task<string> text = jonolukija.ReadToEndAsync();
                        TekstilaatikkoRTB.Rtf = text.Result;
                    }
                }
            }
        }

        //TALLENNA
        private void tallennaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tiedostopolku))
            {
                using(SaveFileDialog ttk = new SaveFileDialog() { Filter = "TextDocument|*.txt|Rich Text Format|*.rft", ValidateNames = true })
                {
                    if (ttk.ShowDialog() == DialogResult.OK)
                    using(StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Text);
                    }
                }
            }
            else
            {
                using(StreamWriter jonokirjoittaja = new StreamWriter(tiedostopolku))
                {
                    jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                }
            }
        }

        //TALLENNA NIMELLÄ
        private void tallennaNimelläToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog ttk = new SaveFileDialog() { Filter = "TextDocument|*.txt|Rich Text Format|*.rft", ValidateNames = true })
            {
                if (ttk.ShowDialog() == DialogResult.OK)
                    using (StreamWriter jonokirjoittaja = new StreamWriter(ttk.FileName))
                    {
                        jonokirjoittaja.WriteLineAsync(TekstilaatikkoRTB.Rtf);
                    }
            }

        }

        //TULOSTUKSEN ESIKATSELU
        private void tulostuksenEsikatseluToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        //TULOSTA
        private void tulostaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        //POISTU
        private void poistuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //UNDO
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Paste();
        }

        //COPY
        private void kopioiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Copy();
        }

        //CUT
        private void leikkaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Cut();
        }

        //PASTE
        private void liitäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.Paste();
        }

        //REMOVE
        private void poistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectedText = "";
        }

        //SELECT ALL
        private void valitseKaikkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectAll();
        }

        //COPY & CUT CHECK
        private void TekstilaatikkoRTB_TabStopChanged(object sender, EventArgs e)
        {
            if (TekstilaatikkoRTB.Text.Length > 0)
            {
                kopioiToolStripMenuItem.Enabled = true;
                leikkaaToolStripMenuItem.Enabled = true;
            }
            else
            {
                kopioiToolStripMenuItem.Enabled = false;
                leikkaaToolStripMenuItem.Enabled = false;
            }
        }

        //KIRJASIN
        private void kirjasinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            TekstilaatikkoRTB.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
        }

        //TEKSTIN KOROTUS
        private void tekstinKorotusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekstilaatikkoRTB.SelectionBackColor = Color.Yellow;
        }

        //TEKSTIN RIVITYS
        private void tekstinRivitysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tekstinRivitysToolStripMenuItem.Checked == true)
            {
                tekstinRivitysToolStripMenuItem.Checked = false;
                TekstilaatikkoRTB.WordWrap = false;
            }
            else
            {
                tekstinRivitysToolStripMenuItem.Checked = true;
                TekstilaatikkoRTB.WordWrap = true;
            }
        }

        private void tietoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tietoa tietoa = new tietoa();
            tietoa.ShowDialog();
        }
    }
}
