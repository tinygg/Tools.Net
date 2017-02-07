using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
namespace RegexTool
{
    public partial class frmRegex : Form
    {
        Configuration config = null;
        public frmRegex()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (null != config && null != config.AppSettings.Settings["LAST_MSG"] && null != config.AppSettings.Settings["LAST_REGEX"])
            {
                string last = config.AppSettings.Settings["LAST_MSG"].Value;
                string regex = config.AppSettings.Settings["LAST_REGEX"].Value;

                this.msgTxtbox.Text = last;
                this.regexTxtbox.Text = regex;
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            string msg = "";
            Match match = Regex.Match(this.msgTxtbox.Text, this.regexTxtbox.Text);
            if (match.Success)
            {
                msg = "OK" + Environment.NewLine;
                for (int i = 0; i < match.Groups.Count; i++)
                {
                    msg += match.Groups[i] + Environment.NewLine;
                }
            }
            else
            {
                msg = "FAIL" + Environment.NewLine;
            }
            this.rlt_Txtbox.Text = msg;

            //保存最后测试
            if (null != config && null != config.AppSettings.Settings["LAST_MSG"] && null != config.AppSettings.Settings["LAST_REGEX"])
            {
                config.AppSettings.Settings["LAST_MSG"].Value = this.msgTxtbox.Text;
                config.AppSettings.Settings["LAST_REGEX"].Value = this.regexTxtbox.Text;
                config.Save(ConfigurationSaveMode.Modified);
            }
        }
    }
}
