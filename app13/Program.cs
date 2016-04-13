using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app13
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            AbstractCustomer C = new Customer();
            C.print();
        }
    }
}


class Customer : AbstractCustomer {
    public override void print() {
        Console.WriteLine("Printing from customer");
    }
    
    int ID {get;set;}
}

abstract class AbstractCustomer {
    int id;
    string name;
    
    public abstract void print() ;
}