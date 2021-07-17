using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CsharpLearn.Delegates;

namespace CsharpLearn
{
    public class MyDelegates
    {
	public delegate bool ComparsionInt(int left, int right);

	public delegate void HelloWorld();

	public event HelloWorld helloWorldEvent;

	public ComparsionInt comparsionInt;

	public HelloWorld nothing;

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

	public void CallMulticastDelegate()
	{
	    nothing = helloWorld1;
	    nothing = helloWorld2;
	    nothing += helloWorld1;
	    nothing.Invoke();
	}

	public void CallMyWhere()
	{
	    var numbers = System.Linq.Enumerable.Range(1, 20);
	    IEnumerable<string> strings = numbers.MyWhereMethod(n => n % 2 == 0).Select(x => x.ToString());
	    Console.WriteLine(string.Join(" ", strings));
	}

	public void CallEvent() 
	{
	    string s = "Hello world";
	    EventHandler<string> handler = (sender, args) => { };
	    helloWorldEvent += handler;
	}

	private void TestActionParam(Action<DateTime> funcDate)
	{
	    funcDate.Invoke(new DateTime(1995, 6, 25));
	}

	private void TestActionParametrless(Action funcDate)
	{
	    funcDate.Invoke();
	}

	private void helloWorld1()
	{
	    Console.WriteLine($"Hello world 1");
	}

	private void helloWorld2()
	{
	    Console.WriteLine($"Hello world 2");
	}
    }
}
