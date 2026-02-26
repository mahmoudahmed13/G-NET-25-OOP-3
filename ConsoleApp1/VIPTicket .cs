using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; } = 50m;
        public VIPTicket(bool lounge, string movieName, decimal price) : base(movieName, price)
        {
            LoungeAccess = lounge;
        }
        public override string ToString()
        {
            return base.ToString() + $", Lounge: {LoungeAccess}, Service: {ServiceFee} EGP";
        }
    }
}
