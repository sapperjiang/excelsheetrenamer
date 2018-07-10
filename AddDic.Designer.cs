namespace PinYinParse
{
    partial class AddDic
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
            this.button1 = new System.Windows.Forms.Button();
            this.LB_UntrasnLatedText = new System.Windows.Forms.Label();
            this.TB_EnglishTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加好啦！";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LB_UntrasnLatedText
            // 
            this.LB_UntrasnLatedText.AutoSize = true;
            this.LB_UntrasnLatedText.Location = new System.Drawing.Point(12, 18);
            this.LB_UntrasnLatedText.Name = "LB_UntrasnLatedText";
            this.LB_UntrasnLatedText.Size = new System.Drawing.Size(53, 12);
            this.LB_UntrasnLatedText.TabIndex = 20;
            this.LB_UntrasnLatedText.Text = "添加字典";
            // 
            // TB_EnglishTxt
            // 
            this.TB_EnglishTxt.Location = new System.Drawing.Point(71, 37);
            this.TB_EnglishTxt.Multiline = true;
            this.TB_EnglishTxt.Name = "TB_EnglishTxt";
            this.TB_EnglishTxt.Size = new System.Drawing.Size(164, 22);
            this.TB_EnglishTxt.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "翻译为：";
            // 
            // AddDic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_UntrasnLatedText);
            this.Controls.Add(this.TB_EnglishTxt);
            this.Controls.Add(this.button1);
            this.Name = "AddDic";
            this.Text = "AddDic";
            this.Load += new System.EventHandler(this.AddDic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LB_UntrasnLatedText;
        private System.Windows.Forms.TextBox TB_EnglishTxt;
        private System.Windows.Forms.Label label1;
    }
}