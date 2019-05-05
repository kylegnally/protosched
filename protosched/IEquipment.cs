using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface IEquipment : IComparable
    {
        string Name { get; set; }
        string CurrentRoom { get; set; }

        DateTime[] NeededRange { get; set; }


        void CompareTo();
    }
}
