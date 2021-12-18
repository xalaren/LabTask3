using NUnit.Framework;

namespace LabTask3.Tests
{
    public class ExtMath_Test
    {
        [TestCase(1, -5, 4, new double[]{ 2, -2, 1, -1 })]
        [TestCase(-4, 16, 0, new double[] { 0, 2, -2 })]
        [TestCase(1, 0, -16, new double[] { 2, -2 })]
        [TestCase(0, -3, 27, new double[] { 3, -3 })]
        [TestCase(0, 3, 27, new double[] { })]
        [TestCase(0, 0, 0, null)]
        [TestCase(2, 5, 0, new double[] { 0 })]
        [TestCase(1, 2, 10, new double[] { })]

        public void Biq_Test(double a, double b, double c, double[] expected)
        {
            double[] actual = ExtMath.BiquadrateEq(a, b, c);

            if(expected != null)
            {
                Assert.That(actual, Is.EqualTo(expected));
            }
            else
            {
                Assert.IsNull(actual);
            }
            
        }
    }
}