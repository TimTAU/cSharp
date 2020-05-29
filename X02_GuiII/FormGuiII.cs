/*
 *  (C) 2020 a.voss@fh-aachen.de
 *      
 *  content:    
 *      - some advanced GUI stuff
 *  
 *  exercises: 
 *      - understand code snippets part by part      
 *      - use and parameterise all controls in your own GUI app
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_snippets
{
    public partial class FormGuiII : Form
    {
        public FormGuiII()
        {
            InitializeComponent();

            Message("start Form");
        }

        public void Message(string msg)
        {
            this.listBoxMsg.Items.Insert(0, msg);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClearMsg_Click(object sender, EventArgs e)
        {
            this.listBoxMsg.Items.Clear();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicked!");
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            this.checkBoxTest.Checked = !this.checkBoxTest.Checked;
        }

        private void checkBoxTest_CheckedChanged(object sender, EventArgs e)
        {
            Message("check state changed, new state: " + this.checkBoxTest.Checked);

            errorProvider1.SetError(this.checkBoxTest,this.checkBoxTest.Checked ? "my error" : "");
        }

        private void radioButtonn_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = (RadioButton)sender;
            Message("radio state " + btn.Tag + " changed, new state: "+btn.Checked);
        }

        private void textBoxTest_TextChanged(object sender, EventArgs e)
        {
            Message("edit text changed, new text: " + this.textBoxTest.Text);
        }

        private void buttonTo2_Click(object sender, EventArgs e)
        {
            this.tabControlMain.SelectedTab = this.tabPageAdvCtrls;
        }

        private void buttonAddSibl_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeViewTest.SelectedNode;
            TreeNodeCollection nodes = (node == null || node.Parent==null) ? 
                this.treeViewTest.Nodes : node.Parent.Nodes;
            TreeNode newNode = nodes.Add("node " + DateTime.Now);
            treeViewTest.SelectedNode = newNode;
            treeViewTest.Select();
        }

        private void buttonAddChild_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeViewTest.SelectedNode;
            TreeNodeCollection nodes = (node == null) ? this.treeViewTest.Nodes : node.Nodes;
            TreeNode newNode = nodes.Add("node " + DateTime.Now);
            treeViewTest.SelectedNode = newNode;
            treeViewTest.Select();
        }

        private void buttonDelSubtree_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeViewTest.SelectedNode;
            if (node!=null)
            {
                node.Remove();
            }
            treeViewTest.Select();
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {
            this.timerProgress.Start();
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            this.timerProgress.Stop();
        }

        private void timerProgress_Tick(object sender, EventArgs e)
        {
            int n = this.progressBarTest.Value;
            this.progressBarTest.Value = (n < 100) ? n + 10 : 0;
            Message("tick ... " + n);
        }

        private void panelMouse_Click(object sender, EventArgs e)
        {
            Point pt1 = System.Windows.Forms.Cursor.Position;
            Point pt2 = panelMouse.PointToClient(pt1);
            Message("mouse click "+pt2);
        }

        private void panelMouse_DoubleClick(object sender, EventArgs e)
        {
            Point pt1 = System.Windows.Forms.Cursor.Position;
            Point pt2 = panelMouse.PointToClient(pt1);
            Message("mouse dbl click " + pt2);
        }

        private void panelMouse_MouseEnter(object sender, EventArgs e)
        {
            Point pt1 = System.Windows.Forms.Cursor.Position;
            Point pt2 = panelMouse.PointToClient(pt1);
            Message("mouse enter " + pt2);
        }

        private void panelMouse_MouseLeave(object sender, EventArgs e)
        {
            Point pt1 = System.Windows.Forms.Cursor.Position;
            Point pt2 = panelMouse.PointToClient(pt1);
            Message("mouse leave " + pt2);
        }

        private void panelMouse_MouseMove(object sender, MouseEventArgs e)
        {
            //Point pt1 = System.Windows.Forms.Cursor.Position;
            //Point pt2 = panelMouse.PointToClient(pt1);
            Point pt2 = new Point(e.X, e.Y);
            Message("mouse move " + pt2);

        }

        private void buttonProp_Click(object sender, EventArgs e)
        {
            this.propertyGridMain.SelectedObject = this.buttonProp;
            //this.propertyGridMain.SelectedObject = new CCC();
        }

        private void checkBoxProp_CheckedChanged(object sender, EventArgs e)
        {
            this.propertyGridMain.SelectedObject = this.checkBoxProp;
        }


        class CCC
        {
            public int ID { get; set; }
        };
      
    }
}
