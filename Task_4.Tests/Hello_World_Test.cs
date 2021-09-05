using System;
using System.IO;
using Xunit;

namespace Task_4.Tests
{
    public class Hello_World_Test
    {
        [Fact]
        public void Main_Prints_Hello_World()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Hello_World.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("Hello, World!", output);
        }
    }
}
