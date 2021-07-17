using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn.Delegates
{
    public static class MyWhere
    {
	public static IEnumerable<TSource> MyWhereMethod<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) 
	{
	    foreach (var item in source)
		if (predicate.Invoke(item))
		    yield return item;
	}
    }
}
