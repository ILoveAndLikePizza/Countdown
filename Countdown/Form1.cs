namespace Countdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Color color;

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DayInput.Value = new DateTime(now.Year, now.Month, now.Day);
            HourInput.Value = now.Hour;
            MinuteInput.Value = now.Minute;
            SecondInput.Value = now.Second;

            HitsZeroAction.SelectedIndex = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime date = DayInput.Value;
            date = date.AddHours((double)HourInput.Value);
            date = date.AddMinutes((double)MinuteInput.Value);
            date = date.AddSeconds((double)SecondInput.Value);
            if (DateTime.Now.ToFileTime() > date.ToFileTime())
            {
                MessageBox.Show("You cannot set the countdown to the past.", "Cannot set countdown", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    StreamWriter writer = new StreamWriter(Environment.GetEnvironmentVariable("appdata") + "\\Countdown\\.countdownrc");
                    writer.WriteLine("countdown-timestamp=" + date.ToFileTime());
                    writer.WriteLine("window-color=" + color.ToArgb().ToString());
                    writer.WriteLine("action=" + HitsZeroAction.SelectedIndex.ToString());
                    writer.WriteLine("run-on-startup=" + DoRunAtStart.Checked.ToString());
                    writer.WriteLine("always-on-top=" + DoAlwaysOnTop.Checked.ToString());
                    writer.WriteLine(Subtitle.Text);
                    writer.Dispose();
                    writer.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show("Could not save the settings.\n" + ex, "Error while saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } finally
                {
                    Environment.Exit(1);
                }
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void SetColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
            }
        }
    }
}