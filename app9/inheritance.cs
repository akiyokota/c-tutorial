using System;

namespace inheritanceClasses {
    public class Employee {
        public string Firstname;
        public string Lastname;
        public string Email;
        
        public virtual void PrintFullName() {
            Console.WriteLine("Fullname: {0} {1}\n"
                                + "Email: {2}" , Firstname, Lastname, Email);
        }
    }
    
    
    public class FullTimeEmployee : Employee {
        public float YearlySalary;
        
        public override void PrintFullName() {
            // Console.WriteLine("Fulltime - Fullname: {0} {1}\n"
            //                     + "Email: {2}" , Firstname, Lastname, Email);
            base.PrintFullName();
            Console.WriteLine("Salary: {0}", YearlySalary);
        }
    }
    
    
    public class PartTimeEmployee : Employee {
        public float HourlySalary;
        
        public new void PrintFullName() {
            base.PrintFullName();
            Console.WriteLine("Salary: {0}", HourlySalary);
        }

    }
}