using System;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace protosched
{
    public class Program
    {
        static void Main(string[] args)
        {
            EquipmentCollection equipmentColl = new EquipmentCollection();
            SessionCollection sessionColl = new SessionCollection();
            AddTestData(equipmentColl, sessionColl);
            equipmentColl.PrintTheInventory();
            Console.WriteLine();
            sessionColl.PrintTheClassroomSchedule();
            Console.WriteLine();
            //equipmentColl.PrintAStack("w");
            //equipmentColl.PrintAStack("v");
            //equipmentColl.PrintAStack("b");
            //equipmentColl.PrintAStack("m");
            PreparePossibleMoves(equipmentColl, sessionColl);
            
            Console.WriteLine("Complete!");
        }

        static void AddTestData(EquipmentCollection eqColl, SessionCollection sessColl)
        {
            //string[] names = {"Mic", "Podium", "Amplifier"};

            // equipment collection test data (actual locations as of 5/9/19)
            eqColl.Add("WOWCart", "AWH328", "First WOW cart", true, 30);
            eqColl.Add("WOWCart", "AWH309", "Second WOW cart", true, 30);
            eqColl.Add("WOWCart", "AWH206", "Third WOW cart", false, 24);
            eqColl.Add("Visualizer", "AWH209", "Visualizer 1", false);
            eqColl.Add("Visualizer", "AWH207", "Visualizer 2", true);
            eqColl.Add("Visualizer", "AWH208", "Visualizer 3", true);
            eqColl.Add("Visualizer", "AWH328", "Visualizer 4", false);
            eqColl.Add("Visualizer", "AWH306", "Visualizer 5", false);
            eqColl.Add("Visualizer", "AWH307", "Visualizer 6", false);
            eqColl.Add("Misc", "AWH128", "Miscellaneous", 3/*, names*/);
            eqColl.Add("Whiteboard", "AWH208", "Whiteboard #1", false, false);
            eqColl.Add("Whiteboard", "AWH205", "Whiteboard #2", true, true);

            // class session collection test data (actual data taken from Astra 5/9/19)
            sessColl.Add(
                "AWH206",
                new DateTime(2019, 5, 9, 9, 0, 0),
                new DateTime(2019, 5, 9, 10, 40, 0));

            // this is the only piece of equipment needed this day per the AV schedule
            sessColl.Add(
                "AWH304", 
                new DateTime(2019,5,9,9,0,0), 
                new DateTime(2019, 5, 9, 11,45,0),
                new VisualizerEquipment("Visualizer", "AWH307", "Don't care about this class", false));
            sessColl.Add(
                "AWH309",
                new DateTime(2019, 5, 9, 9, 0, 0),
                new DateTime(2019, 5, 9, 11, 45, 0),
                new WhiteBoardEquipment("Whiteboard", "AWH208", "Please erase", false, false));
            sessColl.Add(
                "AWH305",
                new DateTime(2019, 5, 9, 11, 0, 0),
                new DateTime(2019, 5, 9, 12, 40, 0),
                new WowCartEquipment("WOWCart", "AWH206", "need one laptop in a broken state (software)", false, 24));
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

        /// The method below isn't used but will be! It's there to demonstrate that we can now
        /// pull the equipment name from the equipment stacks. This is important for later, as
        /// we will be using these stacks (finally!!!) to populate the names of the equipment
        /// in the Unity-based GUI.
        ///
        /// This will need to be in a loop that can iterate through each session in the collection.
        static void PreparePossibleMoves(EquipmentCollection eqColl, SessionCollection sessColl)
        {
            while (sessColl != null)
            {
                string eqWowName = eqColl.WowStack.Pop().EquipmentName;
                string eqVisName = eqColl.VisStack.Pop().EquipmentName;
                string eqBoardName = eqColl.BoardStack.Pop().EquipmentName;
                string eqMiscName = eqColl.MiscStack.Pop().EquipmentName;

                string sessWithEqName = sessColl.SessionWithEquipment.Pop().EquipmentNeeded;

                string comparedNeedHave = null;

                comparedNeedHave = CompareNeedsAndHaves(eqWowName, eqVisName, eqBoardName, eqMiscName, sessWithEqName);

                if (comparedNeedHave == null) Console.WriteLine("No equipment match!!");

                else Console.WriteLine("\nSession " +
                                       sessWithEqName +
                                       " will receive a " +
                                       comparedNeedHave +
                                       ".");
                sessColl.SessionWithEquipment.Pop();
            }

        }

        private static string CompareNeedsAndHaves(string wowName, string visName, string boardName, string miscName, string sessionNeeds)
        {
            if (wowName == sessionNeeds) return wowName;
            if (visName == sessionNeeds) return visName;
            if (boardName == sessionNeeds) return boardName;
            if (miscName == sessionNeeds) return miscName;

            return null;
        }
    }
}
