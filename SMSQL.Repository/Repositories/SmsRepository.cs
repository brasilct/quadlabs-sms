using BookingNotificationSMS_API;
using SMSQL.Domain.Entities;
using SMSQL.Domain.Interfaces;
using SMSQL.Domain.Models.Response;
using System.Threading.Tasks;

namespace SMSQL.Repository.Repositories
{
    public class SmsRepository : BaseSmsRepository, ISmsRepository
    {
        private SmsClass _smsClass;
        public SmsRepository()
        {
            _smsClass = new SmsClass();
        }
        public async Task<SmsStatusResponse> SendSms(Sms sms)
        {
            var normalizeResponse = NormalizeRequest(sms);
            
            var responseStr = _smsClass.fnSendSMS(normalizeResponse);
            var returnObject = CreateResponse<SmsStatusResponse>(responseStr);

            return returnObject.Data;
        }
    }
}
