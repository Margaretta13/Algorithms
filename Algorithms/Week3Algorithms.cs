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

        public decimal GetMaximumValueOfLoot(string[] inputs)
        {
            string[] firstInput = inputs[0].Split(" ");
            int numAmount = Convert.ToInt32(firstInput[0]);
            int totalWeight = Convert.ToInt32(firstInput[1]);

            decimal[] valuesPerWeight = new decimal [numAmount];

            for (int i = 0; i < numAmount - 1; i++)
            {
                string[] temp = inputs[0].Split(" ");

                valuesPerWeight[i] = Convert.ToInt32(temp[0]) / Convert.ToInt32(temp[1]);
            }


            decimal weight = 0;
            while (weight <= totalWeight)
            {
                //int

            }

            return 0;
        }
    }
}