/*
 * Kiet Vo
 * ITSE 1430 
 * Lab 1
 */
using System;
using System.Text;
using System.IO;

namespace Budget
{
    class Program
    {
        static void Main ( string[] args )
        {
            while (true)
            {
                switch (DisplayMenu())
                {
                    case 'Q': return;

                    case 'A': AddInfo(); break;

                    case 'V': ViewInfo(); break;
                };
            };
        }

        static decimal currency;
        static string name = "";
        static string accountNumber;
        static decimal balance;

        static decimal amount;
        static string description;
        static string category;
        static DateTime date;
        static void AddInfo ()
        {
            Console.WriteLine("Name: ");
            name = ReadString(true);

            Console.WriteLine("AccountNumber: ");
            accountNumber = ReadString(true);

            Console.WriteLine("StartingBalance: ");
            balance = ReadDecimal(0);

        }

        static char DisplayMenu ()
        {
            // 1+ iteration, post test
            // do S while (E);
            // block statement => { S* }
            do
            {
                Console.WriteLine("Budget");
                Console.WriteLine("-----------------");

                Console.WriteLine("A)dd Info");
                Console.WriteLine("V)iew Info");
                Console.WriteLine("Q)uit");

                //Get input from user
                string value = Console.ReadLine();

                //C++: if (x = 10) ; //Not valid in C#
                // if (E) S;
                // if (E) S else S;
                //if (value == "Q")   // 2 equal signs => equality 
                if (String.Compare(value, "Q", true) == 0)
                    return 'Q';
                else if (String.Compare(value, "A", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return 'A';
                else if (String.Compare(value, "V", true) == 0)
                    return 'V';

                DisplayError("Invalid option");
            } while (true);
        }


        private static void DisplayError ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
        }

        static int ReadInt32 ()
        {
            return ReadInt32(Int32.MinValue);
        }
        static int ReadInt32 ( int minimumValue )
        {
            do
            {
                string value = Console.ReadLine();
                if (Int32.TryParse(value, out var result) && result > 0)
                    return result;
                if (minimumValue != Int32.MinValue)   
                    DisplayError("Value must be at least " + 1);  
                else
                    DisplayError("Must be integral value");
            } while (true);
        }

        static decimal ReadDecimal ( decimal minimumValue )
        {
            do
            {
                string value = Console.ReadLine();
                if (Decimal.TryParse(value, out var result) && result > 0)
                    return result;
                if (minimumValue != Decimal.MinValue)   
                    DisplayError("Value must be at least " + 0);  
                else
                    DisplayError("Must be integral value");
            } while (true);
        }


        static void ViewInfo ()
        {
            Console.WriteLine("Name\t\tAccountNumber\tBalance");
            //Console.WriteLine("-----------------");
            Console.WriteLine("".PadLeft(60, '-'));
            //var classicIndicator = isClassic ? "Yes" : "No";
            var message = $"{name}\t\t{accountNumber}\t\t{balance.ToString("C")}";
            Console.WriteLine(message);
            //Console.WriteLine( balance.ToString("C"));
            //Console.WriteLine(message);
            //if (!String.IsNullOrEmpty(description))
            //    Console.WriteLine(description);

            //Console.WriteLine("");
        }


        static string ReadString ( bool required )
        {
            do
            {
                string value = Console.ReadLine();

                //If not required or not empty return
                if (!required || value != "")
                    return value;

                DisplayError("Value is required");
            } while (true);
        }

        //static DateTime ReadDateTime ()

        //static void IncomeInfo ()
        //{
        //    Console.WriteLine("Name: ");
        //    description = ReadString(true);

        //    Console.WriteLine("Name: ");
        //    category = ReadString(true);

        //    Console.WriteLine("amount to add: ");
        //    amount = ReadInt32(0);

        //    Console.WriteLine("entryDate: ");
        //    date = ReadDecimal(0);

        //}

    }
}