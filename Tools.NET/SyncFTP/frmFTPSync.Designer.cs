namespace SyncFTP
{
    partial class frmFTPSync
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFTPSync));
            this.start_btn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.stop_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.user_name_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.local_choose = new System.Windows.Forms.Button();
            this.remote_dir = new System.Windows.Forms.TextBox();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteRemoteCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.start_btn.Location = new System.Drawing.Point(2, 235);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(65, 23);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "开始同步";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(147, 2);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(363, 256);
            this.logBox.TabIndex = 2;
            this.logBox.Text = "";
            // 
            // stop_btn
            // 
            this.stop_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stop_btn.Location = new System.Drawing.Point(73, 235);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(56, 23);
            this.stop_btn.TabIndex = 3;
            this.stop_btn.Text = "停  止";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP地址";
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(2, 18);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(127, 21);
            this.ipBox.TabIndex = 5;
            this.ipBox.Text = "172.16.1.114";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "端口";
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(4, 61);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(39, 21);
            this.portBox.TabIndex = 7;
            this.portBox.Text = "2121";
            // 
            // user_name_box
            // 
            this.user_name_box.Location = new System.Drawing.Point(4, 104);
            this.user_name_box.Name = "user_name_box";
            this.user_name_box.Size = new System.Drawing.Size(50, 21);
            this.user_name_box.TabIndex = 9;
            this.user_name_box.Text = "dc_tel_in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "用户名";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(73, 104);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(56, 21);
            this.password_box.TabIndex = 11;
            this.password_box.Text = "dctel";
            this.password_box.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "密码";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clearBtn.Location = new System.Drawing.Point(135, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(10, 256);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "--------------";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "存储路径";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "远程路径";
            // 
            // local_choose
            // 
            this.local_choose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.local_choose.Location = new System.Drawing.Point(73, 187);
            this.local_choose.Name = "local_choose";
            this.local_choose.Size = new System.Drawing.Size(56, 23);
            this.local_choose.TabIndex = 15;
            this.local_choose.Text = "选  择";
            this.local_choose.UseVisualStyleBackColor = true;
            this.local_choose.Click += new System.EventHandler(this.local_choose_Click);
            // 
            // remote_dir
            // 
            this.remote_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.remote_dir.Location = new System.Drawing.Point(73, 211);
            this.remote_dir.Name = "remote_dir";
            this.remote_dir.Size = new System.Drawing.Size(56, 21);
            this.remote_dir.TabIndex = 16;
            this.remote_dir.Text = "/";
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(6, 156);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(39, 21);
            this.intervalBox.TabIndex = 18;
            this.intervalBox.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "同步间隔(s)";
            // 
            // deleteRemoteCheckBox
            // 
            this.deleteRemoteCheckBox.AutoSize = true;
            this.deleteRemoteCheckBox.Checked = true;
            this.deleteRemoteCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteRemoteCheckBox.Location = new System.Drawing.Point(55, 159);
            this.deleteRemoteCheckBox.Name = "deleteRemoteCheckBox";
            this.deleteRemoteCheckBox.Size = new System.Drawing.Size(72, 16);
            this.deleteRemoteCheckBox.TabIndex = 19;
            this.deleteRemoteCheckBox.Text = "删除远程";
            this.deleteRemoteCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmFTPSync
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.deleteRemoteCheckBox);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.remote_dir);
            this.Controls.Add(this.local_choose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_name_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.start_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFTPSync";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "==FTP.Sync== FTP同 步";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox user_name_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button local_choose;
        private System.Windows.Forms.TextBox remote_dir;
        private System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox deleteRemoteCheckBox;

    }
}

