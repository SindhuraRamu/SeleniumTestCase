using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestCase
{
   [TestFixture(typeof(FirefoxDriver))]
   [TestFixture(typeof(InternetExplorerDriver))]
   [TestFixture(typeof(ChromeDriver))]
    public class LoginTC<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        private IWebDriver driver;

        [SetUp]
            public void SetUp()
            {
                driver = new FirefoxDriver();
            }
        
       [TestFixtureTearDown]
       public void FixtureTearDown()
        {
            this.driver.Quit();
        }

        [Test]
            public void LoginTest()
            {
                login.loginmethod(driver,"myEnv", "user");
                login.logoutmethod(driver);
            }


    }

}