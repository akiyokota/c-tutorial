using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace app16
{
    public class Program
    {
        public static void Main(String [] args) {
            try { 
                List<string> a = new List<string>();
                Console.WriteLine(a[1]);
            } catch (Exception e) {
                Console.WriteLine( "An exception has occured: {0}\n{1}" , e.Message ,e.StackTrace);
            } finally {
                
            }
        }
    }
}
