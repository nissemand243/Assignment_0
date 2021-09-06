using System;
using System.IO;
using Xunit;

namespace Leap_Year.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Year1700_Is_Not_Leap()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1700");
            Console.SetIn(input);

            // Act
            Program.Main(new string[0]);

            // Assert
            string[] output = writer.ToString().Split(Environment.NewLine);

            bool isLeap = Program.IsLeapYear(1700);
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
            Assert.Equal("Input is invalid. Please input year from 1582 and fourth", output[1].Trim());
        }

        [Fact]
        public void IsLeapYear_NonInt_Input_Is_Invalid()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("asdasd");
            Console.SetIn(input);

            // Act
            Program.Main(new string[0]);

            // Assert
            string[] output = writer.ToString().Split(Environment.NewLine);
            
            Assert.Equal("Please enter a year", output[0].Trim());
            Assert.Equal("Letters and decimal numbers are not allowed. Please input year in integer format.", output[1].Trim());
        }
    }
}

