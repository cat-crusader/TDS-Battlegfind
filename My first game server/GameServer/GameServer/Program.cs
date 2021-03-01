using System;

namespace GameServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MY_GAME_SERVER";
            Server.Start(50, 26950);
            Console.ReadKey();
        }
    }
}
