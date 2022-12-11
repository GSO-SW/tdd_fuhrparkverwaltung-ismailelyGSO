using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            double kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            double streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Unveraendert_NegativWert()
        {
            //Arrange
            double kilometerstand = 50;
            Auto a = new Auto(kilometerstand);
            double streckeInKilometern = -1;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Fahren_SinktTank()
        {
            //Arrange
            double kilometerstand = 50;
            double tankInhaltInLitern = 10;
            double verbrauchProHundertKilometer = 4;
            Auto a = new Auto(kilometerstand, verbrauchProHundertKilometer, tankInhaltInLitern);
            double streckeInKilometern = 100;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(150, a.Kilometerstand);
            Assert.AreEqual(6, a.TankInhaltInLitern);
        }

        [TestMethod]
        public void Fahren_SinktTankBisNullLiter()
        {
            //Arrange
            double kilometerstand = 50;
            double tankInhaltInLitern = 10;
            double verbrauchProHundertKilometer = 6;
            Auto a = new Auto(kilometerstand, verbrauchProHundertKilometer, tankInhaltInLitern);
            double streckeInKilometern = 200;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(250, a.Kilometerstand);
            Assert.AreEqual(0, a.TankInhaltInLitern);
        }

        [TestMethod]
        public void Fahren_BisTankLeer()
        {
            //Arrange
            double kilometerstand = 50;
            double tankInhaltInLitern = 10;
            double verbrauchProHundertKilometer = 6;
            Auto a = new Auto(kilometerstand, verbrauchProHundertKilometer, tankInhaltInLitern);
            double streckeInKilometern = 200;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(175, a.Kilometerstand);
            Assert.AreEqual(0, a.TankInhaltInLitern);
        }


    }
}
