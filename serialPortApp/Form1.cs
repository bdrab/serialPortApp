using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace serialPortApp
{
    public partial class Form1 : Form
    {

        public Thread trd;


        public Form1()
        {
            InitializeComponent();
            Load += new EventHandler(serialPORTS_Load);
            txtBOX.ReadOnly = true;
        }

        private void ThreadTask()
        {
            while (true)
            {
                txtBOX.AppendText(serialPORTS.SelectedItem.ToString());
                txtBOX.AppendText("\r\n");
                txtBOX.Select(txtBOX.TextLength + 1, 0);
                Thread.Sleep(1000);
            }
        }

        private void btnSTART_Click(object sender, EventArgs e)
        {
            if (trd == null) {
                if (serialPORTS.SelectedItem != null)
                {
                    trd = new Thread(new ThreadStart(this.ThreadTask));
                    trd.IsBackground = true;
                    trd.Start();
                    txtBOX.AppendText("\r\n");
                    txtBOX.AppendText(serialPORTS.SelectedItem.ToString());
                    MessageBox.Show("Communication started", "OK");
                }

                else {
                    MessageBox.Show("Please select PORT", "Error");
                }
            }
            else if (!trd.IsAlive) {
                trd = new Thread(new ThreadStart(this.ThreadTask));
                trd.IsBackground = true;
                trd.Start();
            }
        }

        private void btnSTOP_Click(object sender, EventArgs e)
        {
            trd.Abort();
            MessageBox.Show("Thread stopped!");
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


    }
}
