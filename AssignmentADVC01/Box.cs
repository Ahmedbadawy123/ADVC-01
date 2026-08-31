using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class Box<T> where T : struct
    {
        public T Value { get; set; }
    }
}
