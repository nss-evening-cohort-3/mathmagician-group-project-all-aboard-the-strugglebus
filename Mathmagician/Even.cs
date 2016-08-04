using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even
    {
        public List<int> returnList = new List<int>();

        public int workingNum = 0;

        public void Iterate(int userNum)
        {
            for (int i = 0; i < userNum; i++)
            {
                returnList.Add(workingNum);
                workingNum = workingNum + 2;
            }

            Console.WriteLine("Here they are:  ");
            returnList.ForEach(Console.Write);

        }

    }
}
