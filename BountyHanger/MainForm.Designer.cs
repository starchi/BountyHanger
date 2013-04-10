namespace BountyHanger
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.TeamControl = new BountyHanger.UI.TeamControl();
            this.TestButton = new System.Windows.Forms.Button();
            this.TestTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 500;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // TeamControl
            // 
            this.TeamControl.Location = new System.Drawing.Point(12, 12);
            this.TeamControl.Name = "TeamControl";
            this.TeamControl.Size = new System.Drawing.Size(217, 273);
            this.TeamControl.TabIndex = 0;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(684, 10);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 1;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // TestTextBox
            // 
            this.TestTextBox.Location = new System.Drawing.Point(264, 39);
            this.TestTextBox.Multiline = true;
            this.TestTextBox.Name = "TestTextBox";
            this.TestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TestTextBox.Size = new System.Drawing.Size(495, 679);
            this.TestTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.TestTextBox);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.TeamControl);
            this.Name = "MainForm";
            this.Text = "BountyHanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private UI.TeamControl TeamControl;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TextBox TestTextBox;
    }
}

