namespace protosched
{
    /// <summary>
    /// Class to model a dry-erase whiteboard.
    /// </summary>
    class WhiteBoardEquipment : Equipment
    {
        // vars for a whiteboard
        private bool hasEraser;
        private bool hasMarker;

        private const string NAME = "Whiteboard";

        public WhiteBoardEquipment(
            string equipmentName,
            string curRoom,
            string notes,
            bool hasEraser,
            bool hasMarker) : base(equipmentName, curRoom, notes)
        {
            this.EquipmentName = NAME;
            this.hasEraser = hasEraser;
            this.hasMarker = hasMarker;
        }
    }
}
