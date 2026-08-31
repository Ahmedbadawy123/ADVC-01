using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class FileLogger : ILoggable
    {
        public void Log() => Console.WriteLine("Logging to file...");

    }
}
