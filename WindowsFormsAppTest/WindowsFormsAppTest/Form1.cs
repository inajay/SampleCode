using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        private static readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(2, 2);
        CancellationTokenSource cancelSource = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private async void ClickMe_Click(object sender, EventArgs e)
        {
            cancelSource = new CancellationTokenSource();
            var dueTime = TimeSpan.FromSeconds(10);
            var interval = TimeSpan.FromSeconds(15);

            Debug.WriteLine($"{DateTime.Now.ToString() } Task started ");
            await PeriodicRunGetLogs(FetchDataAtGivenInterval, dueTime, interval, cancelSource.Token, "Ajay", "Tripathi");
        }

        private async Task PeriodicRunGetLogs(Action<string, string> FetchDataAction, TimeSpan dueTime, TimeSpan interval,
          CancellationToken token, string x, string y)
        {

            await Task.Delay(dueTime, token);
            await _semaphoreSlim.WaitAsync();
            while (!token.IsCancellationRequested)
            {
                FetchDataAction?.Invoke(x, y);
                await Task.Delay(interval, token);
            }
             _semaphoreSlim.Release();
        }

        private void FetchDataAtGivenInterval(string a, string b)
        {
            string z = a + b;
            Debug.WriteLine($"{DateTime.Now.ToString()} {z} ");

        }
    }
}
