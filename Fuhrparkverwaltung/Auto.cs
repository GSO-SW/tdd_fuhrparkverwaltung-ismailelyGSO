using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private int kilometerstand;

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public int Kilometerstand
        {
            get { return this.kilometerstand; }
        }

        public void Fahren(int streckeInKilometern)
        {
            if(streckeInKilometern > 0)
            {
                kilometerstand += streckeInKilometern;
            }
        }

    }
}
