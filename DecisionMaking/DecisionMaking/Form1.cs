using DecisionMaking.Onicescu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionMaking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nodesScoreInfluenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            
        }

        private void buttonNewScoreDecision_Click(object sender, EventArgs e)
        {
            dialogName dialog = new dialogName();

            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                scoreNodesForm scoreForm = new scoreNodesForm(dialog.textBoxName.Text.Trim());
                scoreForm.Show();
                
                
            }
        }

        private void buttonNewOnicescuDecision_Click(object sender, EventArgs e)
        {
            dialogName dialog = new dialogName();

            dialog.ShowDialog();

            if (dialog.DialogResult == DialogResult.OK)
            {
                onicescuDecisionForm onicescuForm = new onicescuDecisionForm();
                onicescuForm.Show();


            }
        }
    }
}
