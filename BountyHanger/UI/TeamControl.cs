using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BountyHanger.Library;

namespace BountyHanger.UI
{
    public partial class TeamControl : UserControl
    {
        private Team Team;

        public TeamControl()
        {
            InitializeComponent();
        }

        public TeamControl(Team team)
        {
            InitializeComponent();
            SetTeam(team);
        }

        public void SetTeam(Team team) {
            this.Team = team;
            //this.HeroControl.SetHeroName(this.Team.Hero.Name);
            //this.UnitsControl.SetPosition(this.Team.Hero.Leadership);
            //this.UnitsControl.SetUnits(this.Team.Units);
            //this.TeamHPLabel.Text = "部队HP: " + this.Team.TeamHeal;
        }

        private void ChangeHeroButton_Click(object sender, EventArgs e)
        {
            //open HeroManagerWindows
        }
    }
}
