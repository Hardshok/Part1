using System;

namespace ConcoleApp_Divider
{
    class Program
    {
        static void Main()
        {
            bool bRepeat = true;

            //Header
            Console.Title = "Devider or not devider? :-)";
            WriteColorLine(ConsoleColor.White, "**** Test whether second number is divider of first ****\n");

            while (bRepeat)
            {
                //Input
                WriteColorLine(ConsoleColor.Cyan, "Enter the first number:");                
                string sFirst = Console.ReadLine();
                WriteColorLine(ConsoleColor.Cyan, "Enter the second number:");                
                string sSecond = Console.ReadLine();

                // find modulo + catch format exception
                try
                {
                    int iFirst = Convert.ToInt32(sFirst);
                    int iSecond = Convert.ToInt32(sSecond);

                    if (iFirst % iSecond == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nRESULT: Second number '{0}' is divider of first number '{1}'", iSecond, iFirst);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nRESULT: Second number '{0}' is NOT divider of first number '{1}'", iSecond, iFirst);
                        Console.ResetColor();
                    }
                }
                catch (FormatException)
                {
                    WriteColorLine(ConsoleColor.Red, "\nERROR - Input string is not a number");
                }
                catch (OverflowException)
                {
                    WriteColorLine(ConsoleColor.Red, "\nERROR - Input numbers are not in the range");
                }

                //Is Repeat
                WriteColorLine(ConsoleColor.White, "\nDo you want to repeat? Y/N");                
                string sRepeat = Console.ReadLine();
                if (sRepeat == "y" || sRepeat == "Y")
                {
                    bRepeat = true;
                    Console.WriteLine();
                }
                else
                {
                    bRepeat = false;                    
                }
            }

            WriteColorLine(ConsoleColor.White, "\nPress any key to exit...");            
            Console.ReadKey();
        }

        static void WriteColorLine(ConsoleColor sColor, string sMessage)
        {
            Console.ForegroundColor = sColor;
            Console.WriteLine(sMessage);
            Console.ResetColor();
        }
    }
}
