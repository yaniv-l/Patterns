using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Classes
{
    class Subject : IObservable<string>
    {
        List<IObserver<string>> _observersList = new List<IObserver<string>>();

        // Summary:
        //     Notifies the provider that an observer is to receive notifications.
        //
        // Parameters:
        //   observer:
        //     The object that is to receive notifications.
        //
        // Returns:
        //     A reference to an interface that allows observers to stop receiving notifications
        //     before the provider has finished sending them.
        public IDisposable Subscribe(IObserver<string> observer)
        {
            _observersList.Add(observer);
            return new Unsubscriber(this._observersList, observer);
        }

        public void change(string strValue)
        {
            foreach (var item in _observersList)
            {
                item.OnNext(strValue);
            }
        }
    }
}
