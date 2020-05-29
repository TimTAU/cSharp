using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X04_GuiIV
{
    public partial class Form_17_4 : Form
    {
        const int cards_cols = 13, cards_rows = 4;
        Bitmap[,] cards = new Bitmap[cards_cols, cards_rows];
        bool value_change_ok = true;

        public Form_17_4()
        {
            InitializeComponent();

            numericUpDownX1.Maximum = cards_cols - 1;
            numericUpDownY1.Maximum = cards_rows - 1;
            numericUpDownX2.Maximum = cards_cols - 1;
            numericUpDownY2.Maximum = cards_rows - 1;

            // from http://www.ironstarmedia.co.uk/2010/01/free-game-assets-08-playing-card-pack/
            Bitmap bmpOrig = new Bitmap("../../Cards/classic-cards-gray.gif");

            int sz_x = bmpOrig.Width / cards_cols;
            int sz_y = bmpOrig.Height / cards_rows;

            for (int iy = 0; iy < 4; ++iy)
            {
                int y = ((iy & 1)!=0) ? 4 - iy : iy; // Tausche Reihe 1 und 3
                for (int x = 0; x < 13; ++x)
                {
                    Rectangle rect = new Rectangle(x * sz_x, iy * sz_y, sz_x, sz_y);
                    cards[x, y] = Copy(bmpOrig, rect);
                }
            }

            setCard();
        }

        static public Bitmap Copy(Bitmap srcBitmap, Rectangle section)
        {
            // from MSDN
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            g.Dispose();
            return bmp;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            value_change_ok = false;
            numericUpDownX1.Value = rnd.Next(cards_cols);
            numericUpDownY1.Value = rnd.Next(cards_rows);
            numericUpDownX2.Value = rnd.Next(cards_cols);
            numericUpDownY2.Value = rnd.Next(cards_rows);
            value_change_ok = true;
            setCard();
        }

        private void setCard()
        {
            if (!value_change_ok)
                return;

            int x1 = (int)numericUpDownX1.Value;
            int y1 = (int)numericUpDownY1.Value;
            pictureBoxCard1.Image = cards[x1, y1];

            int x2 = (int)numericUpDownX2.Value;
            int y2 = (int)numericUpDownY2.Value;
            pictureBoxCard2.Image = cards[x2, y2];
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            setCard();
        }

    }
}
