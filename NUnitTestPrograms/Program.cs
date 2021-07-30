﻿using System;

namespace NUnitTestPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" NUnitTesting Programs ");
            Console.WriteLine("\n Here is the list of programs : \n" +
                " 1. Vending machine \n" +
                " 2. Get day of weekfrom calender year\n");

            Console.Write(" Type an Option number to run a program : ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    VendingMachine vm = new VendingMachine();
                    vm.Machine();
                    break;
                case 2:
                    DayOfWeekCalender day = new DayOfWeekCalender();
                    day.TakeInput();
                    break;
                default:
                    Console.WriteLine(" Invalid Option number. ");
                    break;
            }
        }
    }
}
