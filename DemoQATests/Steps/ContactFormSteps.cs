using DemoQATests.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoQATests.Steps
{
    [Binding]
    public class ContactFormSteps
    {
        private readonly HomePage homePage;
        private readonly ContactFormPage contactFormPage;
        private readonly ErrorPage errorPage;
        private readonly SearchResultsPage searchResultsPage;

        public ContactFormSteps(IWebDriver driver, HomePage homePage, ContactFormPage contactFormPage,
            ErrorPage errorPage, SearchResultsPage searchResultsPage)
        {
            this.homePage = homePage;
            this.contactFormPage = contactFormPage;
            this.errorPage = errorPage;
            this.searchResultsPage = searchResultsPage;
        }


        [Given(@"navigates to the Contact Form")]
        public void GivenNavigatesToTheContactForm()
        {
            //homePage.ClickContactFormLink();
            homePage.ContactForm.Click();
        }

        [Given(@"navigates to '(.*)'")]
        public void GivenNavigatesTo(string linkText)
        {
            homePage.NavigateToPageByText(linkText);
        }

        [Given(@"the contact form is completed")]
        public void GivenTheContactFormIsCompleted(Table contactFormDetails)
        {
            foreach (var detail in contactFormDetails.Rows)
            {
                contactFormPage.EnterFirstName(detail["FirstName"]);
                contactFormPage.EnterLastName(detail["LastName"]);
                contactFormPage.EnterCountry(detail["Country"]);
                contactFormPage.EnterSubject(detail["Subject"]);
            }
        }

        [When(@"the form is submitted")]
        public void WhenTheFormIsSubmitted()
        {
            contactFormPage.SubmitButton.Click();
            //contactFormPage.SubmitForm();
        }

        [Then(@"the error '(.*)' is displayed")]
        public void ThenTheErrorIsDisplayed(string errorMessage)
        {
            var displayedError = errorPage.GetError();
            Assert.AreEqual(displayedError, errorMessage);
        }

        [Given(@"submits the contact form with the below values")]
        public void GivenSubmitsTheContactFormWithTheBelowValues(Table contactFormDetails)
        {
            //homePage.ClickContactFormLink();
            homePage.ContactForm.Click();

            foreach (var detail in contactFormDetails.Rows)
            {
                contactFormPage.EnterFirstName(detail["FirstName"]);
                contactFormPage.EnterLastName(detail["LastName"]);
                contactFormPage.EnterCountry(detail["Country"]);
                contactFormPage.EnterSubject(detail["Subject"]);
                contactFormPage.SubmitButton.Click();
            }

            //contactFormPage.SubmitForm();


            var displayedError = errorPage.GetError();
            Assert.AreEqual(displayedError, contactFormDetails.Rows[0]["Error"]);
        }

        [Given(@"searches for '(.*)'")]
        public void GivenSearchesFor(string searchString)
        {
            errorPage.PerformSearch(searchString);
        }

        [When(@"Alert Box is clicked")]
        public void WhenAlertBoxIsClicked()
        {
            searchResultsPage.ActivateAlert();
        }

        [Then(@"the alert is displayed")]
        public void ThenTheAlertIsDisplayed(Table alertTextTable)
        {
            var alert = searchResultsPage.GetAlert();
            var alertText = alert.Text;
            Assert.AreEqual(alertText, alertTextTable.Rows[0]["AlertText"]);
            alert.Dismiss();
        }
    }
}