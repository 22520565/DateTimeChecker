namespace DateTimeChecker.Forms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        PictureBox logo;
        Label labelTitle;
        Label labelDay;
        Label labelMonth;
        Label labelYear;
        tbDay = new TextBox();
        tbMonth = new TextBox();
        tbYear = new TextBox();
        clearButton = new Button();
        checkButton = new Button();
        logo = new PictureBox();
        labelTitle = new Label();
        labelDay = new Label();
        labelMonth = new Label();
        labelYear = new Label();
        ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
        SuspendLayout();
        // 
        // logo
        // 
        logo.Image = Properties.Resources.Logo;
        logo.Location = new Point(0, 0);
        logo.Margin = new Padding(4);
        logo.Name = "logo";
        logo.Size = new Size(256, 84);
        logo.SizeMode = PictureBoxSizeMode.Zoom;
        logo.TabIndex = 1;
        logo.TabStop = false;
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Arial", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelTitle.ForeColor = Color.Blue;
        labelTitle.Location = new Point(38, 99);
        labelTitle.Margin = new Padding(4, 0, 4, 0);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(396, 50);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Date Time Checker";
        // 
        // labelDay
        // 
        labelDay.AutoSize = true;
        labelDay.Location = new Point(119, 170);
        labelDay.Name = "labelDay";
        labelDay.Size = new Size(45, 23);
        labelDay.TabIndex = 1;
        labelDay.Text = "Day";
        // 
        // labelMonth
        // 
        labelMonth.AutoSize = true;
        labelMonth.Location = new Point(119, 217);
        labelMonth.Name = "labelMonth";
        labelMonth.Size = new Size(64, 23);
        labelMonth.TabIndex = 3;
        labelMonth.Text = "Month";
        // 
        // labelYear
        // 
        labelYear.AutoSize = true;
        labelYear.Location = new Point(119, 263);
        labelYear.Name = "labelYear";
        labelYear.Size = new Size(51, 23);
        labelYear.TabIndex = 5;
        labelYear.Text = "Year";
        // 
        // tbDay
        // 
        tbDay.Location = new Point(226, 167);
        tbDay.MaxLength = 5;
        tbDay.Name = "tbDay";
        tbDay.Size = new Size(125, 30);
        tbDay.TabIndex = 2;
        // 
        // tbMonth
        // 
        tbMonth.Location = new Point(226, 214);
        tbMonth.MaxLength = 5;
        tbMonth.Name = "tbMonth";
        tbMonth.Size = new Size(125, 30);
        tbMonth.TabIndex = 4;
        // 
        // tbYear
        // 
        tbYear.Location = new Point(226, 260);
        tbYear.MaxLength = 10;
        tbYear.Name = "tbYear";
        tbYear.Size = new Size(125, 30);
        tbYear.TabIndex = 6;
        // 
        // clearButton
        // 
        clearButton.AutoSize = true;
        clearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        clearButton.Location = new Point(119, 316);
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(67, 33);
        clearButton.TabIndex = 7;
        clearButton.Text = "Clear";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += clearButton_Click;
        // 
        // checkButton
        // 
        checkButton.AutoSize = true;
        checkButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        checkButton.Location = new Point(276, 316);
        checkButton.Name = "checkButton";
        checkButton.Size = new Size(75, 33);
        checkButton.TabIndex = 8;
        checkButton.Text = "Check";
        checkButton.UseVisualStyleBackColor = true;
        checkButton.Click += checkButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(11F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(480, 361);
        Controls.Add(checkButton);
        Controls.Add(clearButton);
        Controls.Add(tbYear);
        Controls.Add(labelYear);
        Controls.Add(tbMonth);
        Controls.Add(labelMonth);
        Controls.Add(tbDay);
        Controls.Add(labelDay);
        Controls.Add(labelTitle);
        Controls.Add(logo);
        Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Margin = new Padding(4);
        Name = "MainForm";
        Text = "DateTimeChecker";
        FormClosing += MainForm_FormClosing;
        ((System.ComponentModel.ISupportInitialize)logo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox logo;
    private Label labelTitle;
    private Label labelDay;
    private TextBox tbDay;
    private TextBox tbMonth;
    private TextBox tbYear;
    private Button clearButton;
    private Button checkButton;
}
