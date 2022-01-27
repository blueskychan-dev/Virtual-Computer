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

namespace Virtual_Computer__VC_for_Intel_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ProcessStartInfo ProcessInfo;
                Process Process;

                ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + "title VC For Intel x64 LOG && echo CPU Model: " + textBox4.Text + " && echo Accelerators: " + comboBox3.Text + " && qemu-system-x86_64 -machine q35 -accel " + comboBox3.Text + " -cdrom " + textBox1.Text + " -m " + textBox2.Text + " -smp " + textBox3.Text + " -cpu " + textBox4.Text + " " + textBox5.Text + " -hda " + textBox6.Text + " -vga " + comboBox1.Text + " -soundhw " + comboBox2.Text + " && timeout 3 && exit");
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = true;

                Process = Process.Start(ProcessInfo);
            }
            else
            { 
                ProcessStartInfo ProcessInfo;
                Process Process;

                ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + "title VC For Intel x64 LOG && echo Accelerators: " + comboBox3.Text + " && qemu-system-x86_64 -machine q35 -accel " + comboBox3.Text + " -cdrom " + textBox1.Text + " -m " + textBox2.Text + " -smp " + textBox3.Text + " -hda " + textBox6.Text + " -vga " + comboBox1.Text + " -soundhw " + comboBox2.Text + " && timeout 3 && exit");
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = true;

                Process = Process.Start(ProcessInfo);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                this.textBox1.Text = FD.FileName;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

                this.textBox6.Text = FD.FileName;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + "diskmaker.cmd && exit");
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = true;

            Process = Process.Start(ProcessInfo);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
