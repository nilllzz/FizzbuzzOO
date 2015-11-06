using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Core
{
    interface IStandardExecutable
    {
        void Input();

        void Start();

        void Finish();

        void MapInputParameters(string[] args);
    }
}
