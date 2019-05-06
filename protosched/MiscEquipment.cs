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
            string currentRoom,
            string notes,
            bool isAvailable,
            int piecesOfEquipment) : base(currentRoom, notes, isAvailable)
        {
            this.piecesOfEquipment = piecesOfEquipment;
            this.EquipmentName = NAME;
        }
    }
}
