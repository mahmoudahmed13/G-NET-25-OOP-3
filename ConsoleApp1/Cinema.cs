using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cinema
    {
        public string CinemaName { get; set; }
        private Projector _projector;
        public Cinema()
        {
            _projector = new Projector();
        }

        List<Ticket> _list = new List<Ticket>(20);
        public Ticket this[int index]
        {
            get
            {
                if (index >= 0 && index < _list.Count())
                    return _list[index];
                return null;


            }
            set
            {
                if (index >= 0 && index < _list.Count())
                    _list[index] = value;
                return;
            }

        }
        public Ticket? this[string movie]
        {
            get
            {
                foreach (var ticket in _list)
                {
                    if (ticket.MovieName == movie)
                        return ticket;
                }
                return null;
            }
        }
        public void AddTicket(Ticket t)
        {
            if (_list.Count <= 20)
            {
                _list.Add(t);
                return;
            }
            Console.WriteLine("Cinema Cannot add ticket – cinema is fully booked.");
        }
        public void PrintAllTickets()
        {
            Console.WriteLine("========== All Tickets ==========");
            for (int i = 0; i < _list.Count; i++)
                Console.WriteLine($"{_list[i]}");
            Console.WriteLine("========== Statistics ==========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTicketsSold()}");


        }
        public void OpenCinema()
        {
            Console.Write($"========= Cinema is opened ==========");
            _projector.Start();
        }

        public void CloseCinema()
        {
            Console.WriteLine($"========= Cinema is closed ==========");
            _projector.Stop();
        }








        //Console.WriteLine();
        //Console.WriteLine("========== Search by Movie ==========");
        //Console.WriteLine();
        //Console.Write("Enter movie name to search: ");
        //string? movie = Console.ReadLine();

        //for (int i = 0; i < 3; i++)
        //{
        //    if (cinema[movie].MovieName == movie)
        //    {
        //        Console.WriteLine($"Ticket #{i} - {cinema[movie].MovieName} - {cinema[movie].Type} -" +
        //        $" Seat: {cinema[movie].Seat.ToString()} - Price: {cinema[movie].Price} EGP - After Tax: {cinema[movie].PriceAfterTax} EGP");
        //        return;
        //    }
        //    Console.WriteLine("This Movie Name Not Fount");
        //}


    }
}
