using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app7
{
    public class Program
    {
        public static void referenceParameter(ref int i) {
            Console.WriteLine("### refernce parameter ###");
            
            i = 5;
        }
        
        public static void Calculate(int FN, int SN, out int Sum, out int Product){
            Console.WriteLine("### Multiple Return Types ###");
            
            Sum = FN + SN;
            Product = FN * SN;    
        }
        
        public static void ParameterArrays (params int[] Numbers) {
            Console.WriteLine("### Array type parameter ###");

            
            Console.WriteLine("THere are {0} elements", Numbers.Length);
            
            foreach (int i in Numbers) {
                Console.WriteLine(i);
            }
        }
        
        public static void Main(string[] args)
        {
            int i = 0;
            referenceParameter(ref i);
            Console.WriteLine(i);
            
            int FN = 2;
            int SN = 5;
            int Sum = 0;
            int Product = 0;
            Calculate(FN, SN, out Sum, out Product);
            Console.WriteLine("Sum = {0} \nProduct = {1}", Sum, Product);
            
            int[] Numbers = {1, 2, 3, 4, 5};
            ParameterArrays(Numbers);
            ParameterArrays();
            ParameterArrays(6, 7, 8, 9, 10); //Another way to use this
        }
    }
}
