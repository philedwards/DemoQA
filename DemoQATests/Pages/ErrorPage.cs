using OpenQA.Selenium;

namespace DemoQATests.Pages
{
    public class ErrorPage : BasePage

    {
        private readonly By _error = By.XPath("//*[@id=\"main\"]/div/header/h1");
        private readonly By _searchField = By.ClassName("search-field");
        private readonly By _searchButton = By.ClassName("search-submit");

        public ErrorPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetError()
        {
            var error = Driver.FindElement(_error).Text;
            return error;
        }

        public void PerformSearch(string searchText)
        {
            Driver.FindElement(_searchField).SendKeys(searchText);
            Driver.FindElement(_searchButton).Click();
        }
    }
}
