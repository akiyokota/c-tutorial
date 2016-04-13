using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Employeee;
using staticInstances;
using inheritanceClasses;
using overloadingtutorial;
namespace app9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer c = new Customer("Akiyo", "Yokota");
            c.print_name();
            
            Employeee.Employee e = new Employeee.Employee("Xenia", "Davila");
            e.print();
            
            Circle cir = new Circle(2);
            Console.WriteLine("Area is {0}", cir.CalculateArea());
            Circle.print();
            
            Circle cir2 = new Circle(3);
            
            
            /*---- inheritence ----*/
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.Firstname = "Akiyo";
            FTE.Lastname = "Yokota";
            FTE.Email = "ayoko001@ucr.edu";
            FTE.YearlySalary = 100000;
            FTE.PrintFullName();
            ((inheritanceClasses.Employee) FTE).PrintFullName();
            
            /*---- polymorphism ----*/
            Console.WriteLine("### polymorphism ###");
            inheritanceClasses.Employee[] employees =  new inheritanceClasses.Employee[3];
            employees[0] = new inheritanceClasses.Employee();
            employees[0].Firstname = "Akiyo";
            employees[0].Lastname = "Yokota";
            employees[0].Email = "ayoko001@ucr.edu";
            employees[0].PrintFullName();
            
            employees[1] = new FullTimeEmployee();
            employees[1].Firstname = "Xenia";
            employees[1].Lastname = "Davila";
            employees[1].Email = "xdavi@ucr.edu";  
            //employees[1].YearlySalary = 500;   
            employees[1].PrintFullName();
            
            /*---- overloading ----*/
            Console.WriteLine("### overloading ###");
            overloadingprogram op = new overloadingprogram();
            op.Add(1, 2);
        }
    }
}

class Customer 
{
    string firstname;
    string lastname;
    
    public Customer() {
        firstname = "";
        lastname = "";
    }
    
    public Customer(String firstname, String lastname) {
        this.firstname = firstname;
        this.lastname = lastname;
    }
    
    public void print_name () {
        Console.WriteLine("{0} {1}", this.firstname, this.lastname);
    }
    
    //this is destructor
    ~Customer() {
        
    }
}