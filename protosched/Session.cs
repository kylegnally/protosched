using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class Session
    {
        private DateTime[] range;
        private int lengthInMinutes;

        public DateTime[] SessionTimes { get; set; }
        public TimeSpan SessionLength { get; set; }

        public Session(DateTime startTime, DateTime endTime)
        {
            range = new DateTime[2];
            range[0] = startTime;
            range[1] = endTime;
            SessionTimes = range;
            SessionLength = endTime - startTime;
        }
    }
}
