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
    interface IEquipmentCollection
    {
        // add method for a WOW cart
        void Add(string equipmentName, string currentRoom, string notes, bool hasPrinter, int numLaptops);

        // add method for a visualizer
        void Add(string equipmentName, string currentRoom, string notes, bool isLocked);

        //add method for a whiteboard
        void Add(string equipmentName, string currentRoom, string notes, bool hasMarker, bool hasEraser);

        // add method for misc stuff
        void Add(string equipmentName, string currentRoom, string notes, int piecesOfEquipment, string[] pieceNames);

        //void Remove(Move move);

        //void SortByEquipmentType();
        //void SorByEarliestTime();
        //string[] PrintTheMovesList();
    }
}