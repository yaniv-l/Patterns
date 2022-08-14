using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassEvent
{
    class Counter
    {
        // Delegate to a function with int signature to be used for event handler
        public delegate void CustomThresholdReached(int threshhold);
        // Event with CustomThresholdReached EventHandler signature
        public event CustomThresholdReached CustomReached;
        // Stadard EventHandler signatuer, i.e ThresholdReached(Object o, EventArgs e)
        public event EventHandler ThresholdReached;

        private int threshold;
        private int total;
        public int current { get { return total; } }
        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                OnThresholdReached(EventArgs.Empty);
                OnCustomThresholdReached(total);
            }
        }

        // Publishing the OnThresholdReached
        protected virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        // Publishing the OnCustomThresholdReached
        protected virtual void OnCustomThresholdReached(int threshold)
        {
            CustomThresholdReached handler = CustomReached;
            if(CustomReached != null)
            {
                CustomReached(threshold);
            }
        }

    }
}
