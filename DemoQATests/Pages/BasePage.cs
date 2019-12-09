using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQATests.Pages
{
    public abstract class BasePage
    {
        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        protected IWebDriver Driver { get; private set; }
    }
}
