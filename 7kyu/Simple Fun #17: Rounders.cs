/*
Description

Task
We want to turn the given integer into a number that has only one non-zero digit using a tail rounding approach. 
This means that at each step we take the last non 0 digit of the number and round it to 0 or to 10. 
If it's less than 5 we round it to 0 if it's larger than or equal to 5 we round it to 10 (rounding to 10 means 
increasing the next significant digit by 1). The process stops immediately once there is only one non-zero digit left.

Example
For value = 15, the output should be 20
For value = 1234, the output should be 1000.
1234 -> 1230 -> 1200 -> 1000.
For value = 1445, the output should be 2000.
1445 -> 1450 -> 1500 -> 2000.

Input/Output
[input] integer value
A positive integer.
Constraints: 1 ≤ value ≤ 108
[output] an integer
The rounded number.
*/

namespace myjinxin
{
    using System;

    public class Kata
    {
        public int Rounders(int Value)
        {
            for (double i = 10; i < Value; i *= 10)
            {
                Value = (int)(i * Math.Round(Value / i, MidpointRounding.AwayFromZero));
            }
            return Value;
        }
    }
}