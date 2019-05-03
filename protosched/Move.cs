using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    abstract class Move : IMove
    {
        private Equipment EquipmentName;
        private string BuildingName;
        private string FromRoom;
        private string ToRoom;

        public DateTime MoveTimeFrom { get; set; }
        public abstract int MoveOrderNumber { get; set; }
        private DateTime MoveTimeTo { get; set; }
        private DateTime NeededTimeFrom { get; set; }
        private DateTime NeededTimeTo { get; set; }

        public Move(string buildingName, 
            string fromRoom,
            string toRoom, 
            DateTime moveTimeFrom, 
            DateTime moveTimeTo, 
            DateTime neededTimeFrom, 
            DateTime neededTimeTo
            )
        {
            this.BuildingName = buildingName;
            this.MoveTimeFrom = moveTimeFrom;
            this.MoveTimeTo = moveTimeTo;
            this.FromRoom = fromRoom;
            this.ToRoom = toRoom;
            this.NeededTimeFrom = neededTimeFrom;
            this.NeededTimeTo = neededTimeTo;
        }

        public override string ToString()
        {
            return BuildingName + " " +
                   FromRoom + " TO " +
                   ToRoom + " @" +
                   MoveTimeFrom + "-" +
                   MoveTimeTo + " NEEDED @" +
                   NeededTimeFrom + "-" +
                   NeededTimeTo;
        }

        public int CompareTo(object move)
        {
            if (move is IMove otherMove)

                // Code for finding the total time available for the move


                return this.MoveTimeFrom.CompareTo(otherMove.MoveTimeFrom);
            else
                throw new ArgumentException("Object is not a Move");
        }

        public abstract void CalculateMoveOrder();
    }
}
