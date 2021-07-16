using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class Delegates
    {
        public void CallTestActionParam() 
        {
            DateTime now = DateTime.Now;
            TestActionParam((now) => 
            {
                Console.WriteLine("Now as parametr");
                Console.WriteLine(now.AddDays(1)); 
            });
            TestActionParam((d) => 
            {
                Console.WriteLine("None as parametr");
                Console.WriteLine(d.AddDays(1)); 
            });
        }

        public void CallTestActionParametrless()
        {
            DateTime now = DateTime.Now;
            TestActionParametrless(() =>
            {
                Console.WriteLine("Now as parametr");
                Console.WriteLine(DateTime.Now.AddDays(1));
            });
            TestActionParametrless(() =>
            {
                Console.WriteLine("None as parametr");
                Console.WriteLine(DateTime.MinValue.AddDays(1));
            });
        }

        private void TestActionParam(Action<DateTime> funcDate) 
        {
            funcDate.Invoke(new DateTime(1995,6,25));
        }

        private void TestActionParametrless(Action funcDate)
        {
            funcDate.Invoke();
        }
    }
}
