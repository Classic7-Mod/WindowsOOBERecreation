using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsOOBERecreation
{
    public partial class TimeAndDate : Form
    {
        private Main _mainForm;

        public TimeAndDate(Main mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            LoadClockHTML();
            FetchTZs(tzCombo);

            this.AcceptButton = _mainForm.nextButton;

            // God why is WinForms such a mess?!
            monthCalBox.AutoSize = false;
            monthCalBox.Width = 170;
            monthCalBox.Height = 137;

            tzCombo.SelectedIndexChanged += TimeZoneCombo_SelectedIndexChanged;
        }

        private void LoadClockHTML()
        {
            string htmlPath = Path.Combine(Application.StartupPath, "time.html");
            clockBrowser.DocumentText = File.ReadAllText(htmlPath);
        }

        private void FetchTZs(ComboBox timeZoneCombo)
        {
            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            string currentTimeZoneId = TimeZoneInfo.Local.Id;

            timeZoneCombo.Items.Clear();

            foreach (var timeZone in timeZones)
            {
                timeZoneCombo.Items.Add(timeZone.DisplayName);

                DSTCheck.Enabled = timeZone.SupportsDaylightSavingTime;

                if (timeZone.Id == currentTimeZoneId)
                {
                    timeZoneCombo.SelectedItem = timeZone.DisplayName;
                    DSTCheck.Checked = timeZone.SupportsDaylightSavingTime;
                }
            }
        }

        private void TimeZoneCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null && comboBox.SelectedItem != null)
            {
                string selectedTimeZoneDisplayName = comboBox.SelectedItem.ToString();
                var timeZone = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(tz => tz.DisplayName == selectedTimeZoneDisplayName);
                if (timeZone != null)
                {
                    DSTCheck.Enabled = timeZone.SupportsDaylightSavingTime;

                    if (timeZone.SupportsDaylightSavingTime) { DSTCheck.Checked = true; }
                    else { DSTCheck.Checked = false; }

                    SetTimeZone(timeZone.Id);
                }
            }
        }

        private void SetTimeZone(string timeZoneId)
        {
            if (DSTCheck.Checked == false) { timeZoneId += "_dstoff"; }
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "tzutil.exe",
                Arguments = $"/s \"{timeZoneId}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (!string.IsNullOrEmpty(error))
                {
                    throw new Exception(error);
                }
            }
        }

        public class ChangeDate
        {
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool SetSystemTime(ref SYSTEMTIME st);

            [StructLayout(LayoutKind.Sequential)]
            public struct SYSTEMTIME
            {
                public ushort wYear;
                public ushort wMonth;
                public ushort wDayOfWeek;
                public ushort wDay;
                public ushort wHour;
                public ushort wMinute;
                public ushort wSecond;
                public ushort wMilliseconds;
            }
        }

        private void MonthCalBox_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;

            ChangeDate.SYSTEMTIME sysTime = new ChangeDate.SYSTEMTIME
            {
                wYear = (ushort)selectedDate.Year,
                wMonth = (ushort)selectedDate.Month,
                wDay = (ushort)selectedDate.Day,
                wHour = (ushort)DateTime.Now.Hour,
                wMinute = (ushort)DateTime.Now.Minute,
                wSecond = (ushort)DateTime.Now.Second,
                wMilliseconds = (ushort)DateTime.Now.Millisecond
            };

            bool result = ChangeDate.SetSystemTime(ref sysTime);
        }
    }
}