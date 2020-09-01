using System;
using System.Collections.Generic;

namespace NumberRandomizer
{
    internal class NumberPoolRandomizer
    {
        internal List<short> GetRandomizedNumbersPool(List<short> numbersPool)
        {
            if (numbersPool == null)
                throw new ArgumentNullException(nameof(numbersPool));

            var result = new List<short>(numbersPool.Capacity);
            var randomizer = new Random();
            while (numbersPool.Count > 0)
            {
                var maxPoolIndex = numbersPool.Count;
                var currentNumberIndex = randomizer.Next(0, maxPoolIndex);
                var currentValue = numbersPool[currentNumberIndex];
                result.Add(currentValue);
                numbersPool.RemoveAt(currentNumberIndex);
            }
            return result;
        }
    }
}
