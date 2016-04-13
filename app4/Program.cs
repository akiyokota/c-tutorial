using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app4
{
    public class Program
    {
        
        public static void nullable_datatype() {
            Console.WriteLine("###Nullable Datatype###");
            
            /*nullable datatypes*/
            String nullstring = null;
            Console.WriteLine("Null String: {0}", nullstring);
            
            int? nullint = null;
            Console.WriteLine("Null Int: {0}", nullint);
            
            bool? boolnull = null;
            if(boolnull == true)
                Console.WriteLine("boolnull is true");
            else if(boolnull == false)
                Console.WriteLine("boolnull is false");
            else if(boolnull == null)
                Console.WriteLine("boolnull is null");
                
            int? numTicket = null;
            int ticketsOnSale = numTicket ?? 10;
            Console.WriteLine("Null int: {0}", ticketsOnSale);
        }
        
        public static void data_conversion() {
            Console.WriteLine("###Data Conversion###");
            
            /*data conversion*/
            //implicit conversion
            int i = 100;
            float f = i; //no loss info when int -> float cause float is large
            Console.WriteLine("int->float {0}", f);
            
            //explicit conversion
            //this way will not throw exception
            float f2 = 123.45F;
            int i2 = (int) f2; 
            Console.WriteLine("float->int {0}", i2);

            //this way will throw exception
            float f3 = 123.45f;
            int i3 = Convert.ToInt32(f3);
            Console.WriteLine("float->int {0}", i3);
            
            String strNumber = "100";
            int i4 = int.Parse(strNumber);
            Console.WriteLine("string->int {0}", i4);

            String strNumber2 = "100GT";
            int i5 = 0;
            bool isConversionSuccessful = int.TryParse(strNumber2, out i5);
            Console.WriteLine("Conversion successful: {0}", isConversionSuccessful);
            Console.WriteLine("string->int {0}", i5);


        }
        
        public static void Main(string[] args)
        {
            nullable_datatype();
            data_conversion();
          
        }
    }
}
