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
        btnHello = new Button();
        lblStatus = new Label();
        btnShow = new Button();
        btnClose = new Button();
        SuspendLayout();
        // 
        // btnHello
        // 
        btnHello.Location = new Point(497, 250);
        btnHello.Name = "btnHello";
        btnHello.Size = new Size(222, 93);
        btnHello.TabIndex = 1;
        btnHello.Text = "Hello World";
        btnHello.UseVisualStyleBackColor = true;
        btnHello.Click += btnHello_Click;
        // 
        // lblStatus
        // 
        lblStatus.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblStatus.ForeColor = Color.OrangeRed;
        lblStatus.Location = new Point(50, 37);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(447, 72);
        lblStatus.TabIndex = 1;
        lblStatus.Text = "test";
        // 
        // btnShow
        // 
        btnShow.Location = new Point(138, 320);
        btnShow.Name = "btnShow";
        btnShow.Size = new Size(216, 75);
        btnShow.TabIndex = 0;
        btnShow.Text = "Show/Hide";
        btnShow.UseVisualStyleBackColor = true;
        btnShow.Click += btnShow_Click;
        // 
        // btnClose
        // 
        btnClose.Location = new Point(430, 56);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(248, 112);
        btnClose.TabIndex = 2;
        btnClose.Text = "Close";
        btnClose.UseVisualStyleBackColor = true;
        btnClose.Click += btnClose_Click;
        // 
        // frmMain
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        ControlBox = false;
        Controls.Add(btnClose);
        Controls.Add(btnShow);
        Controls.Add(lblStatus);
        Controls.Add(btnHello);
        Name = "frmMain";
        Text = "Our First Program";
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button btnHello;
    private Label lblStatus;
    private Button btnShow;
    private Button btnClose;
}
