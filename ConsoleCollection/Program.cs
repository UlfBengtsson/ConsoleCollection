using System;
using System.Collections.Generic;// Req. for List
using System.Text;// Req. for StringBuilder

namespace ConsoleCollection
{
    class Program
    {

        static void Main(string[] args)
        {
            //PrimitivNumber();

            //Arrays();

            //AskForNumber();

            bool keepLopping = true;
            List<double> numberList = new List<double>();

            while (keepLopping)
            {
                Console.WriteLine("--------Menu---------");
                Console.WriteLine("1: Print list");
                Console.WriteLine("2: Add to list");
                Console.WriteLine("-1: Exit");

                double selection = AskForNumber();

                switch (selection)
                {
                    case 1:
                        PrintList(numberList);
                        break;

                    case 2:
                        numberList.Add( AskForNumber() );
                        break;

                    case 666:
                        SpeedDifStringVSStringBuilder();
                        break;

                    case 667:
                        ExRandom();
                        break;

                    case 668:
                        ExKeyChar();
                        break;

                    case -1:
                        keepLopping = false;
                        Console.WriteLine("Thanks for using this program.");
                        break;
                    default:
                        Console.WriteLine("not a valid selection.");
                        break;
                }
            }

        }

        // line comment

        /*
         * Block comment
         * 
         * 
         */
        static void PrintList(List<double> numbers)
        {
            Console.WriteLine("---- List -----");

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        static void ExRandom()
        {
            Random random = new Random(0);
            Random random2 = new Random(0);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(1 , 5)); // 1-4
            }

            Console.WriteLine("----------");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random2.Next(1, 5)); // 1-4
            }
        }

        static void ExKeyChar()
        {
            Console.WriteLine("press a key");
            char aSymbol = Console.ReadKey().KeyChar;
            
            Console.WriteLine("press a key once more");
            char aSymbol2 = Console.ReadKey(true).KeyChar;

            Console.WriteLine("First press was: " + aSymbol + "\nnumber: " + (int)aSymbol);
            Console.WriteLine("Second press was: " + aSymbol2 + "\nnumber: " + (int)aSymbol2);
            Console.WriteLine(aSymbol + 1 + " look out for doing math on a char " + aSymbol + 1);
        }

        static void TextEx()
        {

            string someText = "some text" + "another text";

            char letter = someText[3];

            someText.Contains('x');//char
            someText.Contains("text");//string
            someText.IndexOf('x');

            Console.WriteLine(someText[3]);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.ToString().Contains('x');

            stringBuilder.Append("some text");
            stringBuilder.Append("another text");

            Console.WriteLine(stringBuilder);

        }

        static void SpeedDifStringVSStringBuilder()
        {
            string star = "";

            DateTime stringStart = DateTime.Now;
            for (int i = 0; i < 1_000; i++)
            {
                star = star + "*";
            }
            DateTime stringEnd = DateTime.Now;

            StringBuilder stringBuilder_star = new StringBuilder();

            DateTime sbStart = DateTime.Now;
            for (int i = 0; i < 1_000; i++)
            {
                stringBuilder_star.Append("*");
            }
            DateTime sbEnd = DateTime.Now;

            Console.WriteLine("String time: " + (stringEnd - stringStart));
            Console.WriteLine("StringBuilder time: " + (sbEnd - sbStart));
        }

        static double AskForNumber()
        {
            bool notNumber = false;

            double number = 0;

            do
            {
                Console.Write("Please input a number: ");


                try
                {

                    number = double.Parse( Console.ReadLine() );
                    // will not go past here is ther is a exception.
                    notNumber = false;

                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Some how i did not get your input.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number was too big for the program.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Was unable to read the number.\nYou must use the numbers and not text.");
                }
                catch
                {
                    Console.WriteLine("Some error happend.");
                    notNumber = true;
                }
                finally //will allways execute
                {
                    //Console.WriteLine("Number was: " + number);
                    //Console.WriteLine("Number was: {0}", number);
                    Console.WriteLine($"Number was: {number}");
                }

            } while (notNumber);

            return number;

        }

        static void PrimitivNumber()
        {
            double number = 0.0;
            
            Console.WriteLine(number);

            CountUpNumber(number);

            Console.WriteLine("after method call");
            Console.WriteLine(number);
        }

        static void CountUpNumber(double num)
        {
            for (int i = 0; i < 5; i++)
            {
                num++;
            }
        }

        //--------------------------------------------------------------------

        static void Arrays()
        {
            int[,] multiTable = new int[5, 5];

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

        //-----------------------------------------------------------------

        static void ListMethod()
        {
            List<double> numbersList = new List<double>();

            numbersList.Add(5.5);
        }
    }
}
