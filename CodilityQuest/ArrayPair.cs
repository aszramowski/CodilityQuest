using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuest
{
    class ArrayPair
    {
        public int solution(int[] A)
        {
            int unpaired = 0;

            unpaired = (from x in A
                        group x by x into y
                        where y.Count() % 2 == 1
                        select y.Last()).Last();

            return unpaired;
        }
    }
}
