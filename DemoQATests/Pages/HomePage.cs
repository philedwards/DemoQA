using OpenQA.Selenium;

namespace DemoQATests.Pages
{
    public class HomePage : BasePage
    {
        private readonly By _contactForm = By.PartialLinkText("contact form");
        private readonly By _firstName = By.ClassName("firstname");

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickContactFormLink()
        {
            Driver.FindElement(_contactForm).Click();
        }

        public void NavigateToPageByText(string linkText)
        {
            Driver.FindElement(By.PartialLinkText(linkText)).Click();
        }

        public void EnterFirstName(string firstName)
        {
            Driver.FindElement(_firstName).SendKeys(firstName);
        }
    }
}
