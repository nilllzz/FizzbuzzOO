using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.Loops.For;
using Fizzbuzz.Printables;

namespace Fizzbuzz.Adapters
{
    class AdapterFactory : Singleton<AdapterFactory>, IFactory
    {
        private AdapterFactory() { }

        public IAdapter Create(Type typeFrom, Type typeTo)
        {
            if (typeFrom == typeof(ForLoopExecutorDescriptorObject) && typeTo == typeof(ForLoopStateObject))
            {
                return new ForLoopExecutorDescriptorObjectToForLoopStateObjectAdapter();
            }
            else if (typeFrom == typeof(int) && typeTo == typeof(FizzbuzzLogicPrintable))
            {
                return new NumericValueToFizzbuzzPrintableAdapter();
            }
            else
            {
                throw new ArgumentException(string.Format("The type combination ({0}, {1}) given to the AdapterFactory object is invalid.", typeFrom.Name, typeTo.Name), 
                    nameof(typeFrom) + "|" + nameof(typeTo));
            }
        }
    }
}
