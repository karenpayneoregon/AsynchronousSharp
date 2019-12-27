using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForumQuestion
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = MockedData.EmployeeDataTable();
            dataGridView1.DataSource = _bindingSource;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SearchForTextBox.Text))
            {
                var dataTable = ((DataTable) _bindingSource.DataSource);

                var dataRow = dataTable.AsEnumerable()
                    .FirstOrDefault(row => row.Field<string>("Empno") == SearchForTextBox.Text);

                if (dataRow == null)
                {
                    dataTable.Rows.Add(
                        null, 
                        SearchForTextBox.Text, string.IsNullOrWhiteSpace(SectionTextBox.Text) ? 
                            "(empty)" : SectionTextBox.Text);
                }
                else
                {
                    dataRow.SetField(
                        "Study1", 
                        string.IsNullOrWhiteSpace(SectionTextBox.Text) ? 
                            "(empty)" : SectionTextBox.Text);
                }
            }
        }

        private void FirstEmptyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SearchForTextBox.Text))
            {
                var dataTable = ((DataTable)_bindingSource.DataSource);

                var dataRow = dataTable.AsEnumerable()
                    .FirstOrDefault(row => row.Field<string>("Empno") == SearchForTextBox.Text);

                if (dataRow == null)
                {
                    dataRow = dataTable.AsEnumerable()
                        .FirstOrDefault(row => row.Field<string>("Empno") == "");
                    if (dataRow != null)
                    {
                        dataRow.SetField(
                            "Empno", SearchForTextBox.Text);
                    }
                }
                else
                {
                    dataRow.SetField(
                        "Study1",
                        string.IsNullOrWhiteSpace(SectionTextBox.Text) ?
                            "(empty)" : SectionTextBox.Text);
                }
            }
        }
    }
}
