using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;
using System.Web;

namespace TestLibrary
{
    public class TriangleTester
    {
        [TestFixture]

        public class EQUILATERAL
        {
            [Test]
            public void ValidTriangle_Input5_5_5_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                string expected = "The triangle is valid and is an EQUILATERAL";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class ISOSCELES1
        {
            [Test]
            public void ValidTriangle_Input5_5_6_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 6;

                string expected = "The triangle is valid and is an ISOSCELES";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class ISOSCELES2
        {
            [Test]
            public void ValidTriangle_Input5_5_8_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 8;

                string expected = "The triangle is valid and is an ISOSCELES";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class ISOSCELES3
        {
            [Test]
            public void ValidTriangle_Input6_6_10_OutputValidTriangle()
            {

                int firstSide = 6;
                int secondSide = 6;
                int thirdSide = 10;

                string expected = "The triangle is valid and is an ISOSCELES";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class SCALENE1
        {
            [Test]
            public void ValidTriangle_Input5_5_5_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                string expected = "The triangle is valid and is an EQUILATERAL";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class SCALENE2
        {
            [Test]
            public void ValidTriangle_Input5_5_5_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                string expected = "The triangle is valid and is an EQUILATERAL";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }
        public class SCALENE3
        {
            [Test]
            public void ValidTriangle_Input5_5_5_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                string expected = "The triangle is valid and is an EQUILATERAL";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }
        public class SCALENE4
        {
            [Test]
            public void ValidTriangle_Input5_5_5_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                string expected = "The triangle is valid and is an EQUILATERAL";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class SCALENE5
        {
            [Test]
            public void ValidTriangle_Input5_5_5_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 5;
                int thirdSide = 5;

                string expected = "The triangle is valid and is an EQUILATERAL";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }
    }
}
