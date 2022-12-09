using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_tehtävä_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        class cSuorakaide
        {
            private float m_kanta, m_korkeus, m_ala;
            public cSuorakaide() { }
            public cSuorakaide(float kanta, float korkeus)
            {
                m_kanta = kanta;
                m_korkeus = korkeus;
            }
            public void laskeAla()
            {
                m_ala = m_korkeus * m_kanta;
            }
            public float Kanta
            {
                set
                {
                    if (value >= 0)
                        m_kanta = value;
                    else
                        m_kanta = 0;
                }
                get
                { return m_kanta; }
            }
            public float Korkeus
            {
                set
                {
                    if (value >= 0)
                        m_korkeus = value;
                    else
                        m_korkeus = 0;
                }
                get
                { return m_korkeus; }
            }
            public float Ala
            {
                get
                { return m_ala; }
            }
        };

        private void btnLaske_Click(object sender, EventArgs e)
        {
           cSuorakaide olio = new cSuorakaide();
           olio.Kanta = Convert.ToSingle(txtKanta.Text);
           olio.Korkeus = Convert.ToSingle(txtKorkeus.Text);
           olio.laskeAla();
           txtAla.Text = olio.Ala.ToString();
        }
    }
}
