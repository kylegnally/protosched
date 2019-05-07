namespace protosched
{
    /// <summary>
    /// Class to model miscellaneous equipment.
    /// </summary>
    class MiscEquipment : Equipment
    {
        // vars for misc stuff
        private const string NAME = "Misc. Equipment";
        private int piecesOfEquipment;
        private string[] pieceNames;

        public MiscEquipment(
            string equipmentName,
            string currentRoom,
            string notes,
            int piecesOfEquipment,
            string[] pieceNames) : base(equipmentName, currentRoom, notes)
        {
            this.EquipmentName = NAME;
            this.piecesOfEquipment = piecesOfEquipment;
            this.pieceNames = pieceNames;
        }
    }
}
