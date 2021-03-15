using System;
using Xunit;

namespace Bonus01.Test
{
    public class LetterConverterTest
    {
        [Fact]
        public void ConvertsToLetter()
        {
            //Arrange
            var converter = new GetGrade();
            //Act
            var result = converter.GetGradeLetter(85);
            //Assert
            Assert.Equal("B", result);

        }
    }
}
