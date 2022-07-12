using HeadFirstDesignPatterns.ObserverPattern.Interfaces;
using HeadFirstDesignPatterns.ObserverPattern.WeatherMainSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.ObserverPattern.Displays
{
    public class PressureDisplay : ICustomObserver
    {
        private readonly WeatherObject weatherObject;
        private int pressure;
        public PressureDisplay()
        {
            weatherObject = new WeatherObject();
            weatherObject.AddObserver(this);
        }

        public PressureDisplay(WeatherObject weatherObject)
        {
            this.weatherObject = weatherObject;
            this.weatherObject.AddObserver(this);
        }

        public void Unsubscribe()
        {
            weatherObject.RemoveObserver(this);
        }

        public void Update()
        {
            pressure = weatherObject.GetPressure();
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"The pressure is: {pressure}\n-------------");
        }
    }
}
