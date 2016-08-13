using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fibonacci
    {

        public List<int> Sequence(int userNum)
        {
            if (userNum == 1)
            {
                return new List<int> { 0 };
            }
            if (userNum == 2)
            {
                return new List<int> { 0, 1 };
            }
            List<int> FibonacciSequence = new List<int> { 0, 1 };
            int prevNum = 0;
            int currentNum = 1;            

            for (int i = 2; i < userNum; i ++)
            {
                int sum = currentNum + prevNum;
                prevNum = currentNum;
                currentNum = sum;
               
                FibonacciSequence.Add(currentNum);
  

            }

            return FibonacciSequence;


        }
    }
}
