using HeadFirstDesignPatterns.ObserverPattern.Interfaces;
using HeadFirstDesignPatterns.ObserverPattern.WeatherMainSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.ObserverPattern.Displays
{
    public class CurrentWeatherDisplay : ICustomObserver
    {
        private readonly WeatherObject weatherObject;
        private int temp;
        private int humidity;

        public CurrentWeatherDisplay()
        {
            weatherObject = new WeatherObject();
        }

        public CurrentWeatherDisplay(WeatherObject weatherObject)
        {
            this.weatherObject = weatherObject;
            weatherObject.AddObserver(this);
        }

        public void Update()
        {
            temp = weatherObject.GetTemperature();
            humidity = weatherObject.GetHumidity();
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current temp is: {temp}C\nCurrent humidity is: {humidity}\n------------------");
        }

        public void Unsubscribe()
        {
            weatherObject.RemoveObserver(this);
        }
    }
}
