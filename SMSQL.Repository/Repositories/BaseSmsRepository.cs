using SMSQL.Domain.Models;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SMSQL.Repository.Repositories
{
    public class BaseSmsRepository
    {
        public string NormalizeRequest<T>(T value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var emptyNamepsaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                OmitXmlDeclaration = true,
                Encoding = System.Text.Encoding.UTF8
            };

            var xmlSerializer = new XmlSerializer(typeof(T));
            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                    xmlSerializer.Serialize(xmlWriter, value, emptyNamepsaces);

                return textWriter.ToString();
            }
        }

        public ApiResponse<T> CreateResponse<T>(string responseStr)
        {
            return new ApiResponse<T>()
            {
                Data = Deserialize<T>(responseStr)
            };
        }

        private T Deserialize<T>(string value)
        {
            if (value == null)
            {
                return default(T);
            }

            if (typeof(T) == typeof(string))
                return (T)Convert.ChangeType(value, typeof(T));

            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                using (var reader = new StringReader(value))
                {
                    var result = xmlSerializer.Deserialize(reader);
                    return (T)result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }
    }
}
