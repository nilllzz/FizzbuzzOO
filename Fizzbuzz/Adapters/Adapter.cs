using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Adapters
{
    abstract class Adapter : IAdapter
    {
        public abstract object Adapt(object fromObject);
    }
}
