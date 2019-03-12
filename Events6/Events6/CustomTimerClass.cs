using System;
using System.Collections.Generic;
using System.Text;

namespace Events6
{
    class CustomTimerClass
    {

        private bool _stopFlag = false;

        public bool StopFlag { get => _stopFlag; set => _stopFlag = value; }

        public delegate void TimerAlarmHandler();

        public event TimerAlertHandler OnTimerAlarm;

        public void run()
        {
            System.Threading.Thread.Sleep(1000);

        }

        public void RaiseTimerAlram()
        {
            if(true)
            {
                var tea = new TimerEventArgs();
            }
        }








    }
}
