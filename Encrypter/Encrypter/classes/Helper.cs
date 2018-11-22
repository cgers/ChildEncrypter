using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Encrypter.classes
{
    public class Helper
    {
        private Hashtable Ht {get;set;}

        public Helper ()
        {
            this.Ht = new Hashtable();
            for (int i = 0;i <= 64; i++)
            {
                Ht.Add((char)i, ((char)i).ToString());
            }
            for (int i = 65; i <= 90; i++)
            {
                Ht.Add((char)i, i-64);
            }
            for (int i = 91; i <= 96; i++)
            {
                Ht.Add((char)i, ((char)i).ToString());
            }
            for (int i = 97; i <= 122; i++)
            {
                Ht.Add((char)i, i - 96);
            }
            for (int i = 123; i <= 126; i++)
            {
                Ht.Add((char)i, ((char)i).ToString());
            }
        }

        public Hashtable GetHashTable()
        {
            return Ht;
        }
        

    }
}
