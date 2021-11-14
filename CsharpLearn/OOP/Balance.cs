using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn.OOP
{
    public class Balance
    {
	public static int x;
	const int z = 2;
	public int y;

	static Balance() 
	{
	    x = 1;
	    Fun();
	}

	public static void Fun() { }
    }
}
