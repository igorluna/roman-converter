using System;
using Xunit;
using roman_converter;
using FluentAssertions;

namespace roman_convertertest
{
    public class ConvertToIntTest
    {
        [Fact]
        public void ToInt_ShouldReturnOne_WhenStringIsI()
        {
            // Arrange
            int expected = 1;
            string romanNumber = "I";

            // Act
            int actual = romanNumber.ToInt();

            // Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void ToInt_ShouldReturnFive_WhenStringIsV()
        {
            // Arrange
            int expected = 5;
            string romanNumber = "V";

            // Act
            int actual = romanNumber.ToInt();

            // Assert
            actual.Should().Be(expected);
        }

        [Fact]
        public void ToInt_ShouldReturnTen_WhenStringIsX()
        {
            // Arrange
            int expected = 10;
            string romanNumber = "X";

            // Act
            int actual = romanNumber.ToInt();

            // Assert
            actual.Should().Be(expected);
        }
        
        
        [Fact]
        public void ToInt_ShouldReturnFifty_WhenStringIsL()
        {
            // Arrange
            int expected = 50;
            string romanNumber = "L";

            // Act
            int actual = romanNumber.ToInt();

            // Assert
            actual.Should().Be(expected);
        }

         [Fact]
        public void ToInt_ShouldReturnOneHundred_WhenStringIsC()
        {
            // Arrange
            int expected = 100;
            string romanNumber = "C";

            // Act
            int actual = romanNumber.ToInt();

            // Assert
            actual.Should().Be(expected);
        }

         [Fact]
        public void ToInt_ShouldReturnFiveHundred_WhenStringIsD()
        {
            // Arrange
            int expected = 500;
            string romanNumber = "D";

            // Act
            int actual = romanNumber.ToInt();

            // Assert
            actual.Should().Be(expected);
        }


         [Fact]
        public void ToInt_ShouldReturnOneThousand_WhenStringIsM()
        {
            // Arrange
            int expected = 1000;
            string romanNumber = "M";

            // Act
            int actual = romanNumber.ToInt();

            // Assert
            actual.Should().Be(expected);
        }
    }
}
