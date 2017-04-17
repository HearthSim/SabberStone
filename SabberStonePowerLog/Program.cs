using System;
using SabberStonePowerLog.Model;

namespace SabberStonePowerLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new Interpreter(@"C:\Users\admin\Source\Repos\SabberStone\SabberStonePowerLog\Files\", "Power.log");
            var games = interpreter.Parse(true, true);
            Console.WriteLine($"Done parsing! Found {games.Count} game(s) in log.");
            Console.ReadKey();

        }
    }
}
