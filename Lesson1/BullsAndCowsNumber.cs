using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson1
{
    public class BullsAndCowsNumber
    {
        public int bullsCount { get; private set; }
        public int cowsCount { get; private set; }

        public BullsAndCowsNumber(int bullsCount, int cowsCount)
        {
            this.bullsCount = bullsCount;
            this.cowsCount = cowsCount;
        }

        public BullsAndCowsNumber()
        {
            bullsCount = 0;
            cowsCount = 0;
        }

        public void IncreaseBull()
        {
            bullsCount++;
        }

        public void IncreaseCow()
        {
            cowsCount++;
        }
    }
}
