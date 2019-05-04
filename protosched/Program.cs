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
        }

        static void AddTestData(MoveCollection coll)
        {
            coll.Add("WOW1", "AWH204", "AWH207", );
        }
    }
}
