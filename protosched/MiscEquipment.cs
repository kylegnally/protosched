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
        //private string[] pieceNames;

        public override string EquipmentListing { get; set; }

        public MiscEquipment(
            string equipmentName,
            string currentRoom,
            string notes,
            int piecesOfEquipment/*,
            string[] pieceNames*/) : base(equipmentName, currentRoom, notes)
        {
            this.EquipmentName = equipmentName;
            this.EquipmentNotes = notes;
            this.piecesOfEquipment = piecesOfEquipment;
            //this.pieceNames = pieceNames;
        }

        public override string ToString()
        {
            return base.ToString() + " NUMBER OF PIECES: " + piecesOfEquipment + " ";
        }
    }
}
