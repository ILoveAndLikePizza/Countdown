using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable CS8600
#pragma warning disable CS8601
#pragma warning disable CS8602
#pragma warning disable CS8618
#pragma warning disable CS8622

namespace Countdown
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private Color backgroundColor;
        private Color textColor;
        private DateTime countdownTimestamp;
        private string subtitle;
        private int zeroAction;
        private bool alwaysOnTop;

        private void Form3_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.GetEnvironmentVariable("appdata") + "\\Countdown")) Directory.CreateDirectory(Environment.GetEnvironmentVariable("appdata") + "\\Countdown");
            if (File.Exists(Environment.GetEnvironmentVariable("appdata") + "\\Countdown\\.countdownrc"))
            {
                StreamReader reader = new StreamReader(Environment.GetEnvironmentVariable("appdata") + "\\Countdown\\.countdownrc");
                int lineNumber = 0;
                while (!reader.EndOfStream)
                {
                    try
                    {
                        lineNumber++;
                        string line = reader.ReadLine();
                        if (lineNumber <= 5)
                        {
                            string value = line.Split('=')[1];
                            if (line.StartsWith("countdown-timestamp=")) countdownTimestamp = DateTime.FromFileTime(long.Parse(value));
                            else if (line.StartsWith("window-color=")) backgroundColor = Color.FromArgb(int.Parse(value));
                            else if (line.StartsWith("text-color=")) textColor = (value == "black") ? Color.Black : Color.White;
                            else if (line.StartsWith("action=")) zeroAction = int.Parse(value);
                            else if (line.StartsWith("always-on-top=")) bool.Parse(value);
                        }
                        else if (lineNumber == 6) subtitle = line;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not load the settings.\n" + ex.Message, "Error while loading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                reader.Close();
                UpdateClock(sender, e);
                if (backgroundColor.A == 1) BackColor = backgroundColor;
                if (textColor.A == 1) CountdownLabel.ForeColor = SubtitleLabel.ForeColor = textColor;
                TopMost = alwaysOnTop;
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(UpdateClock);
                timer.Start();
            }
            else
            {
                MessageBox.Show("You haven't set any configurations, please set them first!", "No configurations found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FileStream rc = File.Create(Environment.GetEnvironmentVariable("appdata") + "\\Countdown\\.countdownrc");
                rc.Close();
                Form1 form = new Form1();
                form.Show();
                
            }           
        }
        private void Form3_DoubleClick(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            int hoursLeft = countdownTimestamp.Hour - DateTime.Now.Hour;
            int minutesLeft = countdownTimestamp.Minute - DateTime.Now.Minute;
            int secondsLeft = countdownTimestamp.Second - DateTime.Now.Second;
            if (hoursLeft < 0) hoursLeft += 24;
            if (minutesLeft < 0) minutesLeft += 60;
            if (secondsLeft < 0) secondsLeft += 60;
            string hours = "0" + hoursLeft;
            string minutes = "0" + minutesLeft;
            string seconds = "0" + secondsLeft;
            hours = hours[hours.Length - 2].ToString() + hours[hours.Length - 1].ToString();
            minutes = minutes[minutes.Length - 2].ToString() + minutes[minutes.Length - 1].ToString();
            seconds = seconds[seconds.Length - 2].ToString() + seconds[seconds.Length - 1].ToString();

            CountdownLabel.Text = hours + ":" + minutes + ":" + seconds;
            SubtitleLabel.Text = subtitle;
        }
    }
}