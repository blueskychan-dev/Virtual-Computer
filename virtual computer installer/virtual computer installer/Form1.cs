using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Security.Principal;

namespace virtual_computer_installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.groupBox2.Visible = false;
            this.groupBox3.Visible = false;
            this.groupBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.groupBox3.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.groupBox2.Visible = true;
            this.groupBox1.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.label21.Text = "Download Haxm...";
            string folderName = @"C:\temp";
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");
            System.IO.Directory.CreateDirectory(pathString);
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/intel/haxm/releases/download/v7.7.1/haxm-macosx_v7_7_1.zip", @"C:\temp\IntelHaxm.zip");
            }
            string zipFilePath = @"C:\temp\IntelHaxm.zip";
            string extractionPath = @"C:\temp";
            ZipFile.ExtractToDirectory(zipFilePath, extractionPath);
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo(@"C:\temp\haxm-7.7.0-setup.exe");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            this.label21.Text = "Wait user install Intel HAXM";
            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
            this.label21.Text = "Clear HAXM Installer file.";

            File.Delete(@"C:\temp\haxm-7.7.0-setup.exe");
            this.label21.Text = "Download QEMU setup from qemu.weilnetz.de";
            using (var client = new WebClient())
            {
                client.DownloadFile("https://qemu.weilnetz.de/w64/2022/qemu-w64-setup-20220419.exe", @"C:\temp\qemu.exe");
            }
            ProcessInfo = new ProcessStartInfo(@"C:\temp\qemu.exe");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            this.label21.Text = "Wait user install QEMU";
            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
            this.label21.Text = "Modifying System Config [add QEMU to %path%]";
            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + "echo %path% > C:/Users/%USERNAME%/backup-path.txt && exit");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/fusedevgithub/Virtual-Computer/main/batch-cmd/sys.bat", @"C:\temp\sys.bat");
            }
            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + "C:/temp/sys.bat");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
            this.label21.Text = "Install VC x64...";
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/fusedevgithub/Virtual-Computer/raw/main/dev/Virtual%20Computer%20(VC%20for%20Intel).exe", desktop + "/Virtual-Computer-x64.exe");
            }
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/fusedevgithub/Virtual-Computer/main/batch-cmd/diskmaker.cmd", "C:/Program Files/qemu/diskmaker.cmd");
            }
            this.label21.Text = "Done!";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            string folderName = @"C:\temp";
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");
            System.IO.Directory.CreateDirectory(pathString);
            
            this.label24.Text = "Download QEMU setup from qemu.weilnetz.de";
            using (var client = new WebClient())
            {
                client.DownloadFile("https://qemu.weilnetz.de/w64/2022/qemu-w64-setup-20220419.exe", @"C:\temp\qemu.exe");
            }
            ProcessStartInfo ProcessInfo;
            Process Process;
            ProcessInfo = new ProcessStartInfo(@"C:\temp\qemu.exe");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            this.label24.Text = "Wait user install QEMU";
            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
            this.label24.Text = "Modifying System Config [add QEMU to %path%]";
            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + "echo %path% > C:/Users/%USERNAME%/backup-path.txt && exit");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/fusedevgithub/Virtual-Computer/main/batch-cmd/sys.bat", @"C:\temp\sys.bat");
            }
            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + "C:/temp/sys.bat");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;
            Process = Process.Start(ProcessInfo);
            Process.WaitForExit();
            this.label24.Text = "Install VC x64...";
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/fusedevgithub/Virtual-Computer/raw/main/dev/Virtual%20Computer%20(VC%20for%20Intel).exe", desktop + "/Virtual-Computer-x64.exe");
            }
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/fusedevgithub/Virtual-Computer/main/batch-cmd/diskmaker.cmd", "C:/Program Files/qemu/diskmaker.cmd");
            }
            this.label24.Text = "Done!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.groupBox3.Visible = true;
            this.groupBox4.Visible = true;
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

