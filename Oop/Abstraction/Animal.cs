using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal
    {
        // abstract method
        public abstract void animalSound();

        // regular method
        public void sleep() 
        {
            Console.WriteLine("ZZZZ");
        }
    }
}
