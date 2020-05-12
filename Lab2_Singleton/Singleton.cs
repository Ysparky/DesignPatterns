using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Singleton
{
    class Singleton
    {
        private static Singleton instance;
        private static int counter = 0;

        private Singleton() { }
        
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

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
    }
}
