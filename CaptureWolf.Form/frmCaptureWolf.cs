namespace CaptureWolf.UI;

public partial class frmCaptureWolf : Form
{
    public bool ImageSet = false;

    public frmCaptureWolf()
    {
        InitializeComponent();
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        Handler.PreventScreenSaver(true);
        Handler.MinimizeAll();

        Thread.Sleep(2000);
        Handler.HookupEvents(OnCapture);
    }

    private bool OnCapture(Image image)
    {
        pictureBox.Image = image;
        ImageSet = true;
        explainLabel.Text = "We captured one!!! Click the photo to save it.";

        // Bring the current application window to the front
        Invoke(() =>
        {
            WindowState = FormWindowState.Normal;
            Activate();
        });
        
        SetupTooltip();
        return true;
    }

    private void pictureBox_Click(object sender, EventArgs e)
    {
        if (!ImageSet || pictureBox.Image == null)
            return;

        using var sfd = new SaveFileDialog();
        sfd.Filter = @"Images|*.png;*.bmp;*.jpg";
        sfd.DefaultExt = "png";

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            pictureBox.Image.Save(sfd.FileName);
        }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void SetupTooltip()
    {
        var toolTip = new ToolTip();
        toolTip.AutoPopDelay = 5000;
        toolTip.InitialDelay = 1000;
        toolTip.ReshowDelay = 500;
        toolTip.ShowAlways = true;
        toolTip.BackColor = Color.FromArgb(50, 50, 50); // Dark gray
        toolTip.ForeColor = Color.White;
        toolTip.SetToolTip(this.pictureBox, "Click the image to save it.");
    }
}
