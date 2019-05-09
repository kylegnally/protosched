using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosched
{
    class SessionCollection : ISessionCollection
    {
        private ISession[] sessions;
        private int collectionPosition;

        GenericStack<ISession> aSessionWithoutEquipmentStack = new GenericStack<ISession>();
        GenericStack<ISession> aSessionWithEquipmentStack = new GenericStack<ISession>();

        public SessionCollection()
        {
            sessions = new ISession[100];
            collectionPosition = 0;
        }

        public void Add(string roomNumber, DateTime startTime, DateTime endTime)
        {
            sessions[collectionPosition] = new NoEqSession(roomNumber, startTime, endTime);
            aSessionWithoutEquipmentStack.Push(sessions[collectionPosition]);
            collectionPosition++;
        }

        public void Add(string roomNumber, DateTime startTime, DateTime endTime, IEquipment equipment)
        {
            sessions[collectionPosition] = new EqSession(roomNumber, startTime, endTime, equipment);
            aSessionWithEquipmentStack.Push(sessions[collectionPosition]);
            collectionPosition++;
        }
    }
}
