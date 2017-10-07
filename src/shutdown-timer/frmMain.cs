using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace shutdown_timer
{
    public partial class frmMain : Form
    {
        private const int MinuteInSeconds = 60;
        private const int HourInSeconds = 3600;
        private const int DayInSeconds = 86400;
        private const int SecondInMiliseconds = 1000;
        public frmMain()
        {
            InitializeComponent();
            CalculateNextDate();
            InitTimer();
        }
        private Timer timerRefresh;
        private void InitTimer()
        {
            timerRefresh = new Timer();
            timerRefresh.Tick += new EventHandler(timerRefresh_Tick);
            timerRefresh.Interval = SecondInMiliseconds;
            timerRefresh.Start();
        }
        private void CalculateNextDate()
        {
            int totalSeconds = CalculateTotalSeconds();
            DateTime now = DateTime.Now;
            DateTime next = now.AddSeconds(totalSeconds);
            lblShutdownTime.Text = next.ToString();
        }
        private int CalculateTotalSeconds()
        {
            int day = (int)numDay.Value;
            int hour = (int)numHour.Value;
            int minute = (int)numMinute.Value;
            int totalSecond = minute * MinuteInSeconds + hour * HourInSeconds + day * DayInSeconds;
            return totalSecond;
        }
        private void Shutdown()
        {
            decimal totalSeconds = CalculateTotalSeconds();
            if (totalSeconds == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to shutdown computer immediately?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Process.Start("shutdown.exe", "-s -f -t " + totalSeconds);
                    Application.Exit();
                }
            }
            else
            {
                Process.Start("shutdown.exe", "-s -f -t " + totalSeconds);
                Application.Exit();
            }
        }
        private void Abort()
        {
            Process.Start("shutdown.exe", "-a");
            Application.Exit();
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            CalculateNextDate();
        }
        private void btnShutdown_Click(object sender, EventArgs e)
        {
            Shutdown();
        }
        private void btnAbort_Click(object sender, EventArgs e)
        {
            Abort();
        }
        private void numHour_ValueChanged(object sender, EventArgs e)
        {
            CalculateNextDate();
        }
        private void numDay_ValueChanged(object sender, EventArgs e)
        {
            CalculateNextDate();
        }
        private void numMinute_ValueChanged(object sender, EventArgs e)
        {
            CalculateNextDate();
        }
    }
}
