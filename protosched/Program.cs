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
            eqColl.Add("WOWCart1", "AWH328", "First WOW cart", true, 30);
            eqColl.Add("WOWCart2", "AWH309", "Second WOW cart", true, 30);
            eqColl.Add("WOWCart3", "AWH206", "Third WOW cart", false, 24);
            eqColl.Add("Visualizer1", "AWH209", "Visualizer 1", false);
            eqColl.Add("Visualizer2", "AWH207", "Visualizer 2", true);
            eqColl.Add("Visualizer3", "AWH208", "Visualizer 3", true);
            eqColl.Add("Visualizer4", "AWH328", "Visualizer 4", false);
            eqColl.Add("Visualizer5", "AWH306", "Visualizer 5", false);
            eqColl.Add("Visualizer6", "AWH307", "Visualizer 6", false);
            eqColl.Add("Misc", "AWH128", "Miscellaneous", 3/*, names*/);
            eqColl.Add("Whiteboard1", "AWH208", "Whiteboard #1", false, false);
            eqColl.Add("Whiteboard2", "AWH205", "Whiteboard #2", true, true);

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

        static void PreparePossibleMoves(EquipmentCollection eqColl, SessionCollection sessColl)
        {
            //if (eqColl.BoardStack.Pop().EquipmentName == sessColl.SessionWithEquipment.Pop().)

            string eqWowName = eqColl.WowStack.Pop().EquipmentName;
            string eqVisName = eqColl.VisStack.Pop().EquipmentName;
            string eqBoardName = eqColl.BoardStack.Pop().EquipmentName;
            string eqMiscName = eqColl.MiscStack.Pop().EquipmentName;

            /* We are only concerning ourselves with sessions that require equipment in this
            /// program, so why create two classes derived from Session that you have to deal
            /// with? ISession is needed, but maybe it's a better idea to just create ONE
            /// Session, and let it do a null check for IEquipment. If it is null, just replace
            /// it with a string and be done. */

            //string sessWithEqName = sessColl.SessionWithEquipment.Pop().;
            //string sessWithoutEqName = sessColl.SessionWithoutEquipment.Pop().;

        }
    }
}
