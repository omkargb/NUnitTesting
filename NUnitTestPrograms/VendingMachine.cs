using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestPrograms
{
    class VendingMachine
    {
        private static readonly NLog nLog = new NLog();

        public void Machine()
        {
            Console.WriteLine(" \tINR Currency vending machine \n" +
                " Denominations Available (Rs.) : 1, 2, 5, 10, 50, 100, 500 and 1000 ");
           
            Console.Write(" Enter the amount you want change for : ");
            int amount = int.Parse(Console.ReadLine());

            int[] notesAvailable = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] numOfNotes = new int[8];
            int count=0;
            Console.WriteLine("\n Dispatched Denomination and count :- ");
            for (int i = 0; i <= 7; i++)
            {
                if (amount >= notesAvailable[i])
                {
                    numOfNotes[i] = amount / notesAvailable[i];
                    amount = amount - notesAvailable[i] * numOfNotes[i];
                    Console.WriteLine(" {0}\t=\t{1} ",notesAvailable[i],numOfNotes[i]);
                    count = count + numOfNotes[i];
                }
            }
            Console.WriteLine(" Total Notes given : "+count);
            nLog.LogDebug(" Debug success for Machine() ");
            nLog.LogInfo(" Machine method passed. ");
        }
    }
}
