using NUnit.Framework;
using Triangle;

namespace Triangle.Tests
{
    public class TriangleTests
    {
        [TestFixture]
        public class Test1
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

            [Test]
            public void ValidTriangle_Input40and80and60_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 40;
                int secondAngle = 80;
                int thirdAngle = 60;
                string expected = "The triangle is valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void InValidTriangle_Input40and81and60_OutputNotValidTriangle()
            {
                // Arrange
                int firstAngle = 40;
                int secondAngle = 81;
                int thirdAngle = 60;
                string expected = "The triangle is not valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void NotValidTriangle_Input61and60and60_OutputNOTValidTriangle()
            {
                // Arrange
                int firstAngle = 61;
                int secondAngle = 60;
                int thirdAngle = 60;
                string expected = "The triangle is NOT valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void ValidTriangle_Input30and30and120_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 30;
                int secondAngle = 30;
                int thirdAngle = 120;
                string expected = "The triangle is valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void ValidTriangle_Input31and29and120_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 31;
                int secondAngle = 29;
                int thirdAngle = 120;
                string expected = "The triangle is valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void ValidTriangle_Input20and40and120_OutputValidTriangle()
            {
                // Arrange
                int firstAngle = 20;
                int secondAngle = 40;
                int thirdAngle = 120;
                string expected = "The triangle is valid.";

                // Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                // Assert
                Assert.That(actual, Is.EqualTo(expected));
            }
        }
    }
}