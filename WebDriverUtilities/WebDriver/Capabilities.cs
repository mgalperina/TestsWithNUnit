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

            return capabilities;
        }
    }
}
