using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repro6815.Platforms.Windows
{
    public class SomethingService : ISomethingService
    {
        public void PrintPlatform()
        {
            Console.WriteLine("Windows");
        }
    }
}
