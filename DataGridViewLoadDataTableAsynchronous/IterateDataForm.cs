using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerLibrary;
using SqlServerLibrary.Classes;
using WinFormsComponentLibrary;
using WinFormsExtensionsLibrary;

namespace DataGridViewLoadDataTableAsynchronous
{
    public partial class IterateDataForm : Form
    {
        private BindingSourceDataTable _contactsBindingSource;
        private readonly Operations _operations = new Operations();
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private int _recordCount = 0;
        public IterateDataForm()
        {
            InitializeComponent();
            Shown += IterateDataForm_Shown;
        }

        private async void IterateDataForm_Shown(object sender, EventArgs e)
        {

            _recordCount = await _operations.PersonTableAsyncCountTask();
            var progress = new Progress<string>(s => label1.Text = $"Loading {s} of {_recordCount}");

            try
            {
                _contactsBindingSource = new BindingSourceDataTable {DataSource = await _operations.LoadPeopleAsyncWithCancellationTask(progress, _cancellationTokenSource.Token)};
                if (_operations.IsSuccessFul)
                {
                    
                    dataGridView1.DataSource = _contactsBindingSource;
                    bindingNavigator1.BindingSource = _contactsBindingSource;

                    _contactsBindingSource.Sort = "LastName";

                    dataGridView1.Columns["id"].Visible = false;
                    dataGridView1.DataError += DataGridView1_DataError;
                    dataGridView1.ExpandColumns();

                    if (_cancellationTokenSource.IsCancellationRequested)
                    {
                        MessageBox.Show($"Operation cancelled with {_contactsBindingSource.Count} of {_recordCount} records.");
                    }

                    dataGridView1.KeyDown += DataGridView1_KeyDown;
                    ActiveControl = dataGridView1;

                }
                else
                {
                    MessageBox.Show(_operations.LastExceptionMessage);
                }                
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Loading of data has been cancelled");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Encountered issues\n{exception.Message}");
            }
        }
        /// <summary>
        /// Show how to access the current row as a Person which can be used
        /// for editing the record in a child form or delete the current row.
        /// Note there are other ways to handle delete via the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_contactsBindingSource.Current == null)
            {
                return;                
            }

            var person = (Person)_contactsBindingSource.Current;

            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;                
                MessageBox.Show($"Edit {person.Id}");
            }else if (e.KeyData == Keys.Delete)
            {
                MessageBox.Show($"Delete {person.Id}");
            }
        }
        private void DeleteCurrentRowtoolStripButton1_Click(object sender, EventArgs e)
        {
            if (_contactsBindingSource.Current == null)
            {
                return;
            }

            var person = (Person)_contactsBindingSource.Current;
            MessageBox.Show($"Delete {person.Id}");

        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message.Contains("does not allow nulls."))
            {
                /*
                 * The offending column name is enclosed in a pair of single quotes, get the
                 * column name between the quotes.
                 */
                var match = Regex.Match(e.Exception.Message, @"'([^']*)");

                /*
                 * Display custom message if a DBNull issue or go with the standard error message
                 */
                MessageBox.Show(match.Success ? $"{match.Groups[1].Value} is required" : e.Exception.Message);

                e.ThrowException = false;
            }
            else
            {
                MessageBox.Show("There was one or more issues with data entered");
                e.ThrowException = false;

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource.Cancel();
        }

    }
}
