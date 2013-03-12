namespace BountyHanger.UI
{
    partial class TeamHeroControl
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
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.AutoEllipsis = true;
            this.HeroNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroNameLabel.ForeColor = System.Drawing.Color.Red;
            this.HeroNameLabel.Location = new System.Drawing.Point(0, 0);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(100, 15);
            this.HeroNameLabel.TabIndex = 0;
            // 
            // TeamHeroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HeroNameLabel);
            this.Name = "TeamHeroControl";
            this.Size = new System.Drawing.Size(100, 15);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeroNameLabel;
    }
}
