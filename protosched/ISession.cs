using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    interface ISession
    {
        string Room { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        TimeSpan LengthInMinutes { get; set; }
    }
}
