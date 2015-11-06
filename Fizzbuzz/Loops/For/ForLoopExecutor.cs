using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Loops.For
{
    class ForLoopExecutor : LoopExecutor
    {
        private ForLoopStateObject _forLoopStateObjectInstance = null;

        public ForLoopExecutor(Func<ILoopStateObject, LoopExecutionReturnObject> loopFunction) : base(loopFunction) { }
        
        public void SetState(ForLoopStateObject stateObject)
        {
            _forLoopStateObjectInstance = stateObject;
        }

        public override void Execute()
        {
            for (int i = this._forLoopStateObjectInstance.ForStartPosition;
                i < this._forLoopStateObjectInstance.ForEndPosition + 1;
                i += this._forLoopStateObjectInstance.ForIncrement)
            {
                _forLoopStateObjectInstance.ForState = i;

                base.LoopFunction.Invoke(_forLoopStateObjectInstance);
            }
        }
    }
}
