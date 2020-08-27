using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryGap bg = new BinaryGap();

            var binaryGap = bg.solution(32);

            ArrayRotation ar = new ArrayRotation();

            var rotatedArray = ar.solution(new int[] { 1, 2, 3, 4, 5 }, 3);

            ArrayPair ap = new ArrayPair();

            var unpairedNumber = ap.solution(new int[] { 1, 1, 2, 2, 3, 4, 3 });

            Console.ReadKey();
        }
    }
}
