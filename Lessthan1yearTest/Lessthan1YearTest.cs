using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lessthan1yearTest
{
    [TestClass]
    public class Lessthan1YearTest
    {
        [TestMethod]
        public void SameYearTest()
        {
            DateTime start = new DateTime(2020, 1, 20);
            DateTime end = new DateTime(2020, 6, 4);
            bool timeframe = LessThan1Year.TimeCalculator.IsDurationLessThanOneYear(start, end);
            Assert.IsTrue(timeframe);
        }

        [TestMethod]
        public void NextYearTest()
        {
            DateTime start = new DateTime(2020, 1, 20);
            DateTime end = new DateTime(2021, 1, 4);
            bool timeframe = LessThan1Year.TimeCalculator.IsDurationLessThanOneYear(start, end);
            Assert.IsTrue(timeframe);
        }

        [TestMethod]
        public void ExactlyOneYear()
        {
            DateTime start = new DateTime(2020, 1, 20);
            DateTime end = new DateTime(2021, 1, 20);
            bool timeframe = LessThan1Year.TimeCalculator.IsDurationLessThanOneYear(start, end);
            Assert.IsFalse(timeframe);
        }

        [TestMethod]
        public void MoreThanOneYear()
        {
            DateTime start = new DateTime(2020, 1, 20);
            DateTime end = new DateTime(2021, 1, 21);
            bool timeframe = LessThan1Year.TimeCalculator.IsDurationLessThanOneYear(start, end);
            Assert.IsFalse(timeframe);
        }

        [TestMethod]
        [TestCategory("Invalid")]
        [ExpectedException(typeof(ArgumentException))]
        public void EndBeforeStart()
        {
            DateTime start = new DateTime(2021, 1, 20);
            DateTime end = new DateTime(2020, 1, 21);
            bool timeframe = LessThan1Year.TimeCalculator.IsDurationLessThanOneYear(start, end);
            Assert.Fail("Exception not thrown");
        }
    }
}
