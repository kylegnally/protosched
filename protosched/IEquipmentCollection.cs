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

        // required stacks for later use
        GenericStack<IEquipment> WowStack { get; set; }
        GenericStack<IEquipment> VisStack { get; set; }
        GenericStack<IEquipment> BoardStack { get; set; }
        GenericStack<IEquipment> MiscStack { get; set; }

        string[] PrintTheInventory();
    }
}