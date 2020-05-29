/*
 *  (C) 2020 a.voss@fh-aachen.de
 *      
 *  content:    
 *      - a simple GUI program
 *  
 *  exercises: 
 *      - understand code snippets part by part      
 *      - use and parameterise all controls in your own GUI app
 */

using System;
using System.Windows.Forms;

namespace cs_snippets
{
    // note the "partial" keyword, there is more class content hidden
    public partial class FormGuiI : Form
    {
        bool firstUseAB = true;

        public FormGuiI()
        {
            // here all properties and controls are set
            InitializeComponent();
        }

        /// <summary>
        /// - event handler, called when button is clicked
        /// </summary>
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
           

            // nothing to add -> abort
            if (this.textBoxItem.Text == "")
            {
                // inform user 
                MessageBox.Show("add text first","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            // check whether it is the first add; in this case clear the box first
            if (firstUseAB)
            {
                this.listBoxItems.Items.Clear();
                firstUseAB = false;
            }
            // add text to list
            this.listBoxItems.Items.Add("(" + DateTime.Now + ") " + this.textBoxItem.Text);
        }

        /// <summary>
        /// - event handler, called when button is clicked
        /// </summary>
        private void buttonDelItem_Click(object sender, EventArgs e)
        {
            // nothing to delete -> abort
            if (this.listBoxItems.Items.Count==0)
            {
                MessageBox.Show("nothing to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // this is the current selected index, can be -1
            int pos = this.listBoxItems.SelectedIndex;

            if (pos >= 0)
            {
                this.listBoxItems.Items.RemoveAt(pos);
                if (pos < this.listBoxItems.Items.Count)
                    this.listBoxItems.SelectedIndex = pos;
                else if (this.listBoxItems.Items.Count > 0)
                    this.listBoxItems.SelectedIndex = this.listBoxItems.Items.Count-1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonAddItem.PerformClick();
        }

        private void buttonShowMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo Button", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
