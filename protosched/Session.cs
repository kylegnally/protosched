using System;

namespace protosched
{
    abstract class Session : ISession
    {
        public string Room { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public abstract string SessionListing { get; set; }
        public abstract string EquipmentNeeded { get; set; }
        public abstract TimeSpan LengthInMinutes { get; set; }

        protected Session(string room, DateTime startTime, DateTime endTime)
        {
            this.Room = room;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public override string ToString()
        {
            return SessionListing = Room + 
                                    " " + 
                                    "class session beginning at " + 
                                    StartTime + 
                                    " and ending at " + 
                                    EndTime +
                                    " with a length of " +
                                    LengthInMinutes.TotalMinutes + 
                                    " minutes ";
        }
    }
}
