using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.Configuration;
using OpenQA.Selenium.IE;

namespace DemoQATests
{
    [Binding]
    public class WebDriverSupport
    {
        private static string browser = ConfigurationManager.AppSettings["browser"];
        private static string _browser = ConfigurationManager.AppSettings.Get("browser");
        private static IWebDriver driver;
        private readonly IObjectContainer _objectContainer;

        public WebDriverSupport(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario()]
        public void InitializeWebDriver()
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(@"C:\selenium\");
                    break;
                case "InternetExplorer":
                    driver = new InternetExplorerDriver(@"C:\selenium\");
                    break;
            }
            driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario()]
        public void TearDownWebDriver()
        {
            var driver = _objectContainer.Resolve<IWebDriver>();
            driver.Quit();
        }
    }
}
