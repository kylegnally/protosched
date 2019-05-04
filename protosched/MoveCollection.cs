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

        // you will need FOUR add methods, one for each type of (droid) equipment you want to move
        //public void Add(string building, string fromRoom, string toRoom, DateTime moveFromTime, DateTime moveToTime, DateTime neededFromTime, DateTime neededToTime)
        //{
        //    moves[collectionPosition] = new 
        //    //BuildingName + " " +
        //    //FromRoom + " TO " +
        //    //    ToRoom + " @" +
        //    //    MoveTimeFrom + "-" +
        //    //    MoveTimeTo + " NEEDED @" +
        //    //    NeededTimeFrom + "-" +
        //    //    NeededTimeTo
        //}
    }
}
