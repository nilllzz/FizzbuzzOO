using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Printables
{
    class FizzbuzzPrintable : FizzbuzzLogicPrintable
    {
        public override string GetText
        {
            get
            {
                return "Fizzbuzz";
            }
        }
    }
}
