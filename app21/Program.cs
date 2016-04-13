using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PartialCustomer C1 = new PartialCustomer ();
            C1.FirstName = "Akiyo";
            C1.LastName = "Yokota";
            Console.WriteLine(C1.GetFullName());
        }
    }
}
