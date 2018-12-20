using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment1
{
    class Vegitable:Plant
    {
        public virtual void Description()
        {
            Console.WriteLine("I am a vegtable");
        }
    }
}
