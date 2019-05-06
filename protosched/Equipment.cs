using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    abstract class Equipment : IEquipment
    {
        public string EquipmentName { get; set; }
        public string CurrentRoom { get; set; }
        public string Notes { get; set; }
        //public DateTime MoveFromTime { get; set; }
        //public DateTime MoveToTime { get; set; }
        public bool IsAvailableToMove { get; set; }


        public Equipment(string currentRoom, string notes, bool isAvailable)
        {
            this.CurrentRoom = currentRoom;
            this.Notes = notes;
            this.IsAvailableToMove = isAvailable;
        }

        public int CompareTo(object otherEquipment)
        {
            return 0;
        }
    }
}
