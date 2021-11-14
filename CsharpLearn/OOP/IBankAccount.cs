using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn.OOP
{
    interface IBankAccount
    {
        void Test()
        {
            Console.WriteLine("Test");
        }

        int GetX(int x)
        {
            return x;
        }
    }
}
