using OpenQA.Selenium;

namespace SpecflowNetCoreDemo.Pages
{
    class LoginPage
    {
        public IWebDriver WebDriver { get; set; }
        public LoginPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;

        }
        public IWebElement lnklogin => WebDriver.FindElement(By.LinkText("Login"));
        public IWebElement txtUserName => WebDriver.FindElement(By.Name("UserName"));

        public IWebElement txtPassword => WebDriver.FindElement(By.Name("Password"));

        public IWebElement btnlogin => WebDriver.FindElement(By.CssSelector(".btn-default"));
        public IWebElement lnkEmployeeDetails => WebDriver.FindElement(By.LinkText("Employee Details"));

        public void ClickLogin() => lnklogin.Click();
        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLoginButton() => btnlogin.Submit();

        public bool IsEmployeeDetailsExist() => lnkEmployeeDetails.Displayed;



    }
}
