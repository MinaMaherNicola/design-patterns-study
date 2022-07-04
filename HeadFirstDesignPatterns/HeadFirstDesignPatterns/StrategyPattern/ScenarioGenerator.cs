using System;

namespace HeadFirstDesignPatterns.StrategyPattern
{
    public static class ScenarioGenerator
    {
        public static void GenerateBeforeDesignScenario()
        {
            HeadFirstDesignPatterns.StrategyPattern.BeforeDesign.LocalDuck localDuck = new();
            Console.WriteLine("Local Duck:");
            Console.WriteLine();
            localDuck.Quack();
            localDuck.Swim();
            localDuck.Fly();

            Console.WriteLine("------------------");

            HeadFirstDesignPatterns.StrategyPattern.BeforeDesign.RubberDuck rubberDuck = new();
            Console.WriteLine("Rubber Duck:");
            Console.WriteLine();
            rubberDuck.Quack();
            rubberDuck.Swim();
            rubberDuck.Fly();
        }

        public static void GenerateAfterDesignScenario()
        {
            HeadFirstDesignPatterns.StrategyPattern.AfterDesign.LocalDuck localDuck = new();
            Console.WriteLine("Local Duck:");
            Console.WriteLine();
            localDuck.Quack();
            localDuck.Swim();
            localDuck.Fly();

            Console.WriteLine("------------------");

            HeadFirstDesignPatterns.StrategyPattern.AfterDesign.RubberDuck rubberDuck = new();
            Console.WriteLine("Rubber Duck:");
            Console.WriteLine();
            rubberDuck.Quack();
            rubberDuck.Swim();
            rubberDuck.Fly();

            rubberDuck.ChangeFlightBehavior(new HeadFirstDesignPatterns.StrategyPattern.AfterDesign.BehaviorsImplementation.FlyableDuck());
            rubberDuck.Fly();
        }
    }
}
