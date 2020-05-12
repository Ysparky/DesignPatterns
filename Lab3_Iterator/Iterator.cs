using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Iterator
{
    public class Iterator
    {
        private ListBox list;
        private int c = 0;

        public Iterator(ListBox list)
        {
            this.list = list;
        }

        public string getTop()
        {
            c = 0;
            return list.Items[c].ToString();
        }
        public string getBottom()
        {
            c = list.Items.Count - 1;
            return list.Items[c].ToString();
        }
        public string getNext()
        {
            c++;
            if(c == list.Items.Count)
            {
                c = 0;
            }
            return list.Items[c].ToString();
        }
        public string getPrevious()
        {
            c--;
            if (c < 0)
            {
                c = list.Items.Count - 1;
            }
            return list.Items[c].ToString();
        }
        public string getCentral()
        {
            if (list.Items.Count % 2 != 0)
            {
                c = ((list.Items.Count + 1) / 2) - 1;
            }
            else
            {
                c = (list.Items.Count / 2) - 1;
            }
            return list.Items[c].ToString();
        }
    }
}
