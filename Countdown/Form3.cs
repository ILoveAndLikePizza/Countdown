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
                BackColor = backgroundColor;
                TopMost = alwaysOnTop;
                CountdownLabel.Text = countdownTimestamp.ToString();
                SubtitleLabel.Text = subtitle;
               
            } else
            {
                MessageBox.Show("You haven't set any configurations, please set them first!", "No configurations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Create(Environment.GetEnvironmentVariable("appdata") + "\\Countdown\\.countdownrc");
                Form1 form = new Form1();
                form.Show();
                
            }           
        }
        private void Form3_DoubleClick(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
