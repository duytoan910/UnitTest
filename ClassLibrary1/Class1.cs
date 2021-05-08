using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int MaxAndMean(int A, int B,int C, out double Mean)
        {
            Mean = (A + B + C) / 3;
            int Max;
            if (A > B)
            {
                if (A > C)
                    Max = A;
                else Max = B;
            }
            else if (B > C) Max = B;
            else Max = C;
            return Max;
        }

        public double GetTotalItemPrice(int count)
        {
            double price = 10.99;
            double total;
            total = count * price;
            if (total < 0)
            {
                throw new Exception("The total is less than zero");
            }
            return total;
        }

    }
}
