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
            var input = 1400;

            // Act -- nothing needed here yet
            

            // Assert
            Assert.False(Program.IsLeapYear(input));

        }
    }
}

