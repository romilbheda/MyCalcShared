using System;

namespace MyCalcShared
{
    public class CalcService
    {
        static public int AddValue(int prodA, int prodB)
        {
            int total1, total2, finaltotal;

            total1 = prodA + prodB;
            total2 = (total1 * 5) / 100;
            finaltotal = total1 - total2;
            return finaltotal;
        }
    }
}
