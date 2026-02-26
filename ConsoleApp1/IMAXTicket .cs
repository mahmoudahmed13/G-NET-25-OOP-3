using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IMAXTicket : Ticket
    {
        private bool _is3D;

        public bool Is3D
        {
            get
            {
                if (_is3D == true)
                     Price += 30m;
                return false;
            }
        }

        public IMAXTicket(bool is3D,string movieName, decimal price) : base(movieName, price)
        {
            _is3D = is3D;
        }
        public override string ToString()
        {
            string label = Is3D ? "Yes" : "No";
            return base.ToString() + $", :IMAX 3D: {label}";
        }
    }
}
