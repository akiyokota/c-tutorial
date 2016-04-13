using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*
Diff between struct vs classes

- structs stored on stack, classes stored on heap
- struct is value type, class is reference type
- value type destroyed immediately after scope is lost
    reference types only destoryed after scope is lost
- structs only creates seperate copy when copying. no shallow copying

*/

namespace app11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //3 ways to initialize a struct
            Customer C1 = new Customer(101, "Akiyo");
            C1.PrintDetails();
            
            Customer C2 = new Customer();
            C2.id=102;
            C2.name="Yokota";
            C2.PrintDetails();
            
            Customer C3 = new Customer {
                id = 103,
                name = "Xenia"
            };
            C3.PrintDetails();
        }
    }
}

public struct Customer {
    private int _id;
    private string _name;
    
    public int id{
        get { return _id;}
        set { _id = value;}    
    }
    public string name {
        get { return _name;}
        set { _name = value;}    
    }
    
    public Customer (int Id, String Name) {
        this._id = Id;
        this._name = Name;
    }
    
    public void PrintDetails() {
        Console.WriteLine("ID is {0}\nName is {1}", this._id, this._name);
    }
}