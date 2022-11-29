using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable CS8618
#pragma warning disable CS8600
#pragma warning disable CS8602
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
                    lineNumber++;
                    string line = reader.ReadLine();
                    if (lineNumber <= 4)
                    {
                        string value = line.Split('=')[1];
                        if (line.StartsWith("countdown-timestamp=")) countdownTimestamp = DateTime.FromFileTime(long.Parse(value));
                        else if (line.StartsWith("window-color=")) backgroundColor = Color.FromArgb(int.Parse(value));
                        else if (line.StartsWith("action=")) zeroAction = int.Parse(value);
                        else if (line.StartsWith("always-on-top=")) bool.Parse(value);
                        else subtitle = value;
                    }
                }
                reader.Close();
                if (backgroundColor.A == 1) BackColor = backgroundColor;
                TopMost = alwaysOnTop;
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 1000;
                timer.Tick += new EventHandler(UpdateClock);
                timer.Start();
            } else
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
            string hours = ("0" + (DateTime.Now.Hour - countdownTimestamp.Hour));
            string minutes = ("0" + (DateTime.Now.Minute - countdownTimestamp.Minute));
            string seconds = ("0" + (DateTime.Now.Second - countdownTimestamp.Second));
            //hours = hours[hours.Length - 2] + hours[hours.Length - 1] + "";
            //minutes = minutes[minutes.Length - 2] + minutes[minutes.Length - 1] + "";
            //seconds = seconds[seconds.Length - 2] + seconds[seconds.Length - 1] + "";
            CountdownLabel.Text = hours + ":" + minutes + ":" + seconds;
            SubtitleLabel.Text = subtitle;
        }
    }
}