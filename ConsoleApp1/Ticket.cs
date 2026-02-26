using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ticket
    {
        private string _movieName;
        private decimal _price;
        public decimal PriceAfterTax => ((14 * _price) / 100) + _price;
        public int TicketId { get; }
        private static int ticketCounter = 0;
        public string BookingRef { get; set; }
        //=======================
        public string MovieName
        {
            get
            {
                return _movieName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 3)
                {
                    _movieName = value;
                    return;
                }
                Console.WriteLine("MovieName : cannot be null or empty ");

            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Price : must be greater than 0");
                    return;
                }
                _price = value;
            }
        }
        //Auto Incremented
        public Ticket(string movieName, decimal price)
        {
            ticketCounter++;
            TicketId = ticketCounter;
            BookingRef = $"BK-{TicketId}";
            _movieName = movieName;
            _price = price;
        }

        public override string ToString() 
        {
            return $"Movie Name: {MovieName} - Price: {Price} EGP - Price after tax: {PriceAfterTax} EGP";
        
        }

        public static int GetTotalTicketsSold() => ticketCounter;
    }
}
