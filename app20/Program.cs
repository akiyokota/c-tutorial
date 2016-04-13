using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app20
{
    public class Program
    {
        public static void Main(string[] args)
        {
                bool Equal = Calculator.AreEqual(1,2);
                
                if (Equal) {
                    Console.WriteLine("Equal");
                } else {
                    Console.WriteLine("Not Equal");
                }
                Console.WriteLine(new Calculator().ToString());
        }
    }
    
    public class Calculator {
        public static bool AreEqual<T>(T Value1, T Value2) {
            return Value1.Equals(Value2);
        }
        
        public override string ToString() {
            return "hello this is to string method, override";
        }
        
        public override bool Equals (object obj)
        {
            if(obj!=null)    
                return base.Equals (obj);
            return false;
        }
        
    }
}
