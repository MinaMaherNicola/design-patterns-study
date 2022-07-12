using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.ObserverPattern.Interfaces
{
    public interface IWeatherServices
    {
        int GetTemperature();
        int GetHumidity();
        int GetPressure();
    }
}
