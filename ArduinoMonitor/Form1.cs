using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoMonitor
{
    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;

        private SerialPort port;
        private int baudRate;
        private String serialPortName;

        private String usedCpu;
        private String usedRam;

        public Form1()
        {
            InitializeComponent();
            InitializeCpuCounter();
            InitializeRamCounter();

            String[] portsList = SerialPort.GetPortNames();
            serialList.DataSource = portsList;
        }

        private void InitializeCpuCounter()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        }
  
        private void InitializeRamCounter()
        {
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // When Connect button is pressed...
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortName = serialList.SelectedItem.ToString();
                baudRate = Convert.ToInt32(textBaud.Text);

                port = new SerialPort(serialPortName);
                port.BaudRate = baudRate;
                port.Open();

                if (port.IsOpen)
                {
                    timer1.Enabled = true;
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                }
            } catch(NullReferenceException exc)
            {
                MessageBox.Show("Select a Serial Port!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            } catch(System.FormatException exc)
            {
                MessageBox.Show("Set a Baud Rate!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        // When Disconnect button is pressed...
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            // Close the serial port
            port.Close();
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
        }

        // Update Cpu and Ram usage
        private void timer1_Tick(object sender, EventArgs e)
        {
            //getComponent("Win32_Processor", "CurrentClockSpeed");

            // Send Cpu usage over the serial line
            //usedCpu = ((int)cpuCounter.NextValue()).ToString();
            //port.WriteLine(usedCpu);

            // Send Ram usage over the serial line
            usedRam = ((int)ramCounter.NextValue()).ToString();
            port.WriteLine(usedRam);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            String[] portsList = SerialPort.GetPortNames();
            serialList.DataSource = portsList;
        }

        static private void getComponent(String hwclass, String syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                Console.WriteLine(Convert.ToString(mj[syntax]));
            }
        }

    }
}
