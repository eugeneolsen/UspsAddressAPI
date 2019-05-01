using System;
using System.Windows.Forms;

namespace UspsAddressApi
{
    public partial class MainView : Form
    {
        private MainPresenter presenter;

        public MainView()
        {
            presenter = new MainPresenter(this);

            InitializeComponent();
        }


        private async void buttonCityState_Click(object sender, EventArgs e)
        {
            ClearView();

            if (textBoxZipCode.Text.Length != 5 || !int.TryParse(textBoxZipCode.Text, out int result))
            {
                statusMessage.Text = Properties.Resources.ZipCode5NumericErrorMessage;
                return;
            }

            CityStateLookupResponse cityState = new CityStateLookupResponse();

            try
            {
                cityState = await presenter.GetCityStateAsync(textBoxZipCode.Text);
            }
            catch (AddressApiException ze)
            {
                statusMessage.Text = ze.Message;
                return;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                statusMessage.Text = Properties.Resources.UnknownErrorMessage;
                return;
            }

            textBoxCity.Text = cityState.ZipCodes[0].City;
            textBoxState.Text = cityState.ZipCodes[0].State;
        }


        private void ClearView()
        {
            statusMessage.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxState.Text = string.Empty;
        }
    }
}
