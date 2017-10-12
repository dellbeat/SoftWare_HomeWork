using System;
using System.Collections.Generic;
using System.Xml;

namespace MovieTicketSolder
{
    /// <summary>
    /// 座位销售情况类，支持获取和修改、保存销售情况
    /// </summary>
    public class SoldInfo
    {
        public List<Seat> Info = new List<Seat>();//销售情况列表
        public string MovieName;//电影名称
        public bool IsSuccess = false;//读取文件成功标记

        public SoldInfo(string moviename)
        {
            MovieName = moviename;
        }

        /// <summary>
        /// 读取电影所对应的xml文件并获取座位信息
        /// </summary>
        public void GetInfo()
        {
            Info.Clear();//清除当前的列表

            #region 定义xml文档对象和三个xml节点列表
            XmlDocument doc = null;
            XmlNodeList SoldedNodes = null;
            XmlNodeList RowNodes = null;
            XmlNodeList IndexNodes = null;
            XmlElement root = null;
            #endregion

            try
            {
                doc = new XmlDocument();
                doc.Load(MovieName + ".xml");

                root = doc.DocumentElement;

                #region 指定节点列表的作用范围
                SoldedNodes = root.SelectNodes("/Seats/Seat/Solded");
                RowNodes = root.SelectNodes("/Seats/Seat/Row");
                IndexNodes = root.SelectNodes("/Seats/Seat/Index");
                #endregion

                for (int i = 0; i < SoldedNodes.Count; i++)
                {
                    Seat node = new Seat();
                    node.Solded = (SoldedNodes[i].InnerText == "False" ? false : true);
                    node.X = Convert.ToInt32(RowNodes[i].InnerText);
                    node.Y = Convert.ToInt32(IndexNodes[i].InnerText);
                    Info.Add(node);
                }

                IsSuccess = true;
            }
            catch
            {
                IsSuccess = false;
            }
        }

        /// <summary>
        /// 修改售票情况
        /// </summary>
        /// <param name="index"></param>
        public void ChangeInfo(int index)
        {
            Info[index].Solded = Info[index].Solded == true ? false : true;
        }

        /// <summary>
        /// 将售卖信息保存到xml表内
        /// </summary>
        public void SaveInfo()
        {
            XmlTextWriter writer = new XmlTextWriter(MovieName + ".xml", null);
            writer.WriteStartElement("Seats");//写入根节点

            #region 按照指定格式写入xml文件信息
            for (int i = 0; i < Info.Count; i++)
            {
                writer.WriteStartElement("Seat");
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("Solded", Convert.ToString(Info[i].Solded));
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("Row", Convert.ToString(Info[i].X));
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("Index", Convert.ToString(Info[i].Y));
                writer.WriteWhitespace("\r\n");
                writer.WriteEndElement();
                writer.WriteWhitespace("\r\n");

            }
            #endregion

            writer.WriteEndElement();//根节点写入结束标志
            writer.Close();
        }

        /// <summary>
        /// 初始化销售情况，通常用于新场次上线时
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="Ylength"></param>
        public void InitInfo(int nums,int Ylength)
        {
            for (int i = 1; i <= (nums % Ylength == 0 ? nums / Ylength : nums / Ylength + 1); i++) 
            {
                for (int j = 1; j <= Ylength; j++)
                {
                    Seat seat = new Seat();
                    seat.X = i;
                    seat.Y = j;
                    seat.Solded = false;
                    Info.Add(seat);
                }
            }
        }
    }
}
