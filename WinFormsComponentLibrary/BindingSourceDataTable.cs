using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsComponentLibrary
{
    /// <summary>
    /// BindingSource exclusively for working with DataTables
    /// </summary>
    public class BindingSourceDataTable : BindingSource
    {

        /// <summary>
        /// Returns DataSource as DataTable
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// DataSource must be a DataTable else we throw an exception
        /// </remarks>
        public DataTable DataTable() => (DataTable)DataSource;

        /// <summary>
        /// Returns DataSource as DataView
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// DataSource must be a DataTable else we throw an exception
        /// </remarks>
        public DataView DataView() => (DataView)List;

        /// <summary>
        /// Return current row as a DataRow
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// DataSource must be a DataTable else we throw an exception
        /// </remarks>
        public DataRow CurrentDataRow() => ((DataRowView)Current).Row;

        /// <summary>
        /// Determine if there is a current row
        /// </summary>
        /// <returns></returns>
        public bool CurrentRowIsNotNothing() => Current != null;

        /// <summary>
        /// Creates a comma delimited string representation of the current row.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// DataSource must be a DataTable else we throw an exception
        /// </remarks>
        public string CurrentItemArray()
        {
            return string.Join(",", CurrentDataRow().ItemArray);
        }
     
        /// <summary>
        /// Provides access to the control hosting this BindingSource
        /// At design time this property shows up in the property window for this component.
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        public ContainerControl ContainerControl
        {
            get
            {
                return _containerControl;
            }
            set
            {
                _containerControl = value;
            }
        }
        private ContainerControl _containerControl = null;
        public override ISite Site
        {
            get => base.Site;
            set
            {
                base.Site = value;
                if (value == null)
                {
                    return;
                }

                if ((IDesignerHost)value.GetService(typeof(IDesignerHost)) is IDesignerHost host)
                {
                    IComponent componentHost = host.RootComponent;
                    if (componentHost is ContainerControl)
                    {
                        ContainerControl = componentHost as ContainerControl;
                    }
                }
            }
        }
    }
}
