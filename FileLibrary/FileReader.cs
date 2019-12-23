using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using FileLibrary.Classes;

namespace FileLibrary
{
    public static class FileReader
    {
        public static List<Customer> ConventionalRead(string path)
        {
            var customers = new List<Customer>();

            // Open the FileStream with the same FileMode, FileAccess
            // and FileShare as a call to File.OpenText would've done.
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        var lineParts = line.Split(',');

                        customers.Add(new Customer()
                        {
                            CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                            CompanyName = lineParts[1],
                            ContactName = lineParts[2],
                            ContactTitle = lineParts[3],
                            City = lineParts[4],
                            Country = lineParts[5]
                        });

                    }
                }
            }

            return customers;
        }

        /// <summary>
        /// This is the same default buffer size as
        /// <see cref="StreamReader"/> and <see cref="FileStream"/>.
        /// </summary>
        private const int DefaultBufferSize = 4096;

        /// <summary>
        /// Indicates that
        /// - The file is to be used for asynchronous reading.
        /// - The file is to be accessed sequentially from beginning to end.
        /// </summary>
        private const FileOptions DefaultOptions = FileOptions.Asynchronous | FileOptions.SequentialScan;

        public static Task<Customer[]> ReadAllLinesAsync(string path)
        {
            //return ReadAllLinesAsync1(path, Encoding.UTF8);
            return ReadAllLinesAsync3(path, Encoding.UTF8);

            //return ReadAllLinesAsync2(path, 50);
        }
        public static Task<Customer[]> ReadAllLinesAsyncWithCancellation(string path)
        {
            //return ReadAllLinesAsync1(path, Encoding.UTF8);
            return ReadAllLinesAsync3(path, Encoding.UTF8);

            //return ReadAllLinesAsync2(path, 50);
        }

        public static async Task<Customer[]> ReadAllLinesAsync1(string path, Encoding encoding)
        {
            var customers = new List<Customer>();

            // Open the FileStream with the same FileMode, FileAccess
            // and FileShare as a call to File.OpenText would've done.
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line;

                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        var lineParts = line.Split(',');

                        customers.Add(new Customer()
                        {
                            CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                            CompanyName = lineParts[1],
                            ContactName =  lineParts[2],
                            ContactTitle = lineParts[3],
                            City = lineParts[4],
                            Country = lineParts[5]
                        });


                    }
                }
            }

            return customers.ToArray();
        }
        public static async Task<Customer[]> ReadAllLinesAsync2(string path, int wait)
        {
            var customers = new List<Customer>();
            int index = 0;

            // Open the FileStream with the same FileMode, FileAccess
            // and FileShare as a call to File.OpenText would've done.
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, DefaultBufferSize, DefaultOptions))
            {
                using (var reader = new StreamReader(stream))
                {
                    string line;

                    while ((line = await reader.ReadLineAsync()) != null)
                    {
                        var lineParts = line.Split(',');


                        if (index % wait == 0)
                        {
                            await Task.Delay(1);
                        }

                        customers.Add(new Customer()
                        {
                            CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                            CompanyName = lineParts[1],
                            ContactName = lineParts[2],
                            ContactTitle = lineParts[3],
                            City = lineParts[4],
                            Country = lineParts[5]
                        });

                        index += 1;

                    }
                }
            }

            return customers.ToArray();
        }

        public static async Task<Customer[]> ReadAllLinesAsync3(string path, Encoding encoding)
        {
            var index = 0;
            var customers = new List<Customer>();

            using (var reader = new StreamReader(path))
            {

                var text = await reader.ReadToEndAsync();
                var lines = text.Split('\n');

                foreach (var line in lines)
                {
                    //if (index % 1000 == 0)
                    //{
                    //    await Task.Delay(1);
                    //}

                    var lineParts = line.Split(',');
                    customers.Add(new Customer()
                    {
                        CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                        CompanyName = lineParts[1],
                        ContactName = lineParts[2],
                        ContactTitle = lineParts[3],
                        City = lineParts[4],
                        Country = lineParts[5]
                    });

                    index += 5;
                }

            }

            return customers.ToArray();
        }
        public static async Task<Customer[]> ReadAllLinesAsync3(string path, Encoding encoding, CancellationToken ct)
        {
            var index = 0;
            var customers = new List<Customer>();

            using (var reader = new StreamReader(path))
            {
                var text = await reader.ReadToEndAsync();
                var lines = text.Split('\n');
                foreach (var line in lines)
                {
                    //if (index % 1000 == 0)
                    //{
                    //    await Task.Delay(1);
                    //}
                    var lineParts = line.Split(',');
                    customers.Add(new Customer()
                    {
                        CustomerIdentifier = Convert.ToInt32(lineParts[0]),
                        CompanyName = lineParts[1],
                        ContactName = lineParts[2],
                        ContactTitle = lineParts[3],
                        City = lineParts[4],
                        Country = lineParts[5]
                    });

                    if (ct.IsCancellationRequested)
                    {
                        ct.ThrowIfCancellationRequested();
                    }

                    index += 5;
                }

            }

            return customers.ToArray();
        }

        public static async Task<string> GetContentAsync(string path)
        {
            using (var reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync();
            }
        }
        private static async Task<string> ReadAndParseAsync(StreamReader reader)
        {
            var line = await reader.ReadLineAsync().ConfigureAwait(false);
            return line;
        }
        public static IEnumerable<Task<string>> ParseFile(string path)
        {
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    Task<string> readLineTask = null;
                    try
                    {
                        readLineTask = ReadAndParseAsync(reader);
                        yield return readLineTask;
                    }
                    finally
                    {
                        // There are three ways we can end up here:
                        //  1) an exception occurred (in which case readLineTask may still be null)
                        //  2) The caller asked for the next item (in which case execution will resume
                        //      from the yield return, and we'll try another loop iteration
                        //  3) The caller has decided to stop early, calling Dispose on the enumerator
                        //      before reaching the end
                        // If it's either 2 or 3 (i.e., we have a non-null readLineTask), we need to ensure
                        // that the last task we created is complete. (In case 2, we need it to be complete
                        // because we can't test for EndOfStream, nor can we go on to begin another read until
                        // the last read finishes. In case 3, we need to ensure that the read completes before
                        // we dispose the StreamReader.)
                        // Hopefully the caller already awaited the task for us. But if they didn't we need to
                        // block now until it completes.
                        if (readLineTask?.IsCompleted == false)
                        {
                            // Calling Wait is almost always a terrible idea. But we've been
                            // forced into this by the mismatch between our return type, and the
                            // nature of the work we're doing.
                            readLineTask.Wait();
                        }
                    }
                }
            }
        }
        public static IEnumerable<Task<string>> ParseFile(string path, CancellationToken ct)
        {
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    Task<string> readLineTask = null;
                    try
                    {
                        if (ct.IsCancellationRequested)
                        {
                            ct.ThrowIfCancellationRequested();
                        }

                        readLineTask = ReadAndParseAsync(reader);
                        yield return readLineTask;
                    }
                    finally
                    {
                        // There are three ways we can end up here:
                        //  1) an exception occurred (in which case readLineTask may still be null)
                        //  2) The caller asked for the next item (in which case execution will resume
                        //      from the yield return, and we'll try another loop iteration
                        //  3) The caller has decided to stop early, calling Dispose on the enumerator
                        //      before reaching the end
                        // If it's either 2 or 3 (i.e., we have a non-null readLineTask), we need to ensure
                        // that the last task we created is complete. (In case 2, we need it to be complete
                        // because we can't test for EndOfStream, nor can we go on to begin another read until
                        // the last read finishes. In case 3, we need to ensure that the read completes before
                        // we dispose the StreamReader.)
                        // Hopefully the caller already awaited the task for us. But if they didn't we need to
                        // block now until it completes.
                        if (readLineTask?.IsCompleted == false)
                        {
                            // Calling Wait is almost always a terrible idea. But we've been
                            // forced into this by the mismatch between our return type, and the
                            // nature of the work we're doing.
                            readLineTask.Wait();
                        }
                    }
                }
            }
        }


    }
}
