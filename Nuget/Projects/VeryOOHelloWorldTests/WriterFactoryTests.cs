using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using VeryOOHelloWorld;

namespace VeryOOHelloWorldTests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class WriterFactoryTests
    {
        [Test]
        public void Should_Return_Not_Null_Writer()
        {
            // Arrange
            var factory = new WriterFactory();

            // Act
            IWriter writer = factory.CreateWriter();

            // Assert
            Assert.IsNotNull(writer);
        }
    }
}
