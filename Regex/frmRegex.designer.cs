namespace RegexTool
{
    partial class frmRegex
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
            this.testBtn = new System.Windows.Forms.Button();
            this.msgTxtbox = new System.Windows.Forms.TextBox();
            this.regexTxtbox = new System.Windows.Forms.TextBox();
            this.rlt_Txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(377, 26);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(35, 310);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "测试正则";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // msgTxtbox
            // 
            this.msgTxtbox.Location = new System.Drawing.Point(12, 26);
            this.msgTxtbox.Multiline = true;
            this.msgTxtbox.Name = "msgTxtbox";
            this.msgTxtbox.Size = new System.Drawing.Size(359, 169);
            this.msgTxtbox.TabIndex = 1;
            // 
            // regexTxtbox
            // 
            this.regexTxtbox.Location = new System.Drawing.Point(12, 218);
            this.regexTxtbox.Multiline = true;
            this.regexTxtbox.Name = "regexTxtbox";
            this.regexTxtbox.Size = new System.Drawing.Size(359, 118);
            this.regexTxtbox.TabIndex = 2;
            // 
            // rlt_Txtbox
            // 
            this.rlt_Txtbox.Location = new System.Drawing.Point(418, 26);
            this.rlt_Txtbox.Multiline = true;
            this.rlt_Txtbox.Name = "rlt_Txtbox";
            this.rlt_Txtbox.Size = new System.Drawing.Size(265, 310);
            this.rlt_Txtbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "测试字符";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "正则表达式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "结果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rlt_Txtbox);
            this.Controls.Add(this.regexTxtbox);
            this.Controls.Add(this.msgTxtbox);
            this.Controls.Add(this.testBtn);
            this.Name = "Form1";
            this.Text = "正则测试工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.TextBox msgTxtbox;
        private System.Windows.Forms.TextBox regexTxtbox;
        private System.Windows.Forms.TextBox rlt_Txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

