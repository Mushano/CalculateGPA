namespace 加权平均
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxSub = new System.Windows.Forms.TextBox();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCalGPA = new System.Windows.Forms.Label();
            this.labelCalAve = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(270, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 199);
            this.listBox1.TabIndex = 0;
            // 
            // textBoxSub
            // 
            this.textBoxSub.Location = new System.Drawing.Point(91, 40);
            this.textBoxSub.Name = "textBoxSub";
            this.textBoxSub.Size = new System.Drawing.Size(108, 25);
            this.textBoxSub.TabIndex = 1;
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Location = new System.Drawing.Point(91, 81);
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(108, 25);
            this.textBoxCredit.TabIndex = 2;
            this.textBoxCredit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCredit_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCredit);
            this.groupBox1.Controls.Add(this.textBoxSub);
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 198);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "分数";
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(91, 121);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(108, 25);
            this.textBoxScore.TabIndex = 5;
            this.textBoxScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxScore_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "学分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "课程名";
            // 
            // labelCalGPA
            // 
            this.labelCalGPA.AutoSize = true;
            this.labelCalGPA.Location = new System.Drawing.Point(53, 272);
            this.labelCalGPA.Name = "labelCalGPA";
            this.labelCalGPA.Size = new System.Drawing.Size(39, 15);
            this.labelCalGPA.TabIndex = 4;
            this.labelCalGPA.Text = "GPA:";
            // 
            // labelCalAve
            // 
            this.labelCalAve.AutoSize = true;
            this.labelCalAve.Location = new System.Drawing.Point(267, 272);
            this.labelCalAve.Name = "labelCalAve";
            this.labelCalAve.Size = new System.Drawing.Size(90, 15);
            this.labelCalAve.TabIndex = 5;
            this.labelCalAve.Text = "加权平均值:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "By 黄延彬";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.BackgroundImage")));
            this.buttonOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOpenFile.Location = new System.Drawing.Point(34, 2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(29, 33);
            this.buttonOpenFile.TabIndex = 7;
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 322);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelCalAve);
            this.Controls.Add(this.labelCalGPA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "绩点加权平均值计算";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxSub;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCalGPA;
        private System.Windows.Forms.Label labelCalAve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOpenFile;
    }
}

