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

    private void btnHello_Click(object sender, EventArgs e)
    {
        lblStatus.Text = "Hello World!";
    }

    private void btnShow_Click(object sender, EventArgs e)
    {
        lblStatus.Visible = !lblStatus.Visible;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
