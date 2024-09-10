namespace WinFormsApp1;

partial class frmMain
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
        firstNameLabel = new Label();
        firstNameTextBox = new TextBox();
        lastNameLabel = new Label();
        lastNameTextBox = new TextBox();
        concatButton = new Button();
        statusLabel = new Label();
        hoursWorkedLabel = new Label();
        hoursWorkedTextBox = new TextBox();
        rateTextBox = new Label();
        hourlyRateTextBox = new TextBox();
        computeButton = new Button();
        demoButton = new Button();
        SuspendLayout();
        // 
        // firstNameLabel
        // 
        firstNameLabel.AutoSize = true;
        firstNameLabel.Location = new Point(12, 13);
        firstNameLabel.Name = "firstNameLabel";
        firstNameLabel.Size = new Size(80, 20);
        firstNameLabel.TabIndex = 0;
        firstNameLabel.Text = "&First Name";
        // 
        // firstNameTextBox
        // 
        firstNameTextBox.Location = new Point(12, 45);
        firstNameTextBox.Name = "firstNameTextBox";
        firstNameTextBox.Size = new Size(279, 27);
        firstNameTextBox.TabIndex = 1;
        // 
        // lastNameLabel
        // 
        lastNameLabel.AutoSize = true;
        lastNameLabel.Location = new Point(297, 13);
        lastNameLabel.Name = "lastNameLabel";
        lastNameLabel.Size = new Size(79, 20);
        lastNameLabel.TabIndex = 2;
        lastNameLabel.Text = "&Last Name";
        // 
        // lastNameTextBox
        // 
        lastNameTextBox.Location = new Point(297, 45);
        lastNameTextBox.Name = "lastNameTextBox";
        lastNameTextBox.Size = new Size(243, 27);
        lastNameTextBox.TabIndex = 3;
        // 
        // concatButton
        // 
        concatButton.Location = new Point(546, 45);
        concatButton.Name = "concatButton";
        concatButton.Size = new Size(94, 29);
        concatButton.TabIndex = 4;
        concatButton.Text = "&Concat";
        concatButton.UseVisualStyleBackColor = true;
        concatButton.Click += concatButton_Click;
        // 
        // statusLabel
        // 
        statusLabel.BorderStyle = BorderStyle.FixedSingle;
        statusLabel.Location = new Point(12, 339);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(628, 136);
        statusLabel.TabIndex = 5;
        statusLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // hoursWorkedLabel
        // 
        hoursWorkedLabel.AutoSize = true;
        hoursWorkedLabel.Location = new Point(12, 206);
        hoursWorkedLabel.Name = "hoursWorkedLabel";
        hoursWorkedLabel.Size = new Size(103, 20);
        hoursWorkedLabel.TabIndex = 6;
        hoursWorkedLabel.Text = "Hours &Worked";
        // 
        // hoursWorkedTextBox
        // 
        hoursWorkedTextBox.Location = new Point(12, 229);
        hoursWorkedTextBox.Name = "hoursWorkedTextBox";
        hoursWorkedTextBox.Size = new Size(279, 27);
        hoursWorkedTextBox.TabIndex = 7;
        // 
        // rateTextBox
        // 
        rateTextBox.AutoSize = true;
        rateTextBox.Location = new Point(297, 206);
        rateTextBox.Name = "rateTextBox";
        rateTextBox.Size = new Size(87, 20);
        rateTextBox.TabIndex = 8;
        rateTextBox.Text = "Hourly &Rate";
        // 
        // hourlyRateTextBox
        // 
        hourlyRateTextBox.Location = new Point(297, 229);
        hourlyRateTextBox.Name = "hourlyRateTextBox";
        hourlyRateTextBox.Size = new Size(243, 27);
        hourlyRateTextBox.TabIndex = 9;
        // 
        // computeButton
        // 
        computeButton.Location = new Point(546, 229);
        computeButton.Name = "computeButton";
        computeButton.Size = new Size(94, 29);
        computeButton.TabIndex = 10;
        computeButton.Text = "Compute";
        computeButton.UseVisualStyleBackColor = true;
        computeButton.Click += computeButton_Click;
        // 
        // demoButton
        // 
        demoButton.Location = new Point(231, 123);
        demoButton.Name = "demoButton";
        demoButton.Size = new Size(179, 29);
        demoButton.TabIndex = 11;
        demoButton.Text = "Value Ref Demo";
        demoButton.UseVisualStyleBackColor = true;
        demoButton.Click += demoButton_Click;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(660, 493);
        Controls.Add(demoButton);
        Controls.Add(computeButton);
        Controls.Add(hourlyRateTextBox);
        Controls.Add(rateTextBox);
        Controls.Add(hoursWorkedTextBox);
        Controls.Add(hoursWorkedLabel);
        Controls.Add(statusLabel);
        Controls.Add(concatButton);
        Controls.Add(lastNameTextBox);
        Controls.Add(lastNameLabel);
        Controls.Add(firstNameTextBox);
        Controls.Add(firstNameLabel);
        Name = "frmMain";
        Text = "Our First Program";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label firstNameLabel;
    private TextBox firstNameTextBox;
    private Label lastNameLabel;
    private TextBox lastNameTextBox;
    private Button concatButton;
    private Label statusLabel;
    private Label hoursWorkedLabel;
    private TextBox hoursWorkedTextBox;
    private Label rateTextBox;
    private TextBox hourlyRateTextBox;
    private Button computeButton;
    private Button demoButton;
}
