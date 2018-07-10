namespace PinYinParse
{
    partial class ReNameExcelTools
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_SheetNames = new System.Windows.Forms.ListBox();
            this.BT_OpenFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.LB_NewSheetNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_TotalProgress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_TabColuProgress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_RenameRules = new System.Windows.Forms.TextBox();
            this.TB_DIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_LoadDictionary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_SheetNames
            // 
            this.LB_SheetNames.FormattingEnabled = true;
            this.LB_SheetNames.ItemHeight = 12;
            this.LB_SheetNames.Location = new System.Drawing.Point(456, 53);
            this.LB_SheetNames.Name = "LB_SheetNames";
            this.LB_SheetNames.Size = new System.Drawing.Size(139, 316);
            this.LB_SheetNames.TabIndex = 0;
            // 
            // BT_OpenFile
            // 
            this.BT_OpenFile.Location = new System.Drawing.Point(107, 4);
            this.BT_OpenFile.Name = "BT_OpenFile";
            this.BT_OpenFile.Size = new System.Drawing.Size(75, 23);
            this.BT_OpenFile.TabIndex = 1;
            this.BT_OpenFile.Text = "打开文件";
            this.BT_OpenFile.UseVisualStyleBackColor = true;
            this.BT_OpenFile.Click += new System.EventHandler(this.BT_OpenFile_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "excel文件|*.xls;*.xlsx";
            this.openFile.Multiselect = true;
            // 
            // LB_NewSheetNames
            // 
            this.LB_NewSheetNames.FormattingEnabled = true;
            this.LB_NewSheetNames.ItemHeight = 12;
            this.LB_NewSheetNames.Location = new System.Drawing.Point(637, 53);
            this.LB_NewSheetNames.Name = "LB_NewSheetNames";
            this.LB_NewSheetNames.Size = new System.Drawing.Size(140, 316);
            this.LB_NewSheetNames.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "总进度：";
            // 
            // LB_TotalProgress
            // 
            this.LB_TotalProgress.AutoSize = true;
            this.LB_TotalProgress.Location = new System.Drawing.Point(59, 387);
            this.LB_TotalProgress.Name = "LB_TotalProgress";
            this.LB_TotalProgress.Size = new System.Drawing.Size(41, 12);
            this.LB_TotalProgress.TabIndex = 6;
            this.LB_TotalProgress.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "修改表头进度：";
            // 
            // LB_TabColuProgress
            // 
            this.LB_TabColuProgress.AutoSize = true;
            this.LB_TabColuProgress.Location = new System.Drawing.Point(350, 9);
            this.LB_TabColuProgress.Name = "LB_TabColuProgress";
            this.LB_TabColuProgress.Size = new System.Drawing.Size(89, 12);
            this.LB_TabColuProgress.TabIndex = 8;
            this.LB_TabColuProgress.Text = "修改表头进度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "原来的表名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "新表名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "改名规则(前面关键字，后表类型）:";
            // 
            // TB_RenameRules
            // 
            this.TB_RenameRules.Location = new System.Drawing.Point(253, 53);
            this.TB_RenameRules.Multiline = true;
            this.TB_RenameRules.Name = "TB_RenameRules";
            this.TB_RenameRules.Size = new System.Drawing.Size(147, 316);
            this.TB_RenameRules.TabIndex = 13;
            this.TB_RenameRules.Text = "统计|TB_SUBJECT_\r\n费用|TB_SUBJECT_\r\n默认|TB_BUSINESS_";
            // 
            // TB_DIC
            // 
            this.TB_DIC.Location = new System.Drawing.Point(14, 53);
            this.TB_DIC.Multiline = true;
            this.TB_DIC.Name = "TB_DIC";
            this.TB_DIC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_DIC.Size = new System.Drawing.Size(215, 316);
            this.TB_DIC.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "字段翻译字典";
            // 
            // BT_LoadDictionary
            // 
            this.BT_LoadDictionary.Location = new System.Drawing.Point(12, 4);
            this.BT_LoadDictionary.Name = "BT_LoadDictionary";
            this.BT_LoadDictionary.Size = new System.Drawing.Size(75, 23);
            this.BT_LoadDictionary.TabIndex = 16;
            this.BT_LoadDictionary.Text = "加载字典";
            this.BT_LoadDictionary.UseVisualStyleBackColor = true;
            this.BT_LoadDictionary.Click += new System.EventHandler(this.BT_LoadDictionary_Click);
            // 
            // ReNameExcelTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 408);
            this.Controls.Add(this.BT_LoadDictionary);
            this.Controls.Add(this.TB_DIC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_RenameRules);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_TabColuProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_TotalProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_NewSheetNames);
            this.Controls.Add(this.BT_OpenFile);
            this.Controls.Add(this.LB_SheetNames);
            this.Name = "ReNameExcelTools";
            this.Text = "ReNameExcelTools";
            this.Load += new System.EventHandler(this.ReNameExcelTools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_SheetNames;
        private System.Windows.Forms.Button BT_OpenFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ListBox LB_NewSheetNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_TotalProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_TabColuProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_RenameRules;
        private System.Windows.Forms.TextBox TB_DIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_LoadDictionary;
    }
}