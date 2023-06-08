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
            public void ValidTriangle_Input3_4_5_OutputValidTriangle()
            {

                int firstSide = 3;
                int secondSide = 4;
                int thirdSide = 5;

                string expected = "The triangle is valid and is a SCALENE";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class SCALENE2
        {
            [Test]
            public void ValidTriangle_Input2_3_4_OutputValidTriangle()
            {

                int firstSide = 2;
                int secondSide = 3;
                int thirdSide = 4;

                string expected = "The triangle is valid and is a SCALENE";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }
        public class SCALENE3
        {
            [Test]
            public void ValidTriangle_Input10_11_12_OutputValidTriangle()
            {

                int firstSide = 10;
                int secondSide = 11;
                int thirdSide = 12;

                string expected = "The triangle is valid and is a SCALENE";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }
        public class SCALENE4
        {
            [Test]
            public void ValidTriangle_Input5_27_28_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 27;
                int thirdSide = 28;

                string expected = "The triangle is valid and is a SCALENE";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class SCALENE5
        {
            [Test]
            public void ValidTriangle_Input100_101_102_OutputValidTriangle()
            {

                int firstSide = 100;
                int secondSide = 101;
                int thirdSide = 102;

                string expected = "The triangle is valid and is a SCALENE";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class ZERO1
        {
            [Test]
            public void ValidTriangle_Input0_101_102_OutputValidTriangle()
            {

                int firstSide = 0;
                int secondSide = 101;
                int thirdSide = 102;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class ZERO2
        {
            [Test]
            public void ValidTriangle_Input0_0_102_OutputValidTriangle()
            {

                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 102;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class ZERO3
        {
            [Test]
            public void ValidTriangle_Input0_0_0_OutputValidTriangle()
            {

                int firstSide = 0;
                int secondSide = 0;
                int thirdSide = 0;

                string expected = "At least one side of your triangle has a zero length and is thus invalid";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class OTHER1
        {
            [Test]
            public void ValidTriangle_Input1_2_4_OutputValidTriangle()
            {

                int firstSide = 1;
                int secondSide = 2;
                int thirdSide = 4;

                string expected = "A triangle cannot be formed with those numbers";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class OTHER2
        {
            [Test]
            public void ValidTriangle_Input5_6_20_OutputValidTriangle()
            {

                int firstSide = 5;
                int secondSide = 6;
                int thirdSide = 20;

                string expected = "A triangle cannot be formed with those numbers";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }

        public class OTHER3
        {
            [Test]
            public void ValidTriangle_Input1_10_100_OutputValidTriangle()
            {

                int firstSide = 1;
                int secondSide = 10;
                int thirdSide = 100;

                string expected = "A triangle cannot be formed with those numbers";

                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);

            }
        }
    }
}
