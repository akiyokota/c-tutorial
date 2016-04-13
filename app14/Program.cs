using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//a delegate is a type safe function pointer

public delegate void HelloFunctionDelegate (String Message);

namespace app14
{
    public class Program
    {
        
        public static void Hello(String strMessage) {
            Console.WriteLine(strMessage);
        }
        
        public static void Hello2(String strMessage) {
            Console.WriteLine("hello:" + strMessage);
        }
        
        public static void Bye(String strMessage, String strMessage2) {
            Console.WriteLine("first msg: {0}\nsecond msg: {1}", strMessage, strMessage2);
        }
        
        

        
        public static void Main(string[] args)
        {
                HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
                del ("Hello from Delegate");
                
                List<Employee> emplist = new List<Employee>();
                emplist.Add(new Employee() {ID = 101, Name = "Mary", Salary = 5000, Experience = 5});
                emplist.Add(new Employee() {ID = 101, Name = "Mike", Salary = 4000, Experience = 4});
                emplist.Add(new Employee() {ID = 101, Name = "John", Salary = 6000, Experience = 6});
                emplist.Add(new Employee() {ID = 101, Name = "Todd", Salary = 3000, Experience = 3});

                isPromotable ispromotable = new isPromotable(Promote);

                Employee.PromoteEmployee(emplist, ispromotable);
                
                // or use lamba expression
                
                Employee.PromoteEmployee(emplist, emp => emp.Experience >= 5);
        }
        
        
        public static bool Promote(Employee emp) {
            if (emp.Experience >= 5) {
                return true;
            }
            return false;
        }
    }
    
    
}

public delegate bool isPromotable (Employee empl);

public class Employee 
{
    public int ID {get; set;}
    public String Name {get;set;}
    public int Salary {get;set;}
    public int Experience{get;set;}
    
    
    
    public static void PromoteEmployee(List<Employee> employeeList, isPromotable IsEligibleToPromote) {
        foreach (Employee employee in employeeList) {
            if(IsEligibleToPromote(employee)) {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }
}