using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface IMoveCollection
    {
        void Add(string building, string fromRoom, string toRoom, DateTime moveFromTime, DateTime moveToTime, DateTime neededFromTime, DateTime neededToTime);
        //void Remove(Move move);

        //void SortByEquipmentType();
        //void SorByEarliestTime();
        //string[] PrintTheMovesList();
    }
}
