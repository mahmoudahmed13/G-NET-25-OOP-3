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
        }
    }
}
