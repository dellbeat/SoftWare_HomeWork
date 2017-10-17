using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSolder
{
    /// <summary>
    /// 电影类，内含单个电影的各种信息
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// 电影名
        /// </summary>
        private string moviename;

        public string Moviename
        {
            get { return moviename; }
            set { moviename = value; }
        }

        /// <summary>
        /// 导演
        /// </summary>
        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        /// <summary>
        /// 封面所对应的路径，如果无对应封面用NULL字符串代替
        /// </summary>
        private string imagepath;

        public string ImagePath
        {
            get { return imagepath; }
            set { imagepath = value; }
        }

        /// <summary>
        /// 主演
        /// </summary>
        private string mainactor;

        public string MainActor
        {
            get { return mainactor; }
            set { mainactor = value; }
        }

        /// <summary>
        /// 电影类型
        /// </summary>
        private string movietype;

        public string MovieType
        {
            get { return movietype; }
            set { movietype = value; }
        }



        /// <summary>
        /// 上映时间
        /// </summary>
        public List<string> ActionTime = new List<string>();
    }
}
