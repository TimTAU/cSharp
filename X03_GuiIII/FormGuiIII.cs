using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_220_GUI_Examples
{

    public partial class FormGuiIII : Form, ITTTSystemGUI
    {
        TTTGame tttGame;

        public FormGuiIII()
        {
            InitializeComponent();

            tttGame = new TTTGame(this);
            FormMain_SizeChanged(this, null);
        }

        // ITTTSystemGUI

        public Control Provide_BoardPanelParent() { return this.tabPageTTT; }
        public void Inform_ObjectSelected(Control ctrl)  { propertyGridTTT.SelectedObject = ctrl; }
        public void Inform_NewTurn(int Player, int Move) { this.labelInfo.Text = (Player==0) ? "start new game" : "next player " + Player + " (move "+Move+")"; }

        // Events

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            tttGame.Inform_SizeChanged();
            panelGameControl.Width = this.tabPageTTT.Size.Width - tttGame.Provide_BoardPanel().Size.Width - 30;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            tttGame.Inform_NewGame();
        }

        private void tabPageTTT_Click(object sender, EventArgs e)
        {
            propertyGridTTT.SelectedObject = tttGame;
        }


    }


}
