using System;

namespace protosched
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipmentCollection equipmentColl = new EquipmentCollection();
            AddTestData(equipmentColl);
            equipmentColl.PrintTheInventory();
            Console.WriteLine("Done!");
        }

        static void AddTestData(EquipmentCollection coll)
        {
            string[] names = {"Mic", "Podium", "Amplifier"};

            coll.Add("WOWCart1", "AWH204", "First WOW cart", true, 30);
            coll.Add("WOWCart2", "AWH204", "Second WOW cart", true, 30);
            coll.Add("WOWCart3", "AWH204", "Third WOW cart", false, 24);
            coll.Add("Visualizer1", "AWH209", "Visualizer 1", false);
            coll.Add("Visualizer2", "AWH207", "Visualizer 2", true);
            coll.Add("Visualizer3", "AWH208", "Visualizer 3", true);
            coll.Add("Misc", "AWH128", "Miscellaneous", 3/*, names*/);
            coll.Add("Whiteboard", "AWH208", "Whiteboard #1", false, false);
            coll.Add("Whiteboard", "AWH205", "Whiteboard #2", true, true);
        }
    }
}
