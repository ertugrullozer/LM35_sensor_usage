using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LM35_sensor_usage
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
     
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort = new SerialPort("COM4",9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            serialPort.Open();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            string data1 = serialPort.ReadLine();

            this.Invoke(new MethodInvoker(delegate
            {
             
               
                string take1 = data.Substring(0,2);
                string take2 = data1.Substring(2,3);

         
                int value1 = Convert.ToInt32(take1);
  
                bunifuCircleProgress1.Value = value1;
                bunifuCircleProgress1.SubScriptText = take2;
             
               
                
             
            
                
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
