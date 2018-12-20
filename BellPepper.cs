using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment1
{
    class BellPepper:Vegitable
    {

        public override void Description()
        {
            base.Description();
            Console.WriteLine("Bell Pepper");
        }
    }
}
