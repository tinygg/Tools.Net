namespace XmlToObject
{
    partial class Xml2Object
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xml2Object));
            this.oldTree = new System.Windows.Forms.TreeView();
            this.oldTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setRootMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newTree = new System.Windows.Forms.TreeView();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.chooseBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.jsonBtn = new System.Windows.Forms.Button();
            this.handleThenJson = new System.Windows.Forms.Button();
            this.sureBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rootLabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressNum = new System.Windows.Forms.Label();
            this.oldTreeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // oldTree
            // 
            this.oldTree.ContextMenuStrip = this.oldTreeMenu;
            this.oldTree.Location = new System.Drawing.Point(12, 42);
            this.oldTree.Name = "oldTree";
            this.oldTree.Size = new System.Drawing.Size(285, 447);
            this.oldTree.TabIndex = 0;
            // 
            // oldTreeMenu
            // 
            this.oldTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRootMenu});
            this.oldTreeMenu.Name = "oldTreeMenu";
            this.oldTreeMenu.Size = new System.Drawing.Size(137, 26);
            // 
            // setRootMenu
            // 
            this.setRootMenu.Name = "setRootMenu";
            this.setRootMenu.Size = new System.Drawing.Size(136, 22);
            this.setRootMenu.Text = "设为根节点";
            this.setRootMenu.Click += new System.EventHandler(this.setRootMenu_Click);
            // 
            // newTree
            // 
            this.newTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newTree.Location = new System.Drawing.Point(352, 42);
            this.newTree.Name = "newTree";
            this.newTree.Size = new System.Drawing.Size(408, 447);
            this.newTree.TabIndex = 1;
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.Location = new System.Drawing.Point(766, 42);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(29, 447);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = " X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X  X " +
    " X  X  X  X  X  X  X  X  X  X  X ";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(303, 42);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(43, 447);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "---->---->---->---->---->---->---->---->---->---->---->---->---->---->---->---->-" +
    "--->---->---->---->---->---->---->---->---->---->---->---->---->---->---->---->-" +
    "--->---->---->---->---->---->";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // chooseBtn
            // 
            this.chooseBtn.Location = new System.Drawing.Point(13, 13);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(75, 23);
            this.chooseBtn.TabIndex = 3;
            this.chooseBtn.Text = "选择";
            this.chooseBtn.UseVisualStyleBackColor = true;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(94, 12);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 4;
            this.loadBtn.Text = "加载";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(810, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "属性名";
            // 
            // jsonBtn
            // 
            this.jsonBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.jsonBtn.Location = new System.Drawing.Point(801, 500);
            this.jsonBtn.Name = "jsonBtn";
            this.jsonBtn.Size = new System.Drawing.Size(98, 23);
            this.jsonBtn.TabIndex = 7;
            this.jsonBtn.Text = "生成JSON数据";
            this.jsonBtn.UseVisualStyleBackColor = true;
            this.jsonBtn.Click += new System.EventHandler(this.jsonBtn_Click);
            // 
            // handleThenJson
            // 
            this.handleThenJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.handleThenJson.Location = new System.Drawing.Point(801, 529);
            this.handleThenJson.Name = "handleThenJson";
            this.handleThenJson.Size = new System.Drawing.Size(98, 23);
            this.handleThenJson.TabIndex = 8;
            this.handleThenJson.Text = "导出文件";
            this.handleThenJson.UseVisualStyleBackColor = true;
            this.handleThenJson.Click += new System.EventHandler(this.handleThenJson_Click);
            // 
            // sureBtn
            // 
            this.sureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureBtn.Location = new System.Drawing.Point(871, 92);
            this.sureBtn.Name = "sureBtn";
            this.sureBtn.Size = new System.Drawing.Size(39, 23);
            this.sureBtn.TabIndex = 9;
            this.sureBtn.Text = "确认";
            this.sureBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "根节点";
            // 
            // rootLabel
            // 
            this.rootLabel.AutoSize = true;
            this.rootLabel.Location = new System.Drawing.Point(399, 22);
            this.rootLabel.Name = "rootLabel";
            this.rootLabel.Size = new System.Drawing.Size(29, 12);
            this.rootLabel.TabIndex = 12;
            this.rootLabel.Text = "root";
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logBox.Location = new System.Drawing.Point(12, 501);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(783, 68);
            this.logBox.TabIndex = 13;
            this.logBox.Text = ".............";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 575);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(895, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // progressNum
            // 
            this.progressNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressNum.AutoSize = true;
            this.progressNum.Location = new System.Drawing.Point(867, 557);
            this.progressNum.Name = "progressNum";
            this.progressNum.Size = new System.Drawing.Size(23, 12);
            this.progressNum.TabIndex = 15;
            this.progressNum.Text = "0/1";
            // 
            // Xml2Object
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 605);
            this.Controls.Add(this.progressNum);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.rootLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sureBtn);
            this.Controls.Add(this.handleThenJson);
            this.Controls.Add(this.jsonBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.chooseBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.newTree);
            this.Controls.Add(this.oldTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Xml2Object";
            this.oldTreeMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView oldTree;
        private System.Windows.Forms.TreeView newTree;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button jsonBtn;
        private System.Windows.Forms.Button handleThenJson;
        private System.Windows.Forms.Button sureBtn;
        private System.Windows.Forms.ContextMenuStrip oldTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem setRootMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rootLabel;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label progressNum;
    }
}

