using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace CPUTempMonitorSerial
{
    public partial class HardwareMonitor : Form
    {
        // Creates a new computer that can get hardware diagnostic info
        Computer thisComputer;
        // Creates a serial connection so information can be sent to the arduino
        SerialPort arduinoSerial;
        public HardwareMonitor()
        {
            InitializeComponent();
            // sets thisComputer to a computer with CPU GPU and RAM enabled allowing access to the diagnostics form that hardware
            thisComputer = new Computer { CPUEnabled = true, GPUEnabled = true, RAMEnabled = true };
            // Starts thisComputer
            thisComputer.Open();
            //sets arduinoSerial to a new serial port
            arduinoSerial = new SerialPort();
            //sets the port name to COMx
            arduinoSerial.PortName = "COM3";
            //starts the serial port
            arduinoSerial.Open();

        }
        /**
        *checks to see if the CPU Temperature radio button is slected 
        *if it is selected it enables on the cpuTempTimer 
        *when it isn't selected turns the timer off
        **/
        private void cpuTempButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cpuTempButton.Checked == true)
                cpuTempTimer.Enabled = true;

            if (cpuTempButton.Checked == false)
                cpuTempTimer.Enabled = false;

        }
        /**
       *checks to see if the CPU Load radio button is slected 
       *if it is selected it enables on the cpuLoadTimer
       *when it isn't selected turns the timer off
       **/
        private void cpuLoadButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cpuLoadButton.Checked == true)
                cpuLoadTimer.Enabled = true;

            if (cpuLoadButton.Checked == false)
                cpuLoadTimer.Enabled = false;
        }
        /**
       *checks to see if the GPU Temperature radio button is slected 
       *if it is selected it enables on the gpuTempTimer 
       *when it isn't selected turns the timer off
       **/
        private void gpuTempButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gpuTempButton.Checked == true)
                gpuTempTimer.Enabled = true;

            if (gpuTempButton.Checked == false)
                gpuTempTimer.Enabled = false;
        }
        /**
       *checks to see if the GPU Load radio button is slected 
       *if it is selected it enables on the gpuLoadTimer 
       *when it isn't selected turns the timer off
       **/
        private void gpuLoadButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gpuLoadButton.Checked == true)
                gpuLoadTimer.Enabled = true;

            if (gpuLoadButton.Checked == false)
                gpuLoadTimer.Enabled = false;
        }
        /**
       *checks to see if the RAM Load radio button is slected 
       *if it is selected it enables on the ramLoadTimer 
       *when it isn't selected turns the timer off
       **/
        private void ramLoadButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ramLoadButton.Checked == true)
                ramLoadTimer.Enabled = true;

            if (ramLoadButton.Checked == false)
                ramLoadTimer.Enabled = false;
        }
        /**
        *creates a string outputText that will hold a string of information that will be printed in the GUI and on the arduino
        *checks each typer of hardware item
        *if it is the CPU type then it updates the hardwareItem
        *then it check each sensor in the hardawareItem 
        *if the sensor was temperature then it creates the string based on what the sensor is reading
        *sends outputText to the arduino over serial and sets outputText to the text box output
        **/
        private void cpuTempTimer_Tick(object sender, EventArgs e)
        {
            string outputText = "";


            foreach (var hardwareItem in thisComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            int sensorValue = (int)sensor.Value;
                            outputText = String.Format("{0} Temperature: {1}", "CPU", sensor.Value.HasValue ? sensorValue.ToString() + "^C" : "no value");
                        }
                    }
                }
            }
            arduinoSerial.Write(outputText);
            outputBox.Text = outputText;

        }
        /**
       *creates a string outputText that will hold a string of information that will be printed in the GUI and on the arduino
       *checks each typer of hardware item
       *if it is the CPU type then it updates the hardwareItem
       *then it check each sensor in the hardawareItem 
       *if the sensor was Load then it creates the string based on what the sensor is reading
       *sends outputText to the arduino over serial and sets outputText to the text box output
       **/
        private void cpuLoadTimer_Tick(object sender, EventArgs e)
        {
            string outputText = "";

            foreach (var hardwareItem in thisComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            int sensorValue = (int)sensor.Value;
                            outputText = String.Format("{0} Load: {1}", "CPU" , sensor.Value.HasValue ? sensorValue.ToString() + "%" : "no value");
                            

                            

                        }
                    }
                }
            }
            arduinoSerial.Write(outputText);
            outputBox.Text = outputText;
            

        }
        /**
       *creates a string outputText that will hold a string of information that will be printed in the GUI and on the arduino
       *checks each typer of hardware item
       *if it is the GPU either nvidia or amd type then it updates the hardwareItem
       *then it check each sensor in the hardawareItem 
       *if the sensor was temperature then it creates the string based on what the sensor is reading
       *sends outputText to the arduino over serial and sets outputText to the text box output
       **/
        private void gpuTempTimer_Tick(object sender, EventArgs e)
        {
            string outputText = "";

            foreach (var hardwareItem in thisComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia || hardwareItem.HardwareType == HardwareType.GpuAti)
                {
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            int sensorValue = (int)sensor.Value;
                            outputText = String.Format("{0} Temperature: {1}", "GPU", sensor.Value.HasValue ? sensorValue.ToString() + "^C" : "no value");

                        }
                    }
                }
            }
            arduinoSerial.Write(outputText);
            outputBox.Text = outputText;
        }
        /**
       *creates a string outputText that will hold a string of information that will be printed in the GUI and on the arduino
       *checks each typer of hardware item
       *if it is the GPU type either nvidia or amd then it updates the hardwareItem
       *then it check each sensor in the hardawareItem 
       *if the sensor was Load then it creates the string based on what the sensor is reading
       *sends outputText to the arduino over serial and sets outputText to the text box output
       **/
        private void gpuLoadTimer_Tick(object sender, EventArgs e)
        {
            string outputText = "";

            foreach (var hardwareItem in thisComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia || hardwareItem.HardwareType == HardwareType.GpuAti)
                {
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            int sensorValue = (int)sensor.Value;
                            outputText = String.Format("{0} Load: {1}", "GPU", sensor.Value.HasValue ? sensorValue.ToString() + "%" : "no value");

                        }
                    }
                }
            }
            arduinoSerial.Write(outputText);
            outputBox.Text = outputText;
        }
        /**
       *creates a string outputText that will hold a string of information that will be printed in the GUI and on the arduino
       *checks each typer of hardware item
       *if it is the RAM type then it updates the hardwareItem
       *then it check each sensor in the hardawareItem 
       *if the sensor was Load then it creates the string based on what the sensor is reading
       *sends outputText to the arduino over serial and sets outputText to the text box output
       **/
        private void ramLoadTimer_Tick(object sender, EventArgs e)
        {
            string outputText = "";

            foreach (var hardwareItem in thisComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.RAM)
                {
                    hardwareItem.Update();
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            int sensorValue = (int)sensor.Value;
                            outputText = String.Format("{0} Load: {1}", "RAM", sensor.Value.HasValue ? sensorValue.ToString() + "%" : "no value");
                        }
                    }
                }
            }
            arduinoSerial.Write(outputText);
            outputBox.Text = outputText;
        }
    }
}
