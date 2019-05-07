namespace protosched
{
    /// <summary>
    /// Class to model miscellaneous equipment.
    /// </summary>
    class MiscEquipment : Equipment
    {
        // vars for misc stuff
        private int piecesOfEquipment;
        private const string NAME = "Misc. Equipment";

        public MiscEquipment(
            string equipmentName,
            string currentRoom,
            string notes,
            int piecesOfEquipment) : base(equipmentName, currentRoom, notes)
        {
            this.EquipmentName = NAME;
            this.piecesOfEquipment = piecesOfEquipment;
        }
    }
}
