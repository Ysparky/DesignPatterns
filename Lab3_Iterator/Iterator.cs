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
        private ListBox MiListBox;
        private int rec;
        private int c = 0;

        public Iterator(ListBox list, int rec)
        {
            this.MiListBox = list;
            this.rec = rec;
        }

        public string getTop()
        {
            c = 0; 
            if(rec == 1)//par
            {
                while (!isEven(c))
                {
                    c++;
                }
            }
            else if (rec == 2)//impar
            {
                while (isEven(c))
                {
                    c++;
                }
            }
            else
            {
                c = 0;
            }
            return MiListBox.Items[c].ToString();
        }
        public string getBottom()
        {
            c = MiListBox.Items.Count - 1;
            if (rec == 1)
            {
                while (!isEven(c))
                {
                    c--;
                }
            }
            else if (rec == 2)
            {
                while (isEven(c))
                {
                    c--;
                }
            }
            else
            {
                c = MiListBox.Items.Count - 1;
            }
            return MiListBox.Items[c].ToString();
        }
        public string getNext()
        {
            c++;
            if(c == MiListBox.Items.Count)
            {
                c = 0;
            }
            return MiListBox.Items[c].ToString();
        }
        public string getPrevious()
        {
            c--;
            if (c < 0)
            {
                c = MiListBox.Items.Count - 1;
            }
            return MiListBox.Items[c].ToString();
        }
        public string getCentral()
        {
            if (MiListBox.Items.Count % 2 != 0)
            {
                c = ((MiListBox.Items.Count + 1) / 2) - 1;
            }
            else
            {
                c = (MiListBox.Items.Count / 2) - 1;
            }
            return MiListBox.Items[c].ToString();
        }
        public Boolean isOdd()
        {
            Boolean valor = false;
            string lastname = MiListBox.Items[c].ToString();
            char[] char_lastname = lastname.ToCharArray();
            if (char_lastname.Length % 2 != 0)
            {
                valor = true;
            }
            return valor;
        }
        public Boolean isEven(int x)
        {
            Boolean valor = false;
            string lastname = MiListBox.Items[x].ToString();
            char[] char_lastname = lastname.ToCharArray();
            if (char_lastname.Length % 2 == 0)
            {
                valor = true;
            }
            return valor;
        }
        /*public string dynamic(int x, int tipo)
        {
            int index;
            string lastname = MiListBox.Items[x].ToString();
            char[] char_lastname = lastname.ToCharArray();
            if(tipo == 1)//pares
            {
                if (char_lastname.Length % 2 == 0)
                {
                    
                }
            }
            
            else
            {

            }

        }*/
    }
}
