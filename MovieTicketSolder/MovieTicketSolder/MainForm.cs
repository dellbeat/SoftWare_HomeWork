using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MovieTicketSolder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Movie movienode = null;
        double DisCount = 1;

        int labelx = 10;
        int labely = 10;
        int count = 0;

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

            if(Time==""||GetMovieInfo(MovieName)==false)
            {
                return;
            }

            SelectActTime.Text = Time;

            //MessageBox.Show(MovieName + Time);
        }

        private bool GetMovieInfo(string MovieName)
        {
            MovieList list = new MovieList();
            list.GetList();
            bool Found = false;

            for (int i = 0; i < list.List.Count; i++)
            {
                if(list.List[i].Moviename==MovieName)
                {
                    movienode = list.List[i];
                    Found = true;
                    break;
                }
            }

            if(Found==false)
            {
                return Found;
            }

            SelectMovieName.Text = movienode.Moviename;
            SelectActor.Text = movienode.MainActor;
            SelectDirector.Text = movienode.Director;
            SelectType.Text = movienode.MovieType;
            SelectPrice.Text = Convert.ToString(movienode.Price);
            if(movienode.ImagePath!="NULL")
            {
                MoviePic.ImageLocation = movienode.ImagePath;
            }
            else
            {
                MoviePic.Image = null;
            }

            return Found;
        }

        private void LoadList_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void NormalTicket_CheckedChanged(object sender, EventArgs e)
        {
            if(NormalTicket.Checked==true)
            {
                StuPrice.Enabled = false;
                StuPrice.Text = null;
                SendPerName.Enabled = false;
            }
        }

        private void StuTicket_CheckedChanged(object sender, EventArgs e)
        {
            if(StuTicket.Checked==true)
            {
                StuPrice.Enabled = true;
                SendPerName.Enabled = false;
            }
        }

        private void FreeTickets_CheckedChanged(object sender, EventArgs e)
        {
            if(FreeTickets.Checked==true)
            {
                StuPrice.Enabled = false;
                StuPrice.Text = null;
                SendPerName.Enabled = true;
            }
        }

        private void StuPrice_TextChanged(object sender, EventArgs e)
        {
            Regex nums = new Regex("\\d");

            if(StuPrice.Text=="")
            {
                DisCount = 1.0;
                return;
            }

            Match matchoutput = nums.Match(StuPrice.Text);
            string output = matchoutput.ToString();

            DisCount = 0.1 * Convert.ToInt32(output);
        }

        private void DrawSeatLabel(string text,string name,int x,int y)
        {
            Label label = new Label();
            label.Name = name;
            label.Text = text;
            label.Width = 58;
            label.Height = 23;
            label.BackColor = Color.FromArgb(131, 190, 239);
            label.Font = new Font("微软雅黑", 12);
            label.TextAlign = ContentAlignment.MiddleCenter;
            Point points = new Point(x, y);
            label.Location = points;
            label.BorderStyle = BorderStyle.None;
            SeatPage.Controls.Add(label);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
