using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration;

namespace TriangleTest
{
    [TestFixture]

    public class TriangleTest1
    {
        [Test]

        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "THE TRIANGLE IS VALID.";

            string actual = Triangle.ValidTriangle(firstAngle,secondAngle,thirdAngle);
            Assert.AreEqual(expected, actual);

        }
    }
}
