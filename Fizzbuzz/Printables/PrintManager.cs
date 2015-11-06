using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fizzbuzz.Printables
{
    class PrintManager : Singleton<PrintManager>
    {
        private PrintManager() { }

        public void Print(IPrintable source)
        {
            // Check if the user interaction is possible (first step to check if a console is available.
            // Then, check if the Console has an open standard input.
            if (Environment.UserInteractive && ConsoleHasOutput())
            {
                Console.WriteLine(source.GetText);
            }
        }

        private bool ConsoleHasOutput()
        {
            return Console.OpenStandardOutput(1) != Stream.Null;
        }
    }
}
