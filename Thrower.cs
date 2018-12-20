using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment1
{
    class Thrower
    {
        public static void check(String input) {
            if (input == "error")
            {
                throw new Exception();
            }else {
                Console.WriteLine("Didn't throw");
            }

        }
    }
}
