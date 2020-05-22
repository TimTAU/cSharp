using System;
using System.Windows.Forms;

namespace A6_Fyilion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                this.randomNumListBox.Items.Add(r.Next(100));
            }

        }

        private void randomNumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.numberBox.Text = randomNumListBox.SelectedItem.ToString();
        }
    }
}
