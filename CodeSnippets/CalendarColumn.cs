using System;
using System.Windows.Forms;

namespace CodeSnippets
{
    public class CalendarColumn : DataGridViewColumn
    {
        public CalendarColumn() : base(new CalendarCell())
        {
        }
        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null && !(value.GetType().IsAssignableFrom(typeof(CalendarCell))))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
    }
    public class CalendarCell : DataGridViewTextBoxCell
    {
        public CalendarCell() 
        {
            Style.Format = "d";
            EmptyDate = DateTime.Now;
        }

        public DateTime EmptyDate { get; set; }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            CalendarEditingControl theControl = (CalendarEditingControl)DataGridView.EditingControl;

            if (Convert.IsDBNull(this.Value) || (this.Value == null))
            {
                theControl.Value = DateTime.Now;
            }
            else
            {
                theControl.Value = Convert.ToDateTime(this.Value);
            }

        }
        public override Type EditType => typeof(CalendarEditingControl);

        public override Type ValueType => typeof(DateTime);

        public override object DefaultNewRowValue => DateTime.Now;
    }
    /// <summary>
    /// Provides Calendar popup within the GridView.
    /// </summary>
    /// <remarks></remarks>
    internal class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView dataGridViewControl;
        private bool valueIsChanged = false;
        private int rowIndexNumber;

        public CalendarEditingControl()
        {
            Format = DateTimePickerFormat.Short;
        }

        public object EditingControlFormattedValue
        {
            get => Value.ToShortDateString();

            set
            {
                if (value is string)
                {
                    Value = DateTime.Parse((value == null ? null : Convert.ToString(value)));
                }
            }
        }
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return this.Value.ToString();
        }
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }
        public int EditingControlRowIndex
        {
            get => rowIndexNumber;
            set
            {
                rowIndexNumber = value;
            }
        }
        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            // No preparation needs to be done.
        }
        public bool RepositionEditingControlOnValueChange => false;

        public DataGridView EditingControlDataGridView
        {
            get => dataGridViewControl;
            set
            {
                dataGridViewControl = value;
            }
        }
        public bool EditingControlValueChanged
        {
            get => valueIsChanged;
            set
            {
                valueIsChanged = value;
            }
        }
        Cursor IDataGridViewEditingControl.EditingPanelCursor => this.EditingControlCursor;
        public Cursor EditingControlCursor => base.Cursor;

        protected override void OnValueChanged(EventArgs eventargs)
        {
            // Notify the DataGridView that the contents of the cell have changed.
            valueIsChanged = true;
            EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }

}
