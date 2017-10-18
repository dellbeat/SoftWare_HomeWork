
namespace MovieTicketSolder
{
    public class FreeTicket:Ticket
    {
        public string SendName;
        public FreeTicket(int index, double price, string moviename, string vaildtime,string sendname)
            :base(index,price,moviename,vaildtime)
        {
            Index = index;
            Price = 0;
            MovieName = moviename;
            VaildTime = vaildtime;
            SendName = sendname;
        }
    }
}
