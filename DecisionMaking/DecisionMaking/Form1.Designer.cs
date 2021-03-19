namespace DecisionMaking
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodesScoreInfluenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNewScoreDecision = new System.Windows.Forms.Button();
            this.buttonNewOnicescuDecision = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(955, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nodesScoreInfluenceToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // nodesScoreInfluenceToolStripMenuItem
            // 
            this.nodesScoreInfluenceToolStripMenuItem.Name = "nodesScoreInfluenceToolStripMenuItem";
            this.nodesScoreInfluenceToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nodesScoreInfluenceToolStripMenuItem.Text = "Nodes score influence";
            this.nodesScoreInfluenceToolStripMenuItem.Click += new System.EventHandler(this.nodesScoreInfluenceToolStripMenuItem_Click);
            // 
            // buttonNewScoreDecision
            // 
            this.buttonNewScoreDecision.Location = new System.Drawing.Point(64, 90);
            this.buttonNewScoreDecision.Name = "buttonNewScoreDecision";
            this.buttonNewScoreDecision.Size = new System.Drawing.Size(103, 32);
            this.buttonNewScoreDecision.TabIndex = 2;
            this.buttonNewScoreDecision.Text = "New score nodes decision";
            this.buttonNewScoreDecision.UseVisualStyleBackColor = true;
            this.buttonNewScoreDecision.Click += new System.EventHandler(this.buttonNewScoreDecision_Click);
            // 
            // buttonNewOnicescuDecision
            // 
            this.buttonNewOnicescuDecision.Location = new System.Drawing.Point(64, 153);
            this.buttonNewOnicescuDecision.Name = "buttonNewOnicescuDecision";
            this.buttonNewOnicescuDecision.Size = new System.Drawing.Size(103, 32);
            this.buttonNewOnicescuDecision.TabIndex = 3;
            this.buttonNewOnicescuDecision.Text = "New Onicescu decision";
            this.buttonNewOnicescuDecision.UseVisualStyleBackColor = true;
            this.buttonNewOnicescuDecision.Click += new System.EventHandler(this.buttonNewOnicescuDecision_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 542);
            this.Controls.Add(this.buttonNewOnicescuDecision);
            this.Controls.Add(this.buttonNewScoreDecision);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodesScoreInfluenceToolStripMenuItem;
        private System.Windows.Forms.Button buttonNewScoreDecision;
        private System.Windows.Forms.Button buttonNewOnicescuDecision;
    }
}

