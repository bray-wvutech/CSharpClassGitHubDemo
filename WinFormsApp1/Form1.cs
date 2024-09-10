namespace WinFormsApp1;

public partial class frmMain : Form
{
    public frmMain()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void concatButton_Click(object sender, EventArgs e)
    {
        var firstName = firstNameTextBox.Text;
        string lastName = lastNameTextBox.Text;
        string fullName = firstName + " " + lastName;

        statusLabel.Text = fullName;
    }

    // value vs. reference params
    class ParamTester
    {
        public int x;
    }

    private void demoButton_Click(object sender, EventArgs e)
    {
        ValueRefDemo1();
        //ValueRefDemo2();
        //ValueRefDemo3();
        //ValueRefDemo4();
        //NullErrorDemo();
        //NullCrashDemo();
        //NullableValueDemo();
    }

    private void ValueRefDemo1()
    {
        int x = 1;
        
        MessageBox.Show(x.ToString());
        ValueParam(x);
        MessageBox.Show(x.ToString());
    }

    private void ValueRefDemo2()
    {
        ParamTester paramTester = new ParamTester();
        paramTester.x = 30;
        
        MessageBox.Show(paramTester.x.ToString());
        ObjParam(paramTester);
        MessageBox.Show(paramTester.x.ToString());
    }

    private void ValueRefDemo3()
    {
        string str = "init value";

        MessageBox.Show(str);
        ValueParam(str);
        MessageBox.Show(str);
    }

    private void ValueRefDemo4()
    {
        int x = 3;

        MessageBox.Show(x.ToString());
        RefParam(ref x);
        MessageBox.Show(x.ToString());
    }

    private void ValueParam(int x)
    {
        x = 3;
    }

    private void ValueParam(string str)
    {
        str = "set by RefParam function";
    }

    private void ObjParam(ParamTester pt)
    {
        pt.x = 45;
    }

    private void RefParam(ref int x)
    {
        x = 7;
    }

    // a null warning
    private void NullErrorDemo()
    {
        var firstName = firstNameTextBox.Text;
        string lastName = lastNameTextBox.Text;
        String fullName;
        System.String sameThing = "";

        // comment this out to show error
        fullName = firstName + " " + lastName;

        statusLabel.Text = fullName;
    }

    // crash by using stringVariable.Length.ToString()
    private void NullCrashDemo()
    {
        string crash = null;
        //string? crash = null;

        statusLabel.Text = crash.ToString();

        //if (!string.IsNullOrEmpty(crash))
        //{
        //    statusLabel.Text = crash.ToString();
        //}

        //if (crash is not null)
        //{
        //    statusLabel.Text = crash.ToString();
        //}

        //if (crash != null)
        //{
        //    statusLabel.Text = crash.ToString();
        //}

        // null conditional operator
        statusLabel.Text = crash?.ToString();

        // null coalescing operator
        statusLabel.Text = crash ?? "null coalescing operator";
    }

    private void NullableValueDemo()
    {
        int? x = null;

        //x = 1;
        int y = x ?? 3;
        MessageBox.Show(y.ToString());
    }



    private void computeButton_Click(object sender, EventArgs e)
    {
        CalculateDollars();
        //CalculateEuros();
        //CalculateWithExceptionHandling();
    }

    private void CalculateDollars()
    {
        // uncomment this and comment next to show error
        //int hoursWorked = hoursWorkedTextBox.Text;
        int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

        //decimal hourlyRate = hourlyRateTextBox.Text;
        decimal hourlyRate = decimal.Parse(hourlyRateTextBox.Text);

        // typecasting
        double total = (double)(hoursWorked * hourlyRate);

        // formatting pg. 150-152
        //statusLabel.Text = total;
        statusLabel.Text = total.ToString();
    }

    private void CalculateEuros()
    {
        int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
        decimal hourlyRate = decimal.Parse(hourlyRateTextBox.Text);
        double dollars = (double)(hoursWorked * hourlyRate);
        double euros = dollars * CONVERSION_RATE;
        
        // string interpolation
        // formatting pg. 150-152
        statusLabel.Text = $"we earned {euros} euros.";
    }

    // with exception handling
    private void CalculateWithExceptionHandling()
    {
        try
        {
            CalculateDollars();
        }
        catch (Exception ex)
        {
            statusLabel.ForeColor = Color.Red;
            statusLabel.Text = ex.Message;
        }
    }

    private const double CONVERSION_RATE = 0.91;
    private readonly decimal CONVERSION_RATE2 = 0.91m;
}
