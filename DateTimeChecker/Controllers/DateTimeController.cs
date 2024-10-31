namespace DateTimeChecker.Controllers;

public static class DateTimeController
{
    public static bool IsValidDate(short year, byte month, byte day)
    {
        return (month >= 1) && (month <= 12)
            && (day >= 1) && (day <= DaysInMonth(year, month));
    }

    public static byte DaysInMonth(short year, byte month)
    => month switch
    {
        1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
        4 or 6 or 9 or 11 => 30,
        2 => DaysInFebruary(year),
        _ => 0,
    };

    public static byte DaysInFebruary(short year)
    {
        byte result = 0;

        if ((year % 400) == 0)
        {
            result = 29;
        }
        else if ((year % 100) == 0)
        {
            result = 28;
        }
        else if ((year % 4) == 0)
        {
            result = 29;
        }
        else
        {
            result = 28;
        }

        return result;
    }
}
