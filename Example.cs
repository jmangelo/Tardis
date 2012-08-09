using System;
using NSubstitute;
using NUnit.Framework;
using Tardis;

public class Example
{
    public Example()
        : this(string.Empty) { }

    public Example(string title)
    {
#if DEBUG
        this.DateTime = DateTimeProvider.Default;
        this.Initialize(title);
    }

    internal IDateTimeProvider DateTime { get; set; }

    internal Example(string title, IDateTimeProvider provider)
    {
        this.DateTime = provider;
#endif
        this.Initialize(title);
    }

    private void Initialize(string title)
    {
        this.Title = title;
        this.CreatedAt = DateTime.UtcNow;
    }

    private string title;

    public string Title
    {
        get { return this.title; }
        set
        {
            this.title = value;
            this.UpdatedAt = DateTime.UtcNow;
        }
    }

    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
}

public class TExample
{
    public void T001()
    {
        // Arrange
        var tardis = Substitute.For<IDateTimeProvider>();
        tardis.UtcNow.Returns(DateTime.UtcNow);

        // Act
        var sut = new Example("Title", tardis);

        // Assert
        Assert.That(sut.CreatedAt, Is.EqualTo(tardis.UtcNow));
    }

    public void T002()
    {
        // Arrange
        var tardis = Substitute.For<IDateTimeProvider>();
        var sut = new Example("Title", tardis);
        tardis.UtcNow.Returns(DateTime.UtcNow);

        // Act
        sut.Title = "Updated";

        // Assert
        Assert.That(sut.UpdatedAt, Is.EqualTo(tardis.UtcNow));
    }
}

class Program
{
    static void Main(string[] args)
    {
        var tests = new TExample();

        tests.T001();
        tests.T002();
    }
}
