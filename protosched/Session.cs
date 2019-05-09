using System;

namespace protosched
{
    abstract class Session : ISession
    {
        public string Room { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        protected Session(string room, DateTime startTime, DateTime endTime)
        {
            this.Room = room;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        // for a session that has equipment needs
        protected Session(DateTime startTime, DateTime endTime)
        {

        }
    }
}
