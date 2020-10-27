namespace Singleton.Tests
{
    using Moq;
    using NUnit.Framework;

    using Singleton.Services;
    using Singleton.Logging;

    public class FooServiceTests
    {
        FooService service;
        Mock<ILogger> injectedLoggerMock;

        [SetUp]
        public void Setup()
        {
            injectedLoggerMock = new Mock<ILogger>();
            injectedLoggerMock.Setup(i => i.Log(It.IsAny<string>())).Verifiable();

            service = new FooService(injectedLoggerMock.Object);
        }

        [Test]
        public void Foo1Test()
        {
            service.Foo1();
        }

        [Test]
        public void Foo2Test()
        {
            service.Foo2();
        }

        [Test]
        public void Foo3Test()
        {
            service.Foo3();
            injectedLoggerMock.Verify();
        }
    }
}