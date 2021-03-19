namespace DecisionMaking.Onicescu
{
    partial class onicescuDecisionForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxCriteria = new System.Windows.Forms.TextBox();
            this.labelCriteria = new System.Windows.Forms.Label();
            this.buttonCriteria = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonViewOutput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.header});
            this.dataGridView1.Location = new System.Drawing.Point(168, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxCriteria
            // 
            this.textBoxCriteria.Location = new System.Drawing.Point(168, 39);
            this.textBoxCriteria.Name = "textBoxCriteria";
            this.textBoxCriteria.Size = new System.Drawing.Size(140, 20);
            this.textBoxCriteria.TabIndex = 1;
            // 
            // labelCriteria
            // 
            this.labelCriteria.AutoSize = true;
            this.labelCriteria.Location = new System.Drawing.Point(43, 45);
            this.labelCriteria.Name = "labelCriteria";
            this.labelCriteria.Size = new System.Drawing.Size(39, 13);
            this.labelCriteria.TabIndex = 2;
            this.labelCriteria.Text = "Criteria";
            // 
            // buttonCriteria
            // 
            this.buttonCriteria.Location = new System.Drawing.Point(399, 39);
            this.buttonCriteria.Name = "buttonCriteria";
            this.buttonCriteria.Size = new System.Drawing.Size(75, 23);
            this.buttonCriteria.TabIndex = 3;
            this.buttonCriteria.Text = "Criteria";
            this.buttonCriteria.UseVisualStyleBackColor = true;
            this.buttonCriteria.Click += new System.EventHandler(this.buttonCriteria_Click);
            // 
            // header
            // 
            this.header.HeaderText = "Options/Criteria";
            this.header.Name = "header";
            // 
            // buttonViewOutput
            // 
            this.buttonViewOutput.Location = new System.Drawing.Point(46, 481);
            this.buttonViewOutput.Name = "buttonViewOutput";
            this.buttonViewOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonViewOutput.TabIndex = 4;
            this.buttonViewOutput.Text = "ViewOutput";
            this.buttonViewOutput.UseVisualStyleBackColor = true;
            this.buttonViewOutput.Click += new System.EventHandler(this.buttonViewOutput_Click);
            // 
            // onicescuDecisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 547);
            this.Controls.Add(this.buttonViewOutput);
            this.Controls.Add(this.buttonCriteria);
            this.Controls.Add(this.labelCriteria);
            this.Controls.Add(this.textBoxCriteria);
            this.Controls.Add(this.dataGridView1);
            this.Name = "onicescuDecisionForm";
            this.Text = "onicescuDecisionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCriteria;
        private System.Windows.Forms.Label labelCriteria;
        private System.Windows.Forms.Button buttonCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn header;
        private System.Windows.Forms.Button buttonViewOutput;
    }
}