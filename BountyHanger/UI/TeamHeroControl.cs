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
    public partial class TeamHeroControl : UserControl
    {
        public TeamHeroControl()
        {
            InitializeComponent();
        }

        public TeamHeroControl(string heroName)
        {
            InitializeComponent();
            SetHeroName(heroName);
        }

        public void SetHeroName(string heroName)
        {
            this.HeroNameLabel.Text = heroName;
        }
    }
}
