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
            return 0;
        }

        public int GetNext(int v)
        {
            return v+1;
        }

        public List<int> GetList(int end)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < end; i++)
                list.Add(i + 1);
            return list;
        }

    }
}
