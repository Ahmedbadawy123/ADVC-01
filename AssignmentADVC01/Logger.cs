using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class Logger<T> where T : ILoggable
    {
        public void Execute(T item)
        {
            item.Log();
        }

    }
}
