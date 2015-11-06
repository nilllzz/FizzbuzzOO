using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.Printables;
using Fizzbuzz.Core;

namespace Fizzbuzz.Adapters
{
    internal sealed class NumericValueToFizzbuzzPrintableAdapter : Adapter
    {
        public override object Adapt(object fromObject)
        {
            if (fromObject != null)
            {
                if (fromObject.GetType() == typeof(int))
                {
                    switch (FizzbuzzLogic.Instance.GetResultTypeFromNumber((int)fromObject))
                    {
                        case FizzbuzzResultType.Fizz:
                            return new FizzPrintable();
                        case FizzbuzzResultType.Buzz:
                            return new BuzzPrintable();
                        case FizzbuzzResultType.Fizzbuzz:
                            return new FizzbuzzPrintable();
                        case FizzbuzzResultType.Number:
                            return new NumericalPrintable((int)fromObject);
                        default:
                            //todo: exception
                            return null;
                    }
                }
                else
                {
                    //todo: exception
                    return null;
                }
            }
            else
            {
                //todo: exception
                return null;
            }
        }
    }
}
