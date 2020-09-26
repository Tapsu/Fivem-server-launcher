using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellCity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
          System.Diagnostics.Process.Start($"fivem://connect/cfx.re/join/wx94pe");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var kkon = new System.Diagnostics.Process();
            kkon.StartInfo.FileName = "C:\\Program Files\\TeamSpeak 3 Client\\ts3client_win64.exe";
            kkon.StartInfo.Arguments = "ts3server://ts.hellcity.fi?password=perkele";
            kkon.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ohjeet f3 = new Ohjeet();
            this.Hide();
            f3.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tiedotteet f3 = new tiedotteet();
            this.Hide();
            f3.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/hellcityrp");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
            {
                this.MouseDown += new MouseEventHandler(AppFormBase_MouseDown);
                this.MouseMove += new MouseEventHandler(AppFormBase_MouseMove);
                this.MouseUp += new MouseEventHandler(AppFormBase_MouseUp);
            }
            base.OnLoad(e);
        }

        void AppFormBase_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }

        void AppFormBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
             this.Left + e.X - downPoint.X,
             this.Top + e.Y - downPoint.Y);
             this.Location = location;
        }

        void AppFormBase_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }

        public Point downPoint = Point.Empty;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }
}
