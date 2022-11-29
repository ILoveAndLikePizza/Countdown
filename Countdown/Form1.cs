using Microsoft.Win32;

#pragma warning disable CS8600
#pragma warning disable CS8602

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
            if (!Directory.Exists(Environment.GetEnvironmentVariable("appdata") + "\\Countdown")) Directory.CreateDirectory(Environment.GetEnvironmentVariable("appdata") + "\\Countdown");
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + "\\Countdown\\.countdownrc"))
            {
                try
                {
                    StreamReader reader = new StreamReader(Environment.GetEnvironmentVariable("appdata") + "\\Countdown\\.countdownrc");
                    DateTime countdownTimestamp = DateTime.FromFileTime(long.Parse(reader.ReadLine().Split('=')[1]));
                    Color windowColor = Color.FromArgb(int.Parse(reader.ReadLine().Split('=')[1]));
                    string textColor = reader.ReadLine().Split('=')[1];
                    int action = int.Parse(reader.ReadLine().Split('=')[1]);
                    bool alwaysOnTop = bool.Parse(reader.ReadLine().Split('=')[1]);
                    string subtitle = reader.ReadLine();
                    reader.Close();
                    DayInput.Value = countdownTimestamp;
                    HourInput.Value = countdownTimestamp.Hour;
                    MinuteInput.Value = countdownTimestamp.Minute;
                    SecondInput.Value = countdownTimestamp.Second;
                    HitsZeroAction.SelectedIndex = action;
                    DoAlwaysOnTop.Checked = alwaysOnTop;
                    Subtitle.Text = subtitle;
                    if (textColor == "black") BlackTextColor.Checked = true; else WhiteTextColor.Checked = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load the settings.\n" + ex.Message, "Error while loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                FileStream rc = File.Create(Environment.GetEnvironmentVariable("appdata") + "\\Countdown\\.countdownrc");
                rc.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
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
                    writer.WriteLine("text-color=" + (BlackTextColor.Checked ? "black":"white"));
                    writer.WriteLine("action=" + HitsZeroAction.SelectedIndex.ToString());
                    writer.WriteLine("always-on-top=" + DoAlwaysOnTop.Checked.ToString());
                    writer.WriteLine(Subtitle.Text);
                    writer.Dispose();
                    writer.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not save the settings.\n" + ex.Message, "Error while saving", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    MessageBox.Show(Environment.CurrentDirectory, Environment.ProcessPath);
                    if (MessageBox.Show("Countdown requires a restart in order to apply them.\nWould you like to restart now?", "Settings saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Environment.Exit(1);
                    else Close();
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