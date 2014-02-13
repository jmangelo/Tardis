using System;
using NSubstitute;
using NUnit.Framework;

namespace Tardis.Samples
{
    public class Example1Tests
    {
        public void T001()
        {
            // Arrange
            var expected = new DateTime(2000, 1, 1, 6, 6, 6);

            var tardis = Substitute.For<IDateTimeProvider>();
            tardis.UtcNow.Returns(expected);

            // Act
            var sut = new Example1("Title", tardis);

            // Assert
            Assert.That(sut.CreatedAt, Is.EqualTo(expected));
        }

        public void T002()
        {
            // Arrange
            var expected = new DateTime(2000, 1, 1, 6, 6, 6);

            var tardis = Substitute.For<IDateTimeProvider>();
            var sut = new Example1("Title", tardis);
            tardis.UtcNow.Returns(expected);

            // Act
            sut.Title = "Updated Title";

            // Assert
            Assert.That(sut.UpdatedAt, Is.EqualTo(expected));
        }
    }
}