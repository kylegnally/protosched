using System.Runtime.CompilerServices;

namespace protosched
{
    /// <summary>
    /// Class to model a Visualizer.
    /// </summary>
    class VisualizerEquipment : Equipment
    {
        // vars for a visualizer
        private bool isLocked;

        private const string NAME = "Visualizer";

        public VisualizerEquipment(
            string equipmentName,
            string currentRoom,
            string notes,
            bool isLocked) : base(equipmentName, currentRoom, notes)
        {
            this.EquipmentName = NAME;
            this.isLocked = isLocked;
        }
    }
}
