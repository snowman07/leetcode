﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat says: meow meow.");
        }
    }
}
