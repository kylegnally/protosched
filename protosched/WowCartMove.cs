using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class WowCartMove : Move
    {
        private const string Name = "WOWCart";
        public bool HasPrinter { get; set; }

        public WowCartMove(
            string fromRoom,
            string toRoom,
            //DateTime neededFromTime,
            //DateTime neededToTime,
            string notes,
            bool hasPrinter) : base(fromRoom, toRoom, notes)
        {
            this.HasPrinter = hasPrinter;
        }

        public override string ToString()
        {
            return base.ToString() +
                   HasPrinter.ToString();
        }

        public override void CalculateMoveOrder()
        {

        }
    }
}
