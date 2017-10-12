using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSolder
{
    /// <summary>
    /// 电影列表类，支持获取和更新
    /// </summary>
    public class MovieList
    {
        public List<Movie> MovieList = new List<Movie>();

        /// <summary>
        /// 新增电影信息
        /// </summary>
        /// <param name="MovieName">电影名</param>
        /// <param name="Director">导演</param>
        /// <param name="ImagePath">电影封面图片路径</param>
        /// <param name="MainActor">主演</param>
        /// <param name="MovieType">电影类型</param>
        public void AddMovie(string MovieName,string Director,string ImagePath,string MainActor,string MovieType)
        {
            Movie node = new Movie();
            node.Moviename = MovieName;
            node.Director = Director;
            node.ImagePath = ImagePath;
            node.MainActor = MainActor;
            node.MovieType = MovieType;

            MovieList.Add(node);
        }
    }
}
