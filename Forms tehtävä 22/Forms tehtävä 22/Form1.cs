using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_tehtävä_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            DialogResult vast;

            vast = MessageBox.Show("Suljetaanko ohjelma", "Muunnin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vast == DialogResult.Yes)
                Application.Exit();
        }

        private void rbnEng_Click(object sender, EventArgs e)
        {
          lstMuunnos.Items.Clear();
          lstMuunnos.Items.Add("Jalka to metri");
          lstMuunnos.Items.Add("Tuuma to sentti");
          lstMuunnos.Items.Add("Naula to kilo");
        }

        private void rbnKan_Click(object sender, EventArgs e)
        {
          lstMuunnos.Items.Clear();
          lstMuunnos.Items.Add("Metri to jalka");
          lstMuunnos.Items.Add("Sentti to tuuma");
          lstMuunnos.Items.Add("Kilo to naula");

        }

        private void lstMuunnos_DoubleClick(object sender, EventArgs e)
        {
            if (rbnEng.Checked)
            {
                if (lstMuunnos.SelectedItem.ToString() == "Jalka to metri")
                    txtKan.Text = Convert.ToString(Convert.ToSingle(txtEng.Text) * 0.3048);
                else if (lstMuunnos.SelectedItem.ToString() == "Tuuma to sentti")
                    txtKan.Text = Convert.ToString(Convert.ToSingle(txtEng.Text) * 2.54);
                else
                    txtKan.Text = Convert.ToString(Convert.ToSingle(txtEng.Text) * 0.45359);
            }
            else
            {
                if (lstMuunnos.SelectedItem.ToString() == "Metri to jalka")
                    txtEng.Text = Convert.ToString(Convert.ToSingle(txtKan.Text) / 0.3048);
                else if (lstMuunnos.SelectedItem.ToString() == "Sentti to tuuma")
                    txtEng.Text = Convert.ToString(Convert.ToSingle(txtKan.Text) / 2.54);
                else
                    txtEng.Text = Convert.ToString(Convert.ToSingle(txtKan.Text) / 0.45359);
            }

        }
    }
}
