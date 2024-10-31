namespace DateTimeChecker;

using MainForm = Forms.MainForm;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();

        using var mainForm = new MainForm();
        Application.Run(mainForm);
    }
}
