
namespace MovieTicketSolder
{
    public class StudentTicket:Ticket
    {
        public double PriceRate
        {
            get;
            set;
        }

        public StudentTicket(double rate,Ticket ticket,int index)
        {
            PriceRate = rate;
            Price = ticket.Price * PriceRate;
            Index = index;
            MovieName = ticket.MovieName;
            VaildTime = ticket.VaildTime;
        }
    }
}
