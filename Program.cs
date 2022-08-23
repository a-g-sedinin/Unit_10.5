using System;

namespace Unit_10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myCalc myCalc = new myCalc();
            
            
            NumReader numReader = new NumReader();
            
            

            
            
            Console.WriteLine(myCalc.Sum(1, 5));
        }
    }
}
