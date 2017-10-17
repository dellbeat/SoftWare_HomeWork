using System;
using System.Collections.Generic;
using System.Xml;

namespace MovieTicketSolder
{
    /// <summary>
    /// 电影列表类，支持获取和更新
    /// </summary>
    public class MovieList
    {
        public List<Movie> List = new List<Movie>();
        public bool IsSuccess = false;

        /// <summary>
        /// 新增电影信息
        /// </summary>
        /// <param name="MovieName">电影名</param>
        /// <param name="Director">导演</param>
        /// <param name="ImagePath">电影封面图片路径</param>
        /// <param name="MainActor">主演</param>
        /// <param name="MovieType">电影类型</param>
        /// <param name="HaveTime">是否附带时间列表的标识</param>
        /// <param name="TimeList">时间列表，当HaveTime为true传入，false传入null即可</param>
        public bool AddMovie(string MovieName,string Director,string ImagePath,string MainActor,string MovieType,bool HaveTime,List<string> TimeList)
        {
            foreach(Movie nodes in List)
            {
                if(nodes.Moviename==MovieName)
                {
                    return false;
                }
            }

            Movie node = new Movie();
            node.Moviename = MovieName;
            node.Director = Director;
            node.ImagePath = ImagePath;
            node.MainActor = MainActor;
            node.MovieType = MovieType;

            if(HaveTime==true)
            {
                for (int i = 0; i < TimeList.Count; i++)
                {
                    node.ActionTime.Add(TimeList[i]);
                }
            }

            List.Add(node);

            return true;
        }

        /// <summary>
        /// 增加某个电影下的放映时间
        /// </summary>
        /// <param name="MovieName">需要加入时间的电影名称</param>
        /// <param name="ActionTime">放映时间字符串</param>
        /// <returns>bool型变量，true为添加成功；false为添加失败，表示没有找到对应电影或者时间已存在</returns>
        public bool AddActionTime(string MovieName,string ActionTime)
        {

            bool status = false;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Moviename == MovieName)
                {
                    foreach(string str in List[i].ActionTime)
                    {
                        if(str==ActionTime)
                        {
                            return status;
                        }
                    }
                    List[i].ActionTime.Add(ActionTime);
                    status = true;
                    break;
                }
            }

            return status;
        }

        /// <summary>
        /// 删除指定电影节点
        /// </summary>
        /// <param name="MovieName">需要删除的电影名</param>
        /// <returns>true表示删除成功，false表示不存在</returns>
        public bool RemoveMovie(string MovieName)
        {
            bool status = false;
            for (int i = 0; i < List.Count; i++)
            {
                if(List[i].Moviename==MovieName)
                {
                    List.RemoveAt(i);
                    status = true;
                    break;
                }
            }

            return status;
        }

        /// <summary>
        /// 删除某部电影指定时间字符串
        /// </summary>
        /// <param name="MovieName">电影名称</param>
        /// <param name="TimeString">指定时间</param>
        /// <returns></returns>
        public bool RemoveTime(string MovieName,string TimeString)
        {
            bool status = false;
            for (int i = 0; i < List.Count; i++)
            {
                if(List[i].Moviename==MovieName)
                {
                    for (int j = 0; j < List[i].ActionTime.Count; i++)
                    { 
                        if(List[i].ActionTime[j]==TimeString)
                        {
                            List[i].ActionTime.RemoveAt(j);
                            status = true;
                            break;
                        }
                    }
                    break;
                }
            }

            return status;
        }

        /// <summary>
        /// 保存所有已有电影的情况
        /// </summary>
        public void SaveInfo()
        {
            XmlTextWriter writer = new XmlTextWriter("MovieList.xml", null);
            writer.WriteStartElement("MovieLists");

            for (int i = 0; i < List.Count; i++)
            {
                writer.WriteStartElement("Movie");
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("Name", List[i].Moviename);
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("Director", List[i].Director);
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("ImagePath", List[i].ImagePath);
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("MainActor", List[i].MainActor);
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("MovieType", List[i].MovieType);
                writer.WriteWhitespace("\r\n  ");
                writer.WriteElementString("ActionTimeCount", Convert.ToString(List[i].ActionTime.Count));
                writer.WriteWhitespace("\r\n  ");

                if (List[i].ActionTime.Count > 0)
                {
                    for (int j = 0; j < List[i].ActionTime.Count; j++)
                    {
                        writer.WriteElementString("ActionTime", List[i].ActionTime[j]);
                        writer.WriteWhitespace("\r\n  ");
                    }
                }

                writer.WriteEndElement();
                writer.WriteWhitespace("\r\n");
            }

            writer.WriteEndElement();
            writer.Close();
        }

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <returns></returns>
        public bool GetList()
        {
            List.Clear();

            XmlDocument doc = null;
            XmlNodeList NameNodes = null;
            XmlNodeList DirectorNodes = null;
            XmlNodeList ImagePathNodes = null;
            XmlNodeList MainActorNodes = null;
            XmlNodeList MovieTypeNodes = null;
            XmlNodeList ActionTimeCountNodes = null;
            XmlNodeList ActionTimeNodes = null;//可能出现一对多或者一对无的情况
            XmlElement root = null;
            
            try
            {
                doc = new XmlDocument();
                doc.Load("MovieList.xml");

                root = doc.DocumentElement;

                NameNodes = root.SelectNodes("/MovieLists/Movie/Name");
                DirectorNodes = root.SelectNodes("/MovieLists/Movie/Director");
                ImagePathNodes = root.SelectNodes("/MovieLists/Movie/ImagePath");
                MainActorNodes = root.SelectNodes("/MovieLists/Movie/MainActor");
                MovieTypeNodes = root.SelectNodes("/MovieLists/Movie/MovieType");
                ActionTimeCountNodes = root.SelectNodes("/MovieLists/Movie/ActionTimeCount");
                ActionTimeNodes = root.SelectNodes("/MovieLists/Movie/ActionTime");

                for (int i = 0, j = 0; i < NameNodes.Count; i++) 
                {
                    Movie node = new Movie();
                    node.Moviename = NameNodes[i].InnerText;
                    node.Director = DirectorNodes[i].InnerText;
                    node.ImagePath = ImagePathNodes[i].InnerText;
                    node.MainActor = MainActorNodes[i].InnerText;
                    node.MovieType = MovieTypeNodes[i].InnerText;

                    for (int k = 0; k < Convert.ToInt32(ActionTimeCountNodes[i].InnerText); k++, j++) 
                    {
                        node.ActionTime.Add(ActionTimeNodes[j].InnerText);
                    }

                    List.Add(node);
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
