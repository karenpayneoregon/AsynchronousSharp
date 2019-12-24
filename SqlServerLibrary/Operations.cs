using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
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
        /// <summary>
        /// Used to show x records of total records for loading people data
        /// in LoadPeopleAsyncWithCancellation.
        /// </summary>
        /// <returns></returns>
        public async Task<int> PersonTableAsyncCountTask()
        {
            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM Person";
                    await cn.OpenAsync();
                    return (int) await cmd.ExecuteScalarAsync();
                }
            }
        }
        /// <summary>
        /// Demonstrate loading 5,000 records with cancellation.
        /// In this case 5,000 records with several columns really could be
        /// a synchronous method.
        ///
        /// Run this without the Task.Delay and the load is completely acceptable.
        /// Where this method would be truly warranted is with 1 million plus records
        /// but if there are that many records consider not loading them all, instead
        /// consider.
        /// 
        /// a) provide a search form to load partial data
        /// b) virtual mode DataGridView
        /// c) paging DataGridView
        ///
        /// Note the cancellation token can be passed to Task.Delay and also for
        /// reading each field while doing this would need additional code to pass
        /// data back, this version works, no need to pass the token into these items.
        /// </summary>
        /// <param name="progress"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        public async Task<List<Person>> LoadPeopleAsyncWithCancellationTask(IProgress<string> progress, CancellationToken ct)
        {
            mHasException = false;
            var personList = new List<Person>();

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "SELECT Id,FirstName,LastName,Street,City,[State],PostalCode FROM dbo.Person";
                    try
                    {

                        /*
                         * If there is an issue with the connection using
                         * Open will freeze the user interface
                         */
                        await cn.OpenAsync(ct);

                        var reader = await cmd.ExecuteReaderAsync(ct);
                        

                        var index = 1;
                        while (await reader.ReadAsync(ct))
                        {

                            if (index % 50 == 0)
                            {
                                await Task.Delay(1);
                            }


                            progress.Report(index.ToString());

                            personList.Add(new Person()
                            {
                                Id = await reader.GetFieldValueAsync<int>(0),
                                FirstName = await reader.GetFieldValueAsync<string>(1),
                                LastName = await reader.GetFieldValueAsync<string>(2),
                                Street = await reader.GetFieldValueAsync<string>(3),
                                City = await reader.GetFieldValueAsync<string>(4),
                                State = await reader.GetFieldValueAsync<string>(5),
                                PostalCode = await reader.GetFieldValueAsync<string>(6)
                            });

                            index += 1;

                            if (ct.IsCancellationRequested)
                            {
                                if (personList.Count >0)
                                {
                                    return personList;
                                }
                                ct.ThrowIfCancellationRequested();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        mHasException = true;
                        mLastException = ex;

                        if (ct.IsCancellationRequested)
                        {
                            throw ex;
                        }
                    }
                }
            }

            return personList;

        }
        /// <summary>
        /// Async method to load a reference table, no cancellation option as this
        /// is a small table.
        /// </summary>
        /// <param name="progress"></param>
        /// <returns></returns>
        public async Task<List<ContactType>> LoadContactTypesAsyncTask(IProgress<string> progress)
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
                        int index = 1;

                        while (await reader.ReadAsync())
                        {

                            await Task.Delay(1000); // for demo purposes only
                            progress.Report(index.ToString());

                            contactList.Add(new ContactType()
                            {
                                ContactTypeIdentifier = await reader.GetFieldValueAsync<int>(0),
                                ContactTitle = await reader.GetFieldValueAsync<string>(1)
                            });

                            index += 1;

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
