using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn.OOP
{
    class C : B
    {
        public C(string s) : base(s) { }

        public override void Fun()
        {
            base.Fun();
        }
    }
}
