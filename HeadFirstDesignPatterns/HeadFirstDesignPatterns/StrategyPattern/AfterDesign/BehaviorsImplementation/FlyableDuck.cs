using HeadFirstDesignPatterns.StrategyPattern.AfterDesign.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StrategyPattern.AfterDesign.BehaviorsImplementation
{
    public class FlyableDuck : IFlightBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
