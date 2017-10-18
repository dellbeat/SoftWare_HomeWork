using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSolder
{
    public class BuildTicket
    {
        Ticket tk = null;

        public BuildTicket(int type,int index,double price,string moviename,string vaildacttime,double pricerate,string sendname)
        {
            if(type==0)
            {
                tk = new Ticket(index, price, moviename, vaildacttime);
            }
            else if(type==1)
            {
                tk = new StudentTicket(index, price, moviename, vaildacttime, pricerate);
            }
            else if(type==2)
            {
                tk = new FreeTicket(index, price, moviename, vaildacttime, sendname);
            }
            else
            {
                tk = null;
            }
        }
    }
}
