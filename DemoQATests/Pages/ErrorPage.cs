using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQATests.Pages
{
    public class ErrorPage : BasePage

    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"main\"]/div/header/h1")]
        public IWebElement Error { get; set; }
        [FindsBy(How = How.ClassName, Using = "search-field")]
        public IWebElement SearchField { get; set; }
        [FindsBy(How = How.ClassName, Using = "search-submit")]
        public IWebElement SearchButton { get; set; }

        public ErrorPage(IWebDriver driver) : base(driver)
        {
        }

        public string GetError()
        {
            var error = Error.Text;
            return error;
        }

        public void PerformSearch(string searchText)
        {
            SearchField.SendKeys(searchText);
            SearchButton.Click();
        }
    }
}