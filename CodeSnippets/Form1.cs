using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        /// <summary>
        /// Basic async pattern with cancellation option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Run a long running task composed of small awaited and configured tasks
        /// Using ConfigureAwait(false) makes this particular method run a bit faster
        /// then the example above.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            /*
             * It's unsafe to call a control directly from a thread that didn't create it which happens
             * in this case setting ProcessStatus2Label.Text directly, instead the extension method
             * InvokeIfRequired ensuring thread-safe call is made to ProcessStatus2Label.
             *
             * InvokeIfRequired extension method is used in other code samples in this Visual Studio solution.
             * By using InvokeIfRequired creates uniformity when an Action is required in the calling thread.
             *
             */
            if (EnableCrossThreadButton.Checked)
            {
                ProcessStatus2Label.Text = args.ToString();
            }
            else
            {
                ProcessStatus2Label.InvokeIfRequired(d => { ProcessStatus2Label.Text = args.ToString(); });
            }            
            
        }
        /// <summary>
        /// Wrap synchronous operation in a task.
        ///
        /// Before running this code, change the path to an existing folder which has a decent amount
        /// of child folders followed by changing fileExtension variable pattern to files that can
        /// be found in the folder assigned in the variable rooFolder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void IterateFolderButton_Click(object sender, EventArgs e)
        {
            var rootFolder = "C:\\Dotnet_Development\\VS2017\\TechNet";
            var fileExtension = "*.cs";

            if (!Directory.Exists(rootFolder))
            {
                MessageBox.Show("Folder does not exists, please read comments in this method");
                return;
            }

            if (!Directory.Exists(rootFolder)) return;

            var result = await Task.Run(() => DirectoryLibrary.GetFileList(fileExtension, rootFolder));

            foreach (FileInfo item in result)
            {
                Console.WriteLine($"{item.DirectoryName}\\{item.Name}");
            }

        }

        public static async Task SomeDummyTaskExample(int index)
        {
            Console.WriteLine("Thread {0} - Start {1}", Thread.CurrentThread.ManagedThreadId, index);

            await Task.Delay(1000);

            Console.WriteLine("Thread {0} - End {1}", Thread.CurrentThread.ManagedThreadId, index);
        }


        /// <summary>
        /// Simple Example for Task.WaitAll which updates a TextBox
        /// via IProgress
        ///
        /// One task does real work while the other does no real work.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void WaitAll_Click(object sender, EventArgs e)
        {

            var fileName1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Names1.txt");

            if (!File.Exists(fileName1))
            {
                MessageBox.Show("Failed to find file, please ensure the file exists.");
                return;
            }

            var personArgs1 = new PersonArguments()
            {
                FileName = fileName1,
                FirstName = "Rebecca",
                LastName = "Clark"
            };

            var progress = new Progress<string>(value => textBox1.AppendText($"{value}{Environment.NewLine}") );
            var operations = new ShortSamples();
            await Task.Run(() => operations.Example1Async(personArgs1, progress));
        }
        /// <summary>
        /// User interface will not be responsive on the average machince
        /// The bottleneck is opening Excel for the first time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExcelSynchronousButton_Click(object sender, EventArgs e)
        {
            var excelFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyFile.xlsx");

            if (!File.Exists(excelFile))
            {
                MessageBox.Show("Failed to find file, please ensure the file exists.");
                return;
            }

            var ops = new Examples();
            ops.OpenExcel(excelFile, "Sheet2");

            MessageBox.Show("Done. Check Task Manager Processes and Excel should not be in the list.");

        }
        /// <summary>
        /// Allow the user interface to remain responsive.
        /// The bottleneck is opening Excel for the first time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ExcelAsynchronousButton_Click(object sender, EventArgs e)
        {

            var excelFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyFile.xlsx");

            if (!File.Exists(excelFile))
            {
                MessageBox.Show("Failed to find file, please ensure the file exists.");
                return;
            }

            var ops = new Examples();

            try
            {
                await Task.Run(() => ops.OpenExcel(excelFile, "Sheet2"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encountered errors\n{ex.Message}");
            }

            MessageBox.Show("Done");

        }
    }
}
