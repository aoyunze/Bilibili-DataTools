using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading;
using System.Windows.Forms;
namespace Bilibili_DataTools
{
    public static class Tools
    {
        /// <summary>
        /// 获取网页源代码
        /// </summary>
        /// <param name="p_url">网址</param>
        /// <returns></returns>
        public static string GetWebCode(string p_url)
        {
            WebProxy a = new WebProxy("117.69.201.189", 9999);//设置代理IP，不然爬虫会被拦截
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(p_url);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
        /// <summary>
        /// 获取B站用户的mid
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public static string GetMid(string name)
        {
            string api = "https://api.bilibili.com/x/web-interface/search/all/v2?context=&page=1&order=&keyword=";
            string code = GetWebCode(api + name);
            JObject Json = (JObject)JsonConvert.DeserializeObject(code);
            string mid = Json["data"]["result"].ToArray()[5].ToObject<JObject>()["data"].ToArray()[0].ToObject<JObject>()["mid"].ToString();
            return mid;
        }
        /// <summary>
        /// 获取用户统计信息
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetBilibiliUserInfo(string name)
        {
            Dictionary<string, string> userInfoDic = new Dictionary<string, string>();
            string mid = GetMid(name);
            string api1 = "https://api.bilibili.com/x/space/upstat?mid=";//播放量
            string api2 = "https://space.bilibili.com/ajax/member/getSubmitVideos?mid=";//视频总量
            string api3 = "https://api.bilibili.com/x/space/acc/info?mid=";//头像
            string api4 = "https://api.bilibili.com/x/relation/stat?vmid=";//粉丝量
            JObject Json1 = JObject.Parse(GetWebCode(api4 + mid));
            JObject Json2 = JObject.Parse(GetWebCode(api2 + mid));
            JObject Json3 = JObject.Parse(GetWebCode(api3 + mid));
            JObject Json4 = JObject.Parse(GetWebCode(api1 + mid));
            string logo = Json3["data"]["face"].ToString();
            string username = Json3["data"]["name"].ToString();
            string playCount = Json4["data"]["archive"]["view"].ToString();
            string follower = Json1["data"]["follower"].ToString();
            string videoCount = Json2["data"]["count"].ToString();
            userInfoDic.Add("头像", logo);
            userInfoDic.Add("用户名", username);
            userInfoDic.Add("播放量", playCount);
            userInfoDic.Add("粉丝量", follower);
            userInfoDic.Add("视频量", videoCount);
            return userInfoDic;
        }
        /// <summary>
        /// 获取B站UP主的所有视频信息
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public static Dictionary<string, List<string>> GetBilibiliVideoInfo(string name)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            string api1 = "https://space.bilibili.com/ajax/member/getSubmitVideos?mid=";
            string api2 = "https://api.bilibili.com/x/web-interface/view?aid=";
            List<string> listVideoName = new List<string>();//视频名称数组
            List<string> listVideoId = new List<string>();//视频avID
            List<string> listVideoTime = new List<string>();//视频发布时间
            List<string> listVideoView = new List<string>();//视频播放数量
            List<string> listVideoGood = new List<string>();//视频点赞数量
            List<string> listVideoCoin = new List<string>();//视频投币数量
            List<string> listVideoCollect = new List<string>();//视频收藏量
            List<string> listVideoShare = new List<string>();//视频分享数量
            List<string> listVideoComment = new List<string>();//视频评论数量
            List<string> listVideoDanmu = new List<string>();//视频弹幕数量
            string mid = GetMid(name);
            JObject Json = JObject.Parse(GetWebCode(api1 + mid + "&pagesize=1"));//先获取加载所有视频信息需要的页面数 =1减轻代码量和更快获取。
            double page = Math.Ceiling(((double)Json["data"]["count"]) / 100); //视频总数除以每页的视频数量等于页面数
            for (int i = 0; i < page; i++)//有多少页，就循环打开多少次接口
            {
                JObject Json1 = JObject.Parse(GetWebCode(api1 + mid + "&pagesize=100" + "&page=" + (i + 1).ToString()));//int类型的后缀也需要转成文本类型，才能拼接在一起。
                int repeatCount = Json1["data"]["vlist"].ToArray().Length;//页面的视频信息数量,有多少就循环添加多少次
                for (int j = 0; j < repeatCount; j++)
                {
                    string videoName = Json1["data"]["vlist"].ToArray()[j].ToObject<JObject>()["title"].ToString();
                    string videoId = Json1["data"]["vlist"].ToArray()[j].ToObject<JObject>()["aid"].ToString();
                    string unixTime = Json1["data"]["vlist"].ToArray()[j].ToObject<JObject>()["created"].ToString();
                    DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
                    DateTime TranslateDate = startTime.AddSeconds(double.Parse(unixTime));
                    string videoTime = TranslateDate.ToString();
                    listVideoName.Add(videoName);
                    listVideoId.Add(videoId);
                    listVideoTime.Add(videoTime);
                    

                    //获取单个视频具体数据(先获取到视频api，然后再进行下面的重新获取)
                    JObject Json2 = JObject.Parse(GetWebCode(api2 + videoId));
                    string videoView = Json2["data"]["stat"]["view"].ToString();
                    string videoGood = Json2["data"]["stat"]["like"].ToString();
                    string videoCoin = Json2["data"]["stat"]["coin"].ToString();
                    string videoCollect = Json2["data"]["stat"]["favorite"].ToString();
                    string videoShare = Json2["data"]["stat"]["share"].ToString();
                    string videoComment = Json2["data"]["stat"]["reply"].ToString();
                    string videoDanmu = Json2["data"]["stat"]["danmaku"].ToString();
                    listVideoView.Add(videoView);
                    listVideoGood.Add(videoGood);
                    listVideoCoin.Add(videoCoin);
                    listVideoCollect.Add(videoCollect);
                    listVideoShare.Add(videoShare);
                    listVideoComment.Add(videoComment);
                    listVideoDanmu.Add(videoDanmu);

                }
            }
            dic.Add("视频名称", listVideoName);
            dic.Add("视频ID", listVideoId);
            dic.Add("视频日期", listVideoTime);
            dic.Add("视频播放量", listVideoView);
            dic.Add("视频点赞量", listVideoGood);
            dic.Add("视频硬币量", listVideoCoin);
            dic.Add("视频收藏量", listVideoCollect);
            dic.Add("视频分享量", listVideoShare);
            dic.Add("视频评论量", listVideoComment);
            dic.Add("视频弹幕量", listVideoDanmu);
            return dic;
        }

    }
}
