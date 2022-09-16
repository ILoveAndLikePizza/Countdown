namespace Countdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                Environment.SetEnvironmentVariable("CountdownClock", date.ToFileTime().ToString(), EnvironmentVariableTarget.User);
                Environment.Exit(1);
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }
    }
}