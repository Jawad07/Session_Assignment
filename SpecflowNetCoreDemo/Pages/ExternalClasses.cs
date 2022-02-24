using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecflowNetCoreDemo.Pages
{
    public class ExternalClasses
    {
        public IWebDriver WebDriver { get; set; }
        public void EWebDriver(string URL, IWebDriver web)
        {
            WebDriver = web;
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl(URL);


        }

    }
}
