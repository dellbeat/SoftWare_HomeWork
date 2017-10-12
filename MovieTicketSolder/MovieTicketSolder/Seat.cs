using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSolder
{
    /// <summary>
    /// 座位类，内部包含销售状态和位置信息
    /// </summary>
    public class Seat
    {
        /// <summary>
        /// 销售状态，true为售出，false为未售出
        /// </summary>
        public bool Solded { get; set; }

        /// <summary>
        /// 座位的排数
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// 座位的列数
        /// </summary>
        public int Y { get; set; }
    }
}
