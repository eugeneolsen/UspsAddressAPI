using System;
using System.Windows.Forms;

namespace UspsAddressApi
{
    public partial class MainView : Form, IMainView
    {
        private MainPresenter presenter;

        public string City
        {
            get { return textBoxCity.Text; }
            set { textBoxCity.Text = value; }
        }
        public string State
        {
            get { return textBoxState.Text; }
            set { textBoxState.Text = value; }
        }
        public string Zip
        {
            get { return textBoxZipCode.Text; }
            set { textBoxZipCode.Text = value; }
        }

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

            try
            {
                await presenter.GetCityStateAsync();
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
        }


        private void ClearView()
        {
            City = string.Empty;
            State = string.Empty;
            statusMessage.Text = string.Empty;
        }
    }
}
