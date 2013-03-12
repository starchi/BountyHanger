namespace BountyHanger.UI
{
    partial class TeamUnitsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UnitsDataGridView = new System.Windows.Forms.DataGridView();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitsDataGridView
            // 
            this.UnitsDataGridView.AllowUserToAddRows = false;
            this.UnitsDataGridView.AllowUserToDeleteRows = false;
            this.UnitsDataGridView.AllowUserToResizeColumns = false;
            this.UnitsDataGridView.AllowUserToResizeRows = false;
            this.UnitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UnitColumn});
            this.UnitsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.UnitsDataGridView.MultiSelect = false;
            this.UnitsDataGridView.Name = "UnitsDataGridView";
            this.UnitsDataGridView.ReadOnly = true;
            this.UnitsDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.UnitsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UnitsDataGridView.RowTemplate.Height = 23;
            this.UnitsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UnitsDataGridView.ShowEditingIcon = false;
            this.UnitsDataGridView.ShowRowErrors = false;
            this.UnitsDataGridView.Size = new System.Drawing.Size(150, 200);
            this.UnitsDataGridView.TabIndex = 0;
            // 
            // UnitColumn
            // 
            this.UnitColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitColumn.HeaderText = "战斗单位";
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.ReadOnly = true;
            this.UnitColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TeamUnitsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UnitsDataGridView);
            this.Name = "TeamUnitsControl";
            this.Size = new System.Drawing.Size(150, 200);
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UnitsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
    }
}
