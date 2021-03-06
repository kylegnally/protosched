﻿namespace protosched
{
    /// <summary>
    /// Class to model a Visualizer.
    /// </summary>
    class VisualizerEquipment : Equipment
    {
        // vars for a visualizer
        private bool isLocked;
        public override string EquipmentListing { get; set; }

        public VisualizerEquipment(
            string equipmentName,
            string currentRoom,
            string notes,
            bool isLocked) : base(equipmentName, currentRoom, notes)
        {
            EquipmentName = equipmentName;
            this.isLocked = isLocked;
            EquipmentNotes = notes;
        }

        public override string ToString()
        {
            //if (!isLocked) base.Notes = "IS UNLOCKED ";
            //else base.Notes = "IS LOCKED ";
            return base.ToString();
        }
    }
}
