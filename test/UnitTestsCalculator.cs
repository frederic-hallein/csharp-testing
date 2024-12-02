namespace test;

using CalculatorNS;
public class UnitTestsCalculator
{

    public static IEnumerable<object[]> TestDataAddingTwoNumbers
    {
        get
        {
            yield return new object[] {  1,  2,  3 };
            yield return new object[] { -1, -2, -3 };
        }
    }
    [Theory]
    [MemberData(nameof(TestDataAddingTwoNumbers))]
    public void Add_TwoNumbers_GivesSum(int a, int b, int expectedResult)
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int actualResult = calculator.Add(a, b);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
    


    public static IEnumerable<object[]> TestDataDividingTwoNumbers
    {
        get
        {
            yield return new object[] {  1, 0,  float.PositiveInfinity };
            yield return new object[] { -1, 0, -float.PositiveInfinity };
            yield return new object[] {  0, 0,  float.NaN };
        }
    }
    [Theory]
    [MemberData(nameof(TestDataDividingTwoNumbers))]
    public void Divide_ByZero_ExpectUndefined(int a, int b, float expectedResult)
    {
        // Arrange 
        var calculator = new Calculator();

        // Act
        float actualResult = calculator.Divide(a, b);

        // Assert
        Assert.Equal(expectedResult, actualResult); 
        
    }
}