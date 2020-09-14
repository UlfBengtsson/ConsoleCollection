using System;

namespace ConsoleCollection
{
    class Program
    {

        static void Main(string[] args)
        {
            PrimitivNumber();
            
            //Arrays();
            
        }

        static void PrimitivNumber()
        {
            double number = 0.0;

            Console.WriteLine(number);

            countUpNumber(number);

            Console.WriteLine("after method call");
            Console.WriteLine(number);
        }

        static void countUpNumber(double num)
        {
            for (int i = 0; i < 5; i++)
            {
                num++;
            }
        }

        //--------------------------------------------------------------------

        static void Arrays()
        {
            int[,] multiTable = new int[10, 10];

            foreach (var item in multiTable)
            {
                Console.WriteLine(item);
            }

            SetMultiNumbers(multiTable);

            Console.WriteLine("after method call");

            foreach (var item in multiTable)
            {
                Console.WriteLine(item);
            }

        }

        static void SetMultiNumbers(int[,] table)
        {
            for (int y = 0 ; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    table[y, x] = (y + 1) * (x + 1);
                }
            }
        }
    }
}
