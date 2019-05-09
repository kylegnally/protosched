using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    public class SessionCollection : ISessionCollection
    {
        private ISession[] sessions;
        private int collectionPosition;

        GenericStack<ISession> aSessionStack = new GenericStack<ISession>();

        public SessionCollection()
        {
            sessions = new ISession[100];
            collectionPosition = 0;
        }

        public void Add(string roomNumber, DateTime startTime, DateTime endTime)
        {
            sessions[collectionPosition] = new Session(roomNumber, startTime, endTime);
        }
    }
}
