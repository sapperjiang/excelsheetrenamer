using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PinYinParse
{
    class BaiduTranslator
    {
        private class Trans_result
        {
            public string src { get; set; }
            public string dst { get; set; }
        }

        private class TranslateResult
        {
            public string from { get; set; }
            public string to { get; set; }
            public List<Trans_result> trans_result { get; set; }
        }

        public string BaiduFanYi(string txtToSearch)
        {
            string q = txtToSearch;
            string appId = "20180110000113723";
            string password = "kBpsylmpouHZAsiC8dDi";
            //目标语言
            string to = "en";
            //源语言
            string from = "zh";
            //获得随机数
            string randomnum = System.DateTime.Now.Millisecond.ToString();
            //获得需要加密的字符串
            string index = appId + q + randomnum + password;
            //进行加密
            string MD5Sign = GetMD5(index);
            //创建连接地址
            string url = string.Format("http://api.fanyi.baidu.com/api/trans/vip/translate?q={0}&from={1}&to={2}&appid={3}&salt={4}&sign={5}",
                q, from, to, appId, randomnum, MD5Sign
                );
            WebClient wc = new WebClient();
            string result = wc.DownloadString(url);

            StringReader sr = new StringReader(result);
            JsonTextReader jsonReader = new JsonTextReader(sr);
            JsonSerializer serializer = new JsonSerializer();
            var r = serializer.Deserialize<TranslateResult>(jsonReader);
            return r.trans_result[0].dst;

        }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="input">要加密的文本</param>
        /// <returns></returns>
        private string GetMD5(string input)
        {
            //判断是否为空
            if (input == null)
            {
                return null;
            }
            //创建MD5哈希表的默认实例
            MD5 md = MD5.Create();
            //将要加密的字符串转换为字节数组
            byte[] buffer = Encoding.UTF8.GetBytes(input);
            //计算指定的字节数组的哈希值
            byte[] data = md.ComputeHash(buffer);
            StringBuilder sb = new StringBuilder();
            //寻黄将哈需数据的每一个字节格式化为16进制字符串
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            //返回16进制字符串
            return sb.ToString();
        }
    }
}
