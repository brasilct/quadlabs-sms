using SMSQL.App;
using SMSQL.Domain.Interfaces;
using SMSQL.Repository.Repositories;
using StructureMap;

namespace SMSQL.IoCRegistry
{
    public class StandardRegistry : Registry
    {
        public StandardRegistry()
        {
            For<ISmsApp>().Use<SmsApp>();
            For<ISmsRepository>().Use<SmsRepository>();
        }
    }
}