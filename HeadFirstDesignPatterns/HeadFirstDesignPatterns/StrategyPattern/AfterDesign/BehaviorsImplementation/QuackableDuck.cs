using HeadFirstDesignPatterns.StrategyPattern.AfterDesign.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StrategyPattern.AfterDesign.BehaviorsImplementation
{
    public class QuackableDuck : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quaaack!");
        }
    }
}
