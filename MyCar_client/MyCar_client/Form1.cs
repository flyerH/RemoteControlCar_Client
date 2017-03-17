using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyCar_client
{
    public partial class Form1 : Form
    {
        int Reconnections;
        int UDPTimeOut = 5;
        int IsTimeOut;
        UdpClient UDPsend;
        UdpClient udpcRecv;
        TcpClient tcpClient;      
        IPAddress srvAddr;
        NetworkStream stream;
        IPEndPoint endpoint;
        IPEndPoint endpoint2;
        Thread UDPThread;
        bool UDPRecvIsTrue;
        public delegate void buttonEnabled();
        public delegate void buttonDisabled();
        public Form1()
        {
            InitializeComponent();
            buttonfalse();
        }

        public void buttontrue()
        {
            forward.Enabled = true;
            stop.Enabled = true;
            backward.Enabled = true;
            turnleft.Enabled = true;
            turnright.Enabled = true;
            disconnect.Enabled = true;
            camera.Enabled = true;
            camera_left_button.Enabled = true;
            camera_right_button.Enabled = true;
            camera_top_button.Enabled = true;
            camera_down_button.Enabled = true;
            connect.Enabled = false;            
            camera_Label.BackColor = SystemColors.ControlLight;
        }

        public void buttonfalse()
        {
            forward.Enabled = false;
            stop.Enabled = false;
            backward.Enabled = false;
            turnleft.Enabled = false;
            turnright.Enabled = false;
            disconnect.Enabled = false;
            camera.Enabled = false;
            camera_left_button.Enabled = false;
            camera_right_button.Enabled = false;
            camera_top_button.Enabled = false;
            camera_down_button.Enabled = false;
            connect.Enabled = true;           
            camera_Label.BackColor = SystemColors.ScrollBar;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            Reconnections = 1;
            //canstop = false;
            label1.Text = "等待连接客户端";
            UDPThread = new Thread(new ThreadStart(UDPConnect));
            // UDPConnectTimer.Interval = 1000;
            IsTimeOut = UDPTimeOut - 1;
            label1.Text = "正在连接小车 超时：" + (UDPTimeOut) + "秒";
            UDPConnectTimer.Start();

            UDPThread.Start();
        }
        public void sendCommand(int Command)
        {
            byte[] buff = new byte[4];
            buff[0] = (byte)((Command >> 24) & 0xff);
            buff[1] = (byte)((Command >> 16) & 0xff);
            buff[2] = (byte)((Command >> 8) & 0xff);
            buff[3] = (byte)((Command) & 0xff);

            stream.Write(buff, 0, buff.Length);
        }

        private void backward_Click(object sender, EventArgs e)
        {
            sendCommand(2);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            sendCommand(0);
        }


        private void forward_timer_Tick(object sender, EventArgs e)
        {
            sendCommand(1);
        }

        private void forward_MouseDown(object sender, MouseEventArgs e)
        {
            this.forward_timer.Interval = 100;
            this.forward_timer.Enabled = true;
        }

        private void forward_MouseUp(object sender, MouseEventArgs e)
        {
            this.forward_timer.Enabled = false;
            sendCommand(0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && connect.Enabled == false)
            {
                this.forward_timer.Interval = 100;
                this.forward_timer.Enabled = true;
            }
            if (e.KeyCode == Keys.S && connect.Enabled == false)
            {
                this.backward_timer.Interval = 100;
                this.backward_timer.Enabled = true;
            }
            if (e.KeyCode == Keys.A && connect.Enabled == false)
            {
                this.turnleft_timer.Interval = 100;
                this.turnleft_timer.Enabled = true;
            }
            if (e.KeyCode == Keys.D && connect.Enabled == false)
            {
                this.turnright_timer.Interval = 100;
                this.turnright_timer.Enabled = true;
            }

            if (e.KeyCode == Keys.Up && connect.Enabled == false)
            {
                this.forward_timer.Interval = 100;
                this.forward_timer.Enabled = true;
            }
            if (e.KeyCode == Keys.Down && connect.Enabled == false)
            {
                this.backward_timer.Interval = 100;
                this.backward_timer.Enabled = true;
            }
            if (e.KeyCode == Keys.Left && connect.Enabled == false)
            {
                this.turnleft_timer.Interval = 100;
                this.turnleft_timer.Enabled = true;
            }
            if (e.KeyCode == Keys.Right && connect.Enabled == false)
            {
                this.turnright_timer.Interval = 100;
                this.turnright_timer.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W && connect.Enabled == false)
            {
                this.forward_timer.Enabled = false;
                sendCommand(0);
            }
            if (e.KeyCode == Keys.S && connect.Enabled == false)
            {
                this.backward_timer.Enabled = false;
                sendCommand(0);
            }
            if (e.KeyCode == Keys.A && connect.Enabled == false)
            {
                this.turnleft_timer.Enabled = false;
                sendCommand(0);
            }
            if (e.KeyCode == Keys.D && connect.Enabled == false)
            {
                this.turnright_timer.Enabled = false;
                sendCommand(0);
            }

            if (e.KeyCode == Keys.Up && connect.Enabled == false)
            {
                this.forward_timer.Enabled = false;
                sendCommand(0);
            }
            if (e.KeyCode == Keys.Down && connect.Enabled == false)
            {
                this.backward_timer.Enabled = false;
                sendCommand(0);
            }
            if (e.KeyCode == Keys.Left && connect.Enabled == false)
            {
                this.turnleft_timer.Enabled = false;
                sendCommand(0);
            }
            if (e.KeyCode == Keys.Right && connect.Enabled == false)
            {
                this.turnright_timer.Enabled = false;
                sendCommand(0);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected)
            {
                sendCommand(-1);
                tcpClient.Close();
            }
            UDPThread.Abort();
            buttonDisabled bD = new buttonDisabled(buttonfalse);
            this.BeginInvoke(bD);
            label1.Text = "等待连接客户端";
        }
        public void UDPConnect()
        {
            //  while (canstop == false)
            UDPRecvIsTrue = false;

            {
                lock (this)
                {

                    int port = 8866;
                    byte[] ip = new byte[4];
                    ip[0] = (byte)((port >> 24) & 0xff);
                    ip[1] = (byte)((port >> 16) & 0xff);
                    ip[2] = (byte)((port >> 8) & 0xff);
                    ip[3] = (byte)(port & 0xff);
                    
                    do
                    {
                        Console.WriteLine("UDP广播第{0}次", Reconnections);
                        Reconnections++;
                        Console.WriteLine(ip_textBox1.Text);
                        IPAddress a = IPAddress.Parse(ip_textBox1.Text);                                                
                
                        UDPsend = new UdpClient(new IPEndPoint(IPAddress.Any, 6666));
                        if (ip_textBox1 != null)
                           endpoint = new IPEndPoint(a, 8002);
                        else
                            endpoint = new IPEndPoint(IPAddress.Broadcast, 8002);

                        UDPsend.Send(ip, 4, endpoint);
                        UDPsend.Close();
                        udpcRecv = new UdpClient(8866);

                        udpcRecv.Client.ReceiveTimeout = 100;
                        endpoint2 = new IPEndPoint(IPAddress.Any, 0);
                        try
                        {
                            byte[] data = udpcRecv.Receive(ref endpoint2);
                            UDPRecvIsTrue = true;

                        }
                        catch (SocketException ex)
                        {
                            if (ex != null)
                            {
                                udpcRecv.Close();
                                //UDPConnect();
                            }
                        }
                    } while (UDPRecvIsTrue == false);

                    udpcRecv.Close();

                    //下面是小车遥控，先建立连接

                    //   if (endpoint2.Address.ToString() != "0.0.0.0")
                    {
                        srvAddr = IPAddress.Parse(endpoint2.Address.ToString());
                        Console.WriteLine(srvAddr);
                        tcpClient = new TcpClient();
                        int nPort = endpoint2.Port;  //小车端口           
                        try
                        {
                            tcpClient.Connect(srvAddr, 8000);
                            Console.WriteLine("连接成功？？？");
                            stream = tcpClient.GetStream();
                            //out = tcpClient.getOutputStream();
                            buttonEnabled bE = new buttonEnabled(buttontrue);
                            this.BeginInvoke(bE);
                            UDPConnectTimer.Enabled = false;
                        }
                        catch (SocketException ex)
                        {
                            tcpClient.Close();
                            Console.WriteLine("TCP连接异常关闭" + ex);
                            return;
                        }
                    }

                }
            }
        }

        private void UDPConnectTimer_Tick(object sender, EventArgs e)
        {

            label1.Text = "正在连接小车 超时：" + IsTimeOut.ToString() + "秒";
            IsTimeOut--;
            if (IsTimeOut == -1)
            {
                label1.Text = "等待连接客户端";
                UDPsend.Close();
                udpcRecv.Close();
                UDPThread.Abort();
                UDPConnectTimer.Enabled = false;
                Console.WriteLine("连接超时结束！");
            }

        }

        private void turnleft_MouseDown(object sender, MouseEventArgs e)
        {
            this.turnleft_timer.Interval = 100;
            this.turnleft_timer.Enabled = true;
        }

        private void turnleft_timer_Tick(object sender, EventArgs e)
        {
            sendCommand(3);
        }

        private void turnleft_MouseUp(object sender, MouseEventArgs e)
        {
            this.turnleft_timer.Enabled = false;
            sendCommand(0);
        }

        private void turnright_MouseDown(object sender, MouseEventArgs e)
        {
            this.turnright_timer.Interval = 100;
            this.turnright_timer.Enabled = true;
        }

        private void turnright_timer_Tick(object sender, EventArgs e)
        {
            sendCommand(4);
        }

        private void turnright_MouseUp(object sender, MouseEventArgs e)
        {
            this.turnright_timer.Enabled = false;
            sendCommand(0);
        }


        private void backward_MouseDown(object sender, MouseEventArgs e)
        {
            this.backward_timer.Interval = 100;
            this.backward_timer.Enabled = true;
        }

        private void backward_timer_Tick(object sender, EventArgs e)
        {
            sendCommand(2);
        }

        private void backward_MouseUp(object sender, MouseEventArgs e)
        {
            this.backward_timer.Enabled = false;
            sendCommand(0);
        }

        private void camera_Click(object sender, EventArgs e)
        {
            sendCommand(6);
            String url = String.Format("http://{0}:18000/javascript_simple.html", srvAddr);
            Console.WriteLine("URL:{0}", url);
            webBrowser1.Url = new Uri(url);
            if (camera_Label.Text == "关闭")
            {
                camera_Label.Text = "开启";
                Thread.Sleep(800);
                white_Label.Visible = false;
            }
            else
            {
                camera_Label.Text = "关闭";
                white_Label.Visible = true;
            }

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new about();
            about.ShowDialog();
        }

        private void speed1_Click(object sender, EventArgs e)
        {
            sendCommand(11);
            byte[] messages = Encoding.Default.GetBytes("1");
            stream.Write(messages, 0, messages.Length);
        }

        private void camera_Label_MouseUp(object sender, MouseEventArgs e)
        {
            camera_Click(null,null);
        }

        private void speed3_Click(object sender, EventArgs e)
        {

        }

        private void speed2_Click(object sender, EventArgs e)
        {

        }

        private void camera_Label_MouseEnter(object sender, EventArgs e)
        {
            if (white_Label.Visible == false)
            {
                camera_Label.BackColor = Color.FromArgb(255, 226, 242, 255);
                camera.BackColor = Color.FromArgb(255, 226, 242, 255);
            }
        }

        private void camera_Label_MouseLeave(object sender, EventArgs e)
        {
            if (white_Label.Visible == false)
            {
                camera_Label.BackColor = Color.FromArgb(255, 225, 225, 225);
            }
        }

        private void camera_MouseEnter(object sender, EventArgs e)
        {
            if (white_Label.Visible == false)
            {
                camera_Label.BackColor = Color.FromArgb(255, 226, 242, 255);
            }
        }

        private void camera_MouseLeave(object sender, EventArgs e)
        {
            if (white_Label.Visible == false)
            { 
            camera_Label.BackColor = Color.FromArgb(255, 225, 225, 225);
            camera.BackColor = Color.FromArgb(255, 225, 225, 225);
            }
        }
    }
}

