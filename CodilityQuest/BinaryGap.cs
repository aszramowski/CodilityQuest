using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuest
{
    class BinaryGap
    {
        public int solution(int N)
        {
            int rem;
            int counter = 0;
            int maxCounter = 0;
            bool startsWithZero;

            rem = N % 2;
            startsWithZero = rem == 0 ? true : false;

            do
            {
                rem = N % 2;
                N /= 2;
                //number = number << 1;

                if (startsWithZero && rem == 1)
                {
                    startsWithZero = false;
                }
                else if (!startsWithZero)
                {
                    if (rem == 0)
                        counter++;
                    else
                    {
                        maxCounter = counter > maxCounter ? counter : maxCounter;
                        counter = 0;
                    }
                }

            } while (N >= 1);

            return maxCounter;
        }
    }
}
