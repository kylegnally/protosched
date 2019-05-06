using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveCollection collection = new MoveCollection();
            AddTestData(collection);
            collection.PrintTheMoves();
        }

        static void AddTestData(MoveCollection coll)
        {
            Move aMove = new Move(new WowCartEquipment("210", null, false, true, 30 ), "210", "220", null);
            coll.Add(aMove);

        }
    }
}
