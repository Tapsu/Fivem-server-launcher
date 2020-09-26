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
    public partial class tiedotteet : Form
    {
        public tiedotteet()
        {
            InitializeComponent();
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!webBrowser1.Url.Equals("about:blank"))
            {
                webBrowser1.Refresh();
            }
        }
    }
}
