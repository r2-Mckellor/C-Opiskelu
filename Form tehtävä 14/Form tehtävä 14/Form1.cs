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

namespace Form_tehtävä_14
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
            string teksti = File.ReadAllText(@"C:\\Users\\r2Mkeler\\source\\repos\\Form tehtävä 14\\Demo.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yy HH.mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\r2Mkeler\\source\\repos\\Form tehtävä 14\\Demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
