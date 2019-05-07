namespace protosched
{
    /// <summary>
    /// Class that contains information shared by all moves and only moves. 
    /// </summary>
    class Move : IMove
    {
        private string FromRoom;
        private string ToRoom;
        private IEquipment equipment;

        public string MoveNotes { get; set; }

        // private int TotalMinutes { get; } later. Not now.

        public Move(IEquipment equipment, 
            string fromRoom,
            string toRoom, 
            string notes)
        {
            //this.MoveTimeFrom = moveTimeFrom;
            //this.MoveTimeTo = moveTimeTo;
            this.FromRoom = fromRoom;
            this.ToRoom = toRoom;
            this.MoveNotes = notes;
            
        }

        public override string ToString()
        {
            string r = FromRoom + " TO " +
                   ToRoom;

            if (MoveNotes != null)
            {
                r += " MOVE NOTES: " + MoveNotes;
                return r;
            }
            else MoveNotes = "NOTES: NONE";

            return r;
        }

        public int CompareTo(object move)
        {
            return 0;
        }

        public void CalculateMoveOrder()
        {

        }
    }
}
