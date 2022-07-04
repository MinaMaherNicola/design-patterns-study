using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.StrategyPattern.AfterDesign
{
    public class Duck
    {
        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming");
        }
    }
}
