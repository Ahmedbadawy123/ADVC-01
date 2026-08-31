using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class OrderEntity : Entity, ILoggable
    {
        public OrderEntity() { }
        public void Log() => Console.WriteLine($"Order {Id} logged.");
    }
}
