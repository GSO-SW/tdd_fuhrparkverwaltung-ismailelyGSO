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
        private int verbrauchProHundertKilometer;
        private int tankInhaltInLitern;

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public Auto(int kilometerstand, int verbrauchProHundertKilometer, int tankInhaltInLitern) :this(kilometerstand)
        {
            this.verbrauchProHundertKilometer = verbrauchProHundertKilometer;
            this.tankInhaltInLitern = tankInhaltInLitern;
        }

        public int Kilometerstand
        {
            get { return kilometerstand; }
        }

        public int VerbrauchProHundertKilometer
        {
            get { return verbrauchProHundertKilometer; }
        }

        public int TankInhaltInLitern
        {
            get { return tankInhaltInLitern; }
        }

        public void Fahren(int streckeInKilometer)
        {
            if (streckeInKilometer >= 0)
            { 
                kilometerstand = kilometerstand + streckeInKilometer;
                tankInhaltInLitern = tankInhaltInLitern - ((verbrauchProHundertKilometer * streckeInKilometer) / 100);
                if (tankInhaltInLitern < 0)
                {
                    tankInhaltInLitern = 0;
                }
            }
        }
    }
}

