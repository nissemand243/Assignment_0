using System;
using System.IO;
using Xunit;

namespace Leap_Year.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Year1400_Is_Not_Leap()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1400");
            Console.SetIn(input);

            // Act
            Program.Main(new string[0]);

            // Assert
            string[] output = writer.ToString().Split(Environment.NewLine);

            bool isLeap = Program.IsLeapYear(1400);
            Assert.False(isLeap);

            Assert.Equal("Please enter a year", output[0].Trim());
            Assert.Equal("oh no, it is not a leap year", output[1].Trim());

        }

        [Fact]
        public void Year1600_Is_Leap()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1600");
            Console.SetIn(input);

            // Act
            Program.Main(new string[0]);

            // Assert
            string[] output = writer.ToString().Split(Environment.NewLine);
            bool isLeap = Program.IsLeapYear(1600);
            
            Assert.True(isLeap);
            
            Assert.Equal("Please enter a year", output[0].Trim());
            Assert.Equal("yay, it is a leap year", output[1].Trim());

        }

        [Fact]
        public void IsLeapYear1500_Input_Not_Valid()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1500");
            Console.SetIn(input);

            // Act
            Program.Main(new string[0]);

            // Assert
            string[] output = writer.ToString().Split(Environment.NewLine);
            
            Assert.Equal("Please enter a year", output[0].Trim());
            Assert.Equal("Input year below 1582 is invalid", output[1].Trim());
        }
    }
}

