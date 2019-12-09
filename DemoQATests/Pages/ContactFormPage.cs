using OpenQA.Selenium;

namespace DemoQATests.Pages
{
    public class ContactFormPage : BasePage
    {
        private readonly By _firstName = By.ClassName("firstname");
        private readonly By _lastName = By.Id("lname");
        private readonly By _country = By.Name("country");
        private readonly By _subject = By.Id("subject");
        private readonly By _submitButton = By.CssSelector("input[value=\'Submit\']");

        public ContactFormPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnterFirstName(string firstName)
        {
            Driver.FindElement(_firstName).Clear();
            Driver.FindElement(_firstName).SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            Driver.FindElement(_lastName).Clear();
            Driver.FindElement(_lastName).SendKeys(lastName);
        }

        public void EnterCountry(string country)
        {
            Driver.FindElement(_country).Clear();
            Driver.FindElement(_country).SendKeys(country);
        }

        public void EnterSubject(string subject)
        {
            Driver.FindElement(_subject).Clear();
            Driver.FindElement(_subject).SendKeys(subject);
        }

        public void SubmitForm()
        {
            Driver.FindElement(_submitButton).Click();
        }
    }
}
