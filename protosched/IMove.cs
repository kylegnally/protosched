using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface IMove : IComparable
    {
        // method to calculate the order this move is in the list (should be elsewhere?)
        void CalculateMoveOrder();

        // forced inclusions 
        //DateTime MoveTimeFrom { get; set; }
        string Notes { get; set; }
    }
}
