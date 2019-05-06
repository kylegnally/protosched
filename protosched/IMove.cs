using System;

namespace protosched
{
    interface IMove : IComparable
    {
        // method to calculate the order this move is in the list (should be elsewhere?)
        void CalculateMoveOrder();

        //DateTime NeededFromTime { get; set; }
        //DateTime NeededToTime { get; set; }
        string MoveNotes { get; set; }
    }
}
