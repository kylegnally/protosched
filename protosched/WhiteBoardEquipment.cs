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

        public override string EquipmentListing { get; set; }

        public WhiteBoardEquipment(
            string equipmentName,
            string curRoom,
            string notes,
            bool hasEraser,
            bool hasMarker) : base(equipmentName, curRoom, notes)
        {
            this.EquipmentName = equipmentName;
            this.hasEraser = hasEraser;
            this.hasMarker = hasMarker;
            this.Notes = notes;
        }

        public override string ToString()
        {
            //if (!hasEraser) base.Notes = "NO ERASER ";
            //else base.Notes = "HAS ERASER ";
            //if (!hasMarker) base.Notes = "NO MARKER ";
            //else base.Notes = "HAS MARKER ";
            return base.ToString();
        }
    }
}
