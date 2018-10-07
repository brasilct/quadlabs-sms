using System.Xml.Serialization;

namespace SMSQL.Domain.Models.Response
{
    [XmlRoot(ElementName = "Error")]
    public class ErrorMessages
    {
        [XmlElement("ErrorMessage")]
        public string ErrorMessage { get; set; }
    }
}
