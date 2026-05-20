using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnSum_WhenTwoNumbersAreProvided()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int result = calculator.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}