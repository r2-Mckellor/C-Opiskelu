using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_tehtävä_21
{
    public partial class Laskin : Form
    {
        string lasku = "";
        Double ekanum, tokanum;

        public Laskin()
        {
            InitializeComponent();
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = "";
        }

        private void BackBT_Click(object sender, EventArgs e)
        {
            if (TaulukkoTB.Text.Length > 0)
            {
                TaulukkoTB.Text = TaulukkoTB.Text.Remove(TaulukkoTB.Text.Length - 1, 1);
            }
            if (TaulukkoTB.Text == "")
            {
                TaulukkoTB.Text = TaulukkoTB.Text + 0;
            }
        }

        private void NineBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 9;
        }

        private void EightBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 8;
        }

        private void SevenBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 7;
        }

        private void SixBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 6;
        }

        private void FiveBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 5;
        }

        private void FourBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 4;
        }

        private void ThreeBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 3;
        }

        private void TwoBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 2;
        }

        private void OneBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 1;
        }

        private void ZeroBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text = TaulukkoTB.Text + 0;
        }


        private void PlusminusBT_Click(object sender, EventArgs e)
        {
           if (TaulukkoTB.Text.Contains("-"))
            {
                TaulukkoTB.Text = TaulukkoTB.Text.Remove(0, 1);
            }
           
           else
            {
                TaulukkoTB.Text = "-" + TaulukkoTB.Text;
            }
        }

        private void DotBT_Click(object sender, EventArgs e)
        {
            TaulukkoTB.Text += ",";
        }

        private void LaskuToimitus(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            ekanum = Double.Parse(TaulukkoTB.Text);
            lasku = b.Text;
            TaulukkoTB.Text = "";
        }

        private void EqualsBT_Click(object sender, EventArgs e)
        {
            tokanum = Double.Parse(TaulukkoTB.Text);
            switch(lasku)
            {
                case "+":
                    TaulukkoTB.Text = Convert.ToString(ekanum + tokanum);
                    break;
                case "-":
                    TaulukkoTB.Text = Convert.ToString(ekanum - tokanum);
                    break;
                case "X":
                    TaulukkoTB.Text = Convert.ToString(ekanum * tokanum);
                    break;
                case "÷":
                    TaulukkoTB.Text = Convert.ToString(ekanum / tokanum);
                    break;
                case "%":
                    TaulukkoTB.Text = Convert.ToString(ekanum % tokanum);
                    break;
                default:
                    break;
            }
        }
    }
}
