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
        private readonly IMainView mainView;

        public UnitTests()
        {
            mainView = new MainView();
            presenter = new MainPresenter(mainView);
        }


        [Theory]
        [InlineData("12345")]
        public async void ValidZipCodeReturnsResult(string value)
        {
            mainView.Zip = value;
            await presenter.GetCityStateAsync();

            Assert.True(mainView.City != string.Empty);
            Assert.True(mainView.State != string.Empty);
        }


        [Theory]
        [InlineData("12345", "SCHENECTADY")]
        [InlineData("91360", "THOUSAND OAKS")]
        [InlineData("84601", "PROVO")]
        public async void ReturnsExpectedCity(params string[] values)
        {
            mainView.Zip = values[0];
            await presenter.GetCityStateAsync();

            Assert.True(values[1] == mainView.City);
        }


        [Theory]
        [InlineData("12345", "NY")]
        [InlineData("91360", "CA")]
        [InlineData("84601", "UT")]
        public async void ReturnsExpectedState(params string[] values)
        {
            mainView.Zip = values[0];
            await presenter.GetCityStateAsync();

            Assert.True(values[1] == mainView.State);
        }


        [Theory]
        [InlineData("9136")]
        [InlineData("840")]
        [InlineData("123456")]
        [InlineData("9136789")]
        [InlineData("2")]
        public async void ZipCodeNotLengthFive(string value)
        {
            mainView.Zip = value;
            AddressApiException e = await Assert.ThrowsAsync<AddressApiException>(testCode: () => presenter.GetCityStateAsync());

            Assert.True("ZIPCode must be 5 characters" == e.Message);
        }


        [Theory]
        [InlineData("abcde")]
        [InlineData("8405%")]
        public async void ZipCodeNotNumeric(string value)
        {
            mainView.Zip = value;
            AddressApiException e = await Assert.ThrowsAsync<AddressApiException>(testCode: () => presenter.GetCityStateAsync());

            Assert.True("Zip Codes must be numeric." == e.Message.TrimEnd());
        }


        [Theory]
        [InlineData("80000")]
        public async void InvalidZipCodeThrowsZipCodeException(string value)
        {
            mainView.Zip = value;
            AddressApiException e =  await Assert.ThrowsAsync<AddressApiException>(testCode: () => presenter.GetCityStateAsync());

            Assert.True("Invalid Zip Code." == e.Message);
        }
    }
}
