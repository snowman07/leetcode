using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: oink oink");
        }
    }
}
