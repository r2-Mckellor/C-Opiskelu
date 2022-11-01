namespace Form_tehtävä_6
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
             if (KayttajaTB.Text == "Arttu" && SalasanaTB.Text == "nice")
            {
                SalasanaPL.Visible = false;
                SalasanaOikeinPL.Visible = true;
            }
            else
            {
                VirheViestiLB.Text = "Käyttäjätunnus tai salasana virheellinen";
                VirheViestiLB.Visible = true;
            }
        }
    }
}