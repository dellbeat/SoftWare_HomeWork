
namespace MovieTicketSolder
{
    /// <summary>
    /// 基础的门票类，包含座位号、价格、所属电影、有效时间等
    /// </summary>
    public class Ticket
    {
        public int Index { get; set; }
        public double Price { get; set; }
        public string MovieName { get; set; }
        public string VaildTime { get; set; }

        public Ticket(int index,double price,string moviename,string vaildtime)
        {
            Index = index;
            Price = price;
            MovieName = moviename;
            VaildTime = vaildtime;
        }
    }
}
