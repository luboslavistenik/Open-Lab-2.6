using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_2._6
{
    class Calculator
    {
        public bool DivisibleByHundred(int number)
        {
            if (number % 100 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
