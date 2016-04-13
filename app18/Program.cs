using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app18
{
    public class Program
    {
        public static void Main(string[] args)
        {
                Console.WriteLine(Calculator.add(1,2));
        }
    }
}


public class Calculator {
    [Obsolete(
        "Use Add(List<int> Numbers) Method"
    )]
    public static int add (int firstNumber, int secondNumber) {
        return firstNumber + secondNumber;
    }
    
    public static int add (List<int> numbers) {
        int sum = 0;
        foreach (int number in numbers) {
            sum += number;
        }
        return sum;
    }
}