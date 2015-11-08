namespace Convert
{
    partial class frmConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvert));
            this.upEdit = new System.Windows.Forms.RichTextBox();
            this.downEdit = new System.Windows.Forms.RichTextBox();
            this.toDownBtn = new System.Windows.Forms.Label();
            this.toUpBtn = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Label();
            this.byte_check = new System.Windows.Forms.CheckBox();
            this.guid_check = new System.Windows.Forms.CheckBox();
            this.url_check = new System.Windows.Forms.CheckBox();
            this.ascii_check = new System.Windows.Forms.CheckBox();
            this.ffff_check = new System.Windows.Forms.CheckBox();
            this.bin_check = new System.Windows.Forms.CheckBox();
            this.downSizeLabel = new System.Windows.Forms.Label();
            this.upSizeLabel = new System.Windows.Forms.Label();
            this.commaSplitCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // upEdit
            // 
            this.upEdit.Location = new System.Drawing.Point(1, 1);
            this.upEdit.Name = "upEdit";
            this.upEdit.Size = new System.Drawing.Size(355, 49);
            this.upEdit.TabIndex = 1;
            this.upEdit.Text = "";
            this.upEdit.TextChanged += new System.EventHandler(this.upEdit_TextChanged);
            // 
            // downEdit
            // 
            this.downEdit.Location = new System.Drawing.Point(1, 78);
            this.downEdit.Name = "downEdit";
            this.downEdit.Size = new System.Drawing.Size(355, 148);
            this.downEdit.TabIndex = 2;
            this.downEdit.Text = "";
            this.downEdit.TextChanged += new System.EventHandler(this.downEdit_TextChanged);
            // 
            // toDownBtn
            // 
            this.toDownBtn.AutoSize = true;
            this.toDownBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toDownBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toDownBtn.Location = new System.Drawing.Point(12, 56);
            this.toDownBtn.Margin = new System.Windows.Forms.Padding(0);
            this.toDownBtn.Name = "toDownBtn";
            this.toDownBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toDownBtn.Size = new System.Drawing.Size(55, 18);
            this.toDownBtn.TabIndex = 3;
            this.toDownBtn.Text = "↓↓↓↓";
            this.toDownBtn.Click += new System.EventHandler(this.toDownBtn_Click);
            // 
            // toUpBtn
            // 
            this.toUpBtn.AutoSize = true;
            this.toUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toUpBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toUpBtn.Location = new System.Drawing.Point(110, 56);
            this.toUpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.toUpBtn.Name = "toUpBtn";
            this.toUpBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.toUpBtn.Size = new System.Drawing.Size(55, 18);
            this.toUpBtn.TabIndex = 4;
            this.toUpBtn.Text = "↑↑↑↑";
            this.toUpBtn.Click += new System.EventHandler(this.toUpBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.AutoSize = true;
            this.copyBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.copyBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copyBtn.Location = new System.Drawing.Point(300, 56);
            this.copyBtn.Margin = new System.Windows.Forms.Padding(0);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.copyBtn.Size = new System.Drawing.Size(55, 18);
            this.copyBtn.TabIndex = 6;
            this.copyBtn.Text = ">>COPY<<";
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.AutoSize = true;
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.generateBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generateBtn.Location = new System.Drawing.Point(208, 56);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(0);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.generateBtn.Size = new System.Drawing.Size(49, 18);
            this.generateBtn.TabIndex = 7;
            this.generateBtn.Text = ">>New<<";
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // byte_check
            // 
            this.byte_check.AutoSize = true;
            this.byte_check.Location = new System.Drawing.Point(367, 12);
            this.byte_check.Name = "byte_check";
            this.byte_check.Size = new System.Drawing.Size(54, 16);
            this.byte_check.TabIndex = 11;
            this.byte_check.Text = "BYTES";
            this.byte_check.UseVisualStyleBackColor = true;
            // 
            // guid_check
            // 
            this.guid_check.AutoSize = true;
            this.guid_check.Location = new System.Drawing.Point(367, 34);
            this.guid_check.Name = "guid_check";
            this.guid_check.Size = new System.Drawing.Size(48, 16);
            this.guid_check.TabIndex = 12;
            this.guid_check.Text = "GUID";
            this.guid_check.UseVisualStyleBackColor = true;
            // 
            // url_check
            // 
            this.url_check.AutoSize = true;
            this.url_check.Location = new System.Drawing.Point(367, 56);
            this.url_check.Name = "url_check";
            this.url_check.Size = new System.Drawing.Size(42, 16);
            this.url_check.TabIndex = 13;
            this.url_check.Text = "URL";
            this.url_check.UseVisualStyleBackColor = true;
            // 
            // ascii_check
            // 
            this.ascii_check.AutoSize = true;
            this.ascii_check.Location = new System.Drawing.Point(367, 78);
            this.ascii_check.Name = "ascii_check";
            this.ascii_check.Size = new System.Drawing.Size(54, 16);
            this.ascii_check.TabIndex = 14;
            this.ascii_check.Text = "ASCII";
            this.ascii_check.UseVisualStyleBackColor = true;
            // 
            // ffff_check
            // 
            this.ffff_check.AutoSize = true;
            this.ffff_check.Location = new System.Drawing.Point(367, 100);
            this.ffff_check.Name = "ffff_check";
            this.ffff_check.Size = new System.Drawing.Size(60, 16);
            this.ffff_check.TabIndex = 15;
            this.ffff_check.Text = "0xFFFF";
            this.ffff_check.UseVisualStyleBackColor = true;
            // 
            // bin_check
            // 
            this.bin_check.AutoSize = true;
            this.bin_check.Location = new System.Drawing.Point(367, 122);
            this.bin_check.Name = "bin_check";
            this.bin_check.Size = new System.Drawing.Size(48, 16);
            this.bin_check.TabIndex = 16;
            this.bin_check.Text = "0101";
            this.bin_check.UseVisualStyleBackColor = true;
            // 
            // downSizeLabel
            // 
            this.downSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downSizeLabel.AutoSize = true;
            this.downSizeLabel.ForeColor = System.Drawing.Color.Blue;
            this.downSizeLabel.Location = new System.Drawing.Point(292, 210);
            this.downSizeLabel.Name = "downSizeLabel";
            this.downSizeLabel.Size = new System.Drawing.Size(47, 12);
            this.downSizeLabel.TabIndex = 17;
            this.downSizeLabel.Text = "Size：N";
            // 
            // upSizeLabel
            // 
            this.upSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upSizeLabel.AutoSize = true;
            this.upSizeLabel.ForeColor = System.Drawing.Color.Blue;
            this.upSizeLabel.Location = new System.Drawing.Point(292, 35);
            this.upSizeLabel.Name = "upSizeLabel";
            this.upSizeLabel.Size = new System.Drawing.Size(47, 12);
            this.upSizeLabel.TabIndex = 18;
            this.upSizeLabel.Text = "Size：N";
            // 
            // commaSplitCheck
            // 
            this.commaSplitCheck.AutoSize = true;
            this.commaSplitCheck.Location = new System.Drawing.Point(359, 193);
            this.commaSplitCheck.Name = "commaSplitCheck";
            this.commaSplitCheck.Size = new System.Drawing.Size(72, 16);
            this.commaSplitCheck.TabIndex = 19;
            this.commaSplitCheck.Text = "逗号分隔";
            this.commaSplitCheck.UseVisualStyleBackColor = true;
            this.commaSplitCheck.CheckedChanged += new System.EventHandler(this.commaSplitCheck_CheckedChanged);
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 231);
            this.Controls.Add(this.commaSplitCheck);
            this.Controls.Add(this.upSizeLabel);
            this.Controls.Add(this.downSizeLabel);
            this.Controls.Add(this.bin_check);
            this.Controls.Add(this.ffff_check);
            this.Controls.Add(this.ascii_check);
            this.Controls.Add(this.url_check);
            this.Controls.Add(this.guid_check);
            this.Controls.Add(this.byte_check);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.toUpBtn);
            this.Controls.Add(this.toDownBtn);
            this.Controls.Add(this.downEdit);
            this.Controls.Add(this.upEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConvert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "===Bytes转换/GUID===";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox upEdit;
        private System.Windows.Forms.RichTextBox downEdit;
        private System.Windows.Forms.Label toDownBtn;
        private System.Windows.Forms.Label toUpBtn;
        private System.Windows.Forms.Label copyBtn;
        private System.Windows.Forms.Label generateBtn;
        private System.Windows.Forms.CheckBox byte_check;
        private System.Windows.Forms.CheckBox guid_check;
        private System.Windows.Forms.CheckBox url_check;
        private System.Windows.Forms.CheckBox ascii_check;
        private System.Windows.Forms.CheckBox ffff_check;
        private System.Windows.Forms.CheckBox bin_check;
        private System.Windows.Forms.Label downSizeLabel;
        private System.Windows.Forms.Label upSizeLabel;
        private System.Windows.Forms.CheckBox commaSplitCheck;
    }
}

