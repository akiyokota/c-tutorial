using System;

namespace overloadingtutorial {
    public class overloadingprogram {

        public void Add(int FN, int SN) {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        
        public void Add(float FN, float SN) {
            Console.WriteLine("Sum = {0}" + FN + SN);
        }
        
        public void Add(int FN, float SN) {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
    }
}