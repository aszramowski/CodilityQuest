using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuest
{
    class ArrayRotation
    {
        public int[] solution(int[] A, int K)
        {
            int newInd;
            int[] newA = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                newInd = (i + K) % A.Length;
                newA[newInd] = A[i];
            }

            return newA;
        }
    }
}
