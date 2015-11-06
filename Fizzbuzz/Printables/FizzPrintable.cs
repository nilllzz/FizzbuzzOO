using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Printables
{
    class FizzPrintable : FizzbuzzLogicPrintable
    {
        public override string GetText
        {
            get
            {
                return "Fizz";
            }
        }
    }
}
