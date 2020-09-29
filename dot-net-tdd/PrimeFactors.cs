using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace dot_net_tdd
{
    public class PrimeFactors
{
        public List<int> Generate(int num)
        {
            List<int> result = new List<int>();

            int temp = num;

            for (int counter = 2; counter <= temp; counter++)
            {
                while (temp % counter == 0)
                {
                    temp /= counter;
                    result.Add(counter);
                }
            }
           
                  
            return result;
        }
}
}
