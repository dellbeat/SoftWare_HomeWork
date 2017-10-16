using System;
using System.Collections.Generic;
using System.Xml;

namespace MovieTicketSolder
{
    /// <summary>
    /// 座位销售情况类，支持获取和修改、保存座位情况
    /// </summary>
    public class SeatInfo
    {
        public List<Seat> Info = new List<Seat>();//销售情况列表
        public string MovieName;//电影名称
        public string Time;//放映时间
        public bool IsSuccess = false;//读取文件成功标记

        public SeatInfo(string moviename,string time)
        {
            MovieName = moviename;
            Time = time;
        }

        /// <summary>
        /// 读取电影所对应的xml文件并获取座位信息
        /// <return>bool型变量，true表示读取成功，反之表示失败</return>
        /// </summary>
        public bool GetInfo()
        {
            Info.Clear();//清除当前的列表

            #region 定义xml文档对象和三个xml节点列表
            XmlDocument doc = null;
            XmlNodeList SoldedNodes = null;
            XmlNodeList RowNodes = null;
            XmlNodeList IndexNodes = null;
            XmlNodeList SoldTypeNodes = null;
            XmlElement root = null;
            #endregion

            try
            {
                doc = new XmlDocument();
                doc.Load(MovieName + "_" + Time + ".xml");

                root = doc.DocumentElement;

                #region 指定节点列表的作用范围
                SoldedNodes = root.SelectNodes("/Seats/Seat/Solded");
                RowNodes = root.SelectNodes("/Seats/Seat/Row");
                IndexNodes = root.SelectNodes("/Seats/Seat/Index");
                SoldTypeNodes = root.SelectNodes("/Seats/Seat/SoldType");
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

            return IsSuccess;
        }

        /// <summary>
        /// 获取某个座位的售票状态
        /// </summary>
        /// <param name="index">座位的绝对排序</param>
        /// <returns></returns>
        public bool GetSoldStatus(int index)
        {
            bool status = Info[index].Solded;

            return status;
        }

        /// <summary>
        /// 修改售票情况
        /// </summary>
        /// <param name="index">座位的绝对排序</param>
        /// <param name="TypeNum">售票类型，0为未售出，1为普通票，2为学生票，3为赠票</param>
        public void ChangeInfo(int index,int TypeNum)
        {
            Info[index].Solded = Info[index].Solded == true ? false : true;
            Info[index].SoldType = TypeNum;
        }

        /// <summary>
        /// 将售卖信息保存到xml表内
        /// </summary>
        public void SaveInfo()
        {
            XmlTextWriter writer = new XmlTextWriter(MovieName + "_" + Time + ".xml", null);
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
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("SoldType", Convert.ToString(Info[i].SoldType));
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
        /// <param name="nums">座位数</param>
        /// <param name="Ylength">单排的座位个数</param>
        public void InitInfo(int nums,int Ylength)
        {
            int LastIndex = nums % Ylength == 0 ? nums / Ylength : nums / Ylength + 1;
            for (int i = 1; i <= LastIndex; i++) 
            {
                for (int j = 1; j <= Ylength; j++)
                {
                    if (i == LastIndex && j > nums % Ylength)
                    {
                        break;
                    }
                    Seat seat = new Seat();
                    seat.X = i;
                    seat.Y = j;
                    seat.Solded = false;
                    seat.SoldType = 0;
                    Info.Add(seat);
                }
            }
        }
    }
}
