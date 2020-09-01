using System.Collections.Generic;

namespace NumberRandomizer
{
    internal class RandomNumberGenerator
    {
        internal List<short> GenerateRandomNumbers(short numberFrom, short numberTo)
        {
            var numberGenerator = new ConsequtiveNumberPoolFactory();
            var numberPool = numberGenerator.GenerateNumbersPool(numberFrom, numberTo);
            var numberPoolRandomizer = new NumberPoolRandomizer();
            var result = numberPoolRandomizer.GetRandomizedNumbersPool(numberPool);
            return result;
        }
    }
}
