using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern.Classes
{
    class Observer : IObserver<string>
    {
        private TextBox _txtBox;

        public Observer(TextBox txt)
        {
            this._txtBox = txt;
        }

        // Summary:
        //     Notifies the observer that the provider has finished sending push-based notifications.
        public void OnCompleted() { }
        
        //
        // Summary:
        //     Notifies the observer that the provider has experienced an error condition.
        //
        // Parameters:
        //   error:
        //     An object that provides additional information about the error.
        public void OnError(Exception error) { }
        
        //
        // Summary:
        //     Provides the observer with new data.
        //
        // Parameters:
        //   value:
        //     The current notification information.
        public void OnNext(string value)
        {
            this._txtBox.Text = value;
        }
    }
}
