using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class NoEqSession : Session
    {
        private string _equipmentNeeded = " NONE ";

        public override string SessionListing { get; set; }
        public override TimeSpan LengthInMinutes { get; set; }
        public override string EquipmentNeeded { get; set; }

        public NoEqSession(string room, DateTime startTime, DateTime endTime) : base (room, startTime, endTime)
        {
            this.Room = room;
            this.StartTime = startTime;
            this.EndTime = endTime;
            GetTimeSpan();
            SetEquipmentNeeded();
        }

        private void SetEquipmentNeeded()
        {
            EquipmentNeeded = _equipmentNeeded;
        }

        private void GetTimeSpan()
        {
            this.LengthInMinutes = EndTime - StartTime;
        }

        public override string ToString()
        {
            return base.ToString() + " DOES NOT require equipment.";
        }
    }
}
