using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait.UI.Demo
{
    public partial class MainForm : Form
    {
        public int NumClicks { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
        }

        // Wrap this long-running process in a Task so that we can call it asynchronously
        private static Task<string> UpdateUIAsync(int counter)
        {
            return Task.Run(async () =>
                {
                    await Task.Delay(1000);
                    counter++;
                    return string.Format("Async #{0}", counter);
                });
        }

        // Allow this event handler to await on the asynchronous UpdateUIAsync() method
        private async void btnClickMe_Click(object sender, EventArgs e)
        {
            btnClickMe.Enabled = false;

            lblFeedbackAsync.Text = @"Begin async!";
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (var i = 0; i < 9; i++)
            {
                lblFeedback.Text = await UpdateUIAsync(i);
            }

            stopwatch.Stop();
            var seconds = stopwatch.Elapsed.Seconds;
            lblFeedbackAsync.Text = string.Format(@"Done async! Took {0} {1}", seconds, seconds == 1 ? "second" : "seconds");

            btnClickMe.Enabled = true;
        }

        // This method synchronously updates the UI
        private void btnMessage_Click(object sender, EventArgs e)
        {
            NumClicks++;
            lblMessage.Text = string.Format("Clicked {0} {1}", NumClicks, NumClicks == 1 ? "time" : "times");
        }
    }
}
