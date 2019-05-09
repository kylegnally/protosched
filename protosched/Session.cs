using System;

namespace protosched
{
    class Session
    {
        private DateTime[] range;
        private int lengthInMinutes;

        public DateTime[] SessionTimes { get; set; }
        public TimeSpan SessionLength { get; set; }
        public IEquipment Needs { get; set; }

        public Session(DateTime startTime, DateTime endTime)
        {
            range = new DateTime[2];
            range[0] = startTime;
            range[1] = endTime;
            SessionTimes = range;
            SessionLength = endTime - startTime;
        }

        // for a session that has equipment needs
        public Session(DateTime startTime, DateTime endTime, IEquipment equipmenNeeded)
        {
            range = new DateTime[2];
            range[0] = startTime;
            range[1] = endTime;
            SessionTimes = range;
            SessionLength = endTime - startTime;
            Needs = equipmenNeeded;
        }
    }
}
