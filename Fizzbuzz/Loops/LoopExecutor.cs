using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Loops
{
    abstract class LoopExecutor : IExecutable
    {
        private Func<ILoopStateObject, LoopExecutionReturnObject> _loopFunction = null;

        protected Func<ILoopStateObject, LoopExecutionReturnObject> LoopFunction
        {
            get
            {
                return _loopFunction;
            }
        }

        protected LoopExecutor(Func<ILoopStateObject, LoopExecutionReturnObject> loopFunction)
        {
            _loopFunction = loopFunction;
        }

        public abstract void Execute();
    }
}
