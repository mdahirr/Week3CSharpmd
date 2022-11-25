using SafariParkApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkTests
{
    internal class VehicleTests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }


        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [Test]
        public void WhenADefaultVehicleMovesThreeTimesItsPositionIs30()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(3);
            Assert.AreEqual(30, v.Position);
            Assert.AreEqual("Moving along 3 times", result);
        }

        [Test]
        public void WhenAVehilceWithSpeed50IsMovedOnceItsPositionIs20()
        {
            Vehicle v = new Vehicle(5, 50);
            var result = v.Move();
            Assert.AreEqual(50, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        //public void WhenAVehicleWithSpeed25IsMovedTwiceItsPositionIs50()
        //{
        //    Vehicle v = new Vehicle(5, 25);
        //    var result = v.Move(2);
        //    Assert.AreEqual(50, v.Position);
        //    Assert.AreEqual()
        //}

        [TestCase(1)]
        public void WhenGivenAValidNumberForPassengers_Vehicle_UpdatedsProperty(int numPassengers)
        {
            Vehicle v = new Vehicle(10, 40);
            v.NumPassengers = numPassengers;
            Assert.That(v.NumPassengers, Is.EqualTo(numPassengers));
        }
    }
}
