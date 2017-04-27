using OpenQA.Selenium.Remote;

namespace WebDriverUtilities.WebDriver
{
    public static class Capabilities
    {
        public static DesiredCapabilities GetCapabilities(Settings settings)
        {
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, settings.Browser);
            capabilities.SetCapability(CapabilityType.Version, settings.BrowserVersion);
            capabilities.SetCapability(CapabilityType.Version, settings.RemoteDriver);
            capabilities.SetCapability(CapabilityType.Version, settings.Url);
            capabilities.SetCapability(CapabilityType.Version, settings.Resolution);
            capabilities.SetCapability(CapabilityType.Version, settings.WaitBrowserToLaunch);
            return capabilities;
        }
    }
}
