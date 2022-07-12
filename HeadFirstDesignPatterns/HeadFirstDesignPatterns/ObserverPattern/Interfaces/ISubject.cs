using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPatterns.ObserverPattern.Interfaces
{
    public interface ISubject
    {
        void AddObserver(ICustomObserver customObserver);
        void RemoveObserver(ICustomObserver customObserver);
        void NotifyObservers();
    }
}
