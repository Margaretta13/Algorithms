using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Algorithms
{
    public class Week3Algorithms
    {
        private const int One = 1;
        private const int Five = 5;
        private const int Ten = 10;

        public int GetMinimumNumberOfCoins(int inputValue)
        {
            int numnerOfCoins = Convert.ToInt32(inputValue / Ten);
            int remainder = inputValue % Ten;
            if (remainder == 0)
            {
                return numnerOfCoins;
            }
            
            numnerOfCoins = numnerOfCoins + Convert.ToInt32(remainder / Five);
            remainder = remainder % Five;
            if (remainder == 0)
            {
                return numnerOfCoins;
            }

            numnerOfCoins = numnerOfCoins + Convert.ToInt32(remainder / One);
            return numnerOfCoins;
        }
    }
}