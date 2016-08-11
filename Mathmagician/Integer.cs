using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public List<int> integers = new List<int>();

        public void Iteration(int input)
        {

            for (int i = 0; i < input; i++)
            {
                integers.Add(i);

            };
        }
          

        public int GetFirstNumber()
        {
            return 1;
        }

        public int GetNext(int v)
        {
            return v+1;
        }

        public List<int> GetList(int userNum)
        {
            List<int> IntegersList = new List<int>();
            IntegersList.Add(GetFirstNumber());
        
             for (int i = GetFirstNumber(); i < userNum; i++)
            {
                IntegersList.Add(GetNext(i));
               
            }
                 
            return IntegersList;
        }

    }
}
