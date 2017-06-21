namespace ShortMgmt
{
    partial class frmShortMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRegeditData = new System.Windows.Forms.DataGridView();
            this.btnAddShort = new System.Windows.Forms.Button();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectPath = new System.Windows.Forms.TextBox();
            this.btnSelectTarget = new System.Windows.Forms.Button();
            this.linklblSelectPath = new System.Windows.Forms.LinkLabel();
            this.btnDeleteSelect = new System.Windows.Forms.Button();
            this.radiobtnFile = new System.Windows.Forms.RadioButton();
            this.radiobtnFolder = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegeditData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegeditData
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegeditData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegeditData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegeditData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegeditData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRegeditData.Location = new System.Drawing.Point(0, 134);
            this.dgvRegeditData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvRegeditData.Name = "dgvRegeditData";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegeditData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegeditData.RowTemplate.Height = 21;
            this.dgvRegeditData.Size = new System.Drawing.Size(1172, 378);
            this.dgvRegeditData.TabIndex = 5;
            // 
            // btnAddShort
            // 
            this.btnAddShort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShort.Location = new System.Drawing.Point(940, 27);
            this.btnAddShort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddShort.Name = "btnAddShort";
            this.btnAddShort.Size = new System.Drawing.Size(100, 28);
            this.btnAddShort.TabIndex = 3;
            this.btnAddShort.Text = "添加";
            this.btnAddShort.UseVisualStyleBackColor = true;
            this.btnAddShort.Click += new System.EventHandler(this.btnAddShort_Click);
            // 
            // txtShortName
            // 
            this.txtShortName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShortName.Location = new System.Drawing.Point(153, 27);
            this.txtShortName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(132, 27);
            this.txtShortName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "快捷名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "执行目标：";
            // 
            // txtSelectPath
            // 
            this.txtSelectPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectPath.Location = new System.Drawing.Point(153, 67);
            this.txtSelectPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSelectPath.Name = "txtSelectPath";
            this.txtSelectPath.Size = new System.Drawing.Size(445, 27);
            this.txtSelectPath.TabIndex = 1;
            // 
            // btnSelectTarget
            // 
            this.btnSelectTarget.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectTarget.Location = new System.Drawing.Point(606, 62);
            this.btnSelectTarget.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSelectTarget.Name = "btnSelectTarget";
            this.btnSelectTarget.Size = new System.Drawing.Size(117, 32);
            this.btnSelectTarget.TabIndex = 2;
            this.btnSelectTarget.Text = "浏览文件";
            this.btnSelectTarget.UseVisualStyleBackColor = true;
            this.btnSelectTarget.Click += new System.EventHandler(this.btnSelectTarget_Click);
            // 
            // linklblSelectPath
            // 
            this.linklblSelectPath.AutoSize = true;
            this.linklblSelectPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linklblSelectPath.Location = new System.Drawing.Point(151, 103);
            this.linklblSelectPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblSelectPath.Name = "linklblSelectPath";
            this.linklblSelectPath.Size = new System.Drawing.Size(0, 20);
            this.linklblSelectPath.TabIndex = 5;
            this.linklblSelectPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSelectPath_LinkClicked);
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelect.Location = new System.Drawing.Point(940, 67);
            this.btnDeleteSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteSelect.TabIndex = 4;
            this.btnDeleteSelect.Text = "删除";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnDeleteSelect_Click);
            // 
            // radiobtnFile
            // 
            this.radiobtnFile.AutoSize = true;
            this.radiobtnFile.Checked = true;
            this.radiobtnFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radiobtnFile.Location = new System.Drawing.Point(405, 29);
            this.radiobtnFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtnFile.Name = "radiobtnFile";
            this.radiobtnFile.Size = new System.Drawing.Size(60, 24);
            this.radiobtnFile.TabIndex = 6;
            this.radiobtnFile.TabStop = true;
            this.radiobtnFile.Text = "文件";
            this.radiobtnFile.UseVisualStyleBackColor = true;
            this.radiobtnFile.CheckedChanged += new System.EventHandler(this.radiobtnFile_CheckedChanged);
            // 
            // radiobtnFolder
            // 
            this.radiobtnFolder.AutoSize = true;
            this.radiobtnFolder.Location = new System.Drawing.Point(520, 31);
            this.radiobtnFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radiobtnFolder.Name = "radiobtnFolder";
            this.radiobtnFolder.Size = new System.Drawing.Size(73, 19);
            this.radiobtnFolder.TabIndex = 6;
            this.radiobtnFolder.Text = "文件夹";
            this.radiobtnFolder.UseVisualStyleBackColor = true;
            this.radiobtnFolder.CheckedChanged += new System.EventHandler(this.radiobtnFolder_CheckedChanged);
            // 
            // frmShortMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 512);
            this.Controls.Add(this.radiobtnFolder);
            this.Controls.Add(this.radiobtnFile);
            this.Controls.Add(this.btnDeleteSelect);
            this.Controls.Add(this.linklblSelectPath);
            this.Controls.Add(this.btnSelectTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSelectPath);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.btnAddShort);
            this.Controls.Add(this.dgvRegeditData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmShortMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "快捷命令管理工具Ver0.2";
            this.Load += new System.EventHandler(this.frmShortMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegeditData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegeditData;
        private System.Windows.Forms.Button btnAddShort;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelectPath;
        private System.Windows.Forms.Button btnSelectTarget;
        private System.Windows.Forms.LinkLabel linklblSelectPath;
        private System.Windows.Forms.Button btnDeleteSelect;
        private System.Windows.Forms.RadioButton radiobtnFile;
        private System.Windows.Forms.RadioButton radiobtnFolder;
    }
}

