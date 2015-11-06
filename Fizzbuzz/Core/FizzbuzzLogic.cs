using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.Core
{
    internal sealed class FizzbuzzLogic : Singleton<FizzbuzzLogic>
    {
        private FizzbuzzLogic() { }

        private Dictionary<int, FizzbuzzResultType> _resultBuffer = null;

        public FizzbuzzResultType GetResultTypeFromNumber(int number)
        {
            if (!HasBufferEntry(number))
            {
                FillBufferWithNewEntry(number);
            }

            return _resultBuffer[number];
        }

        private bool HasBufferEntry(int number)
        {
            if (_resultBuffer == null)
                _resultBuffer = new Dictionary<int, FizzbuzzResultType>();

            return _resultBuffer.ContainsKey(number);
        }

        private void FillBufferWithNewEntry(int number)
        {
            FizzbuzzResultType value;

            if (IsDivisibleBy3(number) && IsDivisibleBy5(number))
            {
                value = FizzbuzzResultType.Fizzbuzz;
            }
            else if (IsDivisibleBy3(number))
            {
                value = FizzbuzzResultType.Fizz;
            }
            else if (IsDivisibleBy5(number))
            {
                value = FizzbuzzResultType.Buzz;
            }
            else
            {
                value = FizzbuzzResultType.Number;
            }

            _resultBuffer.Add(number, value);
        }

        private bool IsDivisibleBy3(int number)
        {
            //Algorithm to determine if a number is divisible by 3:
            //Reference: https://en.wikipedia.org/wiki/Divisibility_rule#Divisibility_by_3_or_9
            //In short: as long as the number has more than one char, sum up the parts of the number
            //If the resulting number is 3, 6 or 9, it is divisible by 3.

            string numText = number.ToString();

            while (numText.Length > 1)
            {
                int result = 0;
                for (int i = 0; i < numText.Length; i++)
                {
                    result += Convert.ToInt32(numText[i].ToString());
                }
                numText = result.ToString();
            }

            return (numText == "0" ||
                    numText == "3" || 
                    numText == "6" || 
                    numText == "9");
        }

        private bool IsDivisibleBy5(int number)
        {
            //Algorithm to determine if a number is divisible by 5:
            //Reference: https://en.wikipedia.org/wiki/Divisibility_rule#Divisibility_by_5
            //If the last digit is "5" or "0", then it is divisible by 5.

            string numText = number.ToString();
            char lastDigit = numText[numText.Length - 1];

            return (lastDigit == '0' || 
                    lastDigit == '5');
        }
    }
}
