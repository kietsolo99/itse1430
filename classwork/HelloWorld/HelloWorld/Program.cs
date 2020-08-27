/*
 * Kiet Vo
 * ITSE 1430
 * Lab 1
*/
using System;

namespace HelloWorld
{
    //pascal casing - Capitalize on word boundaries including first word
    //Camel casing - Capitalize on word boudaries except first (e.g firstName, payRate)
    class Program
    {
        //Function declaration - decleration to complier that a function exists with a given signature
        //Funtion signature - funtion name and the parameter types (somtimes it will include return type)
        //Funtion definition - declaration + implementation
        static void Main(string[] args) // 1 parameter
        {
            // Comments go above the block of code

            //Display given string to output
            //Arguments - data passed to funtion
            Console.WriteLine("Hello World!"); // same as printf , cout

            //Variable declaration;
            // Type id;
            //int hours;

            //hours = 10; // Assignment operator: id = E

            //Identifier Rules:
            //1. Unique within scope
            //2. Must start with underscore or letter
            //3. Consists of letters, digits and underscores
            //eg.
            //firstName, first_Name, first_name, pay1rate, NOT 1payRate
            //Always Camel case local variables
            //Preferred: T id = E
            int hours = 10;

            //int pay = 0;

            //pay = hours * 9;
            int totalPay = hours * 9;

            //Function overloading - multiple function with  same name but different parameter
            // atof, atoi
            Console.WriteLine(totalPay);

        }
    }
}
