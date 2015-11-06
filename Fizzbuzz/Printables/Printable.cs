using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Printables
{
    abstract class Printable : IPrintable
    {
        public abstract string GetText { get; }

        public void Execute()
        {
            this.Print();
        }

        public void Print()
        {
            PrintManager.Instance.Print(this);
        }
    }
}
