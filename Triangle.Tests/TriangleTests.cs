using NUnit.Framework;
using Triangle;

namespace Triangle.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            string expected = "The triangle is valid.";

            // Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Add your tests below this line

    }
}