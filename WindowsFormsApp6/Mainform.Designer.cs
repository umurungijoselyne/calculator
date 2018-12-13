namespace WindowsFormsApp6
{
    partial class Mainform
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ROOM1");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ROOM", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("STUDENT1");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("STUDENT", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("CALCULATOR");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("UTILITY", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Node3";
            treeNode7.Text = "ROOM1";
            treeNode8.Name = "Node0";
            treeNode8.Text = "ROOM";
            treeNode9.Name = "Node5";
            treeNode9.Text = "STUDENT1";
            treeNode10.Name = "Node1";
            treeNode10.Text = "STUDENT";
            treeNode11.Name = "Node6";
            treeNode11.Text = "CALCULATOR";
            treeNode12.Name = "Node2";
            treeNode12.Text = "UTILITY";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(158, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // mainpanel
            // 
            this.mainpanel.Location = new System.Drawing.Point(188, 12);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(600, 426);
            this.mainpanel.TabIndex = 1;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.treeView1);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel mainpanel;
    }
}