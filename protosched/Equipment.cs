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

        protected Equipment(string equipmentName, string currentRoom, string notes)
        {
            this.EquipmentName = equipmentName;
            this.CurrentRoom = currentRoom;
            this.Notes = notes;
        }
    }
}
