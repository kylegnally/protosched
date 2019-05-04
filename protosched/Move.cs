using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    /// <summary>
    /// Class that contains information shared by all moves and only moves. 
    /// </summary>
    abstract class Move : IMove
    {
        private string FromRoom;
        private string ToRoom;

        public DateTime MoveTimeFrom { get; set; }
        public DateTime MoveTimeTo { get; }
        public string Notes { get; set; }

        // private int TotalMinutes { get; } later. Not now.

        protected Move(string fromRoom,
            string toRoom, 
            DateTime moveTimeFrom, 
            DateTime moveTimeTo, string notes 
            )
        {
            this.MoveTimeFrom = moveTimeFrom;
            this.MoveTimeTo = moveTimeTo;
            this.FromRoom = fromRoom;
            this.ToRoom = toRoom;
            this.Notes = notes;
        }

        public override string ToString()
        {
            string r = FromRoom + " TO " +
                   ToRoom + " @" +
                   MoveTimeFrom + "-" +
                   MoveTimeTo;

            if (Notes != null)
            {
                r += " NOTES: " + Notes;
                return r;
            }
            else Notes = "NOTES: ";

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

        public abstract void CalculateMoveOrder();
    }
}
