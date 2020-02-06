using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileLibrary;
using FileLibrary.Classes;

namespace ForumQuestion1
{
    public partial class Form1 : Form
    {
        private string _FileName;
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            _FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "customers.csv");

            // read lines into a list
            _bindingSource.DataSource = FileReader.ConventionalRead(_FileName);
            bindingNavigator1.BindingSource = _bindingSource;

            // data bind all properties except CustomerIdentifier
            CompanyNameTextBox.DataBindings.Add("Text", _bindingSource, "CompanyName");
            ContactNameTextBox.DataBindings.Add("Text", _bindingSource, "ContactName");
            ContactTitleTextBox.DataBindings.Add("Text", _bindingSource, "ContactTitle");
            CityTextBox.DataBindings.Add("Text", _bindingSource, "City");
            CountryTextBox.DataBindings.Add("Text", _bindingSource, "Country");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var customers = (List<Customer>) _bindingSource.DataSource;
            var lines = customers.Select(customer => customer.LinesItems);

            File.WriteAllLines(_FileName,lines);
        }
    }
}
