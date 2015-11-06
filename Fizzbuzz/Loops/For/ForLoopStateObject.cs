using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Loops.For
{
    class ForLoopStateObject : ILoopStateObject
    {
        private int _forStartPosition = 0;
        private int _forEndPosition = 0;
        private int _forIncrement = 0;

        private int _forState = 0;

        public int ForStartPosition
        {
            get { return _forStartPosition; }
            set { _forStartPosition = value; }
        }
        public int ForEndPosition
        {
            get { return _forEndPosition; }
            set { _forEndPosition = value; }
        }
        public int ForIncrement
        {
            get { return _forIncrement; }
            set { _forIncrement = value; }
        }

        public int ForState
        {
            get { return _forState; }
            set { _forState = value; }
        }
    }
}
