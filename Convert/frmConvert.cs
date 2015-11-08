using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Convert
{
    public partial class frmConvert : Form
    {
        private string sep = " ";
        public frmConvert()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ↓↓↓↓↓↓↓↓
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toDownBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.upEdit.Text))
            {
                this.downEdit.Text = "";
                var t = this.upEdit.Text;
                var bytes = System.Text.Encoding.UTF8.GetBytes(t);
                string template = "{0}:\t {1}" + Environment.NewLine;

                if (byte_check.Checked)
                {
                    var temp = bytes;// ConvertTo(bytes, 10, 2);

                    this.downEdit.Text += string.Format(template, "BYTES ", string.Join(sep, temp));
                }

                if (guid_check.Checked)
                {
                    var temp = Guid.NewGuid().ToString();

                    this.downEdit.Text += string.Format(template, "GUID  ", temp);
                }

                if (url_check.Checked)
                {
                    var temp = System.Web.HttpUtility.UrlDecode(t);

                    this.downEdit.Text += string.Format(template, "URL   ", temp);
                }

                if (ascii_check.Checked)
                {
                    var temp = bytes;

                    this.downEdit.Text += string.Format(template, "ASCII ", string.Join(sep, temp));
                }

                if (ffff_check.Checked)
                {
                    var temp = ConvertTo(bytes, 10, 16);

                    this.downEdit.Text += string.Format(template, "HEX   ", string.Join(sep, temp));
                }

                if (bin_check.Checked)
                {
                    var temp = ConvertTo(bytes, 10, 2);

                    this.downEdit.Text += string.Format(template, "BINARY", string.Join(sep, temp));
                }

                //如只勾选ffff和0101 则添加一行
                if (bin_check.Checked && ffff_check.Checked && //其他不勾选
                    !ascii_check.Checked && !url_check.Checked &&
                    !guid_check.Checked && !byte_check.Checked)
                {
                    int f = -1;
                    if (int.TryParse(t, out f))
                    {
                        this.downEdit.Text = "";//清空一下

                        var temp = System.Convert.ToString(f, 2);

                        this.downEdit.Text += string.Format(template, "HEX-BIN", temp);
                    }
                    //否则就按照字符来转ASCII码,再转10,2进制
                }

            }

        }

        /// <summary>
        /// ↑↑↑↑↑↑↑↑↑↑↑↑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toUpBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.downEdit.Text))
            {
                this.upEdit.Text = "";

                var codes = this.downEdit.Text.Trim();
                if (byte_check.Checked)
                {
                    string[] bytesArray = codes.Split(new string[] { sep.Trim() }, StringSplitOptions.None);
                    byte[] bytes = new byte[bytesArray.Length];
                    for (int i = 0; i < bytesArray.Length; i++)
                    {
                        bytes[i] = System.Convert.ToByte(bytesArray[i].Trim());
                    }

                    this.upEdit.Text += System.Text.Encoding.UTF8.GetString(bytes) + Environment.NewLine;
                }

                if (guid_check.Checked)
                {

                }

                if (url_check.Checked)
                {

                }

                if (ascii_check.Checked)
                {

                }

                if (ffff_check.Checked)
                {

                }

                if (bin_check.Checked)
                {

                }
            }
        }

        /// <summary>
        /// New
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// copy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyBtn_Click(object sender, EventArgs e)
        {

        }

        #region 公共方法
        public List<string> ConvertTo(Array from, int fromType, int toType)
        {
            List<string> rlt = new List<string>();
            if (fromType == 10 && toType == 2)
            {
                foreach (var item in from)
                {
                    int tmp = System.Convert.ToInt32(item.ToString());
                    rlt.Add(System.Convert.ToString(tmp, 2));
                }
            }
            else if (fromType == 10 && toType == 16)
            {
                foreach (var item in from)
                {
                    int tmp = System.Convert.ToInt32(item.ToString());
                    rlt.Add(System.Convert.ToString(tmp, 16));
                }
            }
            return rlt;
        }
        #endregion

        private void upEdit_TextChanged(object sender, EventArgs e)
        {
            this.upSizeLabel.Text = "Size：" + this.upEdit.Text.Length;
        }

        private void downEdit_TextChanged(object sender, EventArgs e)
        {
            this.downSizeLabel.Text = "Size：" + this.downEdit.Text.Length;
        }

        private void commaSplitCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (commaSplitCheck.Checked)
            {
                sep = ",";
            }
            else
            {
                sep = " ";
            }
        }


    }
}
