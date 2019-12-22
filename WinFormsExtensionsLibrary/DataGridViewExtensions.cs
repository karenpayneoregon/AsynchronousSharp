using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExtensionsGeneralLibrary;

namespace WinFormsExtensionsLibrary
{
    public static class DataGridViewExtensions
    {
        public static void ExpandColumns(this DataGridView sender)
        {
            foreach (DataGridViewColumn col in sender.Columns)
            {

                if (col.ValueType == null || col.ValueType.Name == "ICollection`1") continue;

                col.HeaderText = col.HeaderText.SplitCamelCase();
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }
        }
        /// <summary>
        /// Used to export rows by a specific delimiter to a text file
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="fileName">Path and file name to write row data too</param>
        /// <param name="delimiter">character to delimit columns</param>
        /// <example>
        /// <code source="CodeExamples\ExportRows1.cs"  title="C# Example"/>
        /// </example>
        public static void ExportRows(this DataGridView sender, string fileName, string delimiter = ",")
        {
            if (sender.RowCount <= 0) return;

            var sb = new StringBuilder();

            var headers = sender.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(delimiter, headers.Select(column => column.HeaderText)));

            foreach (DataGridViewRow row in sender.Rows)
            {
                if (!row.IsNewRow != true) continue;

                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(delimiter, cells.Select(cell => cell.Value)));

            }

            File.WriteAllText(fileName, sb.ToString());
        }

    }
}
