using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DesignPatternAssignment1
{

    delegate String Delegator();
    class Delegates
    {

        public static String delegate1()
        {
            return "delegate1";
        }

        public static String delegate2()
        {
            return "delegate2";
        }


        public static void delegateRunner(Delegator delegates) {
            Console.WriteLine(delegates());
            
        }
    }
}
