using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtensionsGeneralLibrary;
using FileLibrary;
using FileLibrary.Classes;
using WinFormsComponentLibrary;
using WinFormsExtensionsLibrary;

namespace DataGridViewLoadDelimitedFileAsynchronous
{
    public partial class Form1 : Form
    {

        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        private readonly BindingSource _customersBindingSource = new BindingSource();
        BindingList<Customer> _customerBindingListView = new BindingList<Customer>();

        private string _fileNameToReadFrom = "customersLarge.csv";

        private int _delayIndex = 0;

        public Form1()
        {
            InitializeComponent();


            dataGridView1.RowHeadersVisible = false;

            _delayIndex = File.ReadLines(_fileNameToReadFrom).Count() * 25 / 100;

            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = _customersBindingSource;
        }


        /// <summary>
        /// Read file using StreamReader.ReadLineAsync, create a new customer in each
        /// iteration in a while statement.
        ///
        /// First three lines are to allow the developer to see the sources are cleared
        /// before running the code to populate the DataGridView.
        ///
        /// This method is slow from combining reading lines/parsing then adding a customer to a list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Example1Button_Click(object sender, EventArgs e)
        {

            //dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            var waitForm = new WaitForm() { TopLevel = true, TopMost = true };

            waitForm.Show(this);
            waitForm.Top = (Top + (Height / 2)) - waitForm.Height / 2;
            waitForm.Left = (Left + (Width / 2)) - waitForm.Width / 2;

            ElapsedTimeLabel.Text = "00:00:00";
            ElapsedTimeLabel.Refresh();
            var watch = new Stopwatch();
            watch.Start();

            try
            {
                _customerBindingListView = null;
                dataGridView1.DataSource = null;

                await Task.Delay(500);

                var customers = await FileReader.ReadAllLinesAsync(_fileNameToReadFrom).ConfigureAwait(false);

                _customerBindingListView = new SortableBindingList<Customer>(customers.ToList());


                dataGridView1.InvokeIfRequired(d =>
                {
                    _customersBindingSource.DataSource = _customerBindingListView;
                    dataGridView1.DataSource = _customersBindingSource;

                    dataGridView1.Columns["CustomerIdentifier"].Visible = false;
                    dataGridView1.ExpandColumns();

                });
            }
            finally
            {
                waitForm.Invoke((MethodInvoker)(() => waitForm.Dispose()));
            }

            watch.Stop();

            ElapsedTimeLabel.Invoke((MethodInvoker)(() => ElapsedTimeLabel.Text = watch.Elapsed.ToString("mm\\:ss\\.ff")));

        }
        /// <summary>
        /// Simple example for cancelling an async operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Example1WithCancelButton_Click(object sender, EventArgs e)
        {
            if (_cancellationTokenSource.IsCancellationRequested == true)
            {
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = new CancellationTokenSource();
            }

            bindingNavigator1.BindingSource = null;

            _customerBindingListView = new SortableBindingList<Customer>(new List<Customer>());
            _customersBindingSource.DataSource = _customerBindingListView;
            dataGridView1.DataSource = _customersBindingSource;

            int index = 0;

            try
            {
                foreach (var line in FileReader.ParseFile(_fileNameToReadFrom, _cancellationTokenSource.Token))
                {
                    var lineParts = line.Result.Split(',');

                    if (index % _delayIndex == 0)
                    {
                        await Task.Delay(1);
                    }

                    _customerBindingListView.Add(
                        new Customer()
                        {
                            CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                            CompanyName = lineParts[1],
                            ContactName = lineParts[2],
                            ContactTitle = lineParts[3],
                            City = lineParts[4],
                            Country = lineParts[5]
                        });

                    index += 10;
                }

                bindingNavigator1.BindingSource = _customersBindingSource;
            }
            catch (Exception)
            {
                MessageBox.Show("Cancelled");
            }

            if (_customersBindingSource.Count >0)
            {
                bindingNavigator1.BindingSource = _customersBindingSource;
            }
        }

        private async void Example2Button_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = null;
            ElapsedTimeLabel.Text = "00:00:00";
            ElapsedTimeLabel.Refresh();
            var watch = new Stopwatch();
            watch.Start();

            _customerBindingListView = new SortableBindingList<Customer>(new List<Customer>());
            _customersBindingSource.DataSource = _customerBindingListView;
            dataGridView1.DataSource = _customersBindingSource;

