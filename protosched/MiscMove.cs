using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    /// <summary>
    /// Class to model a miscellaneous equipment move.
    /// </summary>
    class MiscMove : Move
    {
        public string Name { get; set; }
        public string SpecialNotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="equipmentName"></param>
        /// <param name="fromRoom"></param>
        /// <param name="toRoom"></param>
        /// <param name="notes"></param>
        /// <param name="specialNotes"></param>
        public MiscMove(
            string equipmentName,
            string fromRoom,
            string toRoom,
            string notes, string specialNotes) : base(fromRoom, toRoom, notes)
        {
            this.Name = equipmentName;
            this.SpecialNotes = specialNotes;
        }

        public override string ToString()
        {
            return Name + base.ToString() +
                   SpecialNotes;
        }

        public override void CalculateMoveOrder()
        {

        }

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
