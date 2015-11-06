using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Loops.For
{
    class ForLoopExecutorDescriptorObject : ILoopExecutorDescriptorObject
    {
        private Func<ILoopStateObject, LoopExecutionReturnObject> _loopFunction;

        private int _forStartPosition = 0;
        private int _forEndPosition = 0;
        private int _forIncrement = 0;

        public ForLoopExecutorDescriptorObject(Func<ILoopStateObject, LoopExecutionReturnObject> LoopFunction)
        {
            _loopFunction = LoopFunction;
        }

        public int ForStartPosition
        {
            set { _forStartPosition = value; }
            get { return _forStartPosition; }
        }
        public int ForEndPosition
        {
            set { _forEndPosition = value; }
            get { return _forEndPosition; }
        }
        public int ForIncrement
        {
            set { _forIncrement = value; }
            get { return _forIncrement; }
        }

        public Func<ILoopStateObject, LoopExecutionReturnObject> LoopFunction
        {
            get { return _loopFunction; }
        }
    }
}
