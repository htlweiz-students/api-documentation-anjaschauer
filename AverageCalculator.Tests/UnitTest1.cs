using AverageCalculator;

public class AverageCalculatorTests
{
    [Fact]
    public void Add_SingleValue_IncreasesCount()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(5);
        Assert.Equal(1, calculator.count());
    }
}