using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class WowCartEquipment : Equipment
    {
        // WOWcart-specific vars
        private bool hasPrinter;
        private int numLaptops;

        private const string NAME = "WOWCart";

        public WowCartEquipment(
            string curRoom,
            string notes,
            bool isAvailable,
            bool hasPrinter,
            int numLaptops) : base(curRoom, notes, isAvailable)
        {
            this.EquipmentName = NAME;
            this.hasPrinter = hasPrinter;
            this.numLaptops = numLaptops;
        }
    }
}
