namespace AMAP
{
    partial class targetInfoGet
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
            this.pnlMap = new System.Windows.Forms.Panel();
            this.mapBrowser = new System.Windows.Forms.WebBrowser();
            this.pnlOperation = new System.Windows.Forms.Panel();
            this.grbInfomation = new System.Windows.Forms.GroupBox();
            this.dataInfo = new System.Windows.Forms.DataGridView();
            this.grbOperations = new System.Windows.Forms.GroupBox();
            this.btnOutPuttoExcel = new System.Windows.Forms.Button();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.lbMaps = new System.Windows.Forms.Label();
            this.cmbMapSelect = new System.Windows.Forms.ComboBox();
            this.btnMapChange = new System.Windows.Forms.Button();
            this.pnlMap.SuspendLayout();
            this.pnlOperation.SuspendLayout();
            this.grbInfomation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataInfo)).BeginInit();
            this.grbOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMap
            // 
            this.pnlMap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlMap.Controls.Add(this.mapBrowser);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(887, 598);
            this.pnlMap.TabIndex = 0;
            // 
            // mapBrowser
            // 
            this.mapBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapBrowser.Location = new System.Drawing.Point(0, 0);
            this.mapBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapBrowser.Name = "mapBrowser";
            this.mapBrowser.Size = new System.Drawing.Size(887, 598);
            this.mapBrowser.TabIndex = 0;
            // 
            // pnlOperation
            // 
            this.pnlOperation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlOperation.Controls.Add(this.grbInfomation);
            this.pnlOperation.Controls.Add(this.grbOperations);
            this.pnlOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOperation.Location = new System.Drawing.Point(0, 466);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(887, 132);
            this.pnlOperation.TabIndex = 1;
            // 
            // grbInfomation
            // 
            this.grbInfomation.Controls.Add(this.dataInfo);
            this.grbInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbInfomation.Location = new System.Drawing.Point(310, 0);
            this.grbInfomation.Name = "grbInfomation";
            this.grbInfomation.Size = new System.Drawing.Size(577, 132);
            this.grbInfomation.TabIndex = 1;
            this.grbInfomation.TabStop = false;
            this.grbInfomation.Text = "targetInfo";
            // 
            // dataInfo
            // 
            this.dataInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataInfo.Location = new System.Drawing.Point(3, 17);
            this.dataInfo.Name = "dataInfo";
            this.dataInfo.RowTemplate.Height = 23;
            this.dataInfo.Size = new System.Drawing.Size(571, 112);
            this.dataInfo.TabIndex = 0;
            // 
            // grbOperations
            // 
            this.grbOperations.Controls.Add(this.btnOutPuttoExcel);
            this.grbOperations.Controls.Add(this.btnGetInfo);
            this.grbOperations.Controls.Add(this.lbMaps);
            this.grbOperations.Controls.Add(this.cmbMapSelect);
            this.grbOperations.Controls.Add(this.btnMapChange);
            this.grbOperations.Dock = System.Windows.Forms.DockStyle.Left;
            this.grbOperations.Location = new System.Drawing.Point(0, 0);
            this.grbOperations.Name = "grbOperations";
            this.grbOperations.Size = new System.Drawing.Size(310, 132);
            this.grbOperations.TabIndex = 0;
            this.grbOperations.TabStop = false;
            this.grbOperations.Text = "mapControl";
            // 
            // btnOutPuttoExcel
            // 
            this.btnOutPuttoExcel.Location = new System.Drawing.Point(229, 56);
            this.btnOutPuttoExcel.Name = "btnOutPuttoExcel";
            this.btnOutPuttoExcel.Size = new System.Drawing.Size(71, 23);
            this.btnOutPuttoExcel.TabIndex = 5;
            this.btnOutPuttoExcel.Text = "导入Excel";
            this.btnOutPuttoExcel.UseVisualStyleBackColor = true;
            this.btnOutPuttoExcel.Click += new System.EventHandler(this.btnOutPuttoExcel_Click);
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(229, 29);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(71, 20);
            this.btnGetInfo.TabIndex = 4;
            this.btnGetInfo.Text = "获取信息";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // lbMaps
            // 
            this.lbMaps.AutoSize = true;
            this.lbMaps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMaps.Location = new System.Drawing.Point(3, 117);
            this.lbMaps.Name = "lbMaps";
            this.lbMaps.Size = new System.Drawing.Size(89, 12);
            this.lbMaps.TabIndex = 3;
            this.lbMaps.Text = "当前地图源为：";
            // 
            // cmbMapSelect
            // 
            this.cmbMapSelect.FormattingEnabled = true;
            this.cmbMapSelect.Items.AddRange(new object[] {
            "高德地图",
            "百度地图",
            "腾讯地图"});
            this.cmbMapSelect.Location = new System.Drawing.Point(6, 30);
            this.cmbMapSelect.Name = "cmbMapSelect";
            this.cmbMapSelect.Size = new System.Drawing.Size(120, 20);
            this.cmbMapSelect.TabIndex = 2;
            this.cmbMapSelect.Text = "高德地图";
            // 
            // btnMapChange
            // 
            this.btnMapChange.Location = new System.Drawing.Point(142, 29);
            this.btnMapChange.Name = "btnMapChange";
            this.btnMapChange.Size = new System.Drawing.Size(71, 20);
            this.btnMapChange.TabIndex = 1;
            this.btnMapChange.Text = "切换地图";
            this.btnMapChange.UseVisualStyleBackColor = true;
            // 
            // targetInfoGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 598);
            this.Controls.Add(this.pnlOperation);
            this.Controls.Add(this.pnlMap);
            this.Name = "targetInfoGet";
            this.Text = "抓取地图信息";
            this.pnlMap.ResumeLayout(false);
            this.pnlOperation.ResumeLayout(false);
            this.grbInfomation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataInfo)).EndInit();
            this.grbOperations.ResumeLayout(false);
            this.grbOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlOperation;
        private System.Windows.Forms.GroupBox grbOperations;
        private System.Windows.Forms.ComboBox cmbMapSelect;
        private System.Windows.Forms.Button btnMapChange;
        private System.Windows.Forms.WebBrowser mapBrowser;
        private System.Windows.Forms.GroupBox grbInfomation;
        private System.Windows.Forms.Label lbMaps;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.DataGridView dataInfo;
        private System.Windows.Forms.Button btnOutPuttoExcel;
    }
}

