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
            SoldInfo sold = new SoldInfo("爱拼才会赢");
            sold.InitInfo(50, 7);
            sold.SaveInfo();
            //sold.SaveInfo();

            //sold.GetInfo();
            
        }
    }
}
