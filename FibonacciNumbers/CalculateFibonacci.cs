using System;

namespace FibonacciNumbers
{
    public class CalculateFibonacci
    {
        //{ F_{0}=0}
        internal Int32 ReturnedValue = 0;
        public CalculateFibonacci()
        {
        }

        public int Calculate(int steps)
        {
            if (steps == 1 || steps == 2)
            {
                //{ F_{1}=1,}
                ReturnedValue = 1;
            }else if (steps > 2)
            {
                //{F_{n}=F_{n-1}+F_{n-2},} https://en.wikipedia.org/wiki/Fibonacci_number
                ReturnedValue = Calculate(steps -1) + Calculate(steps - 2);
            }

            return ReturnedValue;
        }
    }
}
