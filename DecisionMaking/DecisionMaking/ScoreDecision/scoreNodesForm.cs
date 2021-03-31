using DecisionMaking.ScoreDecision;
using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionMaking
{
    public partial class scoreNodesForm : Form
    {
        String name;
        int generatedNodes = 0;
        public scoreNodesForm(String name)
        {
            this.name = name;
            InitializeComponent();
            
            

            //ScoreTree tree = new ScoreTree(this.name);

        }


       
        private void buttonNodeAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("column", textBoxNodeAdd.Text.Trim());
            
        }

        private void buttonCaseAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBoxCaseAdd.Text.Trim());
           
        }

        private void buttonViewGraph_Click(object sender, EventArgs e)
        {

            ScoreNode root = new ScoreNode(generatedNodes++);

            //createTree(root, dataGridView1);
            //createGraph(root);
            //List<double> thresholds = new List<double>();
            //Tree.calculateThreshold(thresholds, dataGridView1);

            Tree.createTree(root, dataGridView1);
            createGraph(root);

            //foreach (double x in thresholds)
            //    Console.WriteLine(x);
           
            
        }

        private void createGraph(ScoreNode root)
        {
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph(this.name);
            graph = treeToGraph(root, graph);
            viewer.Graph = graph;
            viewer.AutoSize = true;
            viewer.FitGraphBoundingBox();
            form.SuspendLayout();
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.ShowDialog();
        }

        private Graph treeToGraph(ScoreNode root, Graph graph)
        {

            if (root != null)
            {
                if(root.getLeft() != null)
                {
                    graph.AddEdge(root.getNodeText(), root.getLeft().getNodeText());
                    treeToGraph(root.getLeft(), graph);
                }

                if(root.getRight() != null)
                {
                    graph.AddEdge(root.getNodeText(),root.getRight().getNodeText());
                    treeToGraph(root.getRight(), graph);
                }

            }

            return graph;
        }

        private void createTree(ScoreNode root, DataGridView dataGridView1)
        {
                            
                allocateTree(root,dataGridView1.Columns.Count-2,0);

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                rowToTree(root, row);
            }
        }

        private void allocateTree(ScoreNode root, int levelsNumber, int currentLevel)
        {
            if(levelsNumber > currentLevel)
            {
                root.setLeft(new ScoreNode(generatedNodes++));
                root.setRight(new ScoreNode(generatedNodes++));

                allocateTree(root.getLeft(), levelsNumber, currentLevel + 1);
                allocateTree(root.getRight(), levelsNumber, currentLevel + 1);

            }
        }

        private void rowToTree(ScoreNode node,DataGridViewRow row)
        {
            foreach(DataGridViewCell cell in row.Cells)
            {
                if(cell.Value.ToString() == "y")
                {
                    node.setScore1(node.getScore1() + 1);
                    node = node.getRight();
                }
                if(cell.Value.ToString()== "n")
                {
                    node.setScore0(node.getScore0() + 1);
                    node = node.getLeft();
                }
            }
            
        }

        private void buttonImportCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();
            fileBrowser.ShowDialog();
            textBoxCsvPath.Text = fileBrowser.FileName;

            
        }

        private void buttonLoadCsv_Click(object sender, EventArgs e)
        {
            String[] csv = File.ReadAllLines(textBoxCsvPath.Text);
            String[] line;

            line = csv[0].Split(',');
            for (int i = 0; i < line.Length; i++)
            {
                dataGridView1.Columns.Add("column", line[i]);
            }
            for(int i=1;i<csv.Length;i++)
            { line = csv[i].Split(',');
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j< line.Length;j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell());
                    row.Cells[j].Value = line[j];
                }

                dataGridView1.Rows.Add(row);
            }
        }
    }
}
