using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Printables
{
    class BuzzPrintable : FizzbuzzLogicPrintable
    {
        public override string GetText
        {
            get
            {
                return "Buzz";
            }
        }
    }
}
