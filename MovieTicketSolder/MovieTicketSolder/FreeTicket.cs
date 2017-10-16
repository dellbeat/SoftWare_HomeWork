
namespace MovieTicketSolder
{
    public class FreeTicket:Ticket
    {
        public string SendName;
        public FreeTicket(int index,Ticket ticket,string name)
        {
            Index = index;
            MovieName = ticket.MovieName;
            Price = 0;
            VaildTime = ticket.VaildTime;
            SendName = name;
        }
    }
}
