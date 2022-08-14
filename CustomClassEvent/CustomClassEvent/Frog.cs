using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassEvent
{
    class Frog
    {
        public event EventHandler Jump;
        public int CountKey
        {
            get
            {
                return _counter.current;
                }
            set
            {
                _counter.Add(1);
        } }
        private Counter _counter;

        public Frog(int ClickToJump)
        {
            _counter = new Counter(ClickToJump);
            _counter.CustomReached += new Counter.CustomThresholdReached(OnCustomReached);
        }

        public void OnJump(EventArgs e)
        {
            EventHandler handler = Jump;
            if (null != handler) handler.Invoke(this, e);
        }

        private void OnCustomReached(int threshold)
        {
            OnJump(EventArgs.Empty);
        }
    }
}
