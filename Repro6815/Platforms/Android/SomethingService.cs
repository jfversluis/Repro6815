using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repro6815.Platforms.Android
{
    public class SomethingService : ISomethingService
    {
        public void PrintPlatform()
        {
            Console.WriteLine("Android");
        }
    }
}
