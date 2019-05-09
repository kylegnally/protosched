using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class NoEqSession : Session
    {
        public override string SessionListing { get; set; }

        public NoEqSession(string room, DateTime startTime, DateTime endTime) : base (room, startTime, endTime)
        {
            this.Room = room;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
