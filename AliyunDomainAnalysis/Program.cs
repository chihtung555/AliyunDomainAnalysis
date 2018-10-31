using System.Threading;
using System.Threading.Tasks;

namespace AliyunDomainAnalysis
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //var builder = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("AppSetting.json");

            //var configuration = builder.Build();

            DomainRecordOptions domainRecordOptions = new DomainRecordOptions();

            //configuration.GetSection("DomainRecordOptions").Bind(domainRecordOptions);

            DomainRecord domainRecord = new DomainRecord(domainRecordOptions);
            while (true)
            {
                await domainRecord.CheckAndModify();
                Thread.Sleep(30000);
            }
        }
    }
}
