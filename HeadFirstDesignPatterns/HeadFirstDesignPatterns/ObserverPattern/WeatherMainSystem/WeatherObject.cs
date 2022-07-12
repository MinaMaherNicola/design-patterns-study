using HeadFirstDesignPatterns.ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.ObserverPattern.WeatherMainSystem
{
    public class WeatherObject : ISubject, IWeatherServices
    {
        private List<ICustomObserver> observers;
        private int temp;
        private int humidity;
        private int pressure;

        public WeatherObject()
        {
            observers = new List<ICustomObserver>();
            Random random = new();
            temp = random.Next(-15, 55);
            humidity = random.Next(10, 100);
            pressure = random.Next(800, 1100);
        }

        public WeatherObject(List<ICustomObserver> observers)
        {
            this.observers = observers;
        }

        public void AddObserver(ICustomObserver customObserver)
        {
            observers.Add(customObserver);
        }

        public void RemoveObserver(ICustomObserver customObserver)
        {
            observers.Remove(customObserver);
        }

        public void NotifyObservers()
        {
            observers.ForEach(o => o.Update());
        }

        public int GetHumidity()
        {
            return humidity;
            
        }

        public int GetPressure()
        {
            return pressure;
        }

        public int GetTemperature()
        {
            return temp;
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void GetNewMeasurementsFromHardware()
        {
            Random random = new();
            temp = random.Next(-15, 55);
            humidity = random.Next(10, 100);
            pressure = random.Next(800, 1100);
            MeasurementsChanged();
        }
    }
}
