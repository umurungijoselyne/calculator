using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }
        public Form b;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            switch (node.Text)
            {
                case "CALCULATOR":
                    b.Dispose();
                    b = new Form1();
                    b.TopLevel = false;
                    this.mainpanel.Controls.Add(b);
                    b.Dock = DockStyle.Fill;
                    b.Show();

                    break;

                case "STUDENT1":
                    b.Dispose();
                    b = new student1();
                    b.TopLevel = false;
                    this.mainpanel.Controls.Add(b);
                    b.Dock = DockStyle.Fill;
                    b.Show();

                    break;

                case "ROOM1":
                    b.Dispose();
                    b = new formroom();
                    b.TopLevel = false;
                    this.mainpanel.Controls.Add(b);
                    b.Dock = DockStyle.Fill;
                    b.Show();

                    break;


            }
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes[0].ExpandAll();
            b = new Form1();

            b.TopLevel = false;
            this.mainpanel.Controls.Add(b);
            b.Dock = DockStyle.Fill;
        }
    }
}
