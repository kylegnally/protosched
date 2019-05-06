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
            string curRoom,
            string notes,
            bool isAvailable,
            bool hasEraser,
            bool hasMarker) : base(curRoom, notes, isAvailable)
        {
            this.hasEraser = hasEraser;
            this.hasMarker = hasMarker;
            this.EquipmentName = NAME;
        }
    }
}
