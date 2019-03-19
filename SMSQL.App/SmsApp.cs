using SMSQL.Domain.Entities;
using SMSQL.Domain.Interfaces;
using SMSQL.Domain.Models.Request;
using SMSQL.Domain.Models.Response;
using SMSQL.Repository.Repositories;
using System.Threading.Tasks;

namespace SMSQL.App
{
    public class SmsApp : ISmsApp
    {
        ISmsRepository _smsRepository = new SmsRepository();

        public async Task<SmsStatusResponse> Send(SmsRequest sms)
        {
            Sms smsEntity = new Sms()
            {
                CustomerName = sms.CustomerName,
                BranchId = sms.BranchId,
                BookingRef = sms.BookingRef,
                BPoints = sms.BPoints,
                Phone = sms.Phone,
                ProductType = sms.ProductType,
                SalesChannel = "ONLINE-DC",
                CompanyID = "BC",
                EventName = sms.EventName
            };

            return await _smsRepository.SendSms(smsEntity);
        }
    }
}
