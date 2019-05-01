using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UspsAddressApi
{
    public class AddressApiException : Exception
    {
        public AddressApiException(string message) : base(message)
        {
        }

        public AddressApiException(string message, string xmlResponse) : base(message)
        {
            XmlResponse = xmlResponse;
        }

        public string XmlResponse { get; private set; }
    }
}
