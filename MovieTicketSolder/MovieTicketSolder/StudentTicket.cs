
namespace MovieTicketSolder
{
    public class StudentTicket:Ticket
    {
        public double PriceRate
        {
            get;
            set;
        }

        public StudentTicket(int index, double price, string moviename, string vaildtime,double rate)
            :base(index, price, moviename, vaildtime)
        {
            Index = index;
            Price = price;
            MovieName = moviename;
            VaildTime = vaildtime;
            PriceRate = rate;
        }
    }
}
