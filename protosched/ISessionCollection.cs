using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface ISessionCollection
    {
        void Add(DateTime startTime, DateTime endTime);

        void Add(DateTime startTime, DateTime endTime, IEquipment equipmentNeeded);
    }
}
