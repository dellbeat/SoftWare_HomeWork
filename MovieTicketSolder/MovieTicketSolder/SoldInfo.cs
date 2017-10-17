using System;
using System.Collections.Generic;
using System.Xml;

namespace MovieTicketSolder
{
    /// <summary>
    /// 某电影的销售情况
    /// </summary>
    public class SoldInfo
    {
        public string MovieName;
        public string Time;
        public double Price;
        public List<SingleSold> SoldList = new List<SingleSold>();
        public bool IsSuccess = false;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="moviename">电影名称</param>
        /// <param name="price">电影全价</param>
        public SoldInfo(string moviename,double price,string time)
        {
            MovieName = moviename;
            Price = price;
            Time = time;
        }

        /// <summary>
        /// 初始化销售情况，价格为全价
        /// </summary>
        /// <param name="num">某场电影的门票数量</param>
        public void InitSoldInfo(int num)
        {
            for (int i = 0; i < num; i++)
            {
                SingleSold node = new SingleSold();
                node.SoldType = 0;
                node.Price = Price;
                SoldList.Add(node);
            }
        }

        /// <summary>
        /// 修改售票情况
        /// </summary>
        /// <param name="index">门票的下标</param>
        /// <param name="price">门票最终价格</param>
        /// <param name="soldtype">门票销售类型，0为未售出，1为普通票，2为学生票，3为赠票</param>
        /// <param name="SendPerName">如果类型为3赠票人的名称，其它类型请留空</param>
        /// <returns>逻辑变量，返回修改是否成功</returns>
        public bool ChangeSoldInfo(int index,double price,int soldtype,string SendPerName)
        {
            bool status;

            if(index>SoldList.Count)
            {
                status = false;
            }
            else
            {
                SoldList[index - 1].SoldType = soldtype;
                SoldList[index - 1].Price = price;

                if(soldtype==3)
                {
                    SoldList[index - 1].Sender = SendPerName;
                }
                else
                {
                    SoldList[index - 1].Sender = "";
                }

                status = true;
            }

            return status;
        }

        /// <summary>
        ///保存销售情况
        /// </summary>
        public void SaveInfo()
        {
            XmlTextWriter writer = new XmlTextWriter(MovieName + "_" + Time.Replace(":","") + "_SoldInfo.xml", null);
            writer.WriteStartElement("SoldInfo");

            for (int i = 0; i < SoldList.Count; i++)
            {
                writer.WriteStartElement("SingleSold");
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("SoldType", Convert.ToString(SoldList[i].SoldType));
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("Price", Convert.ToString(SoldList[i].Price));
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("Sender", Convert.ToString(SoldList[i].Sender));
                writer.WriteWhitespace("\r\n");
                writer.WriteEndElement();
                writer.WriteWhitespace("\r\n");
            }

            writer.WriteEndElement();
            writer.Close();
        }

        /// <summary>
        /// 从文件获取销售情况
        /// </summary>
        /// <returns></returns>
        public bool GetInfo()
        {
            SoldList.Clear();

            XmlDocument doc = null;
            XmlNodeList SoldTypeNodes = null;
            XmlNodeList PriceNodes = null;
            XmlNodeList SenderNodes = null;
            XmlElement root = null;
            
            try
            {
                doc = new XmlDocument();
                doc.Load(MovieName + "_" + Time.Replace(":", "") + "_SoldInfo.xml");

                root = doc.DocumentElement;

                SoldTypeNodes = root.SelectNodes("/SoldInfo/SingleSold/SoldType");
                PriceNodes = root.SelectNodes("/SoldInfo/SingleSold/Price");
                SenderNodes = root.SelectNodes("/SoldInfo/SingleSold/Sender");

                for (int i = 0; i < SoldTypeNodes.Count; i++)
                {
                    SingleSold node = new SingleSold();
                    node.SoldType = Convert.ToInt32(SoldTypeNodes[i].InnerText);
                    node.Price = Convert.ToDouble(PriceNodes[i].InnerText);
                    node.Sender = SenderNodes[i].InnerText;
                    SoldList.Add(node);
                }

                IsSuccess = true;
            }
            catch
            {
                IsSuccess = false;
            }

            return IsSuccess;
        }
    }
}
