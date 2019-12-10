using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQATests.Pages
{
    public class SearchResultsPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "alert")]
        private IWebElement Alert { get; set; }

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public void ActivateAlert()
        {
            Alert.Click();
        }

        public IAlert GetAlert()
        {
            var alert = Driver.SwitchTo().Alert();
            return alert;
        }
    }
}