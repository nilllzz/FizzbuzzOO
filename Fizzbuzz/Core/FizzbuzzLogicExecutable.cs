using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fizzbuzz.Loops;
using Fizzbuzz.Loops.For;
using Fizzbuzz.Printables;
using Fizzbuzz.Adapters;

namespace Fizzbuzz.Core
{
    class FizzbuzzLogicExecutable : Singleton<FizzbuzzLogicExecutable>, IStandardExecutable
    {
        private const string INPUT_LENGTH_TEXT = "How many numbers? ";
        private int _forEndPosition = 0;

        private FizzbuzzLogicExecutable() { }

        public void MapInputParameters(string[] args)
        {
            // no external arguments are supported.
        }
        
        public void Input()
        {
            Console.Write(INPUT_LENGTH_TEXT);
            string length = Console.ReadLine();

            try
            {
                _forEndPosition = Convert.ToInt32(length);
            }
            catch (Exception)
            {
                // todo: exception
                throw;
            }
        }

        public void Start()
        {
            ForLoopExecutorDescriptorObject descriptor = new ForLoopExecutorDescriptorObject(FizzBuzzLogic)
            {
                ForStartPosition = 1,
                ForEndPosition = _forEndPosition,
                ForIncrement = 1
            };

            LoopExecutor loopExecutor = LoopExecutorFactory.Instance.Create(descriptor);
            StackExecutor.Instance.AddItemToStack(loopExecutor);
        }

        public void Finish()
        {
            StackExecutor.Instance.RunStack();

            Console.ReadKey();
        }

        public void Execute(string[] args)
        {
            MapInputParameters(args);
            Input();
            Start();
            Finish();
        }

        private LoopExecutionReturnObject FizzBuzzLogic(ILoopStateObject loopState)
        {
            ForLoopStateObject forLoopState = (ForLoopStateObject)loopState;

            IAdapter adapter = AdapterFactory.Instance.Create(typeof(int), typeof(FizzbuzzLogicPrintable));

            FizzbuzzLogicPrintable printable = (FizzbuzzLogicPrintable)adapter.Adapt(forLoopState.ForState);
            StackExecutor.Instance.AddItemToStack(printable);

            return new LoopExecutionReturnObject();
        }
    }
}
