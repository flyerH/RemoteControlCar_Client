using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCar_client
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "http://sighttp.qq.com/authd?IDKEY=f512829e9704ab7e48fa8c73a9e48fc9e40c669d49c356c4";
            System.Diagnostics.Process.Start(url);
        }       
    }
}
