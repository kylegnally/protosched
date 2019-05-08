using System;

namespace protosched
{
    /// <summary>
    /// Interface for the Move class.
    /// </summary>
    interface IMove : IComparable
    {
        DateTime MoveFromTime { get; set; }
        DateTime MoveToTime { get; set; }

        string FromRoom { get; set; }
        string ToRoom { get; set; }
        string MoveNotes { get; set; }
    }
}
