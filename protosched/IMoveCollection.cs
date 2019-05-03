using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface IMoveCollection
    {
        void Add(Move move);
        void Remove(Move move);
    }
}
