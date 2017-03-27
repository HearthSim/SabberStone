using System;

namespace SabberStonePowerLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Interpreter interpreter = new Interpreter(@"C:\Users\admin\Source\Repos\SabberStone\SabberStonePowerLog\Files\", "Power.log");
            interpreter.Parse();
            Console.WriteLine("Done parsing!");
            Console.ReadKey();
        }
    }
}