            int index = 0;
            foreach (var line in FileReader.ParseFile(_fileNameToReadFrom))
            {
                var lineParts = line.Result.Split(',');

                if (index % _delayIndex == 0)
                {
                    await Task.Delay(1);
                }

                _customerBindingListView.Add(
                    new Customer()
                    {
                        CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                        CompanyName = lineParts[1],
                        ContactName = lineParts[2],
                        ContactTitle = lineParts[3],
                        City = lineParts[4],
                        Country = lineParts[5]
                    });

                index += 10;
            }

            watch.Stop();

            bindingNavigator1.BindingSource = _customersBindingSource;

            ElapsedTimeLabel.Invoke((MethodInvoker)(() => ElapsedTimeLabel.Text = watch.Elapsed.ToString("mm\\:ss\\.ff")));

        }

        private void Example3Button_Click(object sender, EventArgs e)
        {

            ElapsedTimeLabel.Text = "00:00:00";
            ElapsedTimeLabel.Refresh();
            var watch = new Stopwatch();
            watch.Start();

            _customerBindingListView = new SortableBindingList<Customer>(new List<Customer>());
            _customersBindingSource.DataSource = _customerBindingListView;

            dataGridView1.Visible = false;
            PleaseWaitLabel.Refresh();

            try
            {
                _customerBindingListView = new SortableBindingList<Customer>(new List<Customer>());
                _customersBindingSource.DataSource = _customerBindingListView;
                dataGridView1.DataSource = _customersBindingSource;

                foreach (var line in FileReader.ParseFile(_fileNameToReadFrom))
                {
                    var lineParts = line.Result.Split(',');

                    _customerBindingListView.Add(
                        new Customer()
                        {
                            CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                            CompanyName = lineParts[1],
                            ContactName = lineParts[2],
                            ContactTitle = lineParts[3],
                            City = lineParts[4],
                            Country = lineParts[5]
                        });
                }
            }
            finally
            {
                dataGridView1.Visible = true;

                watch.Stop();

                ElapsedTimeLabel.Invoke((MethodInvoker)(() => ElapsedTimeLabel.Text = watch.Elapsed.ToString("mm\\:ss\\.ff")));
            }
        }

        private void Example4Button_Click(object sender, EventArgs e)
        {

            ElapsedTimeLabel.Text = "00:00:00";
            ElapsedTimeLabel.Refresh();

            var watch = new Stopwatch();
            watch.Start();

            _customerBindingListView = new SortableBindingList<Customer>(new List<Customer>());
            _customersBindingSource.DataSource = _customerBindingListView;

            dataGridView1.Visible = false;
            PleaseWaitLabel.Refresh();

            try
            {
                _customerBindingListView = new SortableBindingList<Customer>(new List<Customer>());
                _customersBindingSource.DataSource = _customerBindingListView;
                dataGridView1.DataSource = _customersBindingSource;

                foreach (var line in FileReader.ParseFile(_fileNameToReadFrom))
                {
                    var lineParts = line.Result.Split(',');

                    _customerBindingListView.Add(
                        new Customer()
                        {
                            CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                            CompanyName = lineParts[1],
                            ContactName = lineParts[2],
                            ContactTitle = lineParts[3],
                            City = lineParts[4],
                            Country = lineParts[5]
                        });
                }
            }
            finally
            {
                dataGridView1.Visible = true;
                dataGridView1.ExpandColumns();

                watch.Stop();

                ElapsedTimeLabel.Invoke((MethodInvoker)(() => ElapsedTimeLabel.Text = watch.Elapsed.ToString("mm\\:ss\\.ff")));

            }
        }

