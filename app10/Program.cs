using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.Id = 101;
            C1.name = "Akiyo Yokota";
            C1.passmark = 100;
            
            Console.WriteLine("ID = {0} && Name = {1} && PassMark = {2}",
                C1.Id, C1.name, C1.passmark);
            
        }
    }
}

public class Student {
    private int ID;
    private string Name;
    private int PassMark;
    
    //new style of getter and setter
    public int Id {
        set {
            Console.WriteLine("In setter");
            if (value <= 0) {
                throw new Exception("Student ID cannot be negative");
            }
            this.ID = value;
        }
        get {
            Console.WriteLine("In getter");
            return this.ID;
        }
    }
    
    //lazy setup
    public string name {
        get;
        set;
    }
    
    public int passmark{get;set;}
}