using System;

namespace protosched
{
    /// <summary>
    /// Class that contains information shared by all moves. Takes an IEquipment.
    /// </summary>
    class Move : IMove
    {
        private string toRoom;
        private IEquipment equipment;

        public string FromRoom { get; set; }
        public string ToRoom { get; set; }
        public DateTime MoveFromTime { get; set; }
        public DateTime MoveToTime { get; set; }
        public string MoveNotes { get; set; }

        public Move(IEquipment equipment, 
            string toRoom, 
            DateTime moveFromTime,
            DateTime moveToTime,
            string notes)
        {
            this.FromRoom = equipment.CurrentRoom;
            this.ToRoom = toRoom;
            this.MoveFromTime = moveFromTime;
            this.MoveToTime = moveToTime;
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
