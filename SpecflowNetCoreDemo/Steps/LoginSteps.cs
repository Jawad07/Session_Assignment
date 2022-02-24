using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowNetCoreDemo.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNetCoreDemo.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        //Anti-context Injection code

        IWebDriver web = null;
        LoginPage loginpage = null;
        ExternalClasses Ex = null;

        //Login Definitions

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            Ex.EWebDriver("http://eaapp.somee.com/", web);
            //IWebDriver webdriver = new ChromeDriver();
            //webdriver.Navigate().GoToUrl("http://eaapp.somee.com/");
            //loginpage = new LoginPage(webdriver);
        }

        [Then(@"I click login link")]
        public void GivenIClickLoginLink()
        {
            loginpage.ClickLogin();
        }

        [Then(@"I enter the following details")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.Login((string)data.UserName, (string)data.Password);

        }

        [Then(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            loginpage.ClickLoginButton();
        }

        [Then(@"I should see Employee details link")]
        public void GivenIShouldSeeEmployeeDetailsLink()
        {
            Assert.That(loginpage.IsEmployeeDetailsExist(), Is.True);

            //ScenarioContext.Current.Pending();

        }
    }

}
