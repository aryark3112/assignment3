using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example using TryParse method to convert string to int
            string intString = "123";
            int intValue;
            if (int.TryParse(intString, out intValue))
            {
                Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
            }
            else
            {
                Console.WriteLine("TryParse failed. Invalid input string.");
            }

            // Example using Convert method to convert string to double
            //string doubleString = "3.14";
            //try
            //{
            //    double doubleValue = Convert.ToDouble(doubleString);
            //    Console.WriteLine("Convert successful. Converted double value: " + doubleValue);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Convert failed. Invalid input format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Convert failed. Input value is too large or too small.");
            //}


            // example using parse method to convert string to decimal
            string decimalstring = "10.25";
            try
            {
                decimal decimalvalue = decimal.parse(decimalstring);
                console.writeline("parse successful. converted decimal value: " + decimalvalue);
            }
            catch (formatexception)
            {
                console.writeline("parse failed. invalid input format.");
            }
            catch (overflowexception)
            {
                console.writeline("parse failed. input value is too large or too small.");
            }
        }
 }
}
