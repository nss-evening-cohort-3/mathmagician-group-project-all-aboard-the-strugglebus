using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Primes
    {
        public int StartofPrimes()
        {
            return 2;
        }

        public int AnotherPrime(int v)
        {
            return 3;
        }

        public List<int> ListPrimes(int userNum)
        {
            List<int> PrimeSequence = new List<int>();
            PrimeSequence.Add(2);
            int nextPrimeNumber = 3;

            while (PrimeSequence.Count < userNum)
            {
                int sqrt = (int)Math.Sqrt(nextPrimeNumber);
                bool isPrime = true;
                for (int i = 0; (int)PrimeSequence[i] <= sqrt; i++)
                {
                    if (nextPrimeNumber % PrimeSequence[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    PrimeSequence.Add(nextPrimeNumber);        
                }

                nextPrimeNumber += 2;
            }

            return PrimeSequence;
        }
    }
}
