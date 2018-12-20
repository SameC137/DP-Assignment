using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment1
{
    class Class1
    {

        public static void Method1() {
            Console.WriteLine("Method");
        }
        public static void Method1(String input) {
            Console.WriteLine($"Over loaded Method with {input}");
        }
    }
}
