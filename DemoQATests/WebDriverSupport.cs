using BoDi;
using DemoQATests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace DemoQATests
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer _objectContainer;

        public WebDriverSupport(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario()]
        public void InitializeWebDriver()
        {
            IWebDriver driver = new ChromeDriver(@"C:\selenium\");
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
