namespace protosched
{
    abstract class Equipment : IEquipment
    {
        public string EquipmentName { get; set; }
        public string CurrentRoom { get; set; }
        public string EquipmentNotes { get; set; }

        public abstract string EquipmentListing { get; set; }

        protected Equipment(string equipmentName, string currentRoom, string notes)
        {
            EquipmentName = equipmentName;
            CurrentRoom = currentRoom;
            EquipmentNotes = notes;
        }

        public override string ToString()
        {
            EquipmentListing = EquipmentName + " located in " + CurrentRoom + " NOTES: " + EquipmentNotes;
            return EquipmentListing;
        }
    }
}
