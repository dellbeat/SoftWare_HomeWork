using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MovieTicketSolder
{
    /// <summary>
    /// 电影列表类，支持获取和更新
    /// </summary>
    public class MovieList
    {
        public List<Movie> List = new List<Movie>();

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
        public void AddMovie(string MovieName,string Director,string ImagePath,string MainActor,string MovieType,bool HaveTime,List<string> TimeList)
        {
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
        }

        /// <summary>
        /// 增加某个电影下的放映时间
        /// </summary>
        /// <param name="MovieName">需要加入时间的电影名称</param>
        /// <param name="ActionTime">放映时间字符串</param>
        /// <returns>bool型变量，true为添加成功；false为添加失败，表示没有找到对应电影</returns>
        public bool AddActionTime(string MovieName,string ActionTime)
        {
            bool status = false;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Moviename == MovieName)
                {
                    List[i].ActionTime.Add(ActionTime);
                    status = true;
                    break;
                }
            }

            return status;
        }

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
    }
}
