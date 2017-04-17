using System;

namespace SabberStonePowerLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new Interpreter(@"C:\Users\admin\Source\Repos\SabberStone\SabberStonePowerLog\Files\", "Power.log");
            interpreter.Parse();
            Console.WriteLine("Done parsing!");
            var powerGame = Interpreter.Load(@"C:\Users\admin\Source\Repos\SabberStone\SabberStonePowerLog\Files\powerLog.json");
            Console.WriteLine($"Done loading ... {(powerGame as PowerGame)?.Entities.Count}!");
            Console.ReadKey();
        }
    }
}
