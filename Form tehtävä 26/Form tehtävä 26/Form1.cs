using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_tehtävä_26
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Task(AskarreTB.Text, PriorityGB.Text, KalenteriDT.Text);
        }

        private void Create_Task(string task, string tarkeys, string paiva)
        {
            tarkeys = PernsonalRB.Text;
            if (NecessaryRB.Checked)
            {
                tarkeys = NecessaryRB.Text;
            }
        
            DateTime date = KalenteriDT.Value.Date;


            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = task;
                newRow.Cells[1].Value = tarkeys;
                newRow.Cells[2].Value = paiva;
                dataGridView1.Rows.Add(newRow);
            }
            catch { }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected && oneCell.RowIndex != -1)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                bool is_Done = Convert.ToBoolean(r.Cells[3].Value);

                if(is_Done == true)
                {
                    r.DefaultCellStyle.BackColor = Color.Green;
                    r.DefaultCellStyle.ForeColor = Color.White;
                }

                else if (is_Done == false)
                {
                    r.DefaultCellStyle.BackColor = Color.White;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
