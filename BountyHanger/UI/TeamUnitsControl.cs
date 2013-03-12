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
    public partial class TeamUnitsControl : UserControl
    {
        private int position;

        public TeamUnitsControl()
        {
            InitializeComponent();
        }

        public void SetPosition(int value)
        {
            this.position = value;
            ResetRows();
        }

        public void ResetRows()
        {
            this.UnitsDataGridView.Rows.Clear();
            this.UnitsDataGridView.Rows.Add(this.position);
        }


        public void SetUnits(Unit[] units)
        {
            if (units.Length > position)
            {
                SetPosition(units.Length);
            }
            else {
                ResetRows();
            }
            for (int i = 0; i < units.Length; i++) {
                this.UnitsDataGridView.Rows[i].Cells[0].Value = units[i].Name;
                this.UnitsDataGridView.Rows[i].Cells[0].ToolTipText = units[i].Name+"\nHP:" + units[i].HealPoint + "\nAttack:" + units[i].Attack;
            }
        }
    }
}
