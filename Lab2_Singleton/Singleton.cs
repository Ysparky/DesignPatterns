using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Singleton
{
    public class Singleton
    {
        private Singleton instance;
        private int counter = 0;
        public Singleton(int counter)
        {
            this.counter = counter;
        }
        public Singleton() { }

        public string addCounter()
        {
            counter += 1;
            return counter.ToString();
        }
        public string subtractCounter()
        {
            counter -= 1;
            return counter.ToString();
        }
        public Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
