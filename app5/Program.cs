using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app5
{
    public class Program
    {
        /// <summary>
        /// XML style comment
        /// </summary>
        public static void arrays() {
            Console.WriteLine("###Arrays###");
            
            int[] EvenNumbers = {0,2,4,6,8,10};
            Console.WriteLine(EvenNumbers[4]);
            
            int[] OddNumbers = new int[3];
            OddNumbers[0] = 1;
            OddNumbers[1] = 3;
            OddNumbers[2] = 5;
            Console.WriteLine(OddNumbers[1]);

        }
        
        public static void if_statements() {
            Console.WriteLine("###If statement###");
            //this is just like if statement from every other language. 
        }
        
        public static void switch_statements() {
            Console.WriteLine("###switch statement###");

            int UserNumber = int.Parse(Console.ReadLine());
            switch (UserNumber) {
                case 10:
                    Console.WriteLine("Your number is 10");
                    break;
                case 20:
                    Console.WriteLine("Your number is 20");
                    break;
                case 30:
                    Console.WriteLine("Your number is 30");
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20, or 30");
                    break;                                                            
            }            
        }
        
        public static void switch_statements2() {
            Console.WriteLine("###switch statement2###");

            int UserNumber = int.Parse(Console.ReadLine());
            switch (UserNumber) {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10, 20, or 30");
                    break;                                                            
            }            
        }
        
        public static void go_to() {
            Console.WriteLine("###goto statement2###");

            int TOtalCoffeeCost = 0;
            
            Start:
            Console.WriteLine("1 - Small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());
            
            switch (UserChoice) {
                case 1:
                    TOtalCoffeeCost += 1;
                    break;
                case 2:
                    TOtalCoffeeCost += 2;
                    break;
                    //goto case 1; //can also use goto case 
                case 3:
                    TOtalCoffeeCost += 3;
                    break;        
                default:
                    Console.WriteLine("Your Choice {0} is invalid", UserChoice);
                    
                    goto Start;                                
            }
            
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount = {0}", TOtalCoffeeCost);
            
            
        }
        
        
        
        public static void Main(string[] args)
        {
            arrays();
            if_statements();
            switch_statements();
            switch_statements2();
            go_to();
        }
    }
}


/// <summary>
///  this is sample class
/// </summary>
public class SampleClass
{
    
}