using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StrategyPattern.BeforeDesign
{
    public class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Quaaaaack!");
        }

        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming!");
        }

        // newly added requirements
        public virtual void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
