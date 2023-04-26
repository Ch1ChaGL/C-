using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Задание_13Варинат
{
    public static class digitalRadical
    {
        public static int CalculateDigitalRadical(int naturalNumber) {      
            if (!(naturalNumber > 0 && naturalNumber % 1 == 0)) throw new ArgumentException("Значение не входит в множество");
            if (naturalNumber / 10 == 0) return naturalNumber;
            int sum = 0;
            while(naturalNumber > 0)
            {
                int digit = naturalNumber % 10;
                sum += digit;
                naturalNumber /= 10;
            }
            return CalculateDigitalRadical(sum);
        }
    }
}
