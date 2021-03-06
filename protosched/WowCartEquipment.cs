﻿namespace protosched
{
    /// <summary>
    /// Class to model a Wow cart.
    /// </summary>
    class WowCartEquipment : Equipment
    {
        // WOWcart-specific vars
        private bool hasPrinter;
        private int numLaptops;

        public override string EquipmentListing { get; set; }

        public WowCartEquipment(
            string equipmentName,
            string curRoom,
            string notes,
            bool hasPrinter,
            int numLaptops) : base(equipmentName, curRoom, notes)
        {
            this.EquipmentName = equipmentName;
            this.CurrentRoom = curRoom;
            this.hasPrinter = hasPrinter;
            this.numLaptops = numLaptops;
            this.EquipmentNotes = notes;
        }

        public override string ToString()
        {
            //if (!hasPrinter) base.Notes = "DOES NOT HAVE PRINTER";
            //else base.Notes = "HAS PRINTER";

            return base.ToString() + " LAPTOPS: " + numLaptops;
        }
    }
}
