using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class Manager<T> where T : Entity, ILoggable, new()
    {
        public T Process()
        {
            T item = new T();
            item.Log();
            return item;
        }
    }
}
