using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQATests.Pages
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.PartialLinkText, Using = "contact form")]
        public IWebElement ContactForm { get; set; }

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateToPageByText(string linkText)
        {
            Driver.FindElement(By.PartialLinkText(linkText)).Click();
        }
    }
}