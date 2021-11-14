using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn.OOP
{
    class B : A
    {
        public B(string s) : base(s) { }

        public override void Fun()
        {
            base.Fun();
        }
    }
}
