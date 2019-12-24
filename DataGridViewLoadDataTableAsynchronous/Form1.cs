using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlServerLibrary;
using WinFormsComponentLibrary;
using WinFormsExtensionsLibrary;
using static WinFormsDialogLibrary.WinFormDialogs;

namespace DataGridViewLoadDataTableAsynchronous
{
    public partial class Form1 : Form
    {
        private BindingSourceDataTable _customersBindingSource;
        private readonly Operations _operations = new Operations();

        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            //var waitForm = new WaitForm() {TopLevel =  true, TopMost = true};
            //waitForm.Show();
            //try
            //{
            //    _customersBindingSource = new BindingSourceDataTable { DataSource = await _operations.LoadCustomerData() };
            //}
            //finally
            //{
            //    waitForm.Dispose();
            //}

            _customersBindingSource = new BindingSourceDataTable { DataSource = await _operations.LoadCustomerData() };

            if ( _operations.IsSuccessFul)
            {
                customerDataGridView.DataSource = _customersBindingSource;
                bindingNavigator1.BindingSource = _customersBindingSource;

                _customersBindingSource.Sort = "CompanyName";
                customerDataGridView.DataError += CustomerDataGridView_DataError;
                customerDataGridView.ExpandColumns();

            }
            else
            {
                MessageBox.Show($"Encountered the following issues\n{_operations.LastExceptionMessage}");
            }
            
        }

        /// <summary>
        /// Rather than allow the DataGridView to show an error message which usually is meaningless
        /// to users present easier to understand messages when an issue occurs.
        ///
        /// If the error is unknown, consider appending to a log file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

    }
}
