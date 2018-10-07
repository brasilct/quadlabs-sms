using SMSQL.Domain.Entities;
using SMSQL.Domain.Models.Response;
using System.Threading.Tasks;

namespace SMSQL.Domain.Interfaces
{
    public interface ISmsRepository
    {
        Task<SmsStatusResponse> SendSms(Sms sms);
    }
}
