namespace DateTimeChecker.Forms;

using Resources = Properties.Resources;

public static class DialogBox
{
    public static DialogResult ShowError(IWin32Window? owner, string message)
    {
        return MessageBox.Show(owner, message, Resources.ErrorTitle, MessageBoxButtons.OK,
            MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }

    public static DialogResult ShowMessage(IWin32Window? owner, string message)
    {
        return MessageBox.Show(owner, message, Resources.MessageTitle, MessageBoxButtons.OK,
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
    }
}
