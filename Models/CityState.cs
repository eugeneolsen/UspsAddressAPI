using System.Collections.Generic;
using System.Xml.Serialization;

namespace UspsAddressApi
{
    public class CityStateLookupResponse
    {
        public CityStateLookupResponse()
        {
            ZipCodes = new List<ZipCode>();
        }

        public List<ZipCode> ZipCodes;  // The CityStateLookupResponse can have up to 5 zip codes.
    }

    public class ZipCode
    {
        [XmlAttribute]
        public string ID { get; set; }

        [XmlElement]
        public string Zip5 { get; set; }

        [XmlElement]
        public string City { get; set; }

        [XmlElement]
        public string State { get; set; }
    }
}

