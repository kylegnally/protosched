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
        // WOW cart
        void Add(string equipmentName, string currentRoom, string notes, bool hasPrinter, int numLaptops);

        // visualizer
        void Add(string equipmentName, string currentRoom, string notes, bool isLocked);

        // whiteboard
        void Add(string equipmentName, string currentRoom, string notes, bool hasMarker, bool hasEraser);

        // misc stuff
        void Add(string equipmentName, string currentRoom, string notes, int piecesOfEquipment/*, string[] pieceNames*/);

        string[] PrintTheInventory();
    }
}