using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UspsAddressApi
{
    class MainPresenter
    {
        private readonly IMainView mainView;

        private HttpClient httpClient = new HttpClient();

        public MainPresenter(IMainView view)
        {
            mainView = view;
        }


        public async Task GetCityStateAsync()
        {
            HttpResponseMessage response = await httpClient.GetAsync(BuildRequest(mainView.Zip));

            if (response.IsSuccessStatusCode)
            {
                string xmlString = await response.Content.ReadAsStringAsync();

                XDocument document = XDocument.Parse(xmlString);
                XElement root = document.Root;

                if (Properties.Resources.ResponseElementName == document.Root.Name.LocalName)   // Successful lookup response
                {
                    foreach (XElement zipCodeElement in document.Descendants(Properties.Resources.ZipCodeElementName))
                    {
                        string id = (string)zipCodeElement.Attribute(Properties.Resources.ZipCodeIDAttribute);
                        string zip5 = (string)zipCodeElement.Element(Properties.Resources.Zip5ElementName);
                        string city = (string)zipCodeElement.Element(Properties.Resources.CityElementName);
                        string state = (string)zipCodeElement.Element(Properties.Resources.StateElementName);
                        string error = (string)zipCodeElement.Element(Properties.Resources.ErrorElementName);

                        if (null == zip5 && null != error)
                        {
                            XElement errorElement = zipCodeElement.Element(Properties.Resources.ErrorElementName);
                            string errorDescription = (string)errorElement.Element(Properties.Resources.DescriptionElementName);

                            throw new AddressApiException(errorDescription, xmlString);
                        }

                        mainView.City = city;
                        mainView.State = state;
                        mainView.Zip = zip5;
                    }
                }
                else
                {
                    if (Properties.Resources.ErrorElementName == root.Name.LocalName)   // Error of expected error type
                    {
                        string description = (string)root.Element(Properties.Resources.DescriptionElementName);

                        if ((string)root.Element(Properties.Resources.SourceElementName) == Properties.Resources.AuthorizationValue)
                        {
                            description = Properties.Resources.InvalidUserIDMessage;
                        }

                        throw new AddressApiException(description, xmlString);
                    }
                    else
                    {
                        Debug.Assert(false, "Unknown, unhandled error.  Developer: debug this and handle.");

                        throw new System.Exception();
                    }
                }
            }
            else
            {
                throw new AddressApiException($"USPS Address API failed: {response.ReasonPhrase}");
            }
        }

        private string BuildRequest(string zipCode)
        {
            XDocument request = XDocument.Load(Config.Settings.RequestFile);
            XElement root = request.Element(Properties.Resources.RequestElementName);
            root.SetAttributeValue(Properties.Resources.UserIDAttribute, Config.Settings.UserID);
            XElement zipCodeElement = root.Element(Properties.Resources.ZipCodeElementName);
            zipCodeElement.SetElementValue(Properties.Resources.Zip5ElementName, zipCode);

            string requestString = Config.Settings.Uri + request.ToString();

            return requestString;
        }
    }
}
