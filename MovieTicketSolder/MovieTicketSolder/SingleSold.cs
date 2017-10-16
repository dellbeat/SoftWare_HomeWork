using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSolder
{
    /// <summary>
    /// 单个座位的销售情况
    /// </summary>
    public class SingleSold
    {
        /// <summary>
        /// 销售代码，0为未出售，1为普通票，2为学生票，3为赠票
        /// </summary>
        public int SoldType { get; set; }

        /// <summary>
        /// 出售的价格
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// 如果属于赠票，赠票人的名字
        /// </summary>
        public string Sender { get; set; }
    }
}
