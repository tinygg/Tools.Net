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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(framLogFinder));
            this.findBtn = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.noRepeatCheckBox = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.targetRelativeLocation = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.targetLineWithWordTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.targetRegexTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.identifyRegexTxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.identifyWordTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.multiLineRegexBox = new System.Windows.Forms.TextBox();
            this.GetIndexTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetRelativeLocation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 238);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "行匹配";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.targetRelativeLocation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.targetLineWithWordTxtBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.targetRegexTxtBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 113);
            this.groupBox2.TabIndex = 15;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "包含";
            // 
            // targetLineWithWordTxtBox
            // 
            this.targetLineWithWordTxtBox.Location = new System.Drawing.Point(142, 58);
            this.targetLineWithWordTxtBox.Name = "targetLineWithWordTxtBox";
            this.targetLineWithWordTxtBox.Size = new System.Drawing.Size(309, 21);
            this.targetLineWithWordTxtBox.TabIndex = 7;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "提取正则";
            // 
            // targetRegexTxtBox
            // 
            this.targetRegexTxtBox.Location = new System.Drawing.Point(142, 86);
            this.targetRegexTxtBox.Name = "targetRegexTxtBox";
            this.targetRegexTxtBox.Size = new System.Drawing.Size(309, 21);
            this.targetRegexTxtBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.identifyRegexTxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.identifyWordTxtBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 84);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "标识行";
            // 
            // identifyRegexTxtbox
            // 
            this.identifyRegexTxtbox.Location = new System.Drawing.Point(142, 52);
            this.identifyRegexTxtbox.Name = "identifyRegexTxtbox";
            this.identifyRegexTxtbox.Size = new System.Drawing.Size(309, 21);
            this.identifyRegexTxtbox.TabIndex = 4;
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
            // identifyWordTxtBox
            // 
            this.identifyWordTxtBox.Location = new System.Drawing.Point(142, 25);
            this.identifyWordTxtBox.Name = "identifyWordTxtBox";
            this.identifyWordTxtBox.Size = new System.Drawing.Size(309, 21);
            this.identifyWordTxtBox.TabIndex = 2;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.GetIndexTxtBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.multiLineRegexBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "跨行匹配";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "提取正则";
            // 
            // multiLineRegexBox
            // 
            this.multiLineRegexBox.Location = new System.Drawing.Point(19, 28);
            this.multiLineRegexBox.Multiline = true;
            this.multiLineRegexBox.Name = "multiLineRegexBox";
            this.multiLineRegexBox.Size = new System.Drawing.Size(443, 132);
            this.multiLineRegexBox.TabIndex = 11;
            this.multiLineRegexBox.Text = "(//trace_start:(\\d{1,})[\\S\\s]*?//trace_end:\\2)";
            // 
            // GetIndexTxtBox
            // 
            this.GetIndexTxtBox.Location = new System.Drawing.Point(419, 166);
            this.GetIndexTxtBox.Multiline = true;
            this.GetIndexTxtBox.Name = "GetIndexTxtBox";
            this.GetIndexTxtBox.Size = new System.Drawing.Size(43, 22);
            this.GetIndexTxtBox.TabIndex = 12;
            this.GetIndexTxtBox.Text = "1";
            this.GetIndexTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "提取项";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "提示:?懒惰匹配符,防止贪婪匹配一次匹配到底！";
            // 
            // framLogFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 462);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.noRepeatCheckBox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.findBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(538, 500);
            this.MinimumSize = new System.Drawing.Size(538, 500);
            this.Name = "framLogFinder";
            this.Text = "日志查找工具";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetRelativeLocation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.CheckBox noRepeatCheckBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown targetRelativeLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox targetLineWithWordTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox targetRegexTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox identifyRegexTxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox identifyWordTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox multiLineRegexBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GetIndexTxtBox;
        private System.Windows.Forms.Label label8;
    }
}

