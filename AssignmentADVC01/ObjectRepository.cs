using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class ObjectRepository<T> where T : class
    {
        public T Item { get; set; }

    }
}
