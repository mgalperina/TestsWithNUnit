using System;
using System.Configuration;

namespace WebDriverUtilities.WebDriver
{
    public class Settings
    {

        public string Browser
        {
            get { return ConfigurationManager.AppSettings["browser"]; }
        }

        public string BrowserVersion
        {
            get { return ConfigurationManager.AppSettings["browserVersion"]; }
        }

        public string RemoteDriver
        {
            get { return ConfigurationManager.AppSettings["remoteDriverUri"]; }
        }

        public string Url
        {
            get { return ConfigurationManager.AppSettings["url"]; ; }
        }

        public string Resolution
        {
            get { return ConfigurationManager.AppSettings["resolution"]; ; }
        }

        public TimeSpan WaitBrowserToLaunch
        {
            get { return TimeSpan.FromSeconds(Convert.ToDouble(ConfigurationManager.AppSettings["timeoutInSeconds"])); }
        }
    }
}
