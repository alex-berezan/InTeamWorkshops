using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using VeryOOHelloWorld;

namespace VeryOOHelloWorldIntegrationTests
{
    [TestFixture]
    public class IntegrationTests
    {
        [Test]
        public void Should_Write_Hello_World_On_Console()
        {
            // Arrange
            var stringWriter = new StringWriter();

            Console.SetOut(stringWriter);
            Program.Main(new string[] { });
            stringWriter.Flush();

            // Act
            var message = stringWriter.GetStringBuilder().ToString();

            // Assert
            Assert.IsTrue(message.Contains("Hello world"));
        }
    }
}
