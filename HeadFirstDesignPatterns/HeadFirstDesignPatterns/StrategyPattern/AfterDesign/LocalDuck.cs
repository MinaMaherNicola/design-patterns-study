using HeadFirstDesignPatterns.StrategyPattern.AfterDesign.Behaviors;
using HeadFirstDesignPatterns.StrategyPattern.AfterDesign.BehaviorsImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StrategyPattern.AfterDesign
{
    public class LocalDuck : Duck
    {
        private IFlightBehavior flightBehavior;
        private IQuackBehavior quackBehavior;

        public LocalDuck()
        {
            flightBehavior = new FlyableDuck();
            quackBehavior = new QuackableDuck();
        }

        public void Fly()
        {
            flightBehavior.Fly();
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }

        public void ChangeFlightBehavior(IFlightBehavior flightBehavior)
        {
            this.flightBehavior = flightBehavior;
        }
    }
}
