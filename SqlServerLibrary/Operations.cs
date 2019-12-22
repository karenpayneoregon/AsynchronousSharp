using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BaseConnectionLibrary.ConnectionClasses;
using SqlServerLibrary.Classes;

namespace SqlServerLibrary
{
    public class Operations : SqlServerConnection
    {
        public Operations()
        {
            DatabaseServer = "KARENS-PC";
            DefaultCatalog = "NorthWindAzure";
        }

        public async Task<DataTable> LoadCustomerData(bool hidePrimaryKey = true)
        {
            mHasException = false;

            var customersDataTable = new DataTable();

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    try
                    {
                        cmd.CommandText = 
                            "SELECT C.CustomerIdentifier, C.CompanyName, C.ContactName, " + 
                                "ContactType.ContactTitle, C.City, C.Country, C.ContactTypeIdentifier " + 
                             "FROM dbo.Customers AS C " + 
                             "INNER JOIN ContactType ON C.ContactTypeIdentifier = ContactType.ContactTypeIdentifier;";

                        /*
                         * If there is an issue with the connection using
                         * Open will freeze the user interface
                         */
                        await cn.OpenAsync();

                        customersDataTable.Load(await cmd.ExecuteReaderAsync());

                        customersDataTable.Columns["Country"].AllowDBNull = false;
                        customersDataTable.Columns["ContactTypeIdentifier"].ColumnMapping = MappingType.Hidden;

                        if (hidePrimaryKey)
                        {
                            customersDataTable.Columns["CustomerIdentifier"].ColumnMapping = MappingType.Hidden;
                        }

                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                    }
                }
            }

            return customersDataTable;
        }

        public async Task<List<ContactType>> LoadContactTypes()
        {
            mHasException = false;

            var contactList = new List<ContactType>();

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "SELECT ContactTypeIdentifier,ContactTitle  FROM dbo.ContactType";
                    try
                    {

                        /*
                         * If there is an issue with the connection using
                         * Open will freeze the user interface
                         */
                        await cn.OpenAsync();

                        var reader = await cmd.ExecuteReaderAsync();

                        while (await reader.ReadAsync())
                        {
                            contactList.Add(new ContactType()
                            {
                                ContactTypeIdentifier = await reader.GetFieldValueAsync<int>(0),
                                ContactTitle = await reader.GetFieldValueAsync<string>(1)
                            });

                        }
                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;
                    }
                }
            }


            return contactList;

        }
    }
}
