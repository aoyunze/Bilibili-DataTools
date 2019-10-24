using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Bilibili_DataTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//解除线程之间不能互相访问的限制（解除UI线程和其他线程之间不能访问的限制）
            listView1.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(listView1, true, null);//开启ListView的双缓冲
        }

        private void btn_Dns_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Dns);
            t.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 解析用户信息
        /// </summary>
        private void Dns()
        {
            listView1.Items.Clear();
            //UP主个人信息加载区
            string name = tb_Name.Text;
            Dictionary<string, string> userInfoDic = Tools.GetBilibiliUserInfo(name);
            pb_logo.ImageLocation = userInfoDic["头像"];
            lb_follower.Text = "粉丝量：" + userInfoDic["粉丝量"];
            lb_playCount.Text = "播放量：" + userInfoDic["播放量"];
            lb_userName.Text = "用户名：" + userInfoDic["用户名"];
            lb_videoCount.Text = "视频量：" + userInfoDic["视频量"];



            //数据列表加载区
            Dictionary<string, List<string>> Dic = Tools.GetBilibiliVideoInfo(name);
            for (int i = 0; i < Dic["视频名称"].Count; i++)
            {
                ListViewItem li = new ListViewItem((i + 1).ToString());
                li.SubItems.Add(Dic["视频名称"][i]);
                li.SubItems.Add(Dic["视频ID"][i]);
                li.SubItems.Add(Dic["视频日期"][i]);
                li.SubItems.Add(Dic["视频播放量"][i]);
                li.SubItems.Add(Dic["视频点赞量"][i]);
                li.SubItems.Add(Dic["视频硬币量"][i]);
                li.SubItems.Add(Dic["视频收藏量"][i]);
                li.SubItems.Add(Dic["视频分享量"][i]);
                li.SubItems.Add(Dic["视频评论量"][i]);
                li.SubItems.Add(Dic["视频弹幕量"][i]);
                listView1.Items.Add(li);
                groupBox3.Text = "数据区   已加载(" + (i + 1).ToString() + ")";
            }
        }
    }
}

