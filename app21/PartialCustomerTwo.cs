using System;
using System.Collections.Generic;
using System.Linq;

namespace app21 {
    public partial class PartialCustomer {
        
        partial void SamplePartialMethod();
        partial void SamplePartialMethod() {
            Console.WriteLine("Hello from sample partial method");
        }
        public string GetFullName() {
            SamplePartialMethod();
            return _firstName + " " + _lastName;
        }
    }
}