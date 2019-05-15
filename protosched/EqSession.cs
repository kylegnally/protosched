using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class EqSession : Session
    {
        private IEquipment eqNeeded;

        public override string SessionListing { get; set; }
        public override TimeSpan LengthInMinutes { get; set; }

        public EqSession(string room, DateTime startTime, DateTime endTime, IEquipment eqNeeded) : base(room, startTime, endTime)
        {
            this.Room = room;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.eqNeeded = eqNeeded;
            GetTimeSpan();
        }

        private void GetTimeSpan()
        {
            this.LengthInMinutes = EndTime - StartTime;
        }

        public override string ToString()
        {
            return base.ToString() +
                   " requires " +
                   eqNeeded.EquipmentName +
                   " by " +
                   this.StartTime.ToString() +
                   " ** NOTES: " +
                   eqNeeded.EquipmentNotes;
        }
    }
}
