using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class VisualizerEquipment : Equipment
    {
        // vars for a visualizer
        private bool isLocked;

        private const string NAME = "Visualizer";

        public VisualizerEquipment(
            string currentRoom,
            string notes,
            bool isAvailable,
            bool isLocked) : base(currentRoom, notes, isAvailable)
        {
            this.isLocked = isLocked;
            this.EquipmentName = NAME;
        }
    }
}
