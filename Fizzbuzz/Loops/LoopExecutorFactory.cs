using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.Adapters;
using Fizzbuzz.Loops.For;

namespace Fizzbuzz.Loops
{
    /// <summary>
    /// A singleton factory class to create loop executors.
    /// </summary>
    class LoopExecutorFactory : Singleton<LoopExecutorFactory>, IFactory
    {
        /// <summary>
        /// The private constructor to aid the singleton behaviour and to prevent instances.
        /// </summary>
        private LoopExecutorFactory() { }
        
        /// <summary>
        /// Creates a loop executor described by the loop executor descriptor object.
        /// </summary>
        /// <param name="descriptor">The descriptor object used to describe the needed LoopExecutor.</param>
        /// <returns>This method returns a loop executor object created from the descriptor.</returns>
        public LoopExecutor Create(ILoopExecutorDescriptorObject descriptor)
        {
            // Check to see if descriptor is null:
            if (descriptor != null)
            {
                if (descriptor.GetType() == typeof(ForLoopExecutorDescriptorObject))
                {
                    return CreateForLoopExecutor((ForLoopExecutorDescriptorObject)descriptor);
                }
                else
                {
                    // todo: exception
                    return null;
                }
            }
            else
            {
                // todo: exception
                return null;
            }
        }

        private LoopExecutor CreateForLoopExecutor(ForLoopExecutorDescriptorObject descriptor)
        {
            ForLoopExecutor forLoopExecutor = new ForLoopExecutor(descriptor.LoopFunction);

            IAdapter adapter = AdapterFactory.Instance.Create(descriptor.GetType(), typeof(ForLoopStateObject));
            ForLoopStateObject forLoopStateObject = (ForLoopStateObject)adapter.Adapt(descriptor);

            forLoopExecutor.SetState(forLoopStateObject);

            return forLoopExecutor;
        }
    }
}
