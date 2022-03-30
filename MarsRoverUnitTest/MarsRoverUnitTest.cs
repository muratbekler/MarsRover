using MarsRover;
using MarsRover.Enums;
using MarsRover.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRoverCaseUnitTest
{
    [TestClass]
    public class MarsRoverCaseUnitTest
    {
        [TestMethod]
        public void CheckRoverOne()
        {
            IMars mars = new Mars(new Position(5, 5));
            IRover one = new Rover(mars, new Position(1, 2), Directions.N);
            one.Go("LMLMLMLMM");
            Assert.AreEqual(one.ToString(), "1 3 N");
        }

        [TestMethod]
        public void CheckRoverTwo()
        {
            IMars mars = new Mars(new Position(5, 5));
            Rover two = new Rover(mars, new Position(3, 3), Directions.E);
            two.Go("MMRMMRMRRM");
            Assert.AreEqual(two.ToString(), "5 1 E");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidOutput()
        {
            IMars mars = new Mars(new Position(5, 5));
            Rover invalid = new Rover(mars, new Position(2, 2), Directions.N);
            invalid.Go("LUMMRRMLL");
        }
    }
}
