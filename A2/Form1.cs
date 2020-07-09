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

namespace A2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            ReadFromFileAndFill();
        }

        private void ReadFromFileAndFill()
        {
            //Leeren bevor neu rein geschrieben wird
            listBox1.Items.Clear();

            StreamReader reader = new StreamReader("../../text.txt");

            using (reader)
            {
                string oneline = reader.ReadLine();
                while (oneline != null)
                {
                    listBox1.Items.Add(oneline);

                    oneline = reader.ReadLine();
                }
            }
        }
    }
}