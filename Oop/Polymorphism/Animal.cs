using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal make a sound.");
        }
    }
}
