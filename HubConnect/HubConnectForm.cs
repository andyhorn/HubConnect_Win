using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HubConnect.Properties;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;


namespace HubConnect
{
    public partial class HubConnectForm : Form
    {
        private readonly List<BluetoothDeviceInfo> _devices;    // store a list of devices after scanning
        private readonly BluetoothClient _blueToothClient;      // this device as a bluetooth client
        private BluetoothAddress _targetAddress;                // when a device is selected, store its address
        public HubConnectForm()
        {
            _devices = new List<BluetoothDeviceInfo>();
            _blueToothClient = new BluetoothClient();
            InitializeComponent();
        }

        private void HubConnectForm_Load(object sender, EventArgs e)
        {

        }
        private void ScanButton_Click(object sender, EventArgs e)
        {
            AddMessage(Resources.ScanningText);
            ScanForDevices();
            AddMessage(Resources.FinishedScanningMessage);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // if a device has been selected, attempt to transmit data
            if (_targetAddress != null)
            {
                SendData();
            }
            else
            {
                // the user must scan for and select a device before sending any data
                MessageBox.Show(Resources.DeviceNotSelectedErrorMessage, "No device selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ScanForDevices()
        {
            DeviceSelectBox.Items.Clear();
            using (new WaitCursor())
            {
                BluetoothRadio.PrimaryRadio.Mode = RadioMode.Connectable;   // allow connections to this device

                var devices = _blueToothClient.DiscoverDevices();    // scan for available devices

                foreach(var device in devices)
                {
                    // add each device to the cache
                    _devices.Add(device);
                    // add the device names to the select box
                    DeviceSelectBox.Items.Add(device.DeviceName);
                }
            }
        }

        private void SendData()
        {
            // get the user data
            string  email = EmailTextBox.Text, 
                    network = NetworkTextBox.Text, 
                    password = PwdTextBox.Text;

            // check that all fields were filled
            if (email != null && network != null && password != null)
            {
                AddMessage(Resources.SendingMessage);
                ObexStatusCode code;    // we will receive a status code after sending data
                using (new WaitCursor())
                {
                    // build the data string
                    var builder = new StringBuilder();
                    builder.AppendLine($"SSID={network}");
                    builder.AppendLine($"PSK={password}");
                    builder.AppendLine($"EMAIL={email}");

                    // send the data to the Hub and wait for a status code
                    code = Obex.SendFile(_targetAddress, builder.ToString());
                }

                // display a success or error message to the user
                if ((code & ObexStatusCode.OK) != 0)
                {
                    AddMessage(Resources.SendSuccess);
                }
                else
                {
                    AddMessage(Resources.SendFail);
                }
            }
        }

        private void DeviceSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when a device is selected, update the target device address
            _targetAddress = _devices.FirstOrDefault(d => d.DeviceName.Equals(DeviceSelectBox.SelectedItem))?.DeviceAddress;
        }

        private void AddMessage(string message)
        {
            if (StatusTextBox.Lines.Length != 0)
                StatusTextBox.AppendText($"\r\n{message}");
            else
                StatusTextBox.Text = message;
        }
    }
}
