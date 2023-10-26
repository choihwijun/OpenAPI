using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace 쇼핑_검색
{
    internal class ShoppingItem
    {
        public static List<Item> Search(string query, int start, int display, string sort)
        {
            string url = "https://openapi.naver.com/v1/search/shop.xml";
            string query_str;
            switch (sort)
            {
                case "asc": query_str = string.Format("{0}?query={1}&start={2}&display={3}&sort=asc", url, query, start, display); break;
                case "dsc": query_str = string.Format("{0}?query={1}&start={2}&display={3}&sort=dsc", url, query, start, display); break;
                default: query_str = string.Format("{0}?query={1}&start={2}&display={3}&sort=sim", url, query, start, display); break;
            }
            WebRequest request = WebRequest.Create(query_str);
            request.Headers.Add("X-Naver-Client-Id", "QrZUflZA_jN2a0NifM9d");
            request.Headers.Add("X-Naver-Client-Secret", "j9JKXCiN7n");
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(stream);
            XmlNode rssnode = xdoc.SelectSingleNode("rss");
            XmlNode chnode = rssnode.SelectSingleNode("channel");
            XmlNode disnode = chnode.SelectSingleNode("display");
            int rd = int.Parse(disnode.InnerText);
            XmlNodeList item_nodes = chnode.SelectNodes("item");
            List<Item> item_list = new List<Item>();
            foreach (XmlNode item_node in item_nodes)
            {
                string name = item_node.SelectSingleNode("title").InnerText;
                string link = item_node.SelectSingleNode("link").InnerText;
                string maker = item_node.SelectSingleNode("maker").InnerText;
                string brand = item_node.SelectSingleNode("brand").InnerText;
                string image = item_node.SelectSingleNode("image").InnerText;
                int lprice = 0;
                int.TryParse(item_node.SelectSingleNode("lprice").InnerText, out lprice);
                int hprice = 0;
                int.TryParse(item_node.SelectSingleNode("hprice").InnerText, out hprice);
                Item item = new Item(name, link, maker, brand, image, lprice, hprice);
                item_list.Add(item);
            }
            return item_list;
        }
    }
}
