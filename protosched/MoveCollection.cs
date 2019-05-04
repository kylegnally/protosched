using System;

namespace protosched
{
    class MoveCollection : IMoveCollection
    {
        private IMove[] moves;
        private int collectionPosition;

        // generic stacks for each move type
        GenericStack<IMove> aWowStack = new GenericStack<IMove>();
        GenericStack<IMove> aVisStack = new GenericStack<IMove>();
        GenericStack<IMove> aBoardStack = new GenericStack<IMove>();
        GenericStack<IMove> aMiscStack = new GenericStack<IMove>();

        // generic queue for all moves
        GenericQueue<IMove> movesQueue = new GenericQueue<IMove>();

        public MoveCollection()
        {
            moves = new IMove[100];
            collectionPosition = 0;
        }

        // you will need FOUR add methods, one for each type of(droid) equipment you want to move

        /// <summary>
        /// Add method for a WOW cart.
        /// </summary>
        /// <param name="equipmentName"></param>
        /// <param name="fromRoom"></param>
        /// <param name="toRoom"></param>
        /// <param name="moveFromTime"></param>
        /// <param name="moveToTime"></param>
        /// <param name="neededFromTime"></param>
        /// <param name="neededToTime"></param>
        /// <param name="notes"></param>
        /// <param name="hasPrinter"></param>
        public void Add(string equipmentName,
            string fromRoom,
            string toRoom,
            //DateTime moveFromTime,
            //DateTime moveToTime,
            //DateTime neededFromTime,
            //DateTime neededToTime,
            string notes,
            bool hasPrinter)
        {
            moves[collectionPosition] = new WowCartMove(
                fromRoom, 
                toRoom, 
                notes, 
                hasPrinter);
            //BuildingName + " " +
            //FromRoom + " TO " +
            //    ToRoom + " @" +
            //    MoveTimeFrom + "-" +
            //    MoveTimeTo + " NEEDED @" +
            //    NeededTimeFrom + "-" +
            //    NeededTimeTo
        }
    }
}
