using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface IEquipment
    {
        string EquipmentName { get; set; }
        string CurrentRoom { get; set; }
        string Notes { get; set; }

        string EquipmentListing { get; set; }
    }
}
