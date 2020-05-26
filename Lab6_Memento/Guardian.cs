using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Memento
{
    class Guardian
    {
        private Stack<Memento> memento;
        public Guardian()
        {
            memento = new Stack<Memento>();
        }
        public void doPush(Memento m)
        {
            memento.Push(m);
        }
        public Memento doPop()
        {
            if (memento.Count == 1)
            {
                return memento.First();
            }
            return memento.Pop();
        }
    }
}
