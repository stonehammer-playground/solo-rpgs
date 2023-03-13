using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;

namespace CodeScanTest
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            using (SqlCommand cm = new()){
                cm.CommandType  = System.Data.CommandType.Text;
                cm.CommandText = "SELECT * FROM tables where ID = " + "hello";
            }
        }
    }
}
