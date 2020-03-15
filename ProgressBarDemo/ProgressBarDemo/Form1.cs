using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarDemo
{
    public partial class Form1 : Form
    {
        public delegate void StartProgressHandler();
        public delegate void ProcessTask(int ass);
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            UpdateProgress.Maximum = 100;
            StartProgressHandler del = new StartProgressHandler(StartProgress);
            var del1 = new StartProgressHandler(StartProgress);
            //sdel1.Invoke();
            del.BeginInvoke(null, null);
            
        }
        public void StartProgress()
        {
            for (int i = 0; i <= 100; i++)
            {
                ProgressUpdate(i);
            }
        }

        public void ProgressUpdate(int i)
        {
            
            if(UpdateLabel.InvokeRequired)
            {
                Thread.Sleep(100);
                var del = new ProcessTask(ProgressUpdate);
                this.BeginInvoke(del, new object[] { i} );
            }
            else
            {
                Thread.Sleep(100);
                UpdateLabel.Text = i.ToString();
                UpdateProgress.Value = i;
                this.Refresh();
            }
        }
    }
}
