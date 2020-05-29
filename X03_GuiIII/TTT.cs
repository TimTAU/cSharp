using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace cs_220_GUI_Examples
{
    // provided by WinForms-Program
    public interface ITTTSystemGUI
    {
        void Inform_NewTurn(int Player, int Move);
        void Inform_ObjectSelected(Control ctrl);
        Control Provide_BoardPanelParent();
    }

    // provided by Game
    public interface ITTTGameGUI
    {
        void Inform_SizeChanged();
        void Inform_NewGame();
        Control Provide_BoardPanel();
    }

    // MVC-Pattern
    public class TTTGame : ITTTGameGUI
    {
        public ITTTSystemGUI SystemGUI { get; private set; }

        public TTTModel tttModel { get; private set; }
        public TTTView tttView { get; private set; }
        public TTTControl tttControl { get; private set; }

        public TTTGame(ITTTSystemGUI _SystemGUI)
        {
            SystemGUI = _SystemGUI;

            tttModel = new TTTModel(this);
            tttView = new TTTView(this);
            tttControl = new TTTControl(this);

            tttModel.Init();
            tttView.Init();
            tttControl.Init();

            tttControl.Reset();
        }

        // ITTTGameGUI

        public void Inform_SizeChanged() { tttView.SizeChanged(); }
        public void Inform_NewGame() { tttControl.NewGame(); }
        public Control Provide_BoardPanel() { return tttView.GamePanel; }

        // MVC

        // all TTT-classes inherit TTTComponent; thus all components are 
        // linked together by tttGame
        public class TTTComponent
        {
            public TTTGame tttGame { get; private set; }

            public TTTComponent(TTTGame Game) { tttGame = Game; }
            public virtual void Init() { }
        }

        // the data model, containing the logical 3x3-board
        public class TTTModel : TTTComponent
        {
            public int[,] Field = new int[3,3];

            public TTTModel(TTTGame Game) : base(Game) { }

            public void ClearData()
            {
                for (int Row = 0; Row < 3; ++Row)
                    for (int Col = 0; Col < 3; ++Col)
                        SetTile(Row, Col, 0);
            }

            public int SetTile(int Row, int Col, int Player)
            {
                Field[Row, Col] = Player;
                tttGame.tttView.SetTile(Row, Col, Player);
                return (Player != 0 && Check(Player)) ? Player : 0;
            }

            bool Check(int Player)
            {
                int[, ,] CheckTiles = { 
                    { { 0, 0 }, { 0, 1 }, { 0, 2 } }, 
                    { { 1, 0 }, { 1, 1 }, { 1, 2 } }, 
                    { { 2, 0 }, { 2, 1 }, { 2, 2 } },
                    { { 0, 0 }, { 1, 0 }, { 2, 0 } },
                    { { 0, 1 }, { 1, 1 }, { 2, 1 } },
                    { { 0, 2 }, { 1, 2 }, { 2, 2 } },
                    { { 0, 0 }, { 1, 1 }, { 2, 2 } },
                    { { 2, 0 }, { 1, 1 }, { 0, 2 } },
                };
                for (int k = 0; k < CheckTiles.GetLength(0); ++k)
                {
                    if (Field[CheckTiles[k, 0, 0],CheckTiles[k, 0, 1]] == Player &&
                        Field[CheckTiles[k, 1, 0], CheckTiles[k, 1, 1]] == Player &&
                        Field[CheckTiles[k, 2, 0], CheckTiles[k, 2, 1]] == Player)
                        return true;
                }

                return false;
            }
        }

        // the view component, containing all GUI-references
        public class TTTView : TTTComponent
        {
            public Panel GamePanel { get; private set; }
            public Panel[,] GameTiles = new Panel[3,3];

            public TTTView(TTTGame Game) : base(Game) { }

            public override void Init()
            {
                Control ParentControl = tttGame.SystemGUI.Provide_BoardPanelParent();

                GamePanel = new Panel();
                GamePanel.Location = new Point(10, 10);
                GamePanel.Size = new Size(10, 10);
                GamePanel.BackColor = Color.Silver;
                GamePanel.Click += OnClick;
                GamePanel.Tag = -1;
                ParentControl.Controls.Add(GamePanel);

                for (int row = 0; row < 3; ++row)
                    for (int col = 0; col < 3; ++col)
                    {
                        Panel TilePanel = GameTiles[row, col] = new Panel();
                        TilePanel.Location = new Point(20, 20);
                        TilePanel.Size = new Size(10, 10);
                        TilePanel.BackColor = Color.White;
                        TilePanel.Click += OnClick;
                        TilePanel.Tag = row * 3 + col;
                        GamePanel.Controls.Add(TilePanel);
                    }
            }

            public void SizeChanged()
            {
                Control ParentControl = tttGame.SystemGUI.Provide_BoardPanelParent();
                Size sz = ParentControl.Size;
                int l = (sz.Width < sz.Height) ? sz.Width : sz.Height;
                GamePanel.Size = new Size(l - 20, l - 20);

                l = (l-20) / 7;
                for (int row = 0; row < 3; ++row)
                    for (int col = 0; col < 3; ++col)
                    {
                        Panel TilePanel = GameTiles[row, col];
                        TilePanel.Location = new Point(l + col * (l + l), l + row * (l + l));
                        TilePanel.Size = new Size(l, l);
                    }
            }

            public void OnClick(object sender, EventArgs e)
            {
                if (sender is Control && (sender as Control).Tag!=null)
                    tttGame.tttControl.Click((int)(sender as Control).Tag);   
            }

            public void Reset()
            {
                for (int Row = 0; Row < 3; ++Row)
                    for (int Col = 0; Col < 3; ++Col)
                        SetTile(Row, Col, 0);
            }

            public void SetTile(int Row, int Col, int Player)
            {
                switch (Player)
                {
                    case 0:
                        GameTiles[Row, Col].BackColor = Color.White;
                        break;
                    case 1:
                        GameTiles[Row, Col].BackColor = Color.Red;
                        break;
                    case 2:
                        GameTiles[Row, Col].BackColor = Color.Blue;
                        break;
                }
            }

        }

        public class TTTControl : TTTComponent
        {
            // could also be in Model
            public int Player { get; private set; }
            public int Move { get; private set; }

            public TTTControl(TTTGame Game) : base(Game) { }

            public override void Init()
            {
                Player = 0;
            }

            // change data, test for final draw
            public void Click(int tag)
            {
                if (-1 == tag)
                {
                    tttGame.SystemGUI.Inform_ObjectSelected(tttGame.tttView.GamePanel);
                }
                else
                {
                    int row = tag / 3, col = tag % 3;
                    tttGame.SystemGUI.Inform_ObjectSelected(tttGame.tttView.GameTiles[row, col]);
                    if (0 < Player && 0 == tttGame.tttModel.Field[row, col])
                    {
                        if (tttGame.tttModel.SetTile(row, col, Player) == Player)
                        {
                            MessageBox.Show("player " + Player+" wins");
                            Reset();
                        }
                        else if (Move == 9)
                        {
                            MessageBox.Show("no one wins");
                            Reset();
                        }
                        else
                        {
                            Player = 3 - Player;
                            ++Move;
                            tttGame.SystemGUI.Inform_NewTurn(Player, Move);
                        }
                    }
                }
            }

            public void NewGame()
            {
                tttGame.tttModel.ClearData();
                Player = 1; Move = 1;
                tttGame.SystemGUI.Inform_NewTurn(Player,Move);
                tttGame.SystemGUI.Inform_ObjectSelected(null);
            }

            public void Reset()
            {
                tttGame.tttModel.ClearData();
                Player = Move = 0;
                tttGame.SystemGUI.Inform_NewTurn(Player,Move);
                tttGame.SystemGUI.Inform_ObjectSelected(null);
            }
        }

    }
}
