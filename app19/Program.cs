using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app19
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Type T = Type.GetType("app19.Customer");
            
            
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo property in properties) {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }
            
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods) {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }
        }
    }
    
    public class Customer {
        public int Id {get;set;}
        public string Name {get; set;}
        
        public Customer (int ID, String Name) {
            this.Id = ID;
            this.Name = Name;
        }
        
        public Customer () {
            this.Id = -1;
            this.Name = string.Empty;
        }
    }
}
