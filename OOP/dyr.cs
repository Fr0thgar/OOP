using System;
using System.Collections.Generic;
using System.Text;

namespace ZooOOP
{
    //Super klassen alle Dyr arver fra...
    class Dyr
    {
        public string navn;
        public int year;
        protected bool tam;

        public bool Tam
        {
            get { return tam; }
            set
            {
                if (tam == true)tam = true;
                if (tam == false) tam = value;
            }
        }
    }
}
