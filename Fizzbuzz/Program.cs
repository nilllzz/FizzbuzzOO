using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.Core;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzbuzzLogicExecutable fizzbuzzLogic = FizzbuzzLogicExecutable.Instance;
            fizzbuzzLogic.Execute(args);
        }
    }
}
