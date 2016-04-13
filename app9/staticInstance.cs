using System;

namespace staticInstances{
    class Circle {
        static float _PI; //this field is the same for all instances, so we make it static
        int _Radius;
        
        static Circle() {
            Console.WriteLine("Static Constructor Called");
            Circle._PI = 3.141F;
        }
        
        public Circle(int Radius) {
            Console.WriteLine("Instance Constructor Called");
            this._Radius = Radius;
        }
        
        public float CalculateArea() {
            return _PI * _Radius * _Radius;
        }
        
        public static void print() {
            Console.WriteLine("Pi is {0}", Circle._PI);
        }
    }
}