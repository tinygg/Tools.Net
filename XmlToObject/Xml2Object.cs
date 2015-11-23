using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using log4net;
using System.Threading;

namespace XmlToObject
{
    public partial class Xml2Object : Form
    {
        private ILog log = LogManager.GetLogger("Xml2Object");

        private string title = "XMl转对象==>提取XML";
        private string path = string.Empty;

        public Xml2Object()
        {
            InitializeComponent();
            this.Text = title;
        }



        private void chooseBtn_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;

            OpenFileDialog odf = new OpenFileDialog();
            odf.Filter = "文本文件(*.xml)|*.xml|所有文件(*.*)|*.*";
            if (odf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = odf.FileName;
                temp = this.title + " - " + path;
            }
            else
            {
                this.path = "";
                temp = this.title;
                this.oldTree.Nodes.Clear();
                this.newTree.Nodes.Clear();
            }
            this.Text = temp;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            this.oldTree.Nodes.Clear();
            this.newTree.Nodes.Clear();
            if (string.IsNullOrEmpty(this.path))
            {
                MessageBox.Show("请选择XML");
            }
            else
            {
                LoadXML();
            }
        }

        XmlDocument doc = null;
        private void LoadXML()
        {
            doc = new XmlDocument();
            doc.Load(this.path);
            if (doc.HasChildNodes)
            {
                foreach (XmlNode item in doc.ChildNodes)
                {
                    LoadChildToTree(this.oldTree.Nodes, item);
                }
            }
        }

        private void LoadChildToTree(TreeNodeCollection treeNodeCollection, XmlNode node)
        {
            if (node.Name == "Post")
            {
                Console.WriteLine(node.ChildNodes.Count);
            }
            TreeNode thisParentNode = treeNodeCollection.Add(node.Value, node.Name);
            if (node.HasChildNodes)
            {
                foreach (XmlNode item in node.ChildNodes)
                {
                    LoadChildToTree(thisParentNode.Nodes, item);
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this.oldTree.SelectedNode;
            if (null != selectedNode)
            {
                string xpath = selectedNode.FullPath.Replace("\\", "/"); ;
                this.newTree.Nodes.Add(xpath);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (this.newTree.SelectedNode != null)
            {
                this.newTree.Nodes.Remove(this.newTree.SelectedNode);
            }
        }

        private void setRootMenu_Click(object sender, EventArgs e)
        {
            if (this.oldTree.SelectedNode != null)
            {
                this.rootLabel.Text = this.oldTree.SelectedNode.FullPath.Replace("\\", "/"); ;
                this.rootLabel.Tag = this.oldTree.SelectedNode;
            }
        }

        private void jsonBtn_Click(object sender, EventArgs e)
        {
            //List<JObject> rlt = new List<JObject>();
            if (!string.IsNullOrEmpty(this.rootLabel.Text) && this.newTree.Nodes.Count > 0)
            {
                XmlNodeList findList = doc.SelectNodes(this.rootLabel.Text);

                this.progressBar1.Maximum = findList.Count;

                Thread fThread = new Thread(new ParameterizedThreadStart(DoWork));//开辟一个新的线程
                fThread.Start(findList);
            }

            this.logBox.Text = ("");
        }

        private StringBuilder sb = new StringBuilder();
        private void DoWork(object p)
        {
            XmlNodeList findList = (XmlNodeList)p;
            for (int j = 1; j <= findList.Count; j++)
            {
                //属性
                JObject obj = new JObject();
                for (int i = 0; i < newTree.Nodes.Count; i++)
                {
                    TreeNode item = newTree.Nodes[i];

                    string replaceStr = this.rootLabel.Text;
                    string tmp_xpath = item.Text.Replace(replaceStr, replaceStr + "[" + (j + 1) + "]");
                    //XmlNodeList tmp = node.SelectNodes(tmp_xpath);
                    XmlNodeList tmp = doc.SelectNodes(tmp_xpath);

                    string key = string.Empty;
                    Regex keyRegex = new Regex("/(.*)$");
                    Match keyMatch = keyRegex.Match(item.Text);
                    if (keyMatch.Success)
                    {
                        if (tmp.Count == 1)
                        {
                            string name = tmp[0].Name;


                            if (name.ToLower() == "createtime")
                            {
                                string value = tmp[0].InnerText;
                                obj.Add(new JProperty(name, value));

                                DateTime dt = new DateTime((long)Convert.ToUInt64(value) * 10000 + 621355968000000000);
                                string date_str = dt.ToString("yyyy-MM-dd");
                                string url = "/post/" + date_str + "/" + obj.GetValue("Id");
                                obj.Add(new JProperty("Url", url));
                            }
                            else
                            {
                                string value = tmp[0].InnerText;
                                obj.Add(new JProperty(name, value));
                            }
                        }
                        else
                        {
                            string name = keyMatch.Groups[1].Value;
                            obj.Add(new JProperty(name, string.Empty));
                        }
                    }
                }
                string newLine = obj.ToString() + Environment.NewLine;
                //newLine = string.Format("db.post.insert({0});" + Environment.NewLine, newLine);
                sb.Append(newLine);
                SetTextMessage(j, findList.Count, newLine);
                if (j % 10 == 0 || j == findList.Count)
                {
                    //WriteBuffLog(sb.ToString());
                    //sb.Clear();
                }
            }
            return;
        }

        private void WriteBuffLog(string sb)
        {
            if (this.InvokeRequired)
            {
                Action<string> setpos = (x) =>
                {
                    log.Info(x);
                };
                this.Invoke(setpos, new object[] { sb });
            }
            else
            {
                log.Info(sb);
            }
        }

        private void SetTextMessage(int index, int all, string newLine)
        {
            if (this.InvokeRequired)
            {
                Action<int> setpos = (x) =>
                {
                    this.progressNum.Text = index.ToString() + "/" + all;
                    this.progressBar1.Step = 1;
                    this.progressBar1.PerformStep();
                    this.logBox.AppendText(newLine);
                };
                this.Invoke(setpos, new object[] { index });
            }
            else
            {
                this.progressNum.Text = index.ToString() + "/" + all;
                this.progressBar1.Step = 1;
                this.progressBar1.PerformStep();
                this.logBox.AppendText(newLine);
            }
        }

        private void handleThenJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "mg";
            sfd.FileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm");
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, this.logBox.Text.Trim(), Encoding.UTF8);
            }
        }



    }
}
