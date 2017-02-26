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
    public partial class Form1 : Form
    {
        private const Int32 ONE_MINUTE_IN_SECONDS = 60;
        private const Int32 ONE_HOUR_IN_SECONDS = 3600;
        private const Int32 ONE_DAY_IN_SECONDS = 86400;
        public Form1()
        {
            InitializeComponent();
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
        private void CalculateNextDate()
        {
            Int32 totalSeconds = CalculateTotalSeconds();
            DateTime now = DateTime.Now;
            DateTime next = now.AddSeconds(totalSeconds);
            lblShutdownTime.Text = next.ToString();
        }
        private Int32 CalculateTotalSeconds()
        {
            Int32 day = (Int32)numDay.Value;
            Int32 hour = (Int32)numHour.Value;
            Int32 minute = (Int32)numMinute.Value;
            Int32 totalSecond = minute * ONE_MINUTE_IN_SECONDS + hour * ONE_HOUR_IN_SECONDS + day * ONE_DAY_IN_SECONDS;
            return totalSecond;
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
        private void Shutdown()
        {
            Decimal totalSeconds = CalculateTotalSeconds();
            Process.Start("shutdown.exe", "-s -t " + totalSeconds);
            Application.Exit();
        }
        private void Abort()
        {
            Process.Start("shutdown.exe", "-a");
            Application.Exit();
        }
    }
}
