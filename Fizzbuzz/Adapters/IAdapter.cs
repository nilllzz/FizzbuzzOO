using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Adapters
{
    interface IAdapter
    {
        object Adapt(object fromObject);
    }
}
