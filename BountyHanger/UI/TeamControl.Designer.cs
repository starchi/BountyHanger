namespace BountyHanger.UI
{
    partial class TeamControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TeamPanel = new System.Windows.Forms.Panel();
            this.TeamHPLabel = new System.Windows.Forms.Label();
            this.ChangeUnitButton = new System.Windows.Forms.Button();
            this.UnitsControl = new BountyHanger.UI.TeamUnitsControl();
            this.HeroPanel = new System.Windows.Forms.Panel();
            this.HeroControl = new BountyHanger.UI.TeamHeroControl();
            this.HeroLabel = new System.Windows.Forms.Label();
            this.ChangeHeroButton = new System.Windows.Forms.Button();
            this.TeamPanel.SuspendLayout();
            this.HeroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamPanel
            // 
            this.TeamPanel.Controls.Add(this.TeamHPLabel);
            this.TeamPanel.Controls.Add(this.ChangeUnitButton);
            this.TeamPanel.Controls.Add(this.UnitsControl);
            this.TeamPanel.Controls.Add(this.HeroPanel);
            this.TeamPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamPanel.Location = new System.Drawing.Point(0, 0);
            this.TeamPanel.Name = "TeamPanel";
            this.TeamPanel.Size = new System.Drawing.Size(217, 273);
            this.TeamPanel.TabIndex = 0;
            // 
            // TeamHPLabel
            // 
            this.TeamHPLabel.AutoSize = true;
            this.TeamHPLabel.Location = new System.Drawing.Point(3, 251);
            this.TeamHPLabel.Name = "TeamHPLabel";
            this.TeamHPLabel.Size = new System.Drawing.Size(53, 12);
            this.TeamHPLabel.TabIndex = 3;
            this.TeamHPLabel.Text = "部队HP：";
            // 
            // ChangeUnitButton
            // 
            this.ChangeUnitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeUnitButton.Location = new System.Drawing.Point(174, 245);
            this.ChangeUnitButton.Name = "ChangeUnitButton";
            this.ChangeUnitButton.Size = new System.Drawing.Size(40, 25);
            this.ChangeUnitButton.TabIndex = 2;
            this.ChangeUnitButton.Text = "调整";
            this.ChangeUnitButton.UseVisualStyleBackColor = true;
            // 
            // UnitsControl
            // 
            this.UnitsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitsControl.Location = new System.Drawing.Point(5, 38);
            this.UnitsControl.Name = "UnitsControl";
            this.UnitsControl.Size = new System.Drawing.Size(209, 201);
            this.UnitsControl.TabIndex = 1;
            // 
            // HeroPanel
            // 
            this.HeroPanel.Controls.Add(this.HeroControl);
            this.HeroPanel.Controls.Add(this.HeroLabel);
            this.HeroPanel.Controls.Add(this.ChangeHeroButton);
            this.HeroPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeroPanel.Location = new System.Drawing.Point(0, 0);
            this.HeroPanel.Name = "HeroPanel";
            this.HeroPanel.Size = new System.Drawing.Size(217, 32);
            this.HeroPanel.TabIndex = 0;
            // 
            // HeroControl
            // 
            this.HeroControl.BackColor = System.Drawing.Color.Transparent;
            this.HeroControl.Location = new System.Drawing.Point(50, 10);
            this.HeroControl.Name = "HeroControl";
            this.HeroControl.Size = new System.Drawing.Size(100, 15);
            this.HeroControl.TabIndex = 2;
            // 
            // HeroLabel
            // 
            this.HeroLabel.AutoSize = true;
            this.HeroLabel.Location = new System.Drawing.Point(3, 10);
            this.HeroLabel.Name = "HeroLabel";
            this.HeroLabel.Size = new System.Drawing.Size(41, 12);
            this.HeroLabel.TabIndex = 1;
            this.HeroLabel.Text = "英雄：";
            // 
            // ChangeHeroButton
            // 
            this.ChangeHeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeHeroButton.Location = new System.Drawing.Point(174, 4);
            this.ChangeHeroButton.Name = "ChangeHeroButton";
            this.ChangeHeroButton.Size = new System.Drawing.Size(40, 25);
            this.ChangeHeroButton.TabIndex = 0;
            this.ChangeHeroButton.Text = "更换";
            this.ChangeHeroButton.UseVisualStyleBackColor = true;
            this.ChangeHeroButton.Click += new System.EventHandler(this.ChangeHeroButton_Click);
            // 
            // TeamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TeamPanel);
            this.Name = "TeamControl";
            this.Size = new System.Drawing.Size(217, 273);
            this.TeamPanel.ResumeLayout(false);
            this.TeamPanel.PerformLayout();
            this.HeroPanel.ResumeLayout(false);
            this.HeroPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TeamPanel;
        private System.Windows.Forms.Panel HeroPanel;
        private System.Windows.Forms.Label HeroLabel;
        private System.Windows.Forms.Button ChangeHeroButton;
        private TeamHeroControl HeroControl;
        private System.Windows.Forms.Button ChangeUnitButton;
        private TeamUnitsControl UnitsControl;
        private System.Windows.Forms.Label TeamHPLabel;
    }
}
