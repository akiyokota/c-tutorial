using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ProjectA.TeamB;
using PATC = ProjectA.TeamC;

namespace app8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProjectA.TeamA.ClassA.Print();
            ClassB.Print();
            PATC.ClassC.Print();
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print() {
                Console.WriteLine("Team A print method");
            }
        }
    }
    
    namespace TeamB
    {
        class ClassB
        {
            public static void Print() {
                Console.WriteLine("Team B print method");
            }
        }
    }
    
    namespace TeamC
    {
        class ClassC
        {
            public static void Print() {
                Console.WriteLine("Team C print method");
            }
        }
    }
}