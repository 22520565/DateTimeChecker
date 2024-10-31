namespace DateTimeChecker.UnitTest.Controllers;

using DateTimeController = DateTimeChecker.Controllers.DateTimeController;

public static class DateTimeControllerTests
{
    [Theory]
    [InlineData(2000, 1, 0, false)]
    [InlineData(2000, 12, 32, false)]
    [InlineData(2000, 0, 1, false)]
    [InlineData(2000, 13, 31, false)]
    [InlineData(2000, 1, 1, true)]
    [InlineData(2000, 12, 31, true)]
    [InlineData(2001, 2, 29, false)]
    private static void IsValidDate_ValidateVariousCases_ReturnsExpectedResult(short year, byte month, byte day, bool expected)
    {
        bool result = DateTimeController.IsValidDate(year, month, day);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2000, 1, 31)]
    [InlineData(2000, 3, 31)]
    [InlineData(2000, 5, 31)]
    [InlineData(2000, 7, 31)]
    [InlineData(2000, 8, 31)]
    [InlineData(2000, 10, 31)]
    [InlineData(2000, 12, 31)]
    [InlineData(2000, 4, 30)]
    [InlineData(2000, 6, 30)]
    [InlineData(2000, 9, 30)]
    [InlineData(2000, 11, 30)]
    [InlineData(2009, 2, 28)]
    [InlineData(2012, 2, 29)]
    [InlineData(2000, 2, 29)]
    [InlineData(2100, 2, 28)]
    [InlineData(2000, 13, 0)]
    [InlineData(2000, 0, 0)]
    private static void DaysInMonth_ValidateVariousCases_ReturnsExpectedResult(short year, byte month, byte expectedDays)
    {
        byte actualDays = DateTimeController.DaysInMonth(year, month);
        Assert.Equal(expectedDays, actualDays);
    }
}
