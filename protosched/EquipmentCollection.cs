using System;
using System.Runtime.InteropServices;

namespace protosched
{
    class EquipmentCollection : IEquipmentCollection
    {
        private IEquipment[] equipment;
        private int pieces;
        private int collectionPosition;

        // generic stacks for each move type
        GenericStack<IEquipment> aWowStack = new GenericStack<IEquipment>();
        GenericStack<IEquipment> aVisStack = new GenericStack<IEquipment>();
        GenericStack<IEquipment> aBoardStack = new GenericStack<IEquipment>();
        GenericStack<IEquipment> aMiscStack = new GenericStack<IEquipment>();

        // generic queue for all moves
        GenericQueue<IEquipment> movesQueue = new GenericQueue<IEquipment>();

        public EquipmentCollection()
        {
            equipment = new IEquipment[100];
            collectionPosition = 0;
        }
        
        // WOW cart Add method
        public void Add(
            string equipmentName,
            string currentRoom,
            string notes,
            bool hasPrinter,
            int numLaptops)
        {
            equipment[collectionPosition] = new WowCartEquipment(equipmentName, currentRoom, notes, hasPrinter, numLaptops);
            collectionPosition++;
        }

        // visualizer
        public void Add(
            string equipmentName, 
            string currentRoom, 
            string notes, 
            bool isLocked)
        {
            equipment[collectionPosition] = new VisualizerEquipment(equipmentName, currentRoom, notes, isLocked);
            collectionPosition++;
        }

        // whiteboard
        public void Add(
            string equipmentName, 
            string currentRoom, 
            string notes, 
            bool hasMarker, 
            bool hasEraser)
        {
            equipment[collectionPosition] = new WhiteBoardEquipment(equipmentName, currentRoom, notes, hasMarker, hasEraser);
            collectionPosition++;
        }

        // misc
        public void Add(
            string equipmentName, 
            string currentRoom, 
            string notes, 
            int piecesOfEquipment/*,
            string[] pieceNames*/)
        {
            equipment[collectionPosition] = new MiscEquipment(equipmentName, currentRoom, notes, piecesOfEquipment/*, pieceNames*/);
        }

        public string[] PrintTheInventory()
        {
            string[] allEquipment = new string[collectionPosition];

            for (int i = 0; i < equipment.Length; i++)
            {
                if (equipment[i] != null)
                {
                    Console.WriteLine(allEquipment[i] = equipment[i].ToString());
                }

                else if (equipment[0] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\t\t\t\t\tNO EQUIPMENT IN INVENTORY");
                    Console.ResetColor();
                }
            }

            return allEquipment;
        }
    }
}
