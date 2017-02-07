using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;

namespace LogFinder
{
    public partial class framLogFinder : Form
    {
        

        string contentText = "";
        List<string> lineList = new List<string>();
        List<string> targetList = new List<string>();
        public framLogFinder()
        {
            InitializeComponent();

            this.tabControl1.SelectedIndex = 1;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.resultBox.Text = "";
        }

        private void findBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.fileLabel.Text))
            {
                MessageBox.Show("请选择一个文件！");
            }
            else if (!File.Exists(this.fileLabel.Text))
            {
                MessageBox.Show("文件不存在！");
            }
            else
            {
                //1.清空上次查询结果
                this.targetList.Clear();
                int get_index = Convert.ToInt32(this.GetIndexTxtBox.Text.Trim());

                if (this.tabControl1.SelectedTab.Text == "跨行匹配")
                {
                    this.contentText = File.ReadAllText(this.fileLabel.Text.Trim(),
                        FileEncodingUtil.GetEncoding(this.fileLabel.Text.Trim())
                        );

                    string target_regex = this.multiLineRegexBox.Text.Trim();

                    Match match = null;
                    try
                    {
                        match = Regex.Match(this.contentText, target_regex, RegexOptions.Multiline);
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("提取行，正则异常！" + e1.Message);
                        return;
                    }

                    while (match.Success)
                    {
                        if (match.Groups.Count >= get_index+1)
                        {
                            string matched_str = match.Groups[get_index].Value;
                            this.targetList.Add(matched_str);
                        }
                        else
                        {
                            this.targetList.Add("-");
                        }
                        match = match.NextMatch();
                    }
                    
                }
                else
                {
                    //2.读取文件
                    this.lineList = File.ReadAllLines(this.fileLabel.Text.Trim(),
                        FileEncodingUtil.GetEncoding(this.fileLabel.Text.Trim())
                        ).ToList<string>();
                    //3.开始匹配
                    string id_txt = this.identifyWordTxtBox.Text.Trim();
                    string id_regex = this.identifyRegexTxtbox.Text.Trim();

                    int index = 0;
                    int lineCount = this.lineList.Count;
                    while (index >= 0 && index < lineCount)
                    {
                        string id_line = this.lineList[index];

                        if (!string.IsNullOrEmpty(id_txt) && string.IsNullOrEmpty(id_regex))
                        {
                            //只有包含，无正则
                            if (!id_line.Contains(id_txt))
                            {
                                index++;
                                continue;
                            }
                            //go to match
                        }
                        else if (string.IsNullOrEmpty(id_txt) && !string.IsNullOrEmpty(id_regex))
                        {
                            //无包含，只有正则
                            try
                            {
                                if (!Regex.IsMatch(id_line, id_regex))
                                {
                                    index++;
                                    continue;
                                }
                            }
                            catch (Exception e1)
                            {
                                MessageBox.Show("标识行，正则异常！" + e1.Message);
                            }

                            //go to match
                        }
                        else if (!string.IsNullOrEmpty(id_txt) && !string.IsNullOrEmpty(id_regex))
                        {
                            //包含+正则
                            if (id_line.Contains(id_txt) && Regex.IsMatch(id_line, id_regex))
                            {
                                //go to match
                            }
                            else
                            {
                                index++;
                                continue;
                            }
                        }
                        else if (string.IsNullOrEmpty(id_regex) && string.IsNullOrEmpty(id_txt))
                        {
                            //go to match directly
                        }
                        else
                        {
                            break;
                        }

                        //target line 
                        string target_line = string.Empty;
                        int move_index = (int)this.targetRelativeLocation.Value;
                        if (move_index + index >= 0 && move_index + index < lineList.Count)
                        {
                            target_line = this.lineList[move_index + index];

                            string target_txt = this.targetLineWithWordTxtBox.Text.Trim();
                            string target_regex = this.targetRegexTxtBox.Text.Trim();
                            if (string.IsNullOrEmpty(target_txt) || target_line.Contains(target_txt))
                            {
                                if (string.IsNullOrEmpty(target_regex))
                                {
                                    this.targetList.Add(target_line);
                                }
                                else
                                {
                                    Match match = null;
                                    try
                                    {
                                        match = Regex.Match(target_line, target_regex);
                                    }
                                    catch (Exception e1)
                                    {
                                        MessageBox.Show("提取行，正则异常！" + e1.Message);
                                        return;
                                    }

                                    if (match.Success)
                                    {
                                        if (match.Groups.Count >= 2)
                                        {
                                            string matched_str = string.Empty;
                                            for (int j = 1; j < match.Groups.Count; j++)
                                            {
                                                matched_str += match.Groups[j];
                                            }
                                            this.targetList.Add(matched_str);
                                        }
                                        else
                                        {
                                            this.targetList.Add("-");
                                        }
                                    }
                                }
                            }

                            index++;
                            continue;
                        }
                        else
                        {
                            index++;
                            continue;
                        }
                    }
                }

            }


            //显示结果
            this.noRepeatCheckBox_CheckedChanged(null, new EventArgs());
        }

        private void SaveConfig()
        {

        }

        /// <summary>
        /// 是否去重
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noRepeatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.noRepeatCheckBox.Checked)
            {
                List<string> temp = new List<string>();
                foreach (var txt in targetList)
                {
                    if (!temp.Contains(txt))
                    {
                        temp.Add(txt);
                    }
                }
                this.resultBox.Text = string.Join(Environment.NewLine, temp);
            }
            else
            {
                this.resultBox.Text = string.Join(Environment.NewLine, targetList);
            }
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.fileLabel.Text = ofd.FileName;
            }
        }


    }
}
