using System;

namespace JufBOT
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            bot.Run().GetAwaiter().GetResult();
        }
    }
}
