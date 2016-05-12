using EnterpriseDT.Net.Ftp.Sync;
using log4net;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SyncFTP
{
	public class frmFTPSyncNewer : Form
	{
		private SyncClient client;

		private ILog log = LogManager.GetLogger("frmFTPSync");

		private string sync_local_dir = "D:/报文处理/AFTN_SITA";

		private IContainer components;

		private Button start_btn;

		private RichTextBox logBox;

		private Button stop_btn;

		private Label label1;

		private TextBox ipBox;

		private Label label2;

		private TextBox portBox;

		private TextBox user_name_box;

		private Label label3;

		private TextBox password_box;

		private Label label4;

		private Button clearBtn;

		private Label label5;

		private Label label6;

		private Button local_choose;

		private TextBox remote_dir;

		private TextBox intervalBox;

		private Label label7;

		private CheckBox deleteRemoteCheckBox;

		private TextBox LastUpdateTimeLbl;

		private Label label8;

		public frmFTPSyncNewer()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
		}

		private void start_btn_Click(object sender, EventArgs e)
		{
			if (this.sync_local_dir == string.Empty)
			{
				this.Print("请选择本地目录");
				return;
			}
			string text = this.ipBox.Text;
			if (string.IsNullOrEmpty(text))
			{
				this.Print("请填写FTP地址");
				return;
			}
			string text2 = this.portBox.Text;
			if (string.IsNullOrEmpty(text2))
			{
				text2 = "21";
			}
			string text3 = this.user_name_box.Text;
			string text4 = this.password_box.Text;
			string text5 = this.remote_dir.Text;
			if (string.IsNullOrEmpty(text5))
			{
				text5 = "/";
			}
			this.client = new SyncClient(text, text2, text3, text4, this.sync_local_dir, null, text5, this.deleteRemoteCheckBox.Checked);
			SyncClient expr_B6 = this.client;
			expr_B6.PrintEventHandler = (SyncClient.PrintLog)Delegate.Remove(expr_B6.PrintEventHandler, new SyncClient.PrintLog(this.Print));
			SyncClient expr_DD = this.client;
			expr_DD.PrintEventHandler = (SyncClient.PrintLog)Delegate.Combine(expr_DD.PrintEventHandler, new SyncClient.PrintLog(this.Print));
			int sync_interval_seconds = 10;
			if (int.TryParse(this.intervalBox.Text, out sync_interval_seconds))
			{
				if (!this.client.Start(sync_interval_seconds))
				{
					this.Print("启动失败,请检查FTP地址是否正确！");
				}
			}
			else
			{
				this.Print("请填写正确的同步间隔！");
			}
			this.deleteRemoteCheckBox.Enabled = false;
			this.ipBox.Enabled = false;
			this.portBox.Enabled = false;
			this.user_name_box.Enabled = false;
			this.password_box.Enabled = false;
			this.intervalBox.Enabled = false;
			this.local_choose.Enabled = false;
			this.remote_dir.Enabled = false;
			this.start_btn.Enabled = false;
			this.stop_btn.Enabled = true;
		}

		private void stop_btn_Click(object sender, EventArgs e)
		{
			if (this.client != null)
			{
				this.client.Stop();
				this.deleteRemoteCheckBox.Enabled = true;
				this.ipBox.Enabled = true;
				this.portBox.Enabled = true;
				this.user_name_box.Enabled = true;
				this.password_box.Enabled = true;
				this.intervalBox.Enabled = true;
				this.local_choose.Enabled = true;
				this.remote_dir.Enabled = true;
			}
			this.start_btn.Enabled = true;
			this.stop_btn.Enabled = false;
		}

		private void local_choose_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.sync_local_dir = folderBrowserDialog.SelectedPath;
				this.Print("设定本地保存路径为:" + this.sync_local_dir);
			}
		}

		public void Print(string txt)
		{
			string text = DateTime.Now.ToString() + Environment.NewLine;
			text = text + txt + Environment.NewLine;
			if (this.logBox.InvokeRequired)
			{
				Action<string> method = delegate(string x)
				{
					if (this.logBox.Lines.Count<string>() > 50)
					{
						this.logBox.Clear();
					}
					this.logBox.AppendText(x);
				};
				this.logBox.Invoke(method, new object[]
				{
					text
				});
			}
			else
			{
				if (this.logBox.Lines.Count<string>() > 50)
				{
					this.logBox.Clear();
				}
				this.logBox.AppendText(text);
			}
			string text2 = string.Format("{0}/{1}/{2} {3}:{4}:{5}", new object[]
			{
				DateTime.Now.Year,
				DateTime.Now.Month,
				DateTime.Now.Day,
				DateTime.Now.Hour,
				DateTime.Now.Minute,
				DateTime.Now.Second
			});
			if (this.LastUpdateTimeLbl.InvokeRequired)
			{
				Action<string> method2 = delegate(string x)
				{
					this.LastUpdateTimeLbl.Text = x;
				};
				this.LastUpdateTimeLbl.Invoke(method2, new object[]
				{
					text2
				});
			}
			else
			{
				this.LastUpdateTimeLbl.Text = text2;
			}
			this.log.Info(text);
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			this.logBox.Clear();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmFTPSync));
			this.start_btn = new Button();
			this.logBox = new RichTextBox();
			this.stop_btn = new Button();
			this.label1 = new Label();
			this.ipBox = new TextBox();
			this.label2 = new Label();
			this.portBox = new TextBox();
			this.user_name_box = new TextBox();
			this.label3 = new Label();
			this.password_box = new TextBox();
			this.label4 = new Label();
			this.clearBtn = new Button();
			this.label5 = new Label();
			this.label6 = new Label();
			this.local_choose = new Button();
			this.remote_dir = new TextBox();
			this.intervalBox = new TextBox();
			this.label7 = new Label();
			this.deleteRemoteCheckBox = new CheckBox();
			this.LastUpdateTimeLbl = new TextBox();
			this.label8 = new Label();
			base.SuspendLayout();
			this.start_btn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.start_btn.Location = new Point(2, 235);
			this.start_btn.Name = "start_btn";
			this.start_btn.Size = new Size(65, 23);
			this.start_btn.TabIndex = 1;
			this.start_btn.Text = "开始同步";
			this.start_btn.UseVisualStyleBackColor = true;
			this.start_btn.Click += new EventHandler(this.start_btn_Click);
			this.logBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.logBox.Location = new Point(147, 2);
			this.logBox.Name = "logBox";
			this.logBox.Size = new Size(363, 256);
			this.logBox.TabIndex = 2;
			this.logBox.Text = "";
			this.stop_btn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.stop_btn.Location = new Point(73, 235);
			this.stop_btn.Name = "stop_btn";
			this.stop_btn.Size = new Size(56, 23);
			this.stop_btn.TabIndex = 3;
			this.stop_btn.Text = "停  止";
			this.stop_btn.UseVisualStyleBackColor = true;
			this.stop_btn.Click += new EventHandler(this.stop_btn_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(2, 2);
			this.label1.Name = "label1";
			this.label1.Size = new Size(41, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "IP地址";
			this.ipBox.Location = new Point(2, 18);
			this.ipBox.Name = "ipBox";
			this.ipBox.Size = new Size(127, 21);
			this.ipBox.TabIndex = 5;
			this.ipBox.Text = "172.16.1.114";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(2, 46);
			this.label2.Name = "label2";
			this.label2.Size = new Size(29, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "端口";
			this.portBox.Location = new Point(4, 61);
			this.portBox.Name = "portBox";
			this.portBox.Size = new Size(39, 21);
			this.portBox.TabIndex = 7;
			this.portBox.Text = "2121";
			this.user_name_box.Location = new Point(4, 104);
			this.user_name_box.Name = "user_name_box";
			this.user_name_box.Size = new Size(50, 21);
			this.user_name_box.TabIndex = 9;
			this.user_name_box.Text = "dc_tel_in";
			this.label3.AutoSize = true;
			this.label3.Location = new Point(4, 88);
			this.label3.Name = "label3";
			this.label3.Size = new Size(41, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "用户名";
			this.password_box.Location = new Point(73, 104);
			this.password_box.Name = "password_box";
			this.password_box.Size = new Size(56, 21);
			this.password_box.TabIndex = 11;
			this.password_box.Text = "dctel";
			this.password_box.TextChanged += new EventHandler(this.textBox4_TextChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new Point(71, 88);
			this.label4.Name = "label4";
			this.label4.Size = new Size(29, 12);
			this.label4.TabIndex = 10;
			this.label4.Text = "密码";
			this.label4.Click += new EventHandler(this.label4_Click);
			this.clearBtn.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.clearBtn.Location = new Point(135, 2);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new Size(10, 256);
			this.clearBtn.TabIndex = 12;
			this.clearBtn.Text = "--------------";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new EventHandler(this.clearBtn_Click);
			this.label5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label5.AutoSize = true;
			this.label5.Location = new Point(4, 192);
			this.label5.Name = "label5";
			this.label5.Size = new Size(53, 12);
			this.label5.TabIndex = 13;
			this.label5.Text = "存储路径";
			this.label6.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label6.AutoSize = true;
			this.label6.Location = new Point(4, 214);
			this.label6.Name = "label6";
			this.label6.Size = new Size(53, 12);
			this.label6.TabIndex = 14;
			this.label6.Text = "远程路径";
			this.local_choose.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.local_choose.Location = new Point(73, 187);
			this.local_choose.Name = "local_choose";
			this.local_choose.Size = new Size(56, 23);
			this.local_choose.TabIndex = 15;
			this.local_choose.Text = "选  择";
			this.local_choose.UseVisualStyleBackColor = true;
			this.local_choose.Click += new EventHandler(this.local_choose_Click);
			this.remote_dir.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.remote_dir.Location = new Point(73, 211);
			this.remote_dir.Name = "remote_dir";
			this.remote_dir.Size = new Size(56, 21);
			this.remote_dir.TabIndex = 16;
			this.remote_dir.Text = "/";
			this.intervalBox.Location = new Point(6, 156);
			this.intervalBox.Name = "intervalBox";
			this.intervalBox.Size = new Size(39, 21);
			this.intervalBox.TabIndex = 18;
			this.intervalBox.Text = "3";
			this.label7.AutoSize = true;
			this.label7.Location = new Point(4, 141);
			this.label7.Name = "label7";
			this.label7.Size = new Size(71, 12);
			this.label7.TabIndex = 17;
			this.label7.Text = "同步间隔(s)";
			this.deleteRemoteCheckBox.AutoSize = true;
			this.deleteRemoteCheckBox.Checked = true;
			this.deleteRemoteCheckBox.CheckState = CheckState.Checked;
			this.deleteRemoteCheckBox.Location = new Point(55, 159);
			this.deleteRemoteCheckBox.Name = "deleteRemoteCheckBox";
			this.deleteRemoteCheckBox.Size = new Size(72, 16);
			this.deleteRemoteCheckBox.TabIndex = 19;
			this.deleteRemoteCheckBox.Text = "删除远程";
			this.deleteRemoteCheckBox.UseVisualStyleBackColor = true;
			this.LastUpdateTimeLbl.Location = new Point(55, 61);
			this.LastUpdateTimeLbl.Name = "LastUpdateTimeLbl";
			this.LastUpdateTimeLbl.Size = new Size(62, 21);
			this.LastUpdateTimeLbl.TabIndex = 20;
			this.label8.AutoSize = true;
			this.label8.Location = new Point(53, 46);
			this.label8.Name = "label8";
			this.label8.Size = new Size(53, 12);
			this.label8.TabIndex = 21;
			this.label8.Text = "更新时间";
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(513, 261);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.LastUpdateTimeLbl);
			base.Controls.Add(this.deleteRemoteCheckBox);
			base.Controls.Add(this.intervalBox);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.remote_dir);
			base.Controls.Add(this.local_choose);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.clearBtn);
			base.Controls.Add(this.password_box);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.user_name_box);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.portBox);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.ipBox);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.stop_btn);
			base.Controls.Add(this.logBox);
			base.Controls.Add(this.start_btn);
			//base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmFTPSync";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "==FTP.Sync== FTP同 步";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
