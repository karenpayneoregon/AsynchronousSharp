using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseConnectionLibrary.ConnectionClasses;

namespace OpenSqlServerExample.Classes
{
    public class SqlServerOperaions : SqlServerConnection
    {
        public bool TryConnectNoServerSync()
        {
            mHasException = false;
            DatabaseServer = "Server1";
            DefaultCatalog = "Customers";

            try
            {
                using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
                {
                    cn.Open();
                    return true;
                }
            }
            catch (Exception e)
            {
                mHasException = true;
                mLastException = e;
                return false;
            }
        }
        public async Task<bool> TryConnectNoServerAsync() 
        {
            mHasException = false;
            DatabaseServer = "Server1";
            DefaultCatalog = "Customers";

            try
            {
                using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
                {
                    await cn.OpenAsync();
                    return true;
                }
            }
            catch (Exception e)
            {
                mHasException = true;
                mLastException = e;
                return false;
            }
        }
        public async Task<bool> ConnectServerAsync(string serverName)
        {
            mHasException = false;
            DatabaseServer = serverName;
            //DefaultCatalog = "Customers";

            try
            {
                using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
                {
                    await cn.OpenAsync();
                    return true;
                }
            }
            catch (Exception e)
            {
                mHasException = true;
                mLastException = e;
                return false;
            }
        }
    }
}

