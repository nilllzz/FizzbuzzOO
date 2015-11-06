using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    abstract class LoopExecutor : IExecutable
    {
        public abstract void Execute();
    }
}
