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

        private void button1_Click(object sender, EventArgs e)
        {
            MovieList list = new MovieList();
            list.AddMovie("爱拼才会赢", "不知道导演是谁", "NULL", "不知道主演", "瞎编乱造片", false, null);
            MessageBox.Show(Convert.ToString(list.AddActionTime("爱拼才会赢", "2017-10-11 5:10")));
            MessageBox.Show(Convert.ToString(list.AddActionTime("爱拼才会赢", "2017-10-11 8:20")));
            list.SaveInfo();
            
        }
    }
}
