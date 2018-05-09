using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IObservable
    {
        void RegisterObserver(IObserver ob);
        void RemoveObserver(IObserver ob);
        void NotifyObservers();
    }
}
