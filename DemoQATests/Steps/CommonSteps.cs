using DemoQATests.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DemoQATests.Steps
{
    [Binding]
    public class CommonSteps : BasePage
    {
        public CommonSteps(IWebDriver driver) : base(driver)
        {
        }

        [Given(@"the user navigates to the DemoQA site")]
        public void GivenTheUserNavigatesToTheDemoQaSite()
        {
            Driver.Url = "https://demoqa.com/";
        }
    }
}
