using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_10._5
{
    internal class Logger : ILogger
    {
        public void Error(Exception ex)
        {
            Console.WriteLine("\n ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }



        public void Event(string s)
        {
            Console.WriteLine("\n ");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s);
            Console.ResetColor();

        }
    }
}
