using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class Factory<T> where T : new()
    {
    public T CreateInstance()
    {
        return new T();
    }
        // Helping With AI
}
}
