using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            coll.Add("WOWCart1", "AWH204", "red", true, 30);
            coll.Add("WOWCart2", "AWH204", "blue", true, 30);
            coll.Add("WOWCart3", "AWH204", "Wants a printer", false, 24);
            coll.Add("Visualizer1", "AWH209", "best friend died", false);
            coll.Add("Visualizer2", "AWH207", "this is fun", true);
            coll.Add("Visualizer3", "AWH208", "relative fun may vary", true);
            coll.Add("Misc", "AWH128", "eat it", 3/*, names*/);
            coll.Add("Whiteboard", "AWH208", "nothing to say", false, false);
            coll.Add("Whiteboard", "AWH205", "GFY", true, true);

        }
    }
}
