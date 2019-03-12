using System;
using System.Collections.Generic;
using System.Text;

namespace Events6
{
    class TimerEventArgs
    {
        private DateTime _time;

        public String TimerDateTime { get => _time.ToString("HH:MM:SS"); }

        public TimerEventArgs()
        {
            _time = DateTime.UtcNow;
        }


    }
}
