using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.Loops.For;

namespace Fizzbuzz.Adapters
{
    internal sealed class ForLoopExecutorDescriptorObjectToForLoopStateObjectAdapter : Adapter
    {
        public override object Adapt(object fromObject)
        {
            this.AssertType<ForLoopExecutorDescriptorObject>(fromObject);

            ForLoopStateObject toObject = new ForLoopStateObject();
            toObject.ForStartPosition = ((ForLoopExecutorDescriptorObject)fromObject).ForStartPosition;
            toObject.ForEndPosition = ((ForLoopExecutorDescriptorObject)fromObject).ForEndPosition;
            toObject.ForIncrement = ((ForLoopExecutorDescriptorObject)fromObject).ForIncrement;

            return toObject;
        }
    }
}
