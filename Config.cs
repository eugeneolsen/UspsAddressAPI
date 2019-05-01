using System.Configuration;

namespace UspsAddressApi
{
    public sealed class Config  // Wraps configuration as a singleton
    {
        private static Config instance = null;

        public string Uri { get; private set; }
        public string UserID { get; private set; }
        public string RequestFile { get; private set; }

        // Private constructor makes the singleton possible
        private Config()
        {
        }

        public static Config Settings
        {
            get
            {
                if (null == instance)   // This is not a reliable singleton strategy for multi-threaded applications
                {
                    instance = new Config();

                    var appSettings = ConfigurationManager.AppSettings;
                    instance.Uri = appSettings.Get("uri");
                    instance.UserID = appSettings.Get("UserID");
                    instance.RequestFile = appSettings.Get("RequestFile");
                }

                return instance;
            }
        }
    }
}
