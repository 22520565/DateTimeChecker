namespace DateTimeChecker.Forms;

using DateTimeChecker.Controllers;
using CultureInfo = System.Globalization.CultureInfo;
using Resources = Properties.Resources;

public partial class MainForm : Form
{
    public static byte MinDay => 1;
    public static byte MaxDay => 31;
    public static byte MinMonth => 1;
    public static byte MaxMonth => 31;
    public static short MinYear => 1000;
    public static short MaxYear => 3000;

    public MainForm()
    {
        this.InitializeComponent();
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        this.tbDay.Clear();
        this.tbMonth.Clear();
        this.tbYear.Clear();
    }

    private void checkButton_Click(object sender, EventArgs e)
    {
        if (!byte.TryParse(this.tbDay.Text, CultureInfo.InvariantCulture, out var day))
        {
            DialogBox.ShowError(this, Resources.DayIsNotNumberErrorString);
        }
        else if ((day < MinDay) || (day > MaxDay))
        {
            DialogBox.ShowError(this, Resources.DayOutOfRangerErrorString);
        }
        else if (!byte.TryParse(this.tbMonth.Text, CultureInfo.InvariantCulture, out var month))
        {
            DialogBox.ShowError(this, Resources.MonthIsNotNumberErrorString);
        }
        else if ((month < MinMonth) || (month > MaxMonth))
        {
            DialogBox.ShowError(this, Resources.MonthOutOfRangerErrorString);
        }
        else if (!short.TryParse(this.tbYear.Text, CultureInfo.InvariantCulture, out var year))
        {
            DialogBox.ShowError(this, Resources.YearIsNotNumberErrorString);
        }
        else if ((year < MinYear) || (year > MaxYear))
        {
            DialogBox.ShowError(this, Resources.YearOutOfRangerErrorString);
        }
        else if (!DateTimeController.IsValidDate(year, month, day))
        {
            DialogBox.ShowMessage(this,
                String.Format(CultureInfo.InvariantCulture,
                Resources.IncorrectDateTimeFormatInfoFormatString,
                day, month, year));
        }
        else
        {
            DialogBox.ShowMessage(this,
                String.Format(CultureInfo.InvariantCulture,
                Resources.CorrectDateTimeFormatInfoFormatString,
                day, month, year));
        }
    }
}
