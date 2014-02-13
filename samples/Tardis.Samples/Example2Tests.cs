using System;
using NSubstitute;
using NUnit.Framework;

namespace Tardis.Samples
{
    public class Example2Tests
    {
        public void T001()
        {
            // Arrange
            var expected = new DateTime(2000, 1, 1, 6, 6, 6);

            var tardis = Substitute.For<IDateTimeProvider>();
            var sut = new Example2(tardis);
            tardis.UtcNow.Returns(expected);

            // Act
            sut.Title = "Updated Title";

            // Assert
            Assert.That(sut.UpdatedAt, Is.EqualTo(expected));
        }
    }
}