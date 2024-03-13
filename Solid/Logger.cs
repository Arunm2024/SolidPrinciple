using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Logger
    {
        public void LogError(string message)
        {
            System.IO.File.WriteAllText("c://log.txt", message);
        }
    }
}
