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

        public abstract string EquipmentListing { get; set; }

        protected Equipment(string equipmentName, string currentRoom, string notes)
        {
            this.EquipmentName = equipmentName;
            this.CurrentRoom = currentRoom;
            this.Notes = notes;

            //if (String.IsNullOrEmpty(notes))
            //{
            //    this.Notes = "NONE";
            //}
            //else this.Notes = notes;


        }

        public override string ToString()
        {
            EquipmentListing = EquipmentName + " is located in " + CurrentRoom + " NOTES: " + Notes;
            return EquipmentListing;
        }
    }
}
