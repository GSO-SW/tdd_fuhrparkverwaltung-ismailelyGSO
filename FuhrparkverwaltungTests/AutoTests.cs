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
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Unveraendert_NegativWert()
        {
            //Arrange
            int kilometerstand = 50;
            Auto a = new Auto(kilometerstand);
            int streckeInKilometern = -1;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Fahren_SinktTank()
        {
            //Arrange
            int kilometerstand = 50;
            int tankInhaltInLitern = 10;
            int verbrauchProHundertKilometer = 4;
            Auto a = new Auto(kilometerstand, verbrauchProHundertKilometer, tankInhaltInLitern);
            int streckeInKilometern = 100;

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
            int kilometerstand = 50;
            int tankInhaltInLitern = 10;
            int verbrauchProHundertKilometer = 6;
            Auto a = new Auto(kilometerstand, verbrauchProHundertKilometer, tankInhaltInLitern);
            int streckeInKilometern = 200;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(250, a.Kilometerstand);
            Assert.AreEqual(0, a.TankInhaltInLitern);
        }
    }
}
