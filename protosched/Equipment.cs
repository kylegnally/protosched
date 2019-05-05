using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class Equipment : IEquipment
    {
        public string Name { get; set; }
        public string CurrentRoom { get; set; }
        public string Notes { get; set; }

        public Equipment(string name, string currentRoom, string notes)
        {
            this.Name = name;
            this.CurrentRoom = currentRoom;
            this.Notes = notes;
        }

        public int CompareTo(object otherEquipment)
        {
            return 0;
        }
    }
}
