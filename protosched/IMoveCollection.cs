using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    /// <summary>
    /// Interface to define methods for a move.
    /// </summary>
    interface IMoveCollection
    {
        // add method for a WOW cart
        void Add(string equipmentName,
            string fromRoom, 
            string toRoom, 
            //DateTime moveFromTime, 
            //DateTime moveToTime, 
            string notes,
            bool hasPrinter,
            int numLaptops
            );

        // add method for a visualizer
        //void Add(string equipmentName,
        //    string fromRoom,
        //    string toRoom,
        //    DateTime moveFromTime,
        //    DateTime moveToTime,
        //string notes,
        //bool hasPrinter,
        //bool isLocked);

        // add method for a whiteboard
        //void Add(
            //string equipmentName,
            //string fromRoom,
            //string toRoom,
            //DateTime moveFromTime,
            //DateTime moveToTime,
            //string notes,
            //bool hasWheels);

        // add method for misc stuff
        void Add(
            string equipmentName,
            string fromRoom,
            string toRoom,
            DateTime moveFromTime,
            DateTime moveToTime,
            string notes,
            string specialNotes);

        //void Remove(Move move);

        //void SortByEquipmentType();
        //void SorByEarliestTime();
        //string[] PrintTheMovesList();
    }
}
