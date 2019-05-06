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
        string EquipmentName { get; set; }
        string CurrentRoom { get; set; }
        DateTime NeededFrom { get; set; }
        DateTime NeededTo { get; set; }
        string Notes { get; set; }
        bool IsAvailableToMove { get; set; }
    }
}
