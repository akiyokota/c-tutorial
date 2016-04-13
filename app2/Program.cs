using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app2
{
    public class Program
    {
        public static void function1() {
            Console.WriteLine("in the fucntion1 bro");
        }
        
        public static String function2() {
            return "function2 returns this string";
        }
        
        public static void function3(){
            String FirstName = "akiyo";
            String LastName = "yokota";
            
            
            Console.WriteLine("function3: {0}, {1}", FirstName, LastName);
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("wassup");
            function1();
            Console.WriteLine(function2());
            
            function3();
            
        }
        
    }
}
