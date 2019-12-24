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
                _contactsBindingSource = new BindingSourceDataTable { DataSource = await _operations.LoadPeopleAsyncWithCancellationTask(progress, _cancellationTokenSource.Token) };
                if (_operations.IsSuccessFul)
                {
                    dataGridView1.DataSource = _contactsBindingSource;
                    bindingNavigator1.BindingSource = _contactsBindingSource;

                    _contactsBindingSource.Sort = "LastName";
                    dataGridView1.DataError += DataGridView1_DataError;
                    dataGridView1.ExpandColumns();

                }

                dataGridView1.DataError += DataGridView1_DataError;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
