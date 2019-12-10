using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DemoQATests.Pages
{
    public class ContactFormPage : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "firstname")]
        public IWebElement FirstName { get; set; }
        [FindsBy(How = How.Id, Using = "lname")]
        public IWebElement LastName { get; set; }
        [FindsBy(How = How.Name, Using = "country")]
        public IWebElement Country { get; set; }
        [FindsBy(How = How.Id, Using = "subject")]
        public IWebElement Subject { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[value=\'Submit\']")]
        public IWebElement SubmitButton { get; set; }

        public ContactFormPage(IWebDriver driver) : base(driver)
        {
        }

        public void EnterFirstName(string firstName)
        {
            FirstName.Clear();
            FirstName.SendKeys(firstName);
        }

        public void EnterLastName(string lastName)
        {
            LastName.Clear();
            LastName.SendKeys(lastName);
        }

        public void EnterCountry(string country)
        {
            Country.Clear();
            Country.SendKeys(country);
        }

        public void EnterSubject(string subject)
        {
            Subject.Clear();
            Subject.SendKeys(subject);
        }
    }
}