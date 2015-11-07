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

        protected void AssertType<T>(object fromObject)
        {
            if (fromObject == null)
            {
                throw new AdapterException(this.GetType(), new ArgumentNullException(nameof(fromObject)));
            }
            else if (fromObject.GetType() != typeof(T))
            {
                throw new AdapterException(this.GetType(), new InvalidOperationException("Invalid input object type."));
            }
        }
    }
}
