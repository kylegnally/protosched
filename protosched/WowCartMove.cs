using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    /// <summary>
    /// Class to model a WOW cart.
    /// </summary>
    class WowCartMove : Move
    {
        private const string Name = "WOWCart";
        public bool HasPrinter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromRoom"></param>
        /// <param name="toRoom"></param>
        /// <param name="notes"></param>
        /// <param name="hasPrinter"></param>
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

        /// <summary>
        /// ToString() override for misc equipment.
        /// </summary>
        /// <returns>string</returns>
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
