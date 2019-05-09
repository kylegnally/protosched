using System;

namespace protosched
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipmentCollection equipmentColl = new EquipmentCollection();
            SessionCollection sessionColl = new SessionCollection();
            AddTestData(equipmentColl, sessionColl);
            equipmentColl.PrintTheInventory();
            Console.WriteLine("Done!");
        }

        static void AddTestData(EquipmentCollection coll, SessionCollection sessColl)
        {
            //string[] names = {"Mic", "Podium", "Amplifier"};

            // equipment collection test data (actual locations as of 5/9/19)
            coll.Add("WOWCart1", "AWH328", "First WOW cart", true, 30);
            coll.Add("WOWCart2", "AWH309", "Second WOW cart", true, 30);
            coll.Add("WOWCart3", "AWH206", "Third WOW cart", false, 24);
            coll.Add("Visualizer1", "AWH209", "Visualizer 1", false);
            coll.Add("Visualizer2", "AWH207", "Visualizer 2", true);
            coll.Add("Visualizer3", "AWH208", "Visualizer 3", true);
            coll.Add("Visualizer4", "AWH328", "Visualizer 3", false);
            coll.Add("Visualizer5", "AWH306", "Visualizer 3", false);
            coll.Add("Visualizer6", "AWH304", "Visualizer 3", false);
            coll.Add("Misc", "AWH128", "Miscellaneous", 3/*, names*/);
            coll.Add("Whiteboard", "AWH208", "Whiteboard #1", false, false);
            coll.Add("Whiteboard", "AWH205", "Whiteboard #2", true, true);

            // class session collection test data (actual data taken from Astra 5/9/19)
            sessColl.Add(
                "AWH206", 
                new DateTime(2019,5,9,9,0,0), 
                new DateTime(2019, 5,9, 10,40,0));
            sessColl.Add(
                "AWH304", 
                new DateTime(2019,5,9,9,0,0), 
                new DateTime(2019, 5, 9, 11,45,0));
            sessColl.Add(
                "AWH309", 
                new DateTime(2019, 5, 9, 9, 0, 0),
                new DateTime(2019, 5, 9, 11,45,0));
            sessColl.Add(
                "AWH305",
                new DateTime(2019, 5, 9, 11, 0, 0),
                new DateTime(2019, 5, 9, 12, 40, 0));
            sessColl.Add(
                "AWH308",
                new DateTime(2019, 5, 9, 12, 0, 0),
                new DateTime(2019, 5, 9, 14, 20, 0));
            sessColl.Add(
                "AWH204",
                new DateTime(2019, 5, 9, 12, 30, 0),
                new DateTime(2019, 5, 9, 16, 10, 0));
            sessColl.Add(
                "AWH207",
                new DateTime(2019, 5, 9, 13, 0, 0),
                new DateTime(2019, 5, 9, 14, 40, 0));
            sessColl.Add(
                "AWH208",
                new DateTime(2019, 5, 9, 13, 0, 0),
                new DateTime(2019, 5, 9, 14, 40, 0));
            sessColl.Add(
                "AWH304",
                new DateTime(2019, 5, 9, 13, 0, 0),
                new DateTime(2019, 5, 9, 14, 45, 0));
            sessColl.Add(
                "AWH309",
                new DateTime(2019, 5, 9, 13, 0, 0),
                new DateTime(2019, 5, 9, 15, 45, 0));
            sessColl.Add(
                "AWH208",
                new DateTime(2019, 5, 9, 18, 0, 0),
                new DateTime(2019, 5, 9, 20, 45, 0));
            sessColl.Add(
                "AWH207",
                new DateTime(2019, 5, 9, 18, 0, 0),
                new DateTime(2019, 5, 9, 20, 20, 0));
            sessColl.Add(
                "AWH307",
                new DateTime(2019, 5, 9, 18, 0, 0),
                new DateTime(2019, 5, 9, 19, 45, 0));
        }
    }
}
