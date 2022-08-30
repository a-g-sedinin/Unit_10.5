using System;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Unit_10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myCalc myCalc = new myCalc();
            NumReader numReader = new NumReader();

            int a;
            int b;
            int i = 1;
            while (true && i>0)
            {
                try
                {
                    Console.WriteLine("\n Input value a");
                    a = numReader.KeyRead();
                    i--;
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            i++;
            while (true && i > 0)
            {
                try
                {
                    Console.WriteLine("\n Input value b");
                    b = numReader.KeyRead();
                    i--;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }



        }
    }
}
