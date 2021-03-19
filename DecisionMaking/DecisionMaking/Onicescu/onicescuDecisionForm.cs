using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionMaking.Onicescu
{
    public partial class onicescuDecisionForm : Form
    {
        OnicescuDecision decision;
        public onicescuDecisionForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Insert(0, "K");
            decision = new OnicescuDecision();

        }

        private void buttonCriteria_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Criteria",textBoxCriteria.Text.Trim());

           
            
            
        }

        private void buttonViewOutput_Click(object sender, EventArgs e)
        {

            int criteriaCount = 0;

            for (int i = 1; i < dataGridView1.Rows.Count-1; i++)
            {

                decision.addOption(new Options(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                for(int j = 1;j<dataGridView1.Rows[i].Cells.Count;j++)
                {
                    decision.getOption(i - 1).addCriteria(new Criteria(dataGridView1.Columns[j].HeaderText,
                        double.Parse(dataGridView1.Rows[0].Cells[j].Value.ToString()),
                        double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString())));

                    criteriaCount++;


                }
            }



        }
    }
}
