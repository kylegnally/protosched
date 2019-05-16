using System;
using System.ComponentModel;

namespace protosched
{
    class EquipmentCollection : IEquipmentCollection
    {
        private IEquipment[] equipment;
        private int pieces;
        private int collectionPosition;

        public IEquipment[] AllEquipment { get; set; }

        public GenericStack<IEquipment> WowStack { get; set; } = new GenericStack<IEquipment>();
        public GenericStack<IEquipment> VisStack { get; set; } = new GenericStack<IEquipment>();
        public GenericStack<IEquipment> BoardStack { get; set; } = new GenericStack<IEquipment>();
        public GenericStack<IEquipment> MiscStack { get; set; } = new GenericStack<IEquipment>();

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
            WowStack.Push(equipment[collectionPosition]);
            //AllEquipment[collectionPosition] = equipment[collectionPosition];
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
            VisStack.Push(equipment[collectionPosition]);
            //AllEquipment[collectionPosition] = equipment[collectionPosition];
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
            BoardStack.Push(equipment[collectionPosition]);
            //AllEquipment[collectionPosition] = equipment[collectionPosition];
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
            MiscStack.Push(equipment[collectionPosition]);
            //AllEquipment[collectionPosition] = equipment[collectionPosition];
            collectionPosition++;
        }

        /// <summary>
        /// Method to print the equipment inventory.
        /// </summary>
        /// <returns>string[]</returns>
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

        public string PrintAStack(string stack)
        {
            string output = "";
            switch (stack)
            {
                case "w":
                    while (!WowStack.IsEmpty)
                    {
                        output += WowStack.Pop().EquipmentListing + Environment.NewLine;
                        WowStack.Print();
                    }
                    break;

                case "v":
                    while (!VisStack.IsEmpty)
                    {
                        output += VisStack.Pop().EquipmentListing + Environment.NewLine;
                        VisStack.Print();
                    }
                    break;

                case "b":
                    while (!BoardStack.IsEmpty)
                    {
                        output += BoardStack.Pop().EquipmentListing + Environment.NewLine;
                        BoardStack.Print();
                    }
                    break;

                case "m":
                    while (!WowStack.IsEmpty)
                    {
                        output += WowStack.Pop().EquipmentListing + Environment.NewLine;
                        MiscStack.Print();
                    }
                    break;
                default:
                    break;

            }

            Console.WriteLine(output);
            return output;
        }
    }
}
