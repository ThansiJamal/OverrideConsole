using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideConsole
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
        class Dog : Animal
        {
            public override void eat()
            {
                Console.WriteLine("Eating bread...");
            }

        }
        class TestOverriding
        {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            Console.ReadKey();
        }

    }
}
   

