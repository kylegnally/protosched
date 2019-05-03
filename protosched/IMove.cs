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
        void CalculateOrder();

        // property to hold this move's order
        int GetOrder { get; set; }

    }
}
