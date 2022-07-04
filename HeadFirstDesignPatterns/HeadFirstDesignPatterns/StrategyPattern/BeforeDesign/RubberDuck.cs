using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StrategyPattern.BeforeDesign
{
    public class RubberDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Squeek!");
        }
    }
}