        private async void Example5Button_Click(object sender, EventArgs e)
        {
            var timeSpanList = new List<TimeSpan>();
            ElapsedTimeLabel.Text = "00:00:00";
            ElapsedTimeLabel.Refresh();

            var watch = new Stopwatch();
            watch.Start();

            var results = await FileReader.GetContentAsync(_fileNameToReadFrom);

            watch.Stop();
            timeSpanList.Add(watch.Elapsed);

            //Console.WriteLine($"Time to read file {watch.Elapsed.ToString("mm\\:ss\\.ff")}");

            watch.Reset();
            watch.Start();

            var lines = results.Split('\n');
            //Console.WriteLine($"Time to read file {watch.Elapsed.ToString("mm\\:ss\\.ff")}");

            timeSpanList.Add(watch.Elapsed);
            watch.Reset();
            watch.Start();

            int index = 0;

            var customers = new List<Customer>();
            foreach (var line in lines)
            {

                var lineParts = line.Split(',');
                customers.Add(new Customer()
                {
                    CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                    CompanyName = lineParts[1],
                    ContactName = lineParts[2],
                    ContactTitle = lineParts[3],
                    City = lineParts[4],
                    Country = lineParts[5]
                });

                if (index % _delayIndex == 0)
                {
                    await Task.Delay(1);
                }

                index += 10;

            }

            timeSpanList.Add(watch.Elapsed);
            watch.Reset();
            watch.Start();


            _customerBindingListView = new SortableBindingList<Customer>(customers.ToList());
            _customersBindingSource.DataSource = _customerBindingListView;
            dataGridView1.DataSource = _customersBindingSource;

            var totalSpan = new TimeSpan(timeSpanList.Sum(r => r.Ticks));
            ElapsedTimeLabel.Text = totalSpan.ToString("mm\\:ss\\.ff");
        }

        private async void Example5AButton_Click(object sender, EventArgs e)
        {

            ElapsedTimeLabel.Text = "00:00:00";
            ElapsedTimeLabel.Refresh();

            var watch = new Stopwatch();
            watch.Start();

            var customers = new List<Customer>();
            var results = await FileReader.GetContentAsync(_fileNameToReadFrom);
            var lines = results.Split('\n');

            foreach (var line in lines)
            {
                var lineParts = line.Split(',');
                customers.Add(new Customer()
                {
                    CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                    CompanyName = lineParts[1],
                    ContactName = lineParts[2],
                    ContactTitle = lineParts[3],
                    City = lineParts[4],
                    Country = lineParts[5]
                });

            }

            _customerBindingListView = new SortableBindingList<Customer>(customers.ToList());
            _customersBindingSource.DataSource = _customerBindingListView;
            dataGridView1.DataSource = _customersBindingSource;

            watch.Stop();

            ElapsedTimeLabel.Invoke((MethodInvoker)(() => ElapsedTimeLabel.Text = watch.Elapsed.ToString("mm\\:ss\\.ff")));

        }

        private void ConventionalReadButton_Click(object sender, EventArgs e)
        {

            _customerBindingListView = null;
            dataGridView1.DataSource = null;

            ElapsedTimeLabel.Text = "00:00:00";
            ElapsedTimeLabel.Refresh();

            var watch = new Stopwatch();
            watch.Start();

            var customers = FileReader.ConventionalRead(_fileNameToReadFrom);
            _customerBindingListView = new SortableBindingList<Customer>(customers);
            _customersBindingSource.DataSource = _customerBindingListView;
            dataGridView1.DataSource = _customersBindingSource;
            dataGridView1.Columns["CustomerIdentifier"].Visible = false;

            /*
             * SuspendLayout and ResumeLayout will not really help
             */
            if (ExpandColumnsCheckBox.Checked)
            {
                dataGridView1.SuspendLayout();
                dataGridView1.ExpandColumns();
                dataGridView1.ResumeLayout();
            }

            ElapsedTimeLabel.Text = watch.Elapsed.ToString("mm\\:ss\\.ff");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void CancelExample1Button_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

        private void ContinueWith1Button_Click(object sender, EventArgs e)
        {
            var customers = new List<Customer>();
            CustomersComoBox.DataSource = null;

            // read lines in file
            var loadLinesTask = Task.Run(() =>
            {
                var lines = File.ReadAllLines(_fileNameToReadFrom);
                return lines;
            });

            // populate customer list
            var processStacksTask = loadLinesTask.ContinueWith( lineTask =>
            {
                var lines = lineTask.Result;
                foreach (var line in lines)
                {
                    var lineParts = line.Split(',');
                    customers.Add(new Customer()
                    {
                        CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                        CompanyName = lineParts[1],
                        ContactName = lineParts[2],
                        ContactTitle = lineParts[3],
                        City = lineParts[4],
                        Country = lineParts[5]
                    });
                }
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            // report exceptions
            loadLinesTask.ContinueWith(t =>
            {
                MessageBox.Show(t.Exception.GetExceptionMessages());

            }, TaskContinuationOptions.OnlyOnFaulted);

            // notify we are finished
            processStacksTask.ContinueWith( _ =>
            {
                CustomersComoBox.Invoke((MethodInvoker)(() => CustomersComoBox.DataSource = customers));
                MessageBox.Show($"Finished loading customers: {customers.Count()}");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
        }
    }
}
