namespace Bilibili_DataTools
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_videoCount = new System.Windows.Forms.Label();
            this.lb_playCount = new System.Windows.Forms.Label();
            this.lb_follower = new System.Windows.Forms.Label();
            this.lb_userName = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_Dns = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightPink;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1084, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "哔哩哔哩";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(961, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "导出EXCEL";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(24, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1040, 362);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据区";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(19, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(912, 325);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "序号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "视频名称";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "视频ID";
            this.columnHeader3.Width = 169;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "视频日期";
            this.columnHeader4.Width = 163;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "播放量";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(937, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 25);
            this.button3.TabIndex = 4;
            this.button3.Text = "点赞排序";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(937, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "时间降序";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_videoCount);
            this.groupBox2.Controls.Add(this.lb_playCount);
            this.groupBox2.Controls.Add(this.lb_follower);
            this.groupBox2.Controls.Add(this.lb_userName);
            this.groupBox2.Controls.Add(this.pb_logo);
            this.groupBox2.Location = new System.Drawing.Point(791, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户信息";
            // 
            // lb_videoCount
            // 
            this.lb_videoCount.AutoSize = true;
            this.lb_videoCount.Location = new System.Drawing.Point(108, 84);
            this.lb_videoCount.Name = "lb_videoCount";
            this.lb_videoCount.Size = new System.Drawing.Size(67, 15);
            this.lb_videoCount.TabIndex = 4;
            this.lb_videoCount.Text = "视频量：";
            // 
            // lb_playCount
            // 
            this.lb_playCount.AutoSize = true;
            this.lb_playCount.Location = new System.Drawing.Point(108, 64);
            this.lb_playCount.Name = "lb_playCount";
            this.lb_playCount.Size = new System.Drawing.Size(67, 15);
            this.lb_playCount.TabIndex = 3;
            this.lb_playCount.Text = "播放量：";
            // 
            // lb_follower
            // 
            this.lb_follower.AutoSize = true;
            this.lb_follower.Location = new System.Drawing.Point(108, 44);
            this.lb_follower.Name = "lb_follower";
            this.lb_follower.Size = new System.Drawing.Size(67, 15);
            this.lb_follower.TabIndex = 2;
            this.lb_follower.Text = "粉丝量：";
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Location = new System.Drawing.Point(108, 24);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(67, 15);
            this.lb_userName.TabIndex = 1;
            this.lb_userName.Text = "用户名：";
            // 
            // pb_logo
            // 
            this.pb_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_logo.Location = new System.Drawing.Point(18, 24);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(84, 76);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btn_Dns);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Location = new System.Drawing.Point(24, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作区";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(19, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(719, 49);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "视频总览：";
            // 
            // btn_Dns
            // 
            this.btn_Dns.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Dns.Location = new System.Drawing.Point(606, 34);
            this.btn_Dns.Name = "btn_Dns";
            this.btn_Dns.Size = new System.Drawing.Size(132, 25);
            this.btn_Dns.TabIndex = 1;
            this.btn_Dns.Text = "分析";
            this.btn_Dns.UseVisualStyleBackColor = true;
            this.btn_Dns.Click += new System.EventHandler(this.btn_Dns_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(19, 34);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(580, 25);
            this.tb_Name.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1084, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "抖音";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "点赞量";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "硬币量";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "收藏量";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "分享量";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "评论量";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "弹幕量";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1116, 586);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilibili DataTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Dns;
        private System.Windows.Forms.Label lb_playCount;
        private System.Windows.Forms.Label lb_follower;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_videoCount;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}

