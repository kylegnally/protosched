using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    abstract class Move : IMove
    {
        private Equipment EquipmentName;
        private string BuildingName;
        private string FromRoom;
        private string ToRoom;
        private DateTime MoveFrom;
        private DateTime MoveTo;
        private DateTime NeededFrom;
        private DateTime NeededTo;
    }

    protected Move(DateTime moveFrom,
    DateTime moveto)
    {

    }

    public int CalculateOrder(object move)
    {
        if (move is IMove otherMove)
            return this.TotalCost.CompareTo(otherMove.TotalCost);
        else
            throw new ArgumentException("Object is not a Move");
    }

    ///// <summary>
    ///// returns the basic droid information when called from any child class.
    ///// </summary>
    ///// <returns></returns>
    //public override string ToString()
    //{
    //    return TotalCost.ToString("C") + " " + Color + " " + Material + " " + Name + " ";
    //}
}
