using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTicketSolder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Movie movienode = null;

        private void button1_Click(object sender, EventArgs e)
        {
            //MovieList list = new MovieList();
            //list.AddMovie("爱拼才会赢", "不知道导演是谁", "NULL", "不知道主演", "瞎编乱造片", false, null);
            //MessageBox.Show(Convert.ToString(list.AddActionTime("爱拼才会赢", "2017-10-11 5:10")));
            //MessageBox.Show(Convert.ToString(list.AddActionTime("爱拼才会赢", "2017-10-11 8:20")));
            //list.SaveInfo();
            //SeatInfo info = new SeatInfo("爱拼才会赢");
            //info.InitInfo(50,7);
            //info.SaveInfo();
            //SoldInfo info = new SoldInfo("爱拼才会赢", 60);
            //info.InitSoldInfo(60);
            //info.SaveInfo();
            //MessageBox.Show("Wait For Write");
            //info.GetInfo();
            //for (int i = 0; i < info.SoldList.Count; i++)
            //{
            //    if(info.SoldList[i].Sender!="")
            //    {
            //        MessageBox.Show("true" + Convert.ToString(i));
            //        break;
            //    }
            //}
            //MovieList list = new MovieList();
            
            //MessageBox.Show(Convert.ToString(list.List.Count));
            //MessageBox.Show(Convert.ToString(list.AddMovie("爱拼才会赢3", "不知道导演是谁", "NULL", "不知道主演", "瞎编乱造片", false, null)));
            //MessageBox.Show(Convert.ToString(list.AddActionTime("爱拼才会赢3", "2017-10-12 5:10")));
            //MessageBox.Show(Convert.ToString(list.AddActionTime("爱拼才会赢2", "2017-10-12 5:10")));
            //list.SaveInfo();
            RefreshList();
        }

        /// <summary>
        /// 刷新列表
        /// </summary>
        private void RefreshList()
        {
            MoviesList.Nodes.Clear();//清空防止重复添加
            MovieList list = new MovieList();
            list.GetList();
            for (int i = 0; i < list.List.Count; i++)
            {
                MoviesList.Nodes.Add(list.List[i].Moviename);
                for (int j = 0; j < list.List[i].ActionTime.Count; j++)
                {
                    MoviesList.Nodes[i].Nodes.Add(list.List[i].ActionTime[j]);
                }
            }
        }

        private void MoviesList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string FullPath = e.Node.FullPath;
            string MovieName;
            string Time = "";

            if(FullPath.IndexOf("\\")==-1)
            {
                MovieName = FullPath;
            }
            else
            {
                string[] array = FullPath.Split('\\');
                MovieName = array[0];
                Time = array[1];
            }

            MessageBox.Show(MovieName+Time);
        }

        private void GetMovieInfo(string MovieName)
        {
            MovieList list = new MovieList();
            list.GetList();

            for (int i = 0; i < list.List.Count; i++)
            {
                if(list.List[i].Moviename==MovieName)
                {
                    movienode = list.List[i];
                    break;
                }
            }
        }
    }
}
