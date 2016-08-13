using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odd
    {
        public List<int> Iterate(int userNum)
        {
            List<int> ReturnList = new List<int>();
            int workingNum = 1;

            for (int i = 0; i < userNum; i++)
            {
                ReturnList.Add(workingNum);
                workingNum = workingNum + 2;
            }
            return ReturnList;
        }
    }
}
