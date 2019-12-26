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
using CodeSnippets.Classes;
using WinFormsExtensionsLibrary;

namespace CodeSnippets
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource = 
            new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
        }

        private async void ProcessAsync1Button_Click(object sender, EventArgs e)
        {

            if (_cancellationTokenSource.IsCancellationRequested)
            {
                ProcessStatus1Label.Text = "0";
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            var ops = new Examples();
            ops.OnIterate += OnIterateLoop1;

            try
            {
                var result = await ops.ProcessAsync1(1000, _cancellationTokenSource.Token);
                Console.WriteLine(result);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Cancelled");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Operation failed with\n{exception.Message}");
            }

        }

        /// <summary>
        /// Cancel operation in ProcessAsync1Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelExample1Button_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private async void ProcessAsync2Button_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            var ops = new Examples();
            ops.OnIterate += Ops_OnIterate2;

            try
            {
                var result = await ops.ProcessAsync2(1000, _cancellationTokenSource.Token);
                Console.WriteLine(result);
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Cancelled");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Operation failed with\n{exception.Message}");
            }

        }
       
        /// <summary>
        /// Cancel operation in ProcessAsync2Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelExample2Button_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        /// <summary>
        /// Show progress on code executed in ProcessAsync1Button. Since in this
        /// example we are not using ConfigureAwait(false) this code executes
        /// in the same thread so not cross 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnIterateLoop1(object sender, ProcessIndexingArgs args)
        {
            ProcessStatus1Label.Text = args.ToString();
        }
        /// <summary>
        /// In this case this event, unlike the event above is called from
        /// a different thread, without InvokeIfRequired in WinFormsExtensionLibrary
        /// a exception would be thrown "cross thread operation not valid".
        ///
        /// InvokeIfRequired language extension is basic code to check if Invoke
        /// needs to be called and if so uses Invoke and if not simple executes
        /// the action, in this case setting Text property of a label.
        ///
        /// In DataGridViewLoadDelimitedFileAsynchronous.Form1 Example1Button_Click
        /// several lines of code are executes as an Action for InvokeIfRequired.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Ops_OnIterate2(object sender, ProcessIndexingArgs args)
        {
            ProcessStatus2Label.Text = args.ToString();
            ProcessStatus2Label.InvokeIfRequired(d => { ProcessStatus2Label.Text = args.ToString(); });
        }
    }
}
