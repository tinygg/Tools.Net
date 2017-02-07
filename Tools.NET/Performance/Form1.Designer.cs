namespace Performance
{
    partial class Form1
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
            this.PDF2Word = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PDF2Word
            // 
            this.PDF2Word.Location = new System.Drawing.Point(97, 60);
            this.PDF2Word.Name = "PDF2Word";
            this.PDF2Word.Size = new System.Drawing.Size(75, 23);
            this.PDF2Word.TabIndex = 0;
            this.PDF2Word.Text = "PDF转Word";
            this.PDF2Word.UseVisualStyleBackColor = true;
            this.PDF2Word.Click += new System.EventHandler(this.PDF2Word_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 236);
            this.Controls.Add(this.PDF2Word);
            this.Name = "Form1";
            this.Text = "性能工具";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PDF2Word;
    }
}

