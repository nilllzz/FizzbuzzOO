using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Printables
{
    class NumericalPrintable : FizzbuzzLogicPrintable
    {
        private string _numText = null;

        public override string GetText
        {
            get
            {
                return _numText;
            }
        }

        public NumericalPrintable(int number)
        {
            _numText = number.ToString();
        }
    }
}
