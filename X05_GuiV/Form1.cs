using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X05_GuiV
{
    public partial class Form1 : Form
    {
        private int StartTop;

        public Form1()
        {
            InitializeComponent();
            StartTop = button1.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                return;
            button1.Enabled = false;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            button1.Enabled = !button1.Enabled;
            // Bsp.: alternierend zwischen n1 und n2: x := (n1+n2)-x
            button1.Top = StartTop + StartTop + 100 - button1.Top;

            //button1.Location;
        }
    }
}
