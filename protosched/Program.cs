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
        }

        static void AddTestData(EquipmentCollection coll)
        {
            string[] names = {"Mic", "Podium", "Amplifier"};

            coll.Add("WOWCart1", "AWH204", null, true, 30);
            coll.Add("WOWCart2", "AWH204", null, true, 30);
            coll.Add("WOWCart3", "AWH204", "Wants a printer", false, 24);
            coll.Add("Visualizer1", "AWH209", null, false);
            coll.Add("Visualizer2", "AWH207", null, true);
            coll.Add("Visualizer3", "AWH208", null, true);
            coll.Add("Misc", "AWH128", null, 3, names);
            coll.Add("Whiteboard", "AWH208", null, false, false);
            coll.Add("Whiteboard", "AWH205", null, true, true);

        }
    }
}
