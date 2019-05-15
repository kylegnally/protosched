using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface ISessionCollection
    {
        // without an AV request
        void Add(string roomNumber, DateTime startTime, DateTime endTime);

        // with an AV request
        void Add(string roomNumber, DateTime startTime, DateTime endTime, Equipment equipmentNeeded);

        string[] PrintTheClassroomSchedule();
    }
}
