using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1_1
{
    public class Class1
    {
        public Class1(int A1,int B1,int X1)
        {
            A = A1;
            B = B1;
            X = X1;
            if (A > 1 && B == 0)
            {
                X = X / A;
            }
            if (A == 2 || X > 1)
            {
                X = X + 1;
                Console.WriteLine(X);
            }
            else
            {
                Console.WriteLine(X);
            }
        }

        private int A,B,X;


    }
    
}
