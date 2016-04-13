using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICustomer c = new Customer();
            c.print();
            
            AB ab= new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}

interface ICustomer {
    
    
    void print();
    void function1();
}

interface I2 {
    void function2();
}

interface I3 : I2 {
    void function3();
}

class Customer : ICustomer, I3 {
    public void print() {
        Console.WriteLine("in print function");
    }
    
    public void function1() {
        
    }
    
    
    public void function2() {
        
    }
    
    public void function3() {
        
    }
}


/*---- use cases ----*/

interface IA {
    void AMethod();
}

class A : IA {
    public void AMethod() {
        Console.WriteLine("A");
    }
}

interface IB {
    void BMethod();
}

class B : IB {
    public void BMethod () {
        Console.WriteLine("B");
    }
}

class AB : IA, IB {
    A a = new A();
    B b = new B();
    
    public void AMethod() {
        a.AMethod();
    }
    
    public void BMethod() {
        b.BMethod();
    }
}