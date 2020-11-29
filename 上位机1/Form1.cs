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

namespace 上位机1
{
    public partial class Form1 : Form
    {
        //private SerialPort com = new SerialPort();
       // System.IO.Ports.SerialDataReceivedEventHandler(com.DataReceived);
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            duankou1.SelectedItem = "COM9";
            byterate.SelectedItem = "9600";
            shujuwei.SelectedItem = "8";
            jiaoyanwei.SelectedItem = "无校验";
            tingzhiwei.SelectedItem = "1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            com.PortName= duankou1.Text;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            com.BaudRate = int.Parse(byterate.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            com.DataBits = int.Parse(shujuwei.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jiaoyanwei.Text == "无校验")
            {
                com.Parity = System.IO.Ports.Parity.None;
            }
            else if (jiaoyanwei.Text == "奇校验")
            {
                com.Parity = System.IO.Ports.Parity.Odd;
            }
            else if (jiaoyanwei.Text == "偶校验")
            {
                com.Parity = System.IO.Ports.Parity.Even;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tingzhiwei.Text == "1")
                com.StopBits = StopBits.One;
            else if (tingzhiwei.Text == "1.5")
                com.StopBits = StopBits.OnePointFive;
            else if (tingzhiwei.Text == "2")
                com.StopBits = StopBits.Two;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(com.IsOpen == false)
            {
                com.Open();
                output_test.AppendText("端口号:" + com.PortName);
                output_test.AppendText("打开成功！\r\n");
                button2.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                com.Close();
                output_test.AppendText("\r\n关闭成功!\r\n");
                button2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //(object sender,SerialDataReceivedEventArgs e)*/
        private void SerialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                output_test.AppendText("Hex");

            }
            else if(radioButton2.Checked==true)
            { 

                output_test.Invoke(new EventHandler(delegate
                {
                    //output_test.AppendText("ASCII");
                    if(show_time.Checked ==true)
                    {
                        get_time();
                    }
                    string data_string = com.ReadExisting();
                    
          
                        output_test.AppendText(data_string);
            
                    if (auto_change_line.Checked == true)
                    {
                        output_test.AppendText("\r\n");
                    }

                }));
                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            send_area.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output_test.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void get_time()
        {
            DateTime now = DateTime.Now;
            
            string output = "[" + DateTime.Now.ToString("HH:mm:ss") + "."+now.Millisecond.ToString() + "]";
            output_test.AppendText(output);
            
        }

        private void show_time_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                com.Write(send_area.Text+"\r\n");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
