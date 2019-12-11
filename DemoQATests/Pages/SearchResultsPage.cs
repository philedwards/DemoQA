using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQATests.Pages
{
    public class SearchResultsPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "alert")]
        public IWebElement AlertButton { get; set; }

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public IAlert GetAlert()
        {
            var alert = Driver.SwitchTo().Alert();
            return alert;
        }
    }
}