using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace threads
{
    public partial class Form1 : Form
    {
        Mutex mutex = new Mutex();
        DateTime time = new DateTime();
        int hours, min, sec;
        void hour()
        {
            mutex.WaitOne();
            time = DateTime.Now;
            hours = time.Hour;
            mutex.ReleaseMutex();
        }
        void minutes()
        {
            mutex.WaitOne();
            time = DateTime.Now;
            min = time.Minute;
            mutex.ReleaseMutex();
        }
        void seconds()
        {
            mutex.WaitOne();
            time = DateTime.Now;
            sec = time.Second;
            mutex.ReleaseMutex();
        }
        void stream()
        {
            Thread threadh = new Thread(hour);
            Thread threadm = new Thread(minutes);
            Thread threads = new Thread(seconds);
            threadh.Start();
            threadm.Start();
            threads.Start();
        }
        void update()
        {
            if (sec < 10)
            {
                labelsec.Text = "0" + sec.ToString();
            }
            else
            {
                labelsec.Text = sec.ToString();
            }

            if (min < 10)
            {
                labelMin.Text = "0" + min.ToString();
            }
            else
            {
                labelMin.Text = min.ToString();
            }
            if (min < 10)
            {
                labelhour.Text = "0" + hours.ToString();
            }
            else
            {
                labelhour.Text = hours.ToString();
            }
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Labelsec_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            stream();
            update();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button2.Enabled = false;
        }

        private void Labeldots_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
