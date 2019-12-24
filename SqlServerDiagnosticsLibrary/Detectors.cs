using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseConnectionLibrary;

namespace SqlServerDiagnosticsLibrary
{
    public class Detectors : BaseExceptionProperties
    {
        public async Task<bool> SqlServerIsAvailable(string ServerName)
        {
            mHasException = false;
            bool success = false;

            try
            {
                await Task.Run(() =>
                {
                    var sqlDataSourceEnumeratorInstance = SqlDataSourceEnumerator.Instance;
                    DataTable dt = sqlDataSourceEnumeratorInstance.GetDataSources();

                    // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            var row = dt.AsEnumerable().FirstOrDefault(
                                dataRow => dataRow.Field<string>("ServerName") == ServerName.ToUpper());

                            success = row != null;

                        }
                        else
                        {
                            success = false;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                mHasException = true;
                mLastException = ex;
            }

            return success;
        }
    }
}
