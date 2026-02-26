using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }
        public StandardTicket(string seatNumber,string movieName, decimal price) : base(movieName, price)
        {
            SeatNumber = seatNumber;
        }
        public override string ToString()
        {
            return base.ToString() + $", Seat: {SeatNumber}";
        }
    }
}
