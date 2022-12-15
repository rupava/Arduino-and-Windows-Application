using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ports
{
    public partial class Ports : Form
    {
        public Ports()
        {
            InitializeComponent();
        }

        private void scanBT_Click(object sender, EventArgs e)
        {
            comportCB.Text = "";
            comportCB.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            comportCB.Items.AddRange(ports);
        }

        private void connectBT_Click(object sender, EventArgs e)
        {
            if(ConnectPort() == true)
            {
                connectBT.Enabled = false;
                disconnectBT.Enabled = true;
                comportCB.Enabled = false;
                baudrateCB.Enabled = false;
                scanBT.Enabled = false;
                sendBT.Enabled  = true;
            }
        }

        public bool ConnectPort()
        {
            try {
                if(comportCB.Text != "" || baudrateCB.Text != "")
                {
                    serialPort1.PortName = comportCB.Text;
                    serialPort1.BaudRate = Int32.Parse(baudrateCB.Text);
                    serialPort1.Open();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
            return false;
        }

        private void disconnectBT_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            connectBT.Enabled = true;
            disconnectBT.Enabled = false;
            comportCB.Enabled = true;
            baudrateCB.Enabled = true;
            scanBT.Enabled = true;
            sendBT.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(serialPort1_DataReceived));
        }

        private void serialPort1_DataReceived(object sender, EventArgs e)
        {
            string dump = serialPort1.ReadLine();
            incomingTB.Text = incomingTB.Text + dump;
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            incomingTB.Text = "";
        }

        private void sendBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(serialPort1.IsOpen)) { serialPort1.Open(); }
                serialPort1.Write(outgoingTB.Text);
                outgoingTB.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
