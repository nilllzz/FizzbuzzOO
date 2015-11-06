using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    class StackExecutor : Singleton<StackExecutor>
    {
        private StackExecutor() { }

        private List<IExecutable> _stack = null;

        private void TouchStack()
        {
            if (_stack == null)
                _stack = new List<IExecutable>();
        }

        public bool HasItemsOnStack()
        {
            TouchStack();
            return _stack.Count > 0;
        }

        public void AddItemToStack(IExecutable executable)
        {
            TouchStack();
            _stack.Add(executable);
        }

        public void RunStack()
        {
            TouchStack();
            while (_stack.Count > 0)
            {
                _stack[0].Execute();
                _stack.RemoveAt(0);
            }
        }
    }
}
