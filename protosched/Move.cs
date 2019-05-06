
/* NOTE
 
      Change this class so it contains FromRoom, ToRoom, NeedEquipmentFromTime, NeedEquipmentToTime, and Notes:

    - WowCart and Visualizer are TYPES of EQUIPMENT.
    - Equipment has a name; 
    - Equipment has printers, wheels, etc.
    - Moves have none of these things
    - Moves should not know these things
    - EQUIPMENT NEEDS ITS OWN CLASS WITH SUBCLASSES, ONE FOR EACH TYPE

*/

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
            //if (move is IMove otherMove)

            //    // Code for finding the total time available for the move


            //    return this.MoveTimeFrom.CompareTo(otherMove.MoveTimeFrom);
            //else
            //    throw new ArgumentException("Object is not a Move");
        }

        public void CalculateMoveOrder()
        {

        }
    }
}
