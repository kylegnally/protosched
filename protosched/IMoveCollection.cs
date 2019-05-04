using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface IMoveCollection
    {
        // add method for a WOW cart
        void Add(
            string equipmentName,
            string fromRoom, 
            string toRoom, 
            //DateTime moveFromTime, 
            //DateTime moveToTime, 
            //DateTime neededFromTime, 
            //DateTime neededToTime,
            string notes,
            bool hasPrinter
            );

        //// add method for a visualizer
        //void Add(string building,
        //    string equipmentName,
        //    string fromRoom,
        //    string toRoom,
        //    DateTime moveFromTime,
        //    DateTime moveToTime,
        //    DateTime neededFromTime,
        //    DateTime neededToTime,
        //    string notes,
        //    bool hasPrinter,
        //    bool isLocked);

        //// add method for a whiteboard
        //void Add(string building,
        //    string equipmentName,
        //    string fromRoom,
        //    string toRoom,
        //    DateTime moveFromTime,
        //    DateTime moveToTime,
        //    DateTime neededFromTime,
        //    DateTime neededToTime,
        //    string notes,
        //    bool hasPrinter,
        //    bool isLocked,
        //    bool mustCarry);

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

        //void SortByEquipmentType();
        //void SorByEarliestTime();
        //string[] PrintTheMovesList();
    }
}
