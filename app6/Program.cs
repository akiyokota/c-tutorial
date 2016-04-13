using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app6
{
    public class Program
    {
        public static void whileLoop() {
            Console.WriteLine("### While Loop ###");
            while(true) {
                Console.WriteLine("In while loop");
                break;
            }
        }
        
        public static void forLoop() {
            Console.WriteLine("### For Loop ###");
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }
        }
        
        public static void forEachLoop() {
            Console.WriteLine("### ForEach Loop ###");
            
            int [] numbers = {1, 2, 3, 4, 5, 6};
            
            foreach (int k in numbers) {
                Console.WriteLine(k);
            }
        }
        
        public void instanceMethod() {
            Console.WriteLine("### Instance Method ###");

        }
        
        public static void Main(string[] args)
        {
            whileLoop();
            forLoop();
            forEachLoop();
            Program p = new Program();
            p.instanceMethod();
        }
    }
}
