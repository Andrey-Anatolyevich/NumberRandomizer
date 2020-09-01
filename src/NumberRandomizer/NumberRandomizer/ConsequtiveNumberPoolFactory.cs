using System;
using System.Collections.Generic;

namespace NumberRandomizer
{
    internal class ConsequtiveNumberPoolFactory
    {
        internal List<short> GenerateNumbersPool(short numberFrom, short numberTo)
        {
            var minNumber = Math.Min(numberFrom, numberTo);
            var maxNumber = Math.Max(numberFrom, numberTo);

            var poolResultCapacity = (maxNumber - minNumber) + 1;
            var result = new List<short>(poolResultCapacity);

            if (numberFrom <= numberTo)
                for (var currentNumber = numberFrom; currentNumber <= (short)numberTo; currentNumber++)
                    result.Add(currentNumber);
            else
                for (var currentNumber = numberFrom; currentNumber >= (short)numberTo; currentNumber--)
                    result.Add(currentNumber);

            return result;
        }
    }
}
