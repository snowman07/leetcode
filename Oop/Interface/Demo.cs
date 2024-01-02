using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Demo : IFirstInterface, ISecondInterface
    {
        public void methodFromFirstInterface()
        {
            Console.WriteLine("Implementation from first interface");
        }

        public void methodFromSecondInterface()
        {
            Console.WriteLine("This is the second interface implementation.");
        }
    }
}
