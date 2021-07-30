using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestPrograms
{
    class DayOfWeekCalender
    {
        private static readonly NLog nLog = new NLog();

        public static void DayOfWeek(int d, int m, int y)
        {

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;

            Console.WriteLine("\n Sunday = 0, Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5 and Saturday = 6");
            Console.WriteLine("\n It is : " + d0);
            nLog.LogDebug(" Debug success for DayOfWeek()");
        }

        public void TakeInput()
        {
            int m, d, y;

            Console.Write(" Enter day Number (1-31) : ");
            d = int.Parse(Console.ReadLine());
            if(d >31 || d<1)
            {
                Console.WriteLine(" Invalid Input. Retry.");
                TakeInput();
            }

            Console.Write(" Enter month number (1 for January, 2 for February, 3 for March...) (1-12) : ");
            m =int.Parse(Console.ReadLine());
            if(m>12 || m<1)
            {
                Console.WriteLine(" Invalid Input. Retry.");
                TakeInput();
            }

            Console.Write(" Enter full year (yyyy) : ");
            y =int.Parse(Console.ReadLine());
            if(y<1000)
            {
                Console.WriteLine(" Invalid Input. Retry.");
                TakeInput();
            }

            DayOfWeek(d, m, y);
            nLog.LogDebug(" Debug success for TakeInput()");
        }
    }
}
