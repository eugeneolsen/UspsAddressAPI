using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace UspsAddressApi
{
    public class UnitTests
    {
        private readonly MainPresenter presenter;

        public UnitTests()
        {
            presenter = new MainPresenter(null);
        }


        [Theory]
        [InlineData("12345")]
        public async void ValidZipCodeReturnsResult(string value)
        {
            CityStateLookupResponse result = await presenter.GetCityStateAsync(value);

            Assert.True(null != result);
        }


        [Theory]
        [InlineData("12345", "SCHENECTADY")]
        [InlineData("91360", "THOUSAND OAKS")]
        [InlineData("84601", "PROVO")]
        public async void ReturnsExpectedCity(params string[] values)
        {
            CityStateLookupResponse result = await presenter.GetCityStateAsync(values[0]);

            string city = result.ZipCodes.First().City;

            Assert.True(values[1] == city);
        }


        [Theory]
        [InlineData("12345", "NY")]
        [InlineData("91360", "CA")]
        [InlineData("84601", "UT")]
        public async void ReturnsExpectedState(params string[] values)
        {
            CityStateLookupResponse result = await presenter.GetCityStateAsync(values[0]);

            string state = result.ZipCodes.First().State;

            Assert.True(values[1] == state);
        }


        [Theory]
        [InlineData("9136")]
        [InlineData("840")]
        [InlineData("123456")]
        [InlineData("9136789")]
        [InlineData("2")]
        public async void ZipCodeNotLengthFive(string value)
        {
            AddressApiException e = await Assert.ThrowsAsync<AddressApiException>(testCode: () => presenter.GetCityStateAsync(value));

            Assert.True("ZIPCode must be 5 characters" == e.Message);
        }


        [Theory]
        [InlineData("abcde")]
        [InlineData("8405%")]
        public async void ZipCodeNotNumeric(string value)
        {
            AddressApiException e = await Assert.ThrowsAsync<AddressApiException>(testCode: () => presenter.GetCityStateAsync(value));

            Assert.True("Zip Codes must be numeric." == e.Message.TrimEnd());
        }


        [Theory]
        [InlineData("80000")]
        public async void InvalidZipCodeThrowsZipCodeException(string value)
        {
            AddressApiException e =  await Assert.ThrowsAsync<AddressApiException>(testCode: () => presenter.GetCityStateAsync(value));

            Assert.True("Invalid Zip Code." == e.Message);
        }
    }
}
