using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        private static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CPSTrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            CPSValue.Text = CPSTrackbar.Value.ToString() + " CPS";
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("enable"))
            {
                btnToggle.Text = "disable";
            }
            else if (btnToggle.Text.Contains("disable"))
            {
                btnToggle.Text = "enable";
            }
        }

        private void btnToggle_TextChanged(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("disable"))
            {
                Autoclicker.Start();
            }
            else
            {
                Autoclicker.Stop();
            }
            if (btnToggle.Text.Contains("disable"))
            {
                btnToggle.ForeColor = Color.FromArgb(80, 80, 80);
                btnToggle.FillColor = Color.Red;
            }
            else if (btnToggle.Text.Contains("enable"))
            {
                btnToggle.ForeColor = Color.Red;
                btnToggle.FillColor = Color.FromArgb(80, 80, 80);
            }
        }

        int min;
        int max;
        IntPtr hWindow;

        public string getActiveWindowName()
        {
            try
            {
                var activatedhandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if (activatedhandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;
                        return processName;
                    }
                }
            }
            catch
            {

            }
            return null;
        }
        private void Random_Tick(object sender, EventArgs e)
        {
            if (btnToggle.Text.Contains("disable"))
            {
                min = CPSTrackbar.Value - 4;
                max = CPSTrackbar.Value + 4;
                Random random = new Random();
                randomTB.Value = (random.Next(min, max));
            }
        }

        private async void Autoclicker_Tick(object sender, EventArgs e)
        {
            try
            {
                Autoclicker.Interval = 1000 / randomTB.Value;
            }
            catch
            {

            }
            if (btnToggle.Text.Contains("disable"))
            {
                Process[] processes = Process.GetProcessesByName("javaw");
                foreach (Process process in processes)
                {
                    hWindow = FindWindow(null, process.MainWindowTitle);
                }

                string currentWindow = getActiveWindowName();
                if (currentWindow == null)
                {
                    return;
                }

                if (currentWindow.Contains("javaw"))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        PostMessage(hWindow, 0x0201, 0, 0);
                        await Task.Delay(20);
                        PostMessage(hWindow, 0x0202, 0, 0);
                    }
                }
            }
        }

        private void btnBind_Click(object sender, EventArgs e)
        {
            btnBind.Text = "...";
        }

        KeysConverter Key = new KeysConverter();

        private void Binding_Tick(object sender, EventArgs e)
        {
            if (btnBind.Text != "none" && btnBind.Text != "...")
            {
                Keys binding = (Keys)Key.ConvertFromString(btnBind.Text.Replace("...", " "));
                if (GetAsyncKeyState(binding) < 0)
                {
                    if (btnToggle.Text.Contains("disable"))
                    {
                        btnToggle.Text = "enable";
                    }
                    else if (btnToggle.Text.Contains("enable"))
                    {
                        btnToggle.Text = "disable";
                    }

                    while (GetAsyncKeyState(binding) < 0)
                    {
                        Thread.Sleep(15);
                    }
                    return;
                }
            }
        }

        private void btnBind_KeyDown(object sender, KeyEventArgs e)
        {
            {
                string keydata = e.KeyData.ToString();
                if (!keydata.Contains("Alt"))
                {
                    if (GetAsyncKeyState(Keys.Escape) < 0)
                    {
                        btnBind.Text = "none";
                    }
                    else
                    {
                        btnBind.Text = keydata;
                    }
                }
            }
            KeysConverter Key = new KeysConverter();
        }

      
    }
}
