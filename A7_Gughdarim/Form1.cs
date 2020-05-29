using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A7_Gughdarim
{
    public partial class Form1 : Form
    {
        private const int CardsCols = 13, CardsRows = 4;
        private readonly Bitmap[,] _cards = new Bitmap[CardsCols, CardsRows];
        private int _nextCard, _score;
        private readonly Random _random = new Random();

        public Form1()
        {
            InitializeComponent();

            // from http://www.ironstarmedia.co.uk/2010/01/free-game-assets-08-playing-card-pack/
            Bitmap bmpOrig = new Bitmap("../../Cards/classic-cards-gray.gif");

            int szX = bmpOrig.Width / CardsCols;
            int szY = bmpOrig.Height / CardsRows;

            for (int iy = 0; iy < 4; ++iy)
            {
                int y = ((iy & 1) != 0) ? 4 - iy : iy; // Tausche Reihe 1 und 3
                for (int x = 0; x < 13; ++x)
                {
                    Rectangle rect = new Rectangle(x * szX, iy * szY, szX, szY);
                    _cards[x, y] = Copy(bmpOrig, rect);
                }
            }

            Start();
        }

        private static Bitmap Copy(Bitmap srcBitmap, Rectangle section)
        {
            // from MSDN
            Bitmap bmp = new Bitmap(section.Width, section.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(srcBitmap, 0, 0, section, GraphicsUnit.Pixel);
            g.Dispose();
            return bmp;
        }

        private void Draw(object sender, EventArgs e)
        {
            RenderCard(_nextCard);
        }

        private void Restart(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
        private void End(object sender, EventArgs e)
        {
            EndGame();
        }

        private void Start()
        {
            RenderCard(0);
            RenderCard(1);
            _nextCard = 2;
        }

        private void RenderCard(int pos)
        {
            int r1 = _random.Next(0, 13);
            int r2 = _random.Next(0, 3);

            switch (pos)
            {
                case 0:
                    pictureBox1.Image = _cards[r1, r2];
                    break;
                case 1:
                    pictureBox2.Image = _cards[r1, r2];
                    break;
                case 2:
                    pictureBox3.Image = _cards[r1, r2];
                    break;
                case 3:
                    pictureBox4.Image = _cards[r1, r2];
                    break;
                case 4:
                    pictureBox5.Image = _cards[r1, r2];
                    break;
                case 5:
                    pictureBox6.Image = _cards[r1, r2];
                    break;
                case 6:
                    pictureBox7.Image = _cards[r1, r2];
                    break;
                case 7:
                    pictureBox8.Image = _cards[r1, r2];
                    break;
                default:
                    return;
            }

            switch (r1)
            {
                case 0:
                    _score += 11;
                    break;
                case 10:
                case 11:
                case 12:
                    _score += 10;
                    break;
                default:
                    _score += r1 + 1;
                    break;
            }
            ValidateScore();
            _nextCard++;
        }

        private void ValidateScore()
        {
            if (_score >= 21)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            int opponent = _random.Next(4, 22);
            if (_score < opponent)
            {
                resultLabel.Text = "Looser. Opponent: " + opponent;
            }
            else if (_score == opponent)
            {
                resultLabel.Text = "Draw. Opponent: " + opponent;
            }
            else
            {
                resultLabel.Text = "Winner. Opponent: " + opponent;
            }
            drawBtn.Enabled = false;
            finishBtn.Enabled = false;
        }
    }
}