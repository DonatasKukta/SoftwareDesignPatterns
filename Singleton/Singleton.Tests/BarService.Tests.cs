namespace Singleton.Tests
{
    using Moq;
    using NUnit.Framework;

    using Singleton.Services;
    using Singleton.Logging;

    public class BarServiceTests
    {
        BarService service;
        Mock<ILogger> injectedLoggerMock;

        [SetUp]
        public void Setup()
        {
            injectedLoggerMock = new Mock<ILogger>();
            injectedLoggerMock.Setup(i => i.Log(It.IsAny<string>())).Verifiable();

            service = new BarService(injectedLoggerMock.Object);
        }

        [Test]
        public void Bar1Test()
        {
            service.Bar1();
        }

        [Test]
        public void Bar2Test()
        {
            service.Bar2();
        }

        [Test]
        public void Bar3Test()
        {
            service.Bar3();
            injectedLoggerMock.Verify();
        }
    }
}