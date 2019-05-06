using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class WhiteBoardEquipment : Equipment
    {
        // vars for a whiteboard
        private bool hasEraser;
        private bool hasMarker;

        private const string NAME = "Whiteboard";

        public WhiteBoardEquipment(
            string curRoom,
            string notes,
            bool isAvailable,
            bool hasEraser,
            bool hasMarker) : base(curRoom, notes, isAvailable)
        {
            this.hasEraser = hasEraser;
            this.hasMarker = hasMarker;
            this.EquipmentName = NAME;
        }
    }
}
