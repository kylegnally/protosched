using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
