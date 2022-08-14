using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Classes
{
    class Unsubscriber :IDisposable
    {
        private List<IObserver<string>> _observersList;
        private IObserver<string> _observer;

        public Unsubscriber(List<IObserver<string>> observsresList, IObserver<string> observer)
        {
            this._observersList = observsresList;
            this._observer = observer;
        }
        
        // Summary:
        //     Performs application-defined tasks associated with freeing, releasing, or
        //     resetting unmanaged resources.
        public void Dispose()
        {
            if (_observersList != null && _observer != null)
            {
                if (this._observersList.Contains(this._observer))
                {
                    this._observersList.Remove(this._observer);
                }
            }
        }
    }
}
