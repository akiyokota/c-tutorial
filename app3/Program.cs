using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("App3 : datatypes");
            
            //boolean type
            bool b = true;

            //Integral types:
            /* 
            sbyte -128 ~ 127,
            byte 0 ~ 255,
            short -32768 ~ 32767,
            ushort 0 ~ 65535,
            int -2147483648 ~ 2147483647,
            uint 0 ~ 4294967295,
            long -9223372036854775808 ~ 9223372036854775807,
            ulong 0 ~ 18446744073709551615,
            char u+0000 ~ u+ffff
            */
            int i = 0;
            Console.WriteLine("Min = {0}", int.MinValue);
            
            
            //Float types
            /*
            float +/- 1.5e-45 ~ +/-3.4e38
            double +/- 5.0e-324 ~ +/-1.7e308
            decimal (-7.9x10^28 ~ 7.9x10^28)/(10^0~28) 128 bit
            */
            double d = 123.22242433;
            Console.WriteLine(d);
            decimal d2 = 5;
            Console.WriteLine(d2);
            
            //Escape sequemce
            /*
            \a bell(alert)
            \b backspace
            \f formfeed
            \n newline
            \r carriage return
            \t horizontal tab
            \v vertical 
            \' single quote
            \" double quote
            */
            Console.WriteLine(@"a\tb\\c\\d");
            
            
            //common operators
            /*
            assignment operator = 
            arithmetic operator +,-,*,/,% 
            comparison operator ==, !=, >, >=, <, <=
            conditional operator &&, ||
            Ternary Operator ?:
            Null coalescinig Operator ??
            */
            int number = 10;
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("number == 10 is {0}", isNumber10);
        }
    }
}
