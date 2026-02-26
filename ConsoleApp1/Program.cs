using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Question 01

            //a) A University has Departments. If the university is closed, the departments no longer exist.
            //Composition Relationship
            //b) A Driver uses a Car.The driver does not own the car.
            //Association Relationship
            //c) A Dog is an Animal.
            //Inheritance Realatinoship
            //d) A Team has Players. If the team is deleted, the players still exist.
            //Aggregation Relationship
            //e) A method receives a Logger as a parameter and calls it inside the method only.
            //Dependency Relatinoship

            #endregion

            #region Question02
            //Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field.Can a child class in a different assembly access it? What about through an object instance from outside?
            //Yes,a child class can accsess it. No,the instance can access it because protected feild behave as private insite the child class
            //b) What is the difference between protected internal and private protected?
            //Without inheritance, private protected behave like private, and protected internal behaves like internal

            //c) What does the sealed keyword do when applied to a class?
            //What about when applied to a method?
            //CallConvThiscall class can not be inherited
            //d) Can you create an object from a sealed class using new? Why or why not?
            //yes,i can.

            #endregion
            #endregion

            #region Part 02 : Practical (Extending the Movie Ticket Booking System)

            //// 1. Create a Cinema and open it
            //Cinema cinema = new Cinema();
            //cinema.OpenCinema();

            //// 2. Create one of each ticket type (hardcoded data)
            //StandardTicket standard = new StandardTicket("C-10","Interstellar", 120m);
            //VIPTicket vip = new VIPTicket(true,"Dune", 250m);
            //IMAXTicket imax = new IMAXTicket(false, "Dune", 180m);

            //// Add them to the cinema
            //cinema.AddTicket(standard);
            //cinema.AddTicket(vip);
            //cinema.AddTicket(imax);

            //// 3. Print all tickets
            //cinema.PrintAllTickets();
            //Console.WriteLine();

            //Console.WriteLine($"Booking Ref 1: {standard.BookingRef}");
            //Console.WriteLine($"Booking Ref 2: {vip.BookingRef}");
            //// 4. Close the cinema
            //cinema.CloseCinema();

            #endregion
        }
    }
}
