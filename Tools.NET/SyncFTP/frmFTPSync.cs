using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnterpriseDT.Net.Ftp.Sync;
using log4net;
using log4net.Repository.Hierarchy;

namespace SyncFTP
{
    public partial class frmFTPSync : Form
    {
        private SyncClient client = null;
        private ILog log = log4net.LogManager.GetLogger("frmFTPSync");
        public frmFTPSync()
        {
            InitializeComponent();
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
            if (sync_local_dir == string.Empty)
            {
                MessageBox.Show("请选择本地目录");
                return;
            }

            string address = this.ipBox.Text;
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("请填写FTP地址");
                return;
            }

            string port = this.portBox.Text;
            if (string.IsNullOrEmpty(port))
            {
                port = "21";
            }

            string user_name = this.user_name_box.Text;
            string passsword = this.password_box.Text;

            string remote_dir = this.remote_dir.Text;
            if (string.IsNullOrEmpty(remote_dir))
            {
                remote_dir = "/";
            }

            client = new SyncClient(address, port, user_name,
                                                passsword,
                                                this.sync_local_dir, null,
                                                remote_dir, this.deleteRemoteCheckBox.Checked);

            client.PrintEventHandler -= Print;
            client.PrintEventHandler += Print;

            int interval = 10;
            if (int.TryParse(this.intervalBox.Text, out interval))
            {
                if (!client.Start(interval))
                {
                    MessageBox.Show("启动失败,请检查FTP地址是否正确！");
                }
            }
            else
            {
                MessageBox.Show("请填写正确的同步间隔！");
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

            //保存配置 TODO

        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                client.Stop();
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

        string sync_local_dir = string.Empty;
        private void local_choose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sync_local_dir = dialog.SelectedPath;
                Print("设定本地保存路径为:" + sync_local_dir);
            }
        }

        public void Print(string txt)
        {
            string msg = DateTime.Now.ToString() + Environment.NewLine;
            msg += txt + Environment.NewLine;
            if (this.logBox.InvokeRequired)
            {
                Action<string> delegate_ = (x) => {
                    if (this.logBox.Lines.Count() > 1000)
                    {
                        this.logBox.Clear();
                    }
                    this.logBox.AppendText(x); 
                };
                this.logBox.Invoke(delegate_, msg);
            }
            else
            {
                if (this.logBox.Lines.Count() > 1000)
                {
                    this.logBox.Clear();
                }
                this.logBox.AppendText(msg);
            }
            log.Info(msg);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.logBox.Clear();
        }


    }
}
