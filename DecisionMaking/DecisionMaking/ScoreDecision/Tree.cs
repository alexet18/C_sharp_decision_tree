using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionMaking.ScoreDecision
{
    class Tree
    {
        private static int generatedNodes;
        private static List<double> valuesThreshold;
        private static void allocTree(ScoreNode root, int levelsNumber, int currentLevel)
        {
            if (levelsNumber > currentLevel)
            {
                root.setLeft(new ScoreNode(generatedNodes++));
                root.setRight(new ScoreNode(generatedNodes++));

                allocTree(root.getLeft(), levelsNumber, currentLevel + 1);
                allocTree(root.getRight(), levelsNumber, currentLevel + 1);

            }
        }

        public static void createTree(ScoreNode root, DataGridView dataGridView1)
        {
            valuesThreshold = new List<double>();

           calculateThreshold(valuesThreshold,dataGridView1);

            dataGridView1.DataSource = null;
            generatedNodes = 1;
            allocTree(root, dataGridView1.Columns.Count - 2, 0);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                rowToTree(root, row,dataGridView1);
            }
        }

        private static void calculateThreshold(List<double> threshold,DataGridView dataGridView)
        {
            int columnsNo = dataGridView.Columns.Count - 1;

            for (int i = 1;i<columnsNo;i++)
            {
                List<double> noValues = new List<double>();
                List<double> yesValues = new List<double>();
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if(row.Cells[columnsNo].Value.ToString() == "0")
                    {
                        try
                        {
                            noValues.Add(Double.Parse(row.Cells[i].Value.ToString()));
                        }
                        catch
                        {
                            noValues.Add(0);
                        }
                    }
                    else
                    {
                        try
                        {
                            yesValues.Add(Double.Parse(row.Cells[i].Value.ToString()));
                        }
                        catch
                        {
                            yesValues.Add(0);
                        }
                       
                    }
                }
                noValues.Sort();
                yesValues.Sort();
                double sum = 0;

                for(int j = 0;j<3;j++)
                {
                    sum += yesValues.ElementAt(j);
                }

                for(int j=noValues.Count-1; j>noValues.Count-4;j--)
                {
                    sum += noValues.ElementAt(j);
                }

                double t = sum / 6;

                threshold.Add(t);
            }
        }

        private static void rowToTree(ScoreNode node, DataGridViewRow row,DataGridView grid)
        {
            int index =  grid.Rows.IndexOf(row);

            for (int i = 1; i < row.Cells.Count - 2; i++)
            {
                try
                {

                    if (Double.Parse(row.Cells[i].Value.ToString()) > valuesThreshold.ElementAt(i))
                    {

                        node.setScore1(node.getScore1() + 1);
                        node = node.getRight();
                    }
                    else
                    {
                        node.setScore0(node.getScore0() + 1);
                        node = node.getLeft();
                    }
                
                }
                catch
                {
                    node.setScore0(node.getScore0() + 1);
                    node = node.getLeft();
                }
            }

        }
    }
}
