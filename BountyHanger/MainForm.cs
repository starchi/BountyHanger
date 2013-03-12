using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BountyHanger.Library;

namespace BountyHanger
{
    public partial class MainForm : Form
    {
        Game game = new Game();

        public MainForm()
        {
            InitializeComponent();
            game.TestGame();
            TeamControl.SetTeam(game.Team);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            //game.GoOn();
        }
    }
}
