using SMSQL.Domain.Enums;

namespace SMSQL.Domain.Models.Request
{
    public class SmsRequest
    {
        public string CustomerName { get; set; }
        public int BranchId { get; set; }
        public string BookingRef { get; set; }
        public int BPoints { get; set; }
        public string Phone { get; set; }
        public ProductType ProductType { get; set; }
        public EventName EventName { get; set; }
    }
}
