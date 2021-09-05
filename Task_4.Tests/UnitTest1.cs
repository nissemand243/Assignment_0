using System;
using System.IO;
using Xunit;

namespace Task_4.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Main_Prints_Hello_World()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("Hello, World!", output);
        }
    }
}
