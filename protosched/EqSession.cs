﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class EqSession : Session
    {
        private IEquipment eqNeeded;
        private TimeSpan lengthInMinutes;

        public override string SessionListing { get; set; }

        public EqSession(string room, DateTime startTime, DateTime endTime, IEquipment eqNeeded) : base(room, startTime, endTime)
        {
            this.Room = room;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.eqNeeded = eqNeeded;
            this.lengthInMinutes = endTime - startTime;
        }

        public override string ToString()
        {
            return base.ToString() + 
                   " with a length of " + 
                   lengthInMinutes.ToString() + 
                   " minutes requires " +
                   eqNeeded.EquipmentListing + 
                   " by " + 
                   this.StartTime.ToString();
        }
    }
}
