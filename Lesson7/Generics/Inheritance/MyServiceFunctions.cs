using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyServiceFunctions
    {
        #region ****** SERVICE METHODS ******
        public static void WriteColorLine(ConsoleColor sColor, string sMessage)
        {
            Console.ForegroundColor = sColor;
            Console.WriteLine(sMessage);
            Console.ResetColor();
        }
        public static bool IsRepeat(string message)
        {
            WriteColorLine(ConsoleColor.White, "\n" + message + " Y/N");
            string sRepeat = Console.ReadLine();
            bool bRepeat = (sRepeat == "y" || sRepeat == "Y") ? true : false;
            return bRepeat;
        }

        /// <summary>
        /// Read console line and convert it to Int32. User have to enter while it will be not number. By default '0' is allowed. 
        /// </summary>
        /// <param name="isZeroAllowed"></param>
        /// <returns></returns>
        public static int ReadAndValidate(bool isZeroAllowed = true)
        {
            int iLine;
            if (!isZeroAllowed) //entering '0' is not allowed
            {
                while (Int32.TryParse(Console.ReadLine(), out iLine) == false || iLine == 0)
                    WriteColorLine(ConsoleColor.Red, "The value is equal '0', not a number or out of the range. Enter it again:");
            }
            else
            {
                while (Int32.TryParse(Console.ReadLine(), out iLine) == false)
                    WriteColorLine(ConsoleColor.Red, "The value is not a number or out of the range. Try to enter it again:");
            }
            return iLine;
        }
        #endregion
    }
}
