using SMSQL.Domain.Interfaces;
using SMSQL.Domain.Models;
using SMSQL.Domain.Models.Request;
using SMSQL.Domain.Models.Response;
using System;
using System.Threading.Tasks;
using System.Web.Http;

/// <summary>
/// API para realizar a interface de envio de SMS com a DLL BookingNotificationSMS.dll da QuadLabs
/// </summary>

namespace SMSQL.Controllers
{
    public class SmsController : ApiController
    {
        private readonly ISmsApp _smsApp;

        public SmsController(ISmsApp smsApp)
        {
            _smsApp = smsApp;
        }

        [HttpPost]
        public async Task<ApiResponse<SmsStatusResponse>> Send([FromBody]SmsRequest sms)
        {            
            try
            {
                var response = new ApiResponse<SmsStatusResponse>
                {
                    Data = await _smsApp.Send(sms)
                };

                return response;
            }

            catch (Exception ex)
            {
                var error = new ApiResponse<SmsStatusResponse>();
                error.SetError(ex.Message);

                return error;
            }
        }
    }
}