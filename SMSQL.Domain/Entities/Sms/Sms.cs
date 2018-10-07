using SMSQL.Domain.Enums;
using System.Xml.Serialization;

namespace SMSQL.Domain.Entities
{
    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "SMS")]
    public class Sms
    {
        [XmlElement(ElementName = "CustomerName")]
        public string CustomerName { get; set; }
        [XmlElement(ElementName = "BranchId")]
        public int BranchId { get; set; }
        [XmlElement(ElementName = "BookingRef")]
        public string BookingRef { get; set; }
        [XmlElement(ElementName = "BPoints")]
        public int BPoints { get; set; }
        [XmlElement(ElementName = "Phone")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "ProductType")]
        public ProductType ProductType { get; set; }
        [XmlElement(ElementName = "SalesChannel")]
        public string SalesChannel { get; set; }
        [XmlElement(ElementName = "EventName")]
        public EventName EventName { get; set; }
        [XmlElement(ElementName = "CompanyID")]
        public string CompanyID { get; set; }
    }
}
