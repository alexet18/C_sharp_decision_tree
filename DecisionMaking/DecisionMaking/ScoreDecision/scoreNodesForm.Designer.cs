namespace DecisionMaking
{
    partial class scoreNodesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
     
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelScores = new System.Windows.Forms.Panel();
            this.buttonLoadCsv = new System.Windows.Forms.Button();
            this.textBoxCsvPath = new System.Windows.Forms.TextBox();
            this.buttonImportCsv = new System.Windows.Forms.Button();
            this.buttonViewGraph = new System.Windows.Forms.Button();
            this.buttonCaseAdd = new System.Windows.Forms.Button();
            this.buttonNodeAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCaseAdd = new System.Windows.Forms.Label();
            this.textBoxCaseAdd = new System.Windows.Forms.TextBox();
            this.labelNodeAdd = new System.Windows.Forms.Label();
            this.textBoxNodeAdd = new System.Windows.Forms.TextBox();
            this.panelScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelScores
            // 
            this.panelScores.Controls.Add(this.buttonLoadCsv);
            this.panelScores.Controls.Add(this.textBoxCsvPath);
            this.panelScores.Controls.Add(this.buttonImportCsv);
            this.panelScores.Controls.Add(this.buttonViewGraph);
            this.panelScores.Controls.Add(this.buttonCaseAdd);
            this.panelScores.Controls.Add(this.buttonNodeAdd);
            this.panelScores.Controls.Add(this.dataGridView1);
            this.panelScores.Controls.Add(this.labelCaseAdd);
            this.panelScores.Controls.Add(this.textBoxCaseAdd);
            this.panelScores.Controls.Add(this.labelNodeAdd);
            this.panelScores.Controls.Add(this.textBoxNodeAdd);
            this.panelScores.Location = new System.Drawing.Point(1, 2);
            this.panelScores.Name = "panelScores";
            this.panelScores.Size = new System.Drawing.Size(955, 513);
            this.panelScores.TabIndex = 2;
            // 
            // buttonLoadCsv
            // 
            this.buttonLoadCsv.Location = new System.Drawing.Point(619, 462);
            this.buttonLoadCsv.Name = "buttonLoadCsv";
            this.buttonLoadCsv.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadCsv.TabIndex = 14;
            this.buttonLoadCsv.Text = "Load csv";
            this.buttonLoadCsv.UseVisualStyleBackColor = true;
            this.buttonLoadCsv.Click += new System.EventHandler(this.buttonLoadCsv_Click);
            // 
            // textBoxCsvPath
            // 
            this.textBoxCsvPath.Location = new System.Drawing.Point(813, 462);
            this.textBoxCsvPath.Name = "textBoxCsvPath";
            this.textBoxCsvPath.Size = new System.Drawing.Size(119, 20);
            this.textBoxCsvPath.TabIndex = 13;
            // 
            // buttonImportCsv
            // 
            this.buttonImportCsv.Location = new System.Drawing.Point(700, 462);
            this.buttonImportCsv.Name = "buttonImportCsv";
            this.buttonImportCsv.Size = new System.Drawing.Size(75, 23);
            this.buttonImportCsv.TabIndex = 12;
            this.buttonImportCsv.Text = "Import csv";
            this.buttonImportCsv.UseVisualStyleBackColor = true;
            this.buttonImportCsv.Click += new System.EventHandler(this.buttonImportCsv_Click);
            // 
            // buttonViewGraph
            // 
            this.buttonViewGraph.Location = new System.Drawing.Point(3, 462);
            this.buttonViewGraph.Name = "buttonViewGraph";
            this.buttonViewGraph.Size = new System.Drawing.Size(75, 23);
            this.buttonViewGraph.TabIndex = 11;
            this.buttonViewGraph.Text = "View graph";
            this.buttonViewGraph.UseVisualStyleBackColor = true;
            this.buttonViewGraph.Click += new System.EventHandler(this.buttonViewGraph_Click);
            // 
            // buttonCaseAdd
            // 
            this.buttonCaseAdd.Location = new System.Drawing.Point(258, 41);
            this.buttonCaseAdd.Name = "buttonCaseAdd";
            this.buttonCaseAdd.Size = new System.Drawing.Size(75, 22);
            this.buttonCaseAdd.TabIndex = 10;
            this.buttonCaseAdd.Text = "Add";
            this.buttonCaseAdd.UseVisualStyleBackColor = true;
            this.buttonCaseAdd.Click += new System.EventHandler(this.buttonCaseAdd_Click);
            // 
            // buttonNodeAdd
            // 
            this.buttonNodeAdd.Location = new System.Drawing.Point(258, 8);
            this.buttonNodeAdd.Name = "buttonNodeAdd";
            this.buttonNodeAdd.Size = new System.Drawing.Size(75, 22);
            this.buttonNodeAdd.TabIndex = 9;
            this.buttonNodeAdd.Text = "Add";
            this.buttonNodeAdd.UseVisualStyleBackColor = true;
            this.buttonNodeAdd.Click += new System.EventHandler(this.buttonNodeAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(3, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(949, 333);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Case/Node";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // labelCaseAdd
            // 
            this.labelCaseAdd.AutoSize = true;
            this.labelCaseAdd.Location = new System.Drawing.Point(7, 46);
            this.labelCaseAdd.Name = "labelCaseAdd";
            this.labelCaseAdd.Size = new System.Drawing.Size(31, 13);
            this.labelCaseAdd.TabIndex = 7;
            this.labelCaseAdd.Text = "Case";
            // 
            // textBoxCaseAdd
            // 
            this.textBoxCaseAdd.Location = new System.Drawing.Point(77, 39);
            this.textBoxCaseAdd.Name = "textBoxCaseAdd";
            this.textBoxCaseAdd.Size = new System.Drawing.Size(154, 20);
            this.textBoxCaseAdd.TabIndex = 6;
            // 
            // labelNodeAdd
            // 
            this.labelNodeAdd.AutoSize = true;
            this.labelNodeAdd.Location = new System.Drawing.Point(7, 17);
            this.labelNodeAdd.Name = "labelNodeAdd";
            this.labelNodeAdd.Size = new System.Drawing.Size(33, 13);
            this.labelNodeAdd.TabIndex = 5;
            this.labelNodeAdd.Text = "Node";
            // 
            // textBoxNodeAdd
            // 
            this.textBoxNodeAdd.Location = new System.Drawing.Point(77, 10);
            this.textBoxNodeAdd.Name = "textBoxNodeAdd";
            this.textBoxNodeAdd.Size = new System.Drawing.Size(154, 20);
            this.textBoxNodeAdd.TabIndex = 4;
            // 
            // scoreNodesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 518);
            this.Controls.Add(this.panelScores);
            this.Name = "scoreNodesForm";
            this.Text = "scoreNodesForm";
            this.panelScores.ResumeLayout(false);
            this.panelScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelScores;
        private System.Windows.Forms.Label labelCaseAdd;
        private System.Windows.Forms.TextBox textBoxCaseAdd;
        private System.Windows.Forms.Label labelNodeAdd;
        private System.Windows.Forms.TextBox textBoxNodeAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCaseAdd;
        private System.Windows.Forms.Button buttonNodeAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonViewGraph;
        private System.Windows.Forms.Button buttonImportCsv;
        private System.Windows.Forms.TextBox textBoxCsvPath;
        private System.Windows.Forms.Button buttonLoadCsv;
        

    }
}