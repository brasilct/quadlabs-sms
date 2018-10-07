using SMSQL.Domain.Models.Request;
using SMSQL.Domain.Models.Response;
using System.Threading.Tasks;

namespace SMSQL.Domain.Interfaces
{
    public interface ISmsApp
    {
        Task<SmsStatusResponse> Send(SmsRequest sms);
    }
}