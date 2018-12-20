using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment1
{
    //Showing different properties of a programming language
    class Program
    {
        static void Main(string[] args)
        {
            //Accepting command Line Arguments
            foreach (string arg in args) {
                Console.WriteLine($"Argument passed is {arg}");
            }
            //Method overloading
            Class1.Method1();
            Class1.Method1("Overload");
            //Error Handeling
            try
            {
                Thrower.check("error");
            }
            catch
            {
                Console.WriteLine("Exception Caught 1");
            }
            finally
            {
                Console.WriteLine("Executed Final Clause 1");
            }


            try
            {

                Thrower.check("Something");
            }
            catch
            {
                Console.WriteLine("Exception Caught 2");
            }
            finally
            {
                Console.WriteLine("Executed Final Clause 2");
            }

            //Virtual and override as well as array for runtime polymorphism
            List<Plant> plant = new List<Plant>() {new Oak(),new BellPepper() };

            foreach (Plant i in plant) {
                i.Description();
            }
            //Delegates
            Delegator delegator1 = new Delegator(Delegates.delegate1);
            Delegator delegator2 = new Delegator(Delegates.delegate2);

            Delegates.delegateRunner(delegator1);
            Delegates.delegateRunner(delegator2);
            Console.ReadKey();
        }
    }
}
