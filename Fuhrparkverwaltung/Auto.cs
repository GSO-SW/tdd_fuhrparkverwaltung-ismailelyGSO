using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private double kilometerstand;
        private double verbrauchProHundertKilometer;
        private double tankInhaltInLitern;

        public Auto(double kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public Auto(double kilometerstand, double verbrauchProHundertKilometer, double tankInhaltInLitern) :this(kilometerstand)
        {
            this.verbrauchProHundertKilometer = verbrauchProHundertKilometer;
            this.tankInhaltInLitern = tankInhaltInLitern;
        }

        public double Kilometerstand
        {
            get { return kilometerstand; }
        }

        public double VerbrauchProHundertKilometer
        {
            get { return verbrauchProHundertKilometer; }
        }

        public double TankInhaltInLitern
        {
            get { return tankInhaltInLitern; }
        }

        public void Fahren(double streckeInKilometer)
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

        ////Ansatz zur Aufgabe 5
        //public void Fahren(double streckeInKilometer)
        //{
        //    streckeInKilometer = (tankInhaltInLitern / verbrauchProHundertKilometer) * 100;

        //    if (streckeInKilometer >= 0)
        //    {
        //        //Zum zurücksetzen
        //        double tankInhaltInLiternZwischenSpeicher = tankInhaltInLitern;
        //        tankInhaltInLitern = tankInhaltInLitern - ((verbrauchProHundertKilometer * streckeInKilometer) / 100);
        //        if (tankInhaltInLitern >= 0)
        //        {
        //            kilometerstand = kilometerstand + streckeInKilometer;
        //        }
        //        else
        //        {
        //            //Zum zurücksetzen
        //            tankInhaltInLitern = tankInhaltInLiternZwischenSpeicher;
        //        }

        //    }
        //}
    }
}

