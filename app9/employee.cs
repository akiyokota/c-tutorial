using System;

namespace Employeee {
    class Employee{
        String firstname;
        String lastname;
        
        public Employee (String firstname, String lastname){
            this.firstname = firstname;
            this.lastname = lastname;
        }
        
        public void print() {
            Console.WriteLine("{0} {1}", this.firstname, this.lastname);
        }
        
        ~Employee() {
            //clean up code
        }
    }
}