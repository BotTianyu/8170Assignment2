using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;


namespace TestClass
{
    public class Class1
    {
        [TestFixture]

            public class TriangleTest1
        {
            [Test]

            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {

                int firstSide = 60;
                int secondSide = 60;
                int thirdSide = 60;

                string expected = "The triangle is valid and is an EQUILATERAL";


                string actual = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
