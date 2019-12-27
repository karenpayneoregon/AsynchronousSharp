using System;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;

namespace CodeSnippets.Classes
{
    public class DateTimeFromInternet
    {
        public async Task<DateTime> GetNistTimeTask()
        {

            var localDateTime = DateTime.MinValue;

            await Task.Run(() =>
            {

                try
                {
                    var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
                    var response = myHttpWebRequest.GetResponse();
                    var todaysDates = response.Headers["date"];

                    localDateTime =  DateTime.ParseExact(todaysDates,"ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                        CultureInfo.InvariantCulture.DateTimeFormat,
                        DateTimeStyles.AssumeUniversal);
                    
                }
                catch (Exception)
                {
                    // ignored - caller can validate against DateTime.MinValue
                }
            });

            return localDateTime;

        }
        /// <summary>
        /// Get current date time formatted
        /// </summary>
        /// <returns></returns>
        public async Task<string> Formatted()
        {
            var theDate = await GetNistTimeTask();
            return theDate.ToString("f");
        }
    }
}
