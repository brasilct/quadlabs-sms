using SMSQL.Domain.Enums;
using System.Xml.Serialization;

namespace SMSQL.Domain.Models.Response
{
    [XmlRoot(Namespace = "", IsNullable = false, ElementName = "SMS")]
    public class SmsStatusResponse
    {   
        [XmlElement(ElementName = "Status")]
        protected StatusSms EnumStatus { get; set; }

        public virtual string Status { get { return EnumStatus.ToString(); } }
    }
}
