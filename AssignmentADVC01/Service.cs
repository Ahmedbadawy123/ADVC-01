using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class Service<T> where T : Entity 
    {
        public void DisplayId(T entity)
        {
            Console.WriteLine(entity.Id);
        }

        // ELfkra Mn EL AI
    }
}
