using OpenQA.Selenium;

namespace DemoQATests.Pages
{
    public class SearchResultsPage : BasePage
    {
        private readonly By _alert = By.Id("alert");

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        public void ActivateAlert()
        {
            Driver.FindElement(_alert).Click();
        }

        public IAlert GetAlert()
        {
            var alert = Driver.SwitchTo().Alert();
            return alert;   

        }
        
    }
}
