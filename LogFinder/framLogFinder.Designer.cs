namespace LogFinder
{
    partial class framLogFinder
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
            this.findBtn = new System.Windows.Forms.Button();
            this.identifyWordTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.identifyRegexTxtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.targetRegexTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.targetLineWithWordTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.targetRelativeLocation = new System.Windows.Forms.NumericUpDown();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.noRepeatCheckBox = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetRelativeLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(435, 256);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 0;
            this.findBtn.Text = "查找";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // identifyWordTxtBox
            // 
            this.identifyWordTxtBox.Location = new System.Drawing.Point(142, 25);
            this.identifyWordTxtBox.Name = "identifyWordTxtBox";
            this.identifyWordTxtBox.Size = new System.Drawing.Size(309, 21);
            this.identifyWordTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "包含";
            // 
            // identifyRegexTxtbox
            // 
            this.identifyRegexTxtbox.Location = new System.Drawing.Point(142, 52);
            this.identifyRegexTxtbox.Name = "identifyRegexTxtbox";
            this.identifyRegexTxtbox.Size = new System.Drawing.Size(309, 21);
            this.identifyRegexTxtbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "正则匹配";
            // 
            // targetRegexTxtBox
            // 
            this.targetRegexTxtBox.Location = new System.Drawing.Point(142, 86);
            this.targetRegexTxtBox.Name = "targetRegexTxtBox";
            this.targetRegexTxtBox.Size = new System.Drawing.Size(309, 21);
            this.targetRegexTxtBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "提取正则";
            // 
            // targetLineWithWordTxtBox
            // 
            this.targetLineWithWordTxtBox.Location = new System.Drawing.Point(142, 58);
            this.targetLineWithWordTxtBox.Name = "targetLineWithWordTxtBox";
            this.targetLineWithWordTxtBox.Size = new System.Drawing.Size(309, 21);
            this.targetLineWithWordTxtBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "包含";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "相对位置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.identifyRegexTxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.identifyWordTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标识行";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.targetRelativeLocation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.targetLineWithWordTxtBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.targetRegexTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(14, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 127);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "提取行";
            // 
            // targetRelativeLocation
            // 
            this.targetRelativeLocation.Location = new System.Drawing.Point(142, 32);
            this.targetRelativeLocation.Name = "targetRelativeLocation";
            this.targetRelativeLocation.Size = new System.Drawing.Size(309, 21);
            this.targetRelativeLocation.TabIndex = 11;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(14, 298);
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.resultBox.Size = new System.Drawing.Size(496, 132);
            this.resultBox.TabIndex = 14;
            this.resultBox.Text = "";
            // 
            // noRepeatCheckBox
            // 
            this.noRepeatCheckBox.AutoSize = true;
            this.noRepeatCheckBox.Location = new System.Drawing.Point(14, 436);
            this.noRepeatCheckBox.Name = "noRepeatCheckBox";
            this.noRepeatCheckBox.Size = new System.Drawing.Size(72, 16);
            this.noRepeatCheckBox.TabIndex = 15;
            this.noRepeatCheckBox.Text = "结果去重";
            this.noRepeatCheckBox.UseVisualStyleBackColor = true;
            this.noRepeatCheckBox.CheckedChanged += new System.EventHandler(this.noRepeatCheckBox_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(435, 436);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "清除";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(14, 256);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(75, 23);
            this.openFileBtn.TabIndex = 17;
            this.openFileBtn.Text = "目标文件";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(95, 261);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(0, 12);
            this.fileLabel.TabIndex = 12;
            // 
            // framLogFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 461);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.noRepeatCheckBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.findBtn);
            this.MaximumSize = new System.Drawing.Size(538, 500);
            this.MinimumSize = new System.Drawing.Size(538, 500);
            this.Name = "framLogFinder";
            this.Text = "日志查找工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetRelativeLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.TextBox identifyWordTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox identifyRegexTxtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetRegexTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targetLineWithWordTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.NumericUpDown targetRelativeLocation;
        private System.Windows.Forms.CheckBox noRepeatCheckBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label fileLabel;
    }
}

