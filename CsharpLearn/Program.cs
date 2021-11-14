using CsharpLearn.Async;
using System;
using System.Threading.Tasks;

namespace CsharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegates delegates = new MyDelegates();
            //delegates.CallMyWhere();
            //string s = "Hello world";
            //EventHandler<string> handler = (sender, args) => { };
            //delegates.helloWorldEvent = handler;
            //handler.Invoke(new object(), "");

            //MainAsync().GetAwaiter().GetResult();
        }
        private static void HelloWorldHandler() { }

        static async Task MainAsync()
        {
            LinqDefferedAsync linqDefferedAsync = new LinqDefferedAsync();
            var users = await linqDefferedAsync.GetUsersAsync();
            foreach (var u in users)
                Console.WriteLine(u);
        }
    }
}
