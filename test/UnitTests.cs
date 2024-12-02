namespace test;

using CalculatorNS;
public class UnitTests
{
    [Fact]
    public void AddPositiveNumbersReturnsExpectedResult()
    {
        // Arrange
        var calculator = new Calculator();
        int a = 3;
        int b = 5;
        int expectedResult = 8;

        // Act
        int actualResult = calculator.Add(a, b);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}