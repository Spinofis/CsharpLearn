using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn
{
    public class DelegateComparer<T>
    {
	public delegate int Comparison(T left, T right);

	public Comparison comparison;
    }
}
