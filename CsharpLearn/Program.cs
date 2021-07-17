using System;

namespace CsharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
	    MyDelegates delegates = new MyDelegates();
            delegates.CallMyWhere();
	    //string s = "Hello world";
	    //EventHandler<string> handler = (sender, args) => { };
	    //delegates.helloWorldEvent = handler;
	    //handler.Invoke(new object(), "");
	}
    }
}
