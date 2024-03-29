using System;
using System.IO.Ports;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;


namespace serialPortApp
{
    public partial class serialPortApp : Form
    {

        public Thread trd;
        bool endThread = false;
        bool sendData = false;

        public serialPortApp()
        {
            InitializeComponent();
            Load += new EventHandler(serialPORTS_Load);
            txtBOX.ReadOnly = true;
        }

        private void ThreadTask()
        {
            while (true)
            {

                if (serialPort1.BytesToRead > 0)
                {
                    string message = serialPort1.ReadLine();
                    txtBOX.AppendText($"{DateTime.Now.ToString()}--->>>{message}");
                    txtBOX.AppendText("\r\n");
                    txtBOX.Select(txtBOX.TextLength + 1, 0);

                }
                else if (sendData) {
                    
                    string dataToSend = txtSENDDATA.Text;
                    serialPort1.Write(dataToSend);

                    txtBOX.AppendText($"{DateTime.Now.ToString()}<<<---{dataToSend}");
                    txtBOX.AppendText("\r\n");
                    txtBOX.Select(txtBOX.TextLength + 1, 0);

                    txtSENDDATA.Text = "";
                    sendData = false;
                }
                if (endThread) {
                    serialPort1.Close();
                    trd.Abort();
                }
            }
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {

            if (serialPORTS.SelectedItem != null && (trd == null || trd.IsAlive == false))
            {
                endThread = false;
                serialPort1.PortName = serialPORTS.SelectedItem.ToString();
                serialPort1.BaudRate = 9600;
                    
                serialPort1.Open();

                trd = new Thread(new ThreadStart(this.ThreadTask));
                trd.IsBackground = true;
                trd.Start();
                txtBOX.AppendText("***Communication started***");
                txtBOX.AppendText("\r\n");
            }

            else {
                MessageBox.Show("Please select PORT", "Error");
            }
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            endThread = true;
            txtBOX.AppendText("***Communication stopped***");
            txtBOX.AppendText("\r\n");
        }

        private void btnSEND_Click(object sender, EventArgs e)
        {
            sendData = true;
        }

        private void serialPORTS_Load(object sender, EventArgs e) 
        {
            string[] ports = SerialPort.GetPortNames();
            serialPORTS.Items.Clear();

            foreach (string port in ports)
            {
                serialPORTS.Items.Add(port);
            }
        }

        private void txtSENDDATA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSEND_Click(this, new EventArgs());
            }
        }
    }
}
