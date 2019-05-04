using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class MiscMove : Move
    {
        private const string Name = "Misc";
        public bool IsLocked { get; set; }

        public MiscMove(string equipmentName, string fromRoom, string toRoom, string , string specialNotes)

        //// add method for misc stuff
        //void Add(string building,
        //    string equipmentName,
        //    string fromRoom,
        //    string toRoom,
        //    DateTime moveFromTime,
        //    DateTime moveToTime,
        //    DateTime neededFromTime,
        //    DateTime neededToTime,
        //    string notes,
        //    string specialNotes);
        //void Remove(Move move);
    }
}
