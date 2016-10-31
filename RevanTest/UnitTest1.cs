using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Revan;

namespace RevanTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSampleTime()
        {
            var expectedOutput = "Y RRRO ROOO YYRYYRYOOOO YYOO";
            var input = "16:37:16";

            // create a clock
            var revan = new Revan.RevanClock();

            Assert.AreEqual(expectedOutput, revan.parse(input), "The time did not parse corectly");
        }

        [TestMethod]
        public void TestBulbSwap()
        {
            var expectedOutput = "R YYYO YOOO RRYRRYROOOO RROO";
            var input = "16:37:16";

            // create a clock
            var revan = new Revan.RevanClock()
            {
                Bulb = new Revan.ROBulb(),
                Accent = new Revan.QuarterAccent(new Revan.YOBulb())
            };

            Assert.AreEqual(expectedOutput, revan.parse(input), "The time did not parse corectly");
        }
    }
}
