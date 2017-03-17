namespace MyCar_client
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.forward = new System.Windows.Forms.Button();
            this.backward = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.forward_timer = new System.Windows.Forms.Timer(this.components);
            this.disconnect = new System.Windows.Forms.Button();
            this.UDPConnectTimer = new System.Windows.Forms.Timer(this.components);
            this.turnleft = new System.Windows.Forms.Button();
            this.turnleft_timer = new System.Windows.Forms.Timer(this.components);
            this.turnright = new System.Windows.Forms.Button();
            this.turnright_timer = new System.Windows.Forms.Timer(this.components);
            this.backward_timer = new System.Windows.Forms.Timer(this.components);
            this.camera = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.camera_Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.white_Label = new System.Windows.Forms.Label();
            this.speed1 = new System.Windows.Forms.Button();
            this.speed2 = new System.Windows.Forms.Button();
            this.speed3 = new System.Windows.Forms.Button();
            this.ip_textBox1 = new System.Windows.Forms.TextBox();
            this.camera_top_button = new System.Windows.Forms.Button();
            this.camera_down_button = new System.Windows.Forms.Button();
            this.camera_left_button = new System.Windows.Forms.Button();
            this.camera_right_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(125, 456);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(111, 43);
            this.connect.TabIndex = 0;
            this.connect.Text = "连接";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 646);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "等待连接客户端";
            // 
            // forward
            // 
            this.forward.Enabled = false;
            this.forward.Location = new System.Drawing.Point(255, 58);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(111, 52);
            this.forward.TabIndex = 2;
            this.forward.Text = "前进";
            this.forward.UseVisualStyleBackColor = true;
            this.forward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forward_MouseDown);
            this.forward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forward_MouseUp);
            // 
            // backward
            // 
            this.backward.Enabled = false;
            this.backward.Location = new System.Drawing.Point(255, 315);
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(111, 49);
            this.backward.TabIndex = 3;
            this.backward.Text = "后退";
            this.backward.UseVisualStyleBackColor = true;
            this.backward.Click += new System.EventHandler(this.backward_Click);
            this.backward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backward_MouseDown);
            this.backward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.backward_MouseUp);
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(255, 185);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(111, 49);
            this.stop.TabIndex = 4;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // forward_timer
            // 
            this.forward_timer.Tick += new System.EventHandler(this.forward_timer_Tick);
            // 
            // disconnect
            // 
            this.disconnect.Enabled = false;
            this.disconnect.Location = new System.Drawing.Point(257, 456);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(106, 43);
            this.disconnect.TabIndex = 5;
            this.disconnect.Text = "断开";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // UDPConnectTimer
            // 
            this.UDPConnectTimer.Interval = 1000;
            this.UDPConnectTimer.Tick += new System.EventHandler(this.UDPConnectTimer_Tick);
            // 
            // turnleft
            // 
            this.turnleft.Enabled = false;
            this.turnleft.Location = new System.Drawing.Point(32, 185);
            this.turnleft.Name = "turnleft";
            this.turnleft.Size = new System.Drawing.Size(114, 49);
            this.turnleft.TabIndex = 6;
            this.turnleft.Text = "左转";
            this.turnleft.UseVisualStyleBackColor = true;
            this.turnleft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.turnleft_MouseDown);
            this.turnleft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.turnleft_MouseUp);
            // 
            // turnleft_timer
            // 
            this.turnleft_timer.Tick += new System.EventHandler(this.turnleft_timer_Tick);
            // 
            // turnright
            // 
            this.turnright.Enabled = false;
            this.turnright.Location = new System.Drawing.Point(472, 185);
            this.turnright.Name = "turnright";
            this.turnright.Size = new System.Drawing.Size(114, 49);
            this.turnright.TabIndex = 7;
            this.turnright.Text = "右转";
            this.turnright.UseVisualStyleBackColor = true;
            this.turnright.MouseDown += new System.Windows.Forms.MouseEventHandler(this.turnright_MouseDown);
            this.turnright.MouseUp += new System.Windows.Forms.MouseEventHandler(this.turnright_MouseUp);
            // 
            // turnright_timer
            // 
            this.turnright_timer.Tick += new System.EventHandler(this.turnright_timer_Tick);
            // 
            // backward_timer
            // 
            this.backward_timer.Tick += new System.EventHandler(this.backward_timer_Tick);
            // 
            // camera
            // 
            this.camera.Enabled = false;
            this.camera.Location = new System.Drawing.Point(396, 456);
            this.camera.Name = "camera";
            this.camera.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.camera.Size = new System.Drawing.Size(121, 43);
            this.camera.TabIndex = 9;
            this.camera.Text = "   摄像头";
            this.camera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.camera.UseVisualStyleBackColor = true;
            this.camera.Click += new System.EventHandler(this.camera_Click);
            this.camera.MouseEnter += new System.EventHandler(this.camera_MouseEnter);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(627, 45);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(590, 482);
            this.webBrowser1.TabIndex = 10;
            // 
            // camera_Label
            // 
            this.camera_Label.AutoSize = true;
            this.camera_Label.BackColor = System.Drawing.SystemColors.ControlLight;
            this.camera_Label.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.camera_Label.ForeColor = System.Drawing.Color.Red;
            this.camera_Label.Location = new System.Drawing.Point(467, 469);
            this.camera_Label.Name = "camera_Label";
            this.camera_Label.Size = new System.Drawing.Size(40, 16);
            this.camera_Label.TabIndex = 11;
            this.camera_Label.Text = "关闭";
            this.camera_Label.MouseEnter += new System.EventHandler(this.camera_Label_MouseEnter);
            this.camera_Label.MouseLeave += new System.EventHandler(this.camera_Label_MouseLeave);
            this.camera_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.camera_Label_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // white_Label
            // 
            this.white_Label.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.white_Label.Location = new System.Drawing.Point(627, 45);
            this.white_Label.Name = "white_Label";
            this.white_Label.Size = new System.Drawing.Size(590, 482);
            this.white_Label.TabIndex = 13;
            // 
            // speed1
            // 
            this.speed1.Location = new System.Drawing.Point(199, 542);
            this.speed1.Name = "speed1";
            this.speed1.Size = new System.Drawing.Size(37, 35);
            this.speed1.TabIndex = 14;
            this.speed1.Text = "1";
            this.speed1.UseVisualStyleBackColor = true;
            this.speed1.Click += new System.EventHandler(this.speed1_Click);
            // 
            // speed2
            // 
            this.speed2.Location = new System.Drawing.Point(262, 542);
            this.speed2.Name = "speed2";
            this.speed2.Size = new System.Drawing.Size(37, 35);
            this.speed2.TabIndex = 15;
            this.speed2.Text = "2";
            this.speed2.UseVisualStyleBackColor = true;
            this.speed2.Click += new System.EventHandler(this.speed2_Click);
            // 
            // speed3
            // 
            this.speed3.Location = new System.Drawing.Point(322, 542);
            this.speed3.Name = "speed3";
            this.speed3.Size = new System.Drawing.Size(37, 35);
            this.speed3.TabIndex = 16;
            this.speed3.Text = "3";
            this.speed3.UseVisualStyleBackColor = true;
            this.speed3.Click += new System.EventHandler(this.speed3_Click);
            // 
            // ip_textBox1
            // 
            this.ip_textBox1.Location = new System.Drawing.Point(419, 401);
            this.ip_textBox1.Name = "ip_textBox1";
            this.ip_textBox1.Size = new System.Drawing.Size(100, 21);
            this.ip_textBox1.TabIndex = 17;
            this.ip_textBox1.Text = "192.168.0.";
            // 
            // camera_top_button
            // 
            this.camera_top_button.Location = new System.Drawing.Point(272, 138);
            this.camera_top_button.Name = "camera_top_button";
            this.camera_top_button.Size = new System.Drawing.Size(75, 23);
            this.camera_top_button.TabIndex = 18;
            this.camera_top_button.Text = "CameraTop";
            this.camera_top_button.UseVisualStyleBackColor = true;
            // 
            // camera_down_button
            // 
            this.camera_down_button.Location = new System.Drawing.Point(272, 267);
            this.camera_down_button.Name = "camera_down_button";
            this.camera_down_button.Size = new System.Drawing.Size(75, 23);
            this.camera_down_button.TabIndex = 19;
            this.camera_down_button.Text = "CameraDown";
            this.camera_down_button.UseVisualStyleBackColor = true;
            // 
            // camera_left_button
            // 
            this.camera_left_button.Location = new System.Drawing.Point(164, 198);
            this.camera_left_button.Name = "camera_left_button";
            this.camera_left_button.Size = new System.Drawing.Size(80, 23);
            this.camera_left_button.TabIndex = 20;
            this.camera_left_button.Text = "Camera_Left";
            this.camera_left_button.UseVisualStyleBackColor = true;
            // 
            // camera_right_button
            // 
            this.camera_right_button.Location = new System.Drawing.Point(382, 198);
            this.camera_right_button.Name = "camera_right_button";
            this.camera_right_button.Size = new System.Drawing.Size(80, 23);
            this.camera_right_button.TabIndex = 21;
            this.camera_right_button.Text = "CameraRight";
            this.camera_right_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 671);
            this.Controls.Add(this.camera_right_button);
            this.Controls.Add(this.camera_left_button);
            this.Controls.Add(this.camera_down_button);
            this.Controls.Add(this.camera_top_button);
            this.Controls.Add(this.ip_textBox1);
            this.Controls.Add(this.speed3);
            this.Controls.Add(this.speed2);
            this.Controls.Add(this.speed1);
            this.Controls.Add(this.white_Label);
            this.Controls.Add(this.camera_Label);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.camera);
            this.Controls.Add(this.turnright);
            this.Controls.Add(this.turnleft);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.backward);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button backward;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer forward_timer;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Timer UDPConnectTimer;
        private System.Windows.Forms.Button turnleft;
        private System.Windows.Forms.Timer turnleft_timer;
        private System.Windows.Forms.Button turnright;
        private System.Windows.Forms.Timer turnright_timer;
        private System.Windows.Forms.Timer backward_timer;
        private System.Windows.Forms.Button camera;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label camera_Label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label white_Label;
        private System.Windows.Forms.Button speed1;
        private System.Windows.Forms.Button speed2;
        private System.Windows.Forms.Button speed3;
        private System.Windows.Forms.TextBox ip_textBox1;
        private System.Windows.Forms.Button camera_top_button;
        private System.Windows.Forms.Button camera_down_button;
        private System.Windows.Forms.Button camera_left_button;
        private System.Windows.Forms.Button camera_right_button;
    }
}

